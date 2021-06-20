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
    public partial class F_DONTHUOC : Form
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
        public void HienThi()
        {
            cmd = new SqlCommand("select * from DONTHUOC", conn);
            da.SelectCommand = cmd;
            table.Clear(); da.Fill(table); dgv_DonThuoc.DataSource = table;
        }

        public F_DONTHUOC()
        {
            InitializeComponent();
            checkconn();HienThi();
            var cmd0 = new SqlCommand("select MaBA from BENHAN", conn);
            var dr = cmd0.ExecuteReader();
            DataTable dvt = new DataTable();
            dvt.Load(dr); comboBox1.DisplayMember = "MaBA"; comboBox1.DataSource = dvt;
            var cmd1 = new SqlCommand("select MaThuoC from THUOC", conn);
            var drr = cmd1.ExecuteReader();
            DataTable nvt = new DataTable();
            nvt.Load(drr); comboBox2.DisplayMember = "MaThuoc"; comboBox2.DataSource = nvt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO DONTHUOC VALUES(N'" + textBox1.Text + "',N'" + comboBox1.Text + "',N'" + comboBox2.Text + "','" + numericUpDown1.Value + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE DONTHUOC SET MaBA=N'" + comboBox1.Text + "', MaThuoc=N'" + comboBox2.Text + "',SoLuong='" + numericUpDown1.Value + "'where MaDT=N'" + textBox1.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM DONTHUOC WHERE MaDT=N'" + textBox1.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dgv_DonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgv_DonThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dgv_DonThuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dgv_DonThuoc.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericUpDown1.Value = int.Parse(dgv_DonThuoc.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
    }
}
