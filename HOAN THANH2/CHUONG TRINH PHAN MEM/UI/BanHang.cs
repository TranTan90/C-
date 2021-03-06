using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using Model;
using Business_Layer;
using System.Drawing.Printing;

namespace UI
{
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        //---------------------
        // CAC BIEN KET NOI
        BUS_CHITIETHDBAN cthd = new BUS_CHITIETHDBAN();
        BUS_HOADONBAN hdban = new BUS_HOADONBAN();
        BUS_SANPHAM sp = new BUS_SANPHAM();
        BUS_NHANVIEN nv = new BUS_NHANVIEN();
        BUS_KHACHHANG kh = new BUS_KHACHHANG();
        KHACH_HANG kh1 = new KHACH_HANG();
        NHAN_VIEN nv1 = new NHAN_VIEN();
        HOA_DON_BAN hdban1 = new HOA_DON_BAN();
        CHI_TIET_HDBAN cthd1 = new CHI_TIET_HDBAN();
        SAN_PHAM sp1 = new SAN_PHAM();
        DataTable sp2 = new DataTable();
        DataTable sp3 = new DataTable();
        Int64 thanhtien = 0;
        Int64 tongcong = 0;
        bool checkKH;
        bool addnew;
        bool exit;
        bool fail = false;
        //--------------------
        private void button_bh_thoat_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn chưa thanh toán hóa đơn ! \n Bạn có muốn lưu ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                if (thongbao == DialogResult.Yes)
                    MessageBox.Show("Vui lòng nhấn nút thanh toán !");
                else
                {
                    this.Hide();
                    Trangchinh tc = new Trangchinh();
                    tc.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                Trangchinh tc = new Trangchinh();
                tc.ShowDialog();
            }
        }
        private void dataGridView_bh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            try
            {
                // MÃ HÓA ĐƠN TỰ SINH
                sp2 = hdban.GetData_HD("");
                if (sp2.Rows.Count == 0)
                {
                    comboBox_bh_mahd.Text = "HDB00001";
                }
                else
                {
                    int tam1 = int.Parse(sp2.Rows[0][0].ToString());
                    if (tam1 < 10)
                    {
                        tam1 = tam1 + 1;
                        comboBox_bh_mahd.Text = "HDB0000" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 100)
                        {
                            tam1 = tam1 + 1;
                            comboBox_bh_mahd.Text = "HDB000" + Convert.ToString(tam1);
                        }
                        else
                            if (tam1 < 1000)
                            {
                                tam1 = tam1 + 1;
                                comboBox_bh_mahd.Text = "HDB00" + Convert.ToString(tam1);
                            }
                            else
                                if (tam1 < 10000)
                                {
                                    tam1 = tam1 + 1;
                                    comboBox_bh_mahd.Text = "HDB0" + Convert.ToString(tam1);
                                }
                                else
                                    if (tam1 < 100000)
                                    {
                                        tam1 = tam1 + 1;
                                        comboBox_bh_mahd.Text = "HDB" + Convert.ToString(tam1);
                                    }
                }
            }
            catch { MessageBox.Show("Loi"); }
            // LOẠI KHÁCH HÀNG
            sp2 = sp.GetMaKH("");
            comboBox_bh_makh.DataSource = sp2;
            comboBox_bh_tenkh.DataSource = sp2;
            comboBox_bh_makh.ValueMember = "MaKH";
            comboBox_bh_tenkh.ValueMember = "TenKH";
            //------------------------------------------------------------------------------
            // LẤY TRƯỜNG NHÂN VIÊN
            sp2 = nv.Select("");
            comboBox_bh_tennv.DataSource = sp2;
            comboBox_bh_manv.DataSource = sp2;
            comboBox_bh_manv.ValueMember = "MaNV";
            comboBox_bh_tennv.ValueMember = "TenNV";
            //------------------------------------------------------------------------------
            // ĐỔ DỮ LIỆU VÀO MÃ HÀNG
            sp2 = sp.GetMaSP("");
            comboBox_bh_mh.DataSource = sp2;
            comboBox_bh_tenhang.DataSource = sp2;
            comboBox_bh_dg.DataSource = sp2;
            comboBox_bh_donvi.DataSource = sp2;
            textBox_bh_soluong.Text = "1";
            comboBox_bh_dg.ValueMember = "GiaBan";
            comboBox_bh_mh.ValueMember = "MaSP";
            comboBox_bh_tenhang.ValueMember = "TenSP";
            comboBox_bh_donvi.ValueMember = "DonviTinh";
            sp3.Columns.Add("MaSP");
            sp3.Columns.Add("TenSP");
            sp3.Columns.Add("DonViTinh");
            sp3.Columns.Add("SoLuong");
            sp3.Columns.Add("GiaBan");
            sp3.Columns.Add("ThanhTienBan");
            sp3.AcceptChanges();
            comboBox_bh_mh.Enabled = false;
            comboBox_bh_tenhang.Enabled = false;
            textBox_bh_soluong.Enabled = false;
            button_bh_them.Enabled = true;
            button_bh_luu.Enabled = false;
            button_bh_xoa.Enabled = false;
            button_bh_sua.Enabled = false;
            //------------------------------------------------------------------------------
            comboBox_bh_makh.Hide();
            comboBox_bh_tenkh.Hide();
            checkKH = false;
            radioButton_kbt.Checked = true;
            //------------------------------------------------------------------------------
            exit = false;
        }
        void testButton()
        {
            if (dataGridView_bh.Rows[0].Cells[0].Value == null)
            {
                button_bh_them.Enabled = true;
                button_bh_luu.Enabled = false;
                button_bh_sua.Enabled = false;
                button_bh_xoa.Enabled = false;
            }
            else
            {
                button_bh_them.Enabled = true;
                button_bh_luu.Enabled = false;
                button_bh_sua.Enabled = true;
                button_bh_xoa.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_bh_nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void label_tenkh_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_bh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // NÚT THÊM
        private void button_bh_nhap_Click(object sender, EventArgs e)
        {
            addnew = false;
            button_bh_luu.Enabled = true;
            button_bh_them.Enabled = false;
            button_bh_sua.Enabled = false;
            button_bh_xoa.Enabled = false;
            comboBox_bh_mh.Enabled = true;
            comboBox_bh_tenhang.Enabled = true;
            textBox_bh_soluong.Text = "1";
            textBox_bh_soluong.Enabled = true;
            this.comboBox_bh_mh.Focus();
        }
        // NÚT  LƯU
        private void button_bh_luu_Click(object sender, EventArgs e)
        {
            if (textBox_bh_soluong.Text == "" || Int32.Parse(textBox_bh_soluong.Text) == 0)
            {
                MessageBox.Show("Xin mời nhập số lượng !");
                return;
            }
            //-------------------------------------------------------------------------------------------------------------------------
            // KIỂM TRA SỐ LƯỢNG CÒN TRONG KHO 
            sp2=sp.GetSL(comboBox_bh_mh.Text);
            if(int.Parse(textBox_bh_soluong.Text) > int.Parse(sp2.Rows[0][0].ToString()))
            {
                MessageBox.Show("Số lượng trong kho không đủ !","Cảnh báo !");
                return;
            }
                        //-------------------------------------------------------------------------------------------------------------------------

            // LƯU DỮ LIỆU VÀO DATATABLE
            if (addnew == true)
            {
                sp3.Rows.RemoveAt(dataGridView_bh.CurrentRow.Index);
            }
            else
            {
                // SO SÁNH NẾU TRÙNG SẢN PHẨM THÌ CỘNG DỒN
                if (dataGridView_bh.Rows.Count >= 2)
                {
                    for (int i = 0; i <= dataGridView_bh.Rows.Count - 1; i++)
                    {
                        try
                        {
                            string chuoi1 = comboBox_bh_mh.Text;
                            string chuoi = dataGridView_bh.Rows[i].Cells[0].Value.ToString();
                            if (chuoi == chuoi1)
                            {
                                textBox_bh_soluong.Text = Convert.ToString(int.Parse(textBox_bh_soluong.Text) + int.Parse(dataGridView_bh.Rows[i].Cells[3].Value.ToString()));
                                dataGridView_bh.Rows.RemoveAt(i);
                            }
                        }
                        catch
                        { }
                    }
                }
            }
                //-------------------------------------------------------------------------------------------------------------------------
                // HIỂN THỊ 
                thanhtien = int.Parse(textBox_bh_soluong.Text) * int.Parse(comboBox_bh_dg.Text);
                sp3.Rows.Add(comboBox_bh_mh.Text, comboBox_bh_tenhang.Text, comboBox_bh_donvi.Text, textBox_bh_soluong.Text, comboBox_bh_dg.Text, thanhtien);
                dataGridView_bh.DataSource = sp3;
                // TÍNH TỔNG CỘNG
                tongcong = 0;
                for(int i=0; i < dataGridView_bh.Rows.Count; i++)
                {
                    tongcong = tongcong + Convert.ToInt64(dataGridView_bh.Rows[i].Cells[5].Value);
                }
                textBox_tongtien.Text = String.Format("{0:0,0}", tongcong);
                testButton();
                comboBox_bh_mh.Enabled = false;
                comboBox_bh_tenhang.Enabled = false;
                textBox_bh_soluong.Text = "1";
                textBox_bh_soluong.Enabled = false;
                //-------------------------------------------------------------------------------------------------------------------------
        }
        // NÚT SỬA
        private void button_bh_suahang_Click(object sender, EventArgs e)
        {
            if(comboBox_bh_mh.Text == "" || comboBox_bh_tenhang.Text == "" || textBox_bh_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới để sửa !", "Thông báo");
                return;
            }
            addnew = true;
            textBox_bh_soluong.Enabled = true;
            button_bh_luu.Enabled = true;
            button_bh_them.Enabled = false;
            button_bh_sua.Enabled = false;
            button_bh_xoa.Enabled = false;
            this.textBox_bh_soluong.Focus();
        }

        private void button_bh_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_bh_mh.Text == "" || comboBox_bh_tenhang.Text == "" || textBox_bh_soluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới để xóa !", "Thông báo");
                return;
            }
            thanhtien = int.Parse(textBox_bh_soluong.Text) * int.Parse(comboBox_bh_dg.Text);
            sp3.Rows.RemoveAt(dataGridView_bh.CurrentRow.Index);
            tongcong = 0;
            for (int i = 0; i < dataGridView_bh.Rows.Count; i++)
            {
                tongcong = tongcong + Convert.ToInt64(dataGridView_bh.Rows[i].Cells[5].Value);
            }
            textBox_tongtien.Text = String.Format("{0:0,0}", tongcong);
            testButton();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button_bh_thanhtoan_Click(object sender, EventArgs e)
        {
            // TÍNH TIỀN THỪA 
            if (textBox_khachdua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiền khách trả !!!");
                return;
            }
            else
                if (int.Parse(textBox_khachdua.Text) < tongcong)
                {
                    MessageBox.Show("Tiền chưa đủ thanh toán !!!");
                    return;
                }
                else
                {
                    DialogResult thongbao;
                    thongbao = (MessageBox.Show("Vui lòng xem kỹ hóa đơn trước khi thanh toán ! \n Bạn đã chắc chắn chưa ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                    if (thongbao == DialogResult.Yes)
                    {
                        // LƯU VÀO HÓA ĐƠN
                        try
                        {
                        hdban1.MaHD = comboBox_bh_mahd.Text;
                        if (checkKH == true)
                        {
                            hdban1.MaKH = "KH0000";
                        }
                        else
                        {
                            hdban1.MaKH = comboBox_bh_makh.Text;
                            kh1.MaKH = comboBox_bh_makh.Text;
                            sp2 = kh.GetPoint(comboBox_bh_tenkh.Text);
                            if (sp2.Rows[0][0].ToString() == "" || int.Parse(sp2.Rows[0][0].ToString()) == 0)
                            {
                                kh1.DiemTichLuy = int.Parse(string.Format("{0}", tongcong)) / 1000;
                            }
                            else
                            {
                                kh1.DiemTichLuy = int.Parse(sp2.Rows[0][0].ToString()) + ((int.Parse(string.Format("{0}", tongcong))) / 1000);
                            }
                            kh.AddPoint(kh1);
                        }
                        hdban1.MaNV = comboBox_bh_manv.Text;
                        hdban1.NgayBan =dateTimePicker_bh.Value;
                            // GIẢM PHẦN TRĂM HÓA ĐƠN
                        if (kh1.DiemTichLuy >= 12000)
                        {
                            MessageBox.Show("Bạn được nhận ưu đãi giảm 15% tổng giá trị đơn hàng ! ");
                            tongcong = int.Parse(string.Format("{0}", tongcong)) - (int.Parse(string.Format("{0}", tongcong)) * 15) / 100;
                        }
                        else
                        {
                            if (kh1.DiemTichLuy >= 6000)
                            {
                                MessageBox.Show("Bạn được nhận ưu đãi giảm 10% tổng giá trị đơn hàng ! ");
                                tongcong = int.Parse(string.Format("{0}", tongcong)) - (int.Parse(string.Format("{0}", tongcong)) * 10) / 100;
                            }
                            else
                            {
                                if (kh1.DiemTichLuy >= 4500)
                                {
                                    MessageBox.Show("Bạn được nhận ưu đãi giảm 7% tổng giá trị đơn hàng ! ");
                                    tongcong = int.Parse(string.Format("{0}", tongcong)) - (int.Parse(string.Format("{0}", tongcong)) * 7) / 100;
                                }
                                else
                                {
                                    if (kh1.DiemTichLuy >= 3000)
                                    {
                                        MessageBox.Show("Bạn được nhận ưu đãi giảm 5% tổng giá trị đơn hàng ! ");
                                        tongcong = int.Parse(string.Format("{0}", tongcong)) - (int.Parse(string.Format("{0}", tongcong)) * 5) / 100;
                                    }

                                    else
                                    {
                                        if (kh1.DiemTichLuy >= 1500)
                                        {
                                            MessageBox.Show("Bạn được nhận ưu đãi giảm 3% tổng giá trị đơn hàng ! ");
                                            tongcong = int.Parse(string.Format("{0}", tongcong)) - (int.Parse(string.Format("{0}", tongcong)) * 3) / 100;
                                        }
                                    }
                                }
                            }
                        }
                            //---------------------
                        hdban1.TongTienBan = int.Parse(string.Format("{0}", tongcong));
                        hdban.AddData(hdban1);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể lưu được !");
                            fail = true;
                        }
                        //------------------------------------------------------------------------------
                        // LƯU VÀO CHI TIẾT HÓA ĐƠN
                        try
                        {
                            for (int i = 0; i < dataGridView_bh.Rows.Count - 1; i++)
                            {
                                cthd1.MaHD = comboBox_bh_mahd.Text;
                                cthd1.MaSP = dataGridView_bh.Rows[i].Cells[0].Value.ToString();
                                cthd1.SLBan = int.Parse(dataGridView_bh.Rows[i].Cells[3].Value.ToString());
                                cthd1.DonGiaBan = int.Parse(dataGridView_bh.Rows[i].Cells[4].Value.ToString());
                                cthd1.ThanhTienBan = Convert.ToInt32(dataGridView_bh.Rows[i].Cells[5].Value.ToString());
                                cthd.AddData(cthd1);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Không thể lưu được !");
                            fail = true;

                        }
                        //-------------------------------------------------------------------------------------------------------------------------
                        //TRỪ ĐI SỐ LƯỢNG
                        try
                        {
                            for (int i = 0; i < dataGridView_bh.Rows.Count - 1; i++)
                            {
                                sp2 = sp.GetSL(dataGridView_bh.Rows[i].Cells[0].Value.ToString());
                                int SL = int.Parse(sp2.Rows[0][0].ToString()) - int.Parse(dataGridView_bh.Rows[i].Cells[3].Value.ToString()) ;
                                sp1.MaSP = dataGridView_bh.Rows[i].Cells[0].Value.ToString();
                                sp1.SLTon = SL;
                                sp.EditSL(sp1);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi số lượng!");
                            fail = true;
                        }
                        //-------------------------------------------------------------------------------------------------------------------------
                        // THANH TOÁN
                        if (fail == true)
                        {
                            MessageBox.Show("Không thể lưu hóa đơn !");
                            return;
                        }
                        else
                        {
                            Int64 tienthua = Convert.ToInt64(textBox_khachdua.Text) - tongcong;
                            textBox_tienthua.Text = String.Format("{0:0,0}", tienthua);
                            textBox_tongtien.Text = String.Format("{0:0,0}", tongcong);
                            textBox_khachdua.Text = String.Format("{0:0,0}", tongcong + tienthua);
                            // TẮT GIAO DIỆN
                            MessageBox.Show("Lưu hóa đơn thành công !");
                            button_bh_thanhtoan.Enabled = false;
                            comboBox_bh_tenhang.Enabled = false;
                            textBox_bh_soluong.Enabled = false;
                            comboBox_bh_mh.Enabled = false;
                            comboBox_bh_tennv.Enabled = false;
                            comboBox_bh_makh.Enabled = false;
                            comboBox_bh_dg.Enabled = false;
                            textBox_tongtien.Enabled = false;
                            textBox_tienthua.Enabled = false;
                            textBox_khachdua.Enabled = false;
                            button_bh_xoa.Enabled = false;
                            button_bh_them.Enabled = false;
                            button_bh_sua.Enabled = false;
                            dataGridView_bh.Enabled = false;
                            radioButton_kbt.Enabled = false;
                            radioButton_ktt.Enabled = false;
                            comboBox_bh_tenkh.Enabled = false;
                        }
                    }
                    else
                        return;
                }
            //------------------------------------------------------------------------------------
            // SO SÁNH ĐÃ NHẤN NÚT THANH TOÁN CHƯA
            exit = true;
            //-------------------------------------------------------------------------------------------------------------------------
            // IN HÓA ĐƠN
            HDBan inhd = new HDBan();
            inhd.FilterString = " [MaHD] = '" + comboBox_bh_mahd.Text + "'";
            inhd.CreateDocument();
            HOADONBAN inhdb = new HOADONBAN();
            inhdb.documentViewer1.DocumentSource = inhd;
            inhdb.ShowDialog();
            

            //------------------------------------------------------------------------------------
        }

        private void textBox_tienthua_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_tongtien_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_khachdua_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_mahd_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView_bh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                comboBox_bh_mh.Text = dataGridView_bh.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_bh_tenhang.Text = dataGridView_bh.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox_bh_dg.Text = dataGridView_bh.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_bh_soluong.Text = dataGridView_bh.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void comboBox_bh_makh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_bh_mahd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_bh_Click(object sender, EventArgs e)
        {
            comboBox_bh_mh.Enabled = false;
            comboBox_bh_tenhang.Enabled = false;
            textBox_bh_soluong.Enabled = false;
            testButton();
        }

        private void textBox_bh_soluong_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_bh_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_bh_soluong_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox_bh_mh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_bh_tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label_bh_soluong_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_bh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_khachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_bh_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_bh_CheckedChanged(object sender, EventArgs e)
        {
            checkKH = true;
            comboBox_bh_tenkh.Hide();
            radioButton_kbt.Show();
            radioButton_ktt.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkKH = false;
            radioButton_kbt.Hide();
            radioButton_ktt.Hide();
            comboBox_bh_tenkh.Show();
        }

        private void BanHang_Click(object sender, EventArgs e)
        {
            radioButton_kbt.Show();
            radioButton_ktt.Show();
            comboBox_bh_tenkh.Hide();
            radioButton_kbt.Checked = true;
        }

    }
}
