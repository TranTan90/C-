using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Data_Access_Layer;
using Business_Layer;

namespace UI
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        BUS_SANPHAM sp = new BUS_SANPHAM();
        BUS_NHOMSANPHAM nsp = new BUS_NHOMSANPHAM();
        BUS_NHACUNGCAP ncc = new BUS_NHACUNGCAP();
        SAN_PHAM sp1 = new SAN_PHAM();
        NHOM_SAN_PHAM nsp1 = new NHOM_SAN_PHAM();
        DataTable sp2 = new DataTable();
        bool addnew;
        void CloseHH()
        {
            comboBox_hh_tensp.Enabled = false;
            comboBox_hh_manhom.Enabled = false;
            comboBox_hh_dvt.Enabled = false;
            comboBox_hh_gn.Enabled = false;
            comboBox_hh_gb.Enabled = false;
            comboBox_hh_slt.Enabled = false;
            comboBox_hh_tennhom.Enabled = false;
            comboBox_hh_dvt.BackColor = Color.DarkGray;
            comboBox_hh_gb.BackColor = Color.DarkGray;
            comboBox_hh_gn.BackColor = Color.DarkGray;
            comboBox_hh_manhom.BackColor = Color.DarkGray;
            comboBox_hh_tennhom.BackColor = Color.DarkGray;
            comboBox_hh_masp.BackColor = Color.DarkGray;
            comboBox_hh_slt.BackColor = Color.DarkGray;
            comboBox_hh_tensp.BackColor = Color.DarkGray;
        }
        void OpenHH()
        {
            comboBox_hh_manhom.Enabled = true;
            comboBox_hh_tensp.Enabled = true;
            comboBox_hh_dvt.Enabled = true;
            comboBox_hh_gn.Enabled = true;
            comboBox_hh_gb.Enabled = true;
            comboBox_hh_slt.Enabled = true;
            comboBox_hh_dvt.BackColor = Color.White;
            comboBox_hh_gb.BackColor = Color.White;
            comboBox_hh_gn.BackColor = Color.White;
            comboBox_hh_slt.BackColor = Color.White;
            comboBox_hh_tensp.BackColor = Color.White;
        }
        void testbutton()
        {
            if(dataGridView_hh.Rows.Count <=0)
            {
                button_hh_xoa.Enabled = false;
                button_hh_huybo.Enabled = false;
                button_hh_luu.Enabled = false;
                button_hh_sua.Enabled = false;
                button_hh_them.Enabled = true;
            }
            else
            {
                button_hh_xoa.Enabled = true;
                button_hh_huybo.Enabled = false;
                button_hh_luu.Enabled = false;
                button_hh_sua.Enabled = true;
                button_hh_them.Enabled = true;
            }
        }
        void Setnull()
        {
            comboBox_hh_masp.Text = "";
            comboBox_hh_manhom.Text = "";
            comboBox_hh_dvt.Text = "";
            comboBox_hh_gb.Text = "";
            comboBox_hh_gn.Text = "";
            comboBox_hh_tensp.Text = "";
            comboBox_hh_slt.Text = "";
            comboBox_timkiem.Text = "";
        }
        void AuToMaSP()
        {
            // MÃ SẢN PHẨM TỰ SINH
            sp2 = sp.GetAUTOMaSP();
            if (sp2 == null || sp2.Rows.Count == 0)
            {
                comboBox_hh_masp.Text = "SP000001";
            }
            else
            {
                int tam1 = int.Parse(sp2.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    comboBox_hh_masp.Text = "SP00000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                    {
                        tam1 = tam1 + 1;
                        comboBox_hh_masp.Text = "SP0000" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 1000)
                        {
                            tam1 = tam1 + 1;
                            comboBox_hh_masp.Text = "SP000" + Convert.ToString(tam1);
                        }
                        else
                            if (tam1 < 10000)
                            {
                                tam1 = tam1 + 1;
                                comboBox_hh_masp.Text = "SP00" + Convert.ToString(tam1);
                            }
                            else
                                if (tam1 < 100000)
                                {
                                    tam1 = tam1 + 1;
                                    comboBox_hh_masp.Text = "SP0" + Convert.ToString(tam1);
                                }
                                else
                                    if (tam1 < 1000000)
                                    {
                                        tam1 = tam1 + 1;
                                        comboBox_hh_masp.Text = "SP" + Convert.ToString(tam1);
                                    }
            }
        }
        void Display()
        {
            dataGridView_hh.DataSource = sp.GetData("");
            CheckStatusHH();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
            void CheckStatusHH()
            {
                            sp2 = sp.GetData("");
            for (int i = 0; i <= sp2.Rows.Count - 1; i++)
            {
                try
                {
                    if (int.Parse(sp2.Rows[i][4].ToString()) == 0)
                    {
                       
                        dataGridView_hh.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

                    }
                    else
                    {
                        if (int.Parse(sp2.Rows[i][4].ToString()) < 10)
                        {
                            dataGridView_hh.Rows[i].DefaultCellStyle.ForeColor = Color.Gold;
                        }
                    }
                }
                catch
                { }
            }
            }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            CloseHH();
            Display();
            // LOAD VÀO CÁC COMBO BOX
            sp2 = sp.GetData("");
            comboBox_hh_masp.DataSource = sp2;
            comboBox_hh_masp.DataSource = sp2;
            comboBox_hh_tensp.DataSource = sp2;
            comboBox_hh_dvt.DataSource = sp2;
            comboBox_hh_slt.DataSource = sp2;
            comboBox_hh_gb.DataSource = sp2;
            comboBox_hh_gn.DataSource = sp2;
            comboBox_hh_masp.ValueMember = "MaSP";
            comboBox_hh_tensp.ValueMember = "TenSP";
            comboBox_hh_dvt.ValueMember = "DonViTinh";
            comboBox_hh_slt.ValueMember = "SLTon";
            comboBox_hh_gb.ValueMember = "GiaBan";
            comboBox_hh_gn.ValueMember = "GiaNhap";
            comboBox_hh_mancc.DataSource = ncc.GetData("");
            comboBox_hh_mancc.ValueMember = "MaNCC";
            comboBox_timkiem.DataSource = sp.GetData("");
            comboBox_timkiem.ValueMember = "TenSP";
            comboBox_timkiem.Text = "";
            sp2 = nsp.GetData("");
            comboBox_hh_manhom.DataSource = sp2;
            comboBox_hh_tennhom.DataSource = sp2;
            comboBox_hh_manhom.ValueMember = "MaNhom";
            comboBox_hh_tennhom.ValueMember = "TenNhom";
            comboBox_hh_masp.Enabled = false;
            comboBox_hh_tennhom.Enabled = false;
            testbutton();
            //----------------------------------------------------------------------------------
        }

        private void button_hh_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void button_hh_huybo_Click(object sender, EventArgs e)
        {
            Setnull();
            testbutton();
            CloseHH();
        }

        private void dataGridView_hh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CloseHH();
            button_hh_sua.Enabled = true;
            button_hh_huybo.Enabled = true;
            try
            {
                comboBox_hh_masp.Text = dataGridView_hh.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_hh_manhom.Text = dataGridView_hh.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox_hh_tensp.Text = dataGridView_hh.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox_hh_dvt.Text = dataGridView_hh.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox_hh_slt.Text = dataGridView_hh.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBox_hh_gb.Text = dataGridView_hh.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBox_hh_gn.Text = dataGridView_hh.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void button_hh_sua_Click(object sender, EventArgs e)
        {
            if (comboBox_hh_masp.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới !","Thông báo !");
                return;
            }
            addnew = false;
            OpenHH();
            button_hh_luu.Enabled = true;
            button_hh_huybo.Enabled = true;
            button_hh_sua.Enabled = false;
            button_hh_them.Enabled = false;
            button_hh_xoa.Enabled = false;
            this.comboBox_hh_tensp.Focus();
        }

        private void button_hh_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_hh_masp.Text=="")
                {
                    MessageBox.Show("Lỗi mã sản phẩm !");
                    return;
                }
                if (comboBox_hh_tensp.Text == "")
                {
                    MessageBox.Show("Xin mời nhập lại tên sản phẩm !");
                    return;
                }
                if (comboBox_hh_manhom.Text == "")
                {
                    MessageBox.Show("Lỗi mã nhóm sản phẩm!");
                    return;
                }
                if (comboBox_hh_dvt.Text == "")
                {
                    MessageBox.Show("Xin mời nhập lại đơn vị tính !");
                    return;
                }
                if (comboBox_hh_slt.Text == "" || int.Parse(comboBox_hh_slt.Text) == 0)
                {
                    MessageBox.Show("Xin mời nhập lại số lượng tồn !");
                    return;
                }
                if (comboBox_hh_gb.Text == "" || int.Parse(comboBox_hh_gb.Text) == 0)
                {
                    MessageBox.Show("Xin mời nhập lại giá bán !");
                    return;
                }
                if (comboBox_hh_gn.Text == "" || int.Parse(comboBox_hh_gn.Text) == 0)
                {
                    MessageBox.Show("Xin mời nhập lại giá nhập !");
                    return;
                }
                if (comboBox_hh_mancc.Text == "")
                {
                    MessageBox.Show("Lỗi mã nhà cung cấp !");
                    return;
                }
                if (addnew == true)
                {
                    sp1.MaSP = comboBox_hh_masp.Text;
                    sp1.TenSP = comboBox_hh_tensp.Text;
                    sp1.MaNhom = comboBox_hh_manhom.Text;
                    sp1.DonViTinh = comboBox_hh_dvt.Text;
                    sp1.SLTon = int.Parse(comboBox_hh_slt.Text);
                    sp1.GiaBan = int.Parse(comboBox_hh_gb.Text);
                    sp1.GiaNhap = int.Parse(comboBox_hh_gn.Text);
                    sp1.MaNCC = comboBox_hh_mancc.Text;
                    sp.AddData(sp1);
                }
                else
                {
                    sp1.MaSP = comboBox_hh_masp.Text;
                    sp1.TenSP = comboBox_hh_tensp.Text;
                    sp1.MaNhom = comboBox_hh_manhom.Text;
                    sp1.DonViTinh = comboBox_hh_dvt.Text;
                    sp1.SLTon = int.Parse(comboBox_hh_slt.Text);
                    sp1.GiaBan = int.Parse(comboBox_hh_gb.Text);
                    sp1.GiaNhap = int.Parse(comboBox_hh_gn.Text);
                    sp1.MaNCC = comboBox_hh_mancc.Text;
                    sp.EditData(sp1);
                }
            }
            catch
            {
                MessageBox.Show("Không thể sửa được !");
            }
            Setnull();
            CloseHH();
            Display();
            button_hh_xoa.Enabled = true;
            button_hh_sua.Enabled = true;
            button_hh_huybo.Enabled = false;
            button_hh_them.Enabled = true;
            button_hh_luu.Enabled = false;
        }

        private void comboBox_hh_slx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_hh_slt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_gn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_hh_gn_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_gb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_sln_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_hh_slx_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_hh.DataSource = sp.GetData("WHERE TenSP=N'" + comboBox_timkiem.Text + "'");
            CloseHH();
            button_hh_them.Enabled = true;
            button_hh_luu.Enabled = false;
            button_hh_sua.Enabled = true;
            button_hh_xoa.Enabled = true;
            button_hh_huybo.Enabled = true;
        }

        private void button_nh_them_Click(object sender, EventArgs e)
        {
            addnew = true;
            Setnull();
            AuToMaSP();
            OpenHH();
            button_hh_huybo.Enabled = true;
            button_hh_luu.Enabled = true;
            button_hh_sua.Enabled = false;
            button_hh_them.Enabled = false;
            button_hh_xoa.Enabled = false;
            this.comboBox_hh_tensp.Focus();
        }

        private void button_hh_xoa_Click(object sender, EventArgs e)
        {
            if(comboBox_hh_masp.Text=="" || comboBox_hh_tensp.Text == "" )
            {
                MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                return;
            }
            sp1.MaSP = comboBox_hh_masp.Text;
            sp.DeleteData(sp1);
            CloseHH();
            Setnull();
            Display();
            testbutton();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
