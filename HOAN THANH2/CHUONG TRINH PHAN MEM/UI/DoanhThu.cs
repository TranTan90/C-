using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Model;
using Data_Access_Layer;
using Business_Layer;
namespace UI
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        BUS_SANPHAM sp = new BUS_SANPHAM();
        BUS_CHITIETHDBAN cthd = new BUS_CHITIETHDBAN();
        BUS_CHITIETPN ctpn = new BUS_CHITIETPN();
        DataTable dt = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        Int64 num = 0;
        bool std ;
        bool Status=false;
        void Opensearch()
        {
            radioButton_tn.Show();
            radioButton_tt.Show();
            dateTimePicker_tn.Show();
        }
        void CloseSearch()
        {
            radioButton_tt.Hide();
            radioButton_tn.Hide();
            dateTimePicker_tn.Hide();
        }
        private void button_nh_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trangchinh tc = new Trangchinh();
            tc.ShowDialog();
        }
        void Display()
        {
            if (Status == false)
            {
                chart_bh.Series["Nhập"].IsValueShownAsLabel = false;
                chart_bh.Series["Bán"].IsValueShownAsLabel = false;
            }
            else
            {
                chart_bh.Series["Nhập"].IsValueShownAsLabel = true;
                chart_bh.Series["Bán"].IsValueShownAsLabel = true;

            }
        }
        void TheoBieuDo()
        {
            try
            {
                this.chart_bh.Series["Nhập"].Points.Clear();
                this.chart_bh.Series["Bán"].Points.Clear();
                Int64 TienNhap = 0;
                Int64 TienBan = 0;
                for (int i = 1; i <= 12; i++)
                {
                    dt = ctpn.HDBH("'" + i + "'");
                    if (dt.Rows[0][0].ToString() == "")
                    { num = 0; }
                    else
                    { num = Int64.Parse(dt.Rows[0][0].ToString()); }
                    TienNhap = TienNhap + num;
                    this.chart_bh.Series["Nhập"].Points.AddXY(i, num);
                    //----------------------------
                    dt = cthd.HDBH("'" + i + "'");
                    if (dt.Rows[0][0].ToString() == "")
                    { num = 0; }
                    else
                    { num = Int64.Parse(dt.Rows[0][0].ToString()); }
                    this.chart_bh.Series["Bán"].Points.AddXY(i, num);
                    TienBan = TienBan + num;
                }
                comboBox_dt_loinhuan.Text = String.Format("{0:0,0}",TienBan - TienNhap) + " VNĐ ";
            }
            catch
            {
                MessageBox.Show("Lỗi số liệu hệ thống !");
                return;
            }
        }
        void TheoThoiGian()
        {
            try
            {
                if (dataGridView_theothang.Rows.Count > 1)
                {
                    while (dataGridView_theothang.Rows.Count > 0)
                    {

                        dataGridView_theothang.Rows.RemoveAt(0);
                    }
                }
                //THEO NGAY : TRUE  -- THEO THANG : FALSE
                if(std==true)
                {
                    DataTable dt11 = sp.GetData("");
                    for(int i= 0;i<=dt11.Rows.Count - 1 ; i++)
                    {
                        DataTable dt22 = ctpn.DTHangNgay("'" + dateTimePicker_tn.Value.Date.ToString("yyyy/MM/dd") + "'", "'" + dt11.Rows[i][2].ToString() + "'");
                        DataTable dt33 = cthd.DTHangNgay("'" + dateTimePicker_tn.Value.Date.ToString("yyyy/MM/dd") + "'", "'" + dt11.Rows[i][2].ToString() + "'");
                        if (dt22.Rows[0][0].ToString() == "")
                        {
                            dt22.Rows[0][0] = "0";
                        }
                        if (dt22.Rows[0][1].ToString() == "")
                        {
                            dt22.Rows[0][1] = "0";
                        }
                        if (dt33.Rows[0][0].ToString() == "")
                        {
                            dt33.Rows[0][0] = "0";
                        }
                        if (dt33.Rows[0][1].ToString() == "")
                        {
                            dt33.Rows[0][1] = "0";
                        }
                        Int64 thanhtien = Int64.Parse(dt33.Rows[0][1].ToString()) - Int64.Parse(dt22.Rows[0][1].ToString());
                        if (thanhtien < 0)
                        {
                            dt5.Rows.Add(dt11.Rows[i][2].ToString(), dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), "Chưa hoàn vốn ");
                        }
                        else
                        {
                            dt5.Rows.Add(dt11.Rows[i][2].ToString(), dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), thanhtien);
                        }
                        dataGridView_theothang.DataSource = dt5;
                    }
                }
                else
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        DataTable dt22 = ctpn.DTTheoNgay("'" + i + "'");
                        DataTable dt33 = cthd.DTTheoNgay("'" + i + "'");
                        if (dt22.Rows[0][0].ToString() == "")
                        {
                            dt22.Rows[0][0] = "0";
                        }
                        if (dt22.Rows[0][1].ToString() == "")
                        {
                            dt22.Rows[0][1] = "0";
                        }
                        if (dt33.Rows[0][0].ToString() == "")
                        {
                            dt33.Rows[0][0] = "0";
                        }
                        if (dt33.Rows[0][1].ToString() == "")
                        {
                            dt33.Rows[0][1] = "0";
                        }
                        Int64 thanhtien = Int64.Parse(dt33.Rows[0][1].ToString()) - Int64.Parse(dt22.Rows[0][1].ToString());
                        if (thanhtien < 0)
                        {
                            dt4.Rows.Add("Tháng " + i, dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), "Chưa hoàn vốn ");
                        }
                        else
                        {
                            dt4.Rows.Add("Tháng " + i, dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), thanhtien);
                        }
                        dataGridView_theothang.DataSource = dt4;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Lỗi số liệu hệ thống !");
                return;
            }
        }
        void TheoMatHang()
        {
            try
            {
                if (dataGridView_theohang.Rows.Count > 1)
                {
                    while (dataGridView_theohang.Rows.Count > 0)
                    {

                            dataGridView_theohang.Rows.RemoveAt(0);
                    }
                }
                    DataTable dt11 = sp.GetData("");
                for (int i = 0; i <= dt11.Rows.Count - 1; i++)
                {
                    DataTable dt22 = ctpn.TongDTNhap("'" + dt11.Rows[i][2].ToString() + "'");
                    DataTable dt33 = cthd.TongDTBan("'" + dt11.Rows[i][2].ToString() + "'");
                    if (dt22.Rows[0][0].ToString() == "")
                    {
                        dt22.Rows[0][0] = "0";
                    }
                    if (dt22.Rows[0][1].ToString() == "")
                    {
                        dt22.Rows[0][1] = "0";
                    }
                    if (dt33.Rows[0][0].ToString() == "")
                    {
                        dt33.Rows[0][0] = "0";
                    }
                    if (dt33.Rows[0][1].ToString() == "")
                    {
                        dt33.Rows[0][1] = "0";
                    }
                    Int64 thanhtien =Int64.Parse(dt33.Rows[0][1].ToString()) - Int64.Parse(dt22.Rows[0][1].ToString());
                    if(thanhtien < 0)
                    {
                        dt3.Rows.Add(dt11.Rows[i][2].ToString(), dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), "Chưa hoàn vốn ");
                    }
                    else
                    {
                        dt3.Rows.Add(dt11.Rows[i][2].ToString(), dt22.Rows[0][0].ToString(), dt33.Rows[0][0].ToString(), dt22.Rows[0][1].ToString(), dt33.Rows[0][1].ToString(), thanhtien);
                    }
                    dataGridView_theohang.DataSource = dt3;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi số liệu hệ thống !");
                return;
            }
        }
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            chart_bh.Hide();
            dataGridView_theohang.Hide();
            dataGridView_theothang.Hide();
            label_tongloinhuan.Hide();
            comboBox_dt_loinhuan.Hide();
            CloseSearch();
            //- bang hang
            dt3.Columns.Add("TenSP");
            dt3.Columns.Add("SoLuongNhap");
            dt3.Columns.Add("SoLuongBan");
            dt3.Columns.Add("TongTienNhap");
            dt3.Columns.Add("TongTienBan");
            dt3.Columns.Add("LoiNhuan");
            //- bang thoi gian theo thang
            dt4.Columns.Add("ThoiGian");
            dt4.Columns.Add("SoLuongNhap");
            dt4.Columns.Add("SoLuongBan");
            dt4.Columns.Add("TongTienNhap");
            dt4.Columns.Add("TongTienBan");
            dt4.Columns.Add("LoiNhuan");
            // Bang thoi gian theo ngay
            dt5.Columns.Add("TenSP");
            dt5.Columns.Add("SoLuongNhap");
            dt5.Columns.Add("SoLuongBan");
            dt5.Columns.Add("TongTienNhap");
            dt5.Columns.Add("TongTienBan");
            dt5.Columns.Add("LoiNhuan");
            //
            pictureBox_bd.Hide();
            pictureBox_mh.Hide();
            pictureBox_tg.Hide();
        }

        private void chart_bh_Click(object sender, EventArgs e)
        {
            Status = true;
            Display();
        }

        private void chart_bh_DoubleClick(object sender, EventArgs e)
        {
            Status = false;
            Display();
        }

        private void dataGridView_hh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton_dt_bd_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_tn.Hide();
            radioButton_tt.Hide();
            label_tongloinhuan.Show();
            comboBox_dt_loinhuan.Show();
            pictureBox_bd.Show();
            pictureBox_mh.Hide();
            pictureBox_tg.Hide();
            CloseSearch();
            chart_bh.Show();
            dataGridView_theohang.Hide();
            dataGridView_theothang.Hide();
            TheoBieuDo();
        }

        private void radioButton_theohang_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_tn.Hide();
            radioButton_tt.Hide();
            label_tongloinhuan.Hide();
            comboBox_dt_loinhuan.Hide();
            pictureBox_bd.Hide();
            pictureBox_mh.Show();
            pictureBox_tg.Hide();
            CloseSearch();
            chart_bh.Hide();
            dataGridView_theothang.Hide();
            dataGridView_theohang.Show();
            TheoMatHang();
        }

        private void radioButton_theothoigian_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_tn.Show();
            radioButton_tt.Show();
            label_tongloinhuan.Hide();
            comboBox_dt_loinhuan.Hide();
            pictureBox_bd.Hide();
            pictureBox_mh.Hide();
            pictureBox_tg.Show();
            CloseSearch();
            chart_bh.Hide();
            dataGridView_theothang.Show();
            dataGridView_theohang.Hide();
            Opensearch();
            dateTimePicker_tn.Hide();
            TheoThoiGian();
        }

        private void dataGridView_theothoigian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker_tn_ValueChanged(object sender, EventArgs e)
        {
            std = true;
            TheoThoiGian();
        }

        private void radioButton_tn_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_tn.Show();
            std = true;
            TheoThoiGian();
        }

        private void radioButton_tt_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_tn.Hide();
            std = false;
            TheoThoiGian();
        }

        private void dateTimePicker_tn_KeyPress(object sender, KeyPressEventArgs e)
        {
            std = true;
            TheoThoiGian();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            std = true;
            TheoThoiGian();
        }
    }
}
