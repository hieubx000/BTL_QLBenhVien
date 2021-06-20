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
    public partial class F_CN_NCC : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        public F_CN_NCC()
        {
            InitializeComponent();
            checkconn();
            HienThi();
        }
        public void checkconn()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        public void HienThi()
        {
            cmd.CommandText = "select * from NHACUNGCAP";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dgv_NCC_show.DataSource = table;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO NHACUNGCAP VALUES(N'" + tb_MaNCC.Text + "',N'" + tb_tenNCC.Text + "',N'" + tb_DiaChi.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE NHACUNGCAP SET MaNCC=N'" + tb_MaNCC.Text + "',TenNCC=N'" + tb_tenNCC.Text + "',DiaChi=N'" + tb_DiaChi.Text + "' where MaNCC=N'" + tb_MaNCC.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM NHACUNGCAP WHERE MaNCC=N'" + tb_MaNCC.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dgv_NCC_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNCC.Text = dgv_NCC_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tenNCC.Text = dgv_NCC_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_DiaChi.Text = dgv_NCC_show.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
