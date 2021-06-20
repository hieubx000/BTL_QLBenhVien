using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhVien_UD
{
    public partial class F_Thongke : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        public F_Thongke()
        {
            InitializeComponent();
            
        }

        private void bt_HienThi_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            if (comboBox1.Text == "Thống Kê Bệnh Án Theo Ngày")
            {
                cmd.CommandText = "Select * from vw_ThongTinKhamBenh where NgayKhamBenh>='" + dateTimePicker1.Text + "'AND NgayKhamBenh<='"+dateTimePicker2.Text+"'";
            }
            if(comboBox1.Text=="Thống Kê Bệnh Án Theo Nhân Viên Khám")
            {
                cmd.CommandText = "Select * from vw_ThongTinKhamBenh WHERE TenNV=N'" + textBox1.Text + "'";
            }
            if(comboBox1.Text== "Thống Kê Đơn Thuốc")
            {
                cmd.CommandText = "Select * from DONTHUOC";
            }
            if(comboBox1.Text=="Thống Kê Hóa Đơn")
            {
                cmd.CommandText = "Select * from HOADON";
            }
            cmd.Connection = conn;
            da.SelectCommand = cmd;table.Clear();da.Fill(table);dataGridView1.DataSource = table; 
        }
    }
}
