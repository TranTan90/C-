using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtidngdung.Text == "" || this.txtmatkhau.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập tài khoản ! ");
            }
            else
            {
                if (this.txtidngdung.Text == "tranthithuy")
                    if (this.txtmatkhau.Text == "123456")
                    {
                        this.Hide();
                        Trangchinh tc = new Trangchinh();
                        tc.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                    }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai ! \n Vui lòng nhập lại !", "Thông báo");
                }
            }
        
            this.txtidngdung.Focus();
        }

        private void button_thoatdangnhap_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtidngdung.Text = "tranthithuy";
            txtmatkhau.Text = "190991";
        }
    }
}
