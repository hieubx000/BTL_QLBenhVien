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
    public partial class F_CN_DV : Form
    {
        public void HienThi()
        {
            cmd.CommandText = "select * from DICHVU";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dgv_DichVu_show.DataSource = table;
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
        public F_CN_DV()
        {
            InitializeComponent();
            checkconn();
            HienThi();
        }

        private void dgv_DichVu_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaDV.Text= dgv_DichVu_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tenDV.Text= dgv_DichVu_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Gia.Text= dgv_DichVu_show.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO DICHVU VALUES(N'" + tb_MaDV.Text + "',N'" + tb_tenDV.Text + "',N'" + tb_Gia.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE DICHVU SET MaDV=N'" + tb_MaDV.Text + "',TenDV=N'" + tb_tenDV.Text + "',GiaDV=N'" + tb_Gia.Text +
                "' WHERE MaDV= N'" + tb_MaDV.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Xóa_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM DICHVU WHERE MaDV=N'" + tb_MaDV.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
