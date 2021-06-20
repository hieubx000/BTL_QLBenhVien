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
    public partial class F_CN_NV : Form
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
        public F_CN_NV()
        {
            InitializeComponent();
            checkconn();HienThi();
            var cmd0 = new SqlCommand("select MaKhoa from KHOA", conn);
            var dr = cmd0.ExecuteReader();
            DataTable dvt = new DataTable();
            dvt.Load(dr); cb_MaKhoa.DisplayMember = "MaKhoa"; cb_MaKhoa.DataSource = dvt;
        }
        public void HienThi()
        {
            cmd.CommandText = "select * from NHANVIEN";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();
            da.Fill(table);
            dgv_NhanVien_show.DataSource = table;
        }
        private void dgv_NhanVien_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNV.Text = dgv_NhanVien_show.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_TenNV.Text = dgv_NhanVien_show.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gt = dgv_NhanVien_show.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (gt == "Nam")
                rb_Nam.Checked = true;
            else rb_Nu.Checked = true;
            dtp_NgaySinh.Text= dgv_NhanVien_show.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_ChucVu.Text = dgv_NhanVien_show.Rows[e.RowIndex].Cells[4].Value.ToString();
            cb_MaKhoa.Text = dgv_NhanVien_show.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_DiaChi.Text = dgv_NhanVien_show.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            checkconn();
            string gt;
            if (rb_Nam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            cmd.CommandText = "INSERT INTO NHANVIEN VALUES(N'" + tb_MaNV.Text + "',N'" + tb_TenNV.Text + "',N'" + gt + "','" + dtp_NgaySinh.Value.Date + "',N'" +
                            tb_ChucVu.Text + "',N'" + cb_MaKhoa.Text + "',N'" + tb_DiaChi.Text + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string gt;
            if (rb_Nam.Checked == true)
                gt = "Nam";
            else gt = "Nữ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd = new SqlCommand("sp_NhanVien_update @MaNV,@MaKhoa,@Ten,@GT,@NS,@DiaChi,@ChucVu", conn);
            cmd.Parameters.AddWithValue("@MaNV", tb_MaNV.Text);
            cmd.Parameters.AddWithValue("@MaKhoa", cb_MaKhoa.Text);
            cmd.Parameters.AddWithValue("@Ten", tb_TenNV.Text);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.Parameters.AddWithValue("@NS", dtp_NgaySinh.Value.Date);
            cmd.Parameters.AddWithValue("@DiaChi", tb_DiaChi.Text);
            cmd.Parameters.AddWithValue("@ChucVu", tb_ChucVu.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM NHANVIEN WHERE MaNV=N'" + tb_MaNV.Text + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM NHANVIEN WHERE TenNV=N'" + tb_find.Text + "'";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();da.Fill(table);
            dgv_NhanVien_show.DataSource = table;
        }
    }
}
