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
    public partial class F_HoaDon : Form
    {
        private const string V = "',N'";
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        public void checkconn()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        public void HienThi()
        {
            cmd = new SqlCommand("select * from HOADON", conn);
            da.SelectCommand = cmd;
            table.Clear(); da.Fill(table); dgv_HoaDon.DataSource = table;
        }
        public F_HoaDon()
        {
            InitializeComponent();
            checkconn();HienThi();
            var cmdd = new SqlCommand("SELECT MaDT FROM DONTHUOC", conn);
            var dr = cmdd.ExecuteReader();
            var dvt = new DataTable();
            dvt.Load(dr); comboBox1.DisplayMember = "MaDT"; comboBox1.DataSource = dvt;
            var cmddd = new SqlCommand("SELECT MaBA FROM BENHAN", conn);
            var drr = cmddd.ExecuteReader();
            var dvt1 = new DataTable();
            dvt1.Load(drr); comboBox2.DisplayMember = "MaBA"; comboBox2.DataSource = dvt1;
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox2.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO HOADON(MaDT,MaBA) VALUES(N'" + comboBox1.Text + "',N'" + comboBox2.Text + "')", conn);
            
            cmd.ExecuteNonQuery();HienThi();
        }
    }
}
