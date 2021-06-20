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
    public partial class F_MainUD : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();

        public F_MainUD()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new F_KhamBenh();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new F_Thongke();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f =new F_CAPNHAT();
            f.ShowDialog();
        }
    }
}
