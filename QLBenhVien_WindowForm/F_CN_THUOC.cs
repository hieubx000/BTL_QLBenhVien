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
    public partial class F_CN_THUOC : Form
    {
        public void HienThi()
        {
            cmd.CommandText = "select * from THUOC";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dgv_THUOC_show.DataSource = table;
        }
        public void checkconn()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        public F_CN_THUOC()
        {
            InitializeComponent();
            checkconn();
            HienThi();
        }

        private void dgv_THUOC_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaThuoc.Text = dgv_THUOC_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tenThuoc.Text = dgv_THUOC_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_MaNCC.Text = dgv_THUOC_show.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_SL.Text= dgv_THUOC_show.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_Gia.Text= dgv_THUOC_show.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO THUOC VALUES(N'" + tb_MaThuoc.Text + "',N'" + tb_tenThuoc.Text + "',N'" + tb_MaNCC.Text + "','" + tb_SL.Text + "','" + tb_Gia.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE THUOC SET MaThuoc=N'" + tb_MaThuoc.Text + "',TenThuoc=N'" + tb_tenThuoc.Text + "',MaNCC=N'" + tb_MaNCC.Text + "',SLCon='" + tb_SL.Text + "',GiaThuoc='" + tb_Gia.Text + "' WHERE MaThuoc=N'" + tb_MaThuoc.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM THUOC WHERE MaThuoc=N'" + tb_MaThuoc.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
