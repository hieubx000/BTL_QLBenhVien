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
    
    public partial class F_CN_Khoa : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=quangsqq;Password=quang123");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        public F_CN_Khoa()
        {
            InitializeComponent();
            conn.Open();
            HienThi();
        }
        public void resettextbox()
        {
            tb_MaKhoa.Clear();
            tb_tenKhoa.Clear();
            tb_SL.Clear();
        }
        public void HienThi()
        {
            cmd.CommandText = "select * from KHOA";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dgv_Khoa_show.DataSource = table;
        }
        public void checkconn()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }
        private void bt_Them_Click(object sender, EventArgs e)
        {
            checkconn();

            //cmd.CommandText = "INSERT INTO  KHOA VALUES(N'"+tb_MaKhoa.Text+"',N'"+tb_tenKhoa.Text+"',N'"+tb_SL.Text+"')";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd =new SqlCommand("sp_Khoa_in @ma,@ten,@SL",conn);
            cmd.Parameters.AddWithValue("@ma", tb_MaKhoa.Text);
            cmd.Parameters.AddWithValue("@ten", tb_tenKhoa.Text);
            cmd.Parameters.AddWithValue("@SL", tb_SL.Text); 
            cmd.ExecuteNonQuery();
            HienThi();
            resettextbox();
        }

        private void dgv_Khoa_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaKhoa.Text = dgv_Khoa_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_tenKhoa.Text = dgv_Khoa_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_SL.Text = dgv_Khoa_show.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            checkconn();
            string mk = tb_MaKhoa.Text;
            cmd.CommandText = "UPDATE KHOA SET MaKhoa=N'" + tb_MaKhoa.Text + "',TenKhoa=N'" + tb_tenKhoa.Text + "',SoNhanVien=N'" + tb_SL.Text +
                "' WHERE MaKhoa= N'" + mk+"'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
            resettextbox();
        }

        private void bt_Xóa_Click(object sender, EventArgs e)
        {
            checkconn();
            cmd.CommandText = "DELETE FROM KHOA WHERE MaKhoa=N'" + tb_MaKhoa.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
            resettextbox();
        }
    }
}
