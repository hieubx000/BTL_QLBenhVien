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
    public partial class F_CAPNHAT : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void checkconn()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        public F_CAPNHAT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = null;
            if (comboBox1.Text == "Khoa")
                f = new F_CN_Khoa();
            else if (comboBox1.Text == "Nhân Viên")
                f = new F_CN_NV();
            else if (comboBox1.Text == "Nhà Cung Cấp")
                f = new F_CN_NCC();
            else if (comboBox1.Text == "Thuốc")
                f = new F_CN_THUOC();
            else if (comboBox1.Text == "Dịch Vụ")
                f = new F_CN_DV();
            f.ShowDialog();
        }
    }
}
