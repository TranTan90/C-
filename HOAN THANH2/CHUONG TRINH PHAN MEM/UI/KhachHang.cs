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
using Business_Layer;
namespace UI
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        BUS_KHACHHANG bus = new BUS_KHACHHANG();
        KHACH_HANG ex = new KHACH_HANG();
        DataTable kh = new DataTable();
        bool addnew;
        void LockKH()
        {
            textBox_kh_makh.Enabled = false;
            textBox_kh_tenkh.Enabled = false;
            textBox_kh_sdt.Enabled = false;
            textBox_kh_dc.Enabled = false;
            textBox_kh_dc.BackColor = Color.DarkGray;
            textBox_kh_makh.BackColor = Color.DarkGray;
            textBox_kh_sdt.BackColor = Color.DarkGray;
            textBox_kh_tenkh.BackColor = Color.DarkGray;
            
             
            button_kh_them.Enabled = true;
            button_kh_luu.Enabled = false;
            button_kh_sua.Enabled = false;
            button_kh_xoa.Enabled = false;
            button_kh_huybo.Enabled = false;
        }
        void OpenKH()
        {
            textBox_kh_tenkh.Enabled = true;
            textBox_kh_sdt.Enabled = true;
            textBox_kh_dc.Enabled = true;
            textBox_kh_dc.BackColor = Color.White;
            textBox_kh_makh.BackColor = Color.White;
            textBox_kh_sdt.BackColor = Color.White;
            textBox_kh_tenkh.BackColor = Color.White;

            button_kh_them.Enabled = false;
            button_kh_luu.Enabled = false;
            button_kh_sua.Enabled = false;
            button_kh_xoa.Enabled =false;
            button_kh_huybo.Enabled = false;
        }
        void SetNull()
        {
            textBox_kh_makh.Text = "";
            textBox_kh_tenkh.Text = "";
            textBox_kh_sdt.Text = "";
            textBox_kh_dc.Text = "";
            comboBox_timkiem.Text = "";
        }
        void AutoNCC()
       {
            kh = bus.GetMaKH();
            if (kh == null || kh.Rows.Count == 0)
            {
                textBox_kh_makh.Text = "KH0001";
            }
            else
            {
                int tam1 = int.Parse(kh.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    textBox_kh_makh.Text = "KH000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                    {
                        tam1 = tam1 + 1;
                        textBox_kh_makh.Text = "KH00" + Convert.ToString(tam1);
                    }
                    else
                        if (tam1 < 1000)
                        {
                            tam1 = tam1 + 1;
                            textBox_kh_makh.Text = "KH0" + Convert.ToString(tam1);
                        }
            }
        }
        void Display()
        {
            dataGridView_kh.DataSource = bus.GetData("");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_kh_thoat_Click(object sender, EventArgs e)
        {
            SetNull();
            LockKH();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            comboBox_timkiem.DataSource = bus.GetData("");
            comboBox_timkiem.ValueMember = "TenKH";
            comboBox_timkiem.Text = "";
            LockKH();
            dataGridView_kh.DataSource = bus.GetData("");
        }

        private void button_kh_them_Click(object sender, EventArgs e)
        {
            OpenKH();
            SetNull();
            addnew = true;
            button_kh_luu.Enabled = true;
            button_kh_huybo.Enabled = true;
            AutoNCC();
            Display(); 
            this.textBox_kh_makh.Focus();

        }

        private void button_kh_luu_Click(object sender, EventArgs e)
        {
            if(textBox_kh_makh.Text=="")
            {
                MessageBox.Show("Lỗi mã khách hàng !");
                return;
            }
            if (textBox_kh_tenkh.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên khách hàng !");
                return;
            }
            if (textBox_kh_sdt.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại của khách hàng !");
                return;
            }
            if (textBox_kh_dc.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại địa chỉ của khách hàng !");
                return;
            }
            if(addnew == true)
            {
                try
                {
                    if (textBox_kh_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_kh_sdt.Text.Length == 10 || textBox_kh_sdt.Text.Length == 11)
                        {
                            ex.MaKH = textBox_kh_makh.Text;
                            ex.TenKH = textBox_kh_tenkh.Text;
                            ex.SDTKH = textBox_kh_sdt.Text;
                            ex.DiaChiKH = textBox_kh_dc.Text;
                            bus.AddData(ex);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
                 else
            {
                try
                {
                    if (textBox_kh_sdt.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (textBox_kh_sdt.Text.Length == 10 || textBox_kh_sdt.Text.Length == 11)
                        {
                            ex.MaKH = textBox_kh_makh.Text;
                            ex.TenKH = textBox_kh_tenkh.Text;
                            ex.SDTKH = textBox_kh_sdt.Text;
                            ex.DiaChiKH = textBox_kh_dc.Text;
                            bus.EditData(ex);
                        }
                    }
                }
                catch 
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }
                    
            }
            LockKH();
            Display();
            }

        private void button_kh_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_kh_makh.Text=="")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                }
                OpenKH();
                textBox_kh_makh.Enabled = false;
                textBox_kh_makh.BackColor = Color.DarkGray;
                addnew = false;
                button_kh_luu.Enabled = true;
                button_kh_huybo.Enabled = true;
                this.textBox_kh_tenkh.Focus();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể sửa dữ liệu !");
                return;
            }
        }

        private void button_kh_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_kh_makh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                }
                ex.MaKH = textBox_kh_makh.Text;
                bus.DeleteData(ex);
                LockKH();
                SetNull();
                Display();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa dữ liệu !");
            }
        }

        private void dataGridView_kh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LockKH();
            button_kh_them.Enabled = false;
            button_kh_sua.Enabled = true;
            button_kh_xoa.Enabled = true;
            button_kh_huybo.Enabled = true;
            try
            {
                textBox_kh_makh.Text = dataGridView_kh.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_kh_tenkh.Text = dataGridView_kh.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_kh_sdt.Text = dataGridView_kh.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_kh_dc.Text = dataGridView_kh.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
        private void dataGridView_kh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenKH();
            textBox_kh_makh.Enabled = false;
            button_kh_luu.Enabled = true;
            button_kh_huybo.Enabled = true;
            addnew = false;
            this.textBox_kh_tenkh.Focus();
        }

        private void dataGridView_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_kh_tc_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }

        private void textBox_kh_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox_timkiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            dataGridView_kh.DataSource = bus.SearchKH("'" + comboBox_timkiem.Text + "'");
            OpenKH();
            button_kh_huybo.Enabled = true;
            button_kh_sua.Enabled = true;
            button_kh_xoa.Enabled = true;
        }

    }
}