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
    public partial class F_KhamBenh : Form
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
            cmd = new SqlCommand("select * from vw_ThongTinKhamBenh", conn);
            da.SelectCommand = cmd;
            table.Clear(); da.Fill(table); dgv_KhamBenh.DataSource = table;
        }
        public F_KhamBenh()
        {
            InitializeComponent();
            checkconn();
            
            var cmd0 = new SqlCommand("select MaDV from DICHVU", conn);
            var dr = cmd0.ExecuteReader();
            DataTable dvt = new DataTable();
            dvt.Load(dr);cb_MaDV.DisplayMember = "MaDV";cb_MaDV.DataSource = dvt;

            var cmd1 = new SqlCommand("select MaNV from NHANVIEN", conn); 
            DataTable nvt = new DataTable();
            var dd = cmd1.ExecuteReader();
            nvt.Load(dd);cb_MaNV.DisplayMember = "MaNV";cb_MaNV.DataSource = nvt;
            HienThi();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            checkconn();
            if (tb_MaBN.Text == "" || tb_MaBA.Text==""|| tb_TenBN.Text=="")
                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd = new SqlCommand("sp_KhamBenh @MaBN,@TenBN,@GioiTinh,@NgaySinh,@DiaChi,@MaBA,@MaNV,@MaDV", conn);
                string gt;
                if (rb_Nam.Checked == true) gt = "Nam"; else gt = "Nữ";
                cmd.Parameters.AddWithValue("@MaBN", tb_MaBN.Text);
                cmd.Parameters.AddWithValue("@TenBN", tb_TenBN.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                cmd.Parameters.AddWithValue("@NgaySinh", dt_NgaySinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", tb_DiaChi.Text);
                cmd.Parameters.AddWithValue("@MaBA", tb_MaBA.Text);
                cmd.Parameters.AddWithValue("@MaNV", cb_MaNV.Text);
                cmd.Parameters.AddWithValue("@MaDV", cb_MaDV.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string gt;
            if (rb_Nam.Checked == true) gt = "Nam"; else gt = "Nữ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd = new SqlCommand("sp_KB_al  @MaBN,@TenBN,@GioiTinh,@NgaySinh,@DiaChi,@MaBA,@MaNV,@MaDV", conn);
            cmd.Parameters.AddWithValue("@MaBN", tb_MaBN.Text);
            cmd.Parameters.AddWithValue("@TenBN", tb_TenBN.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", gt);
            cmd.Parameters.AddWithValue("@NgaySinh", dt_NgaySinh.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tb_DiaChi.Text);
            cmd.Parameters.AddWithValue("@MaBA", tb_MaBA.Text);
            cmd.Parameters.AddWithValue("@MaNV", cb_MaNV.Text);
            cmd.Parameters.AddWithValue("@MaDV", cb_MaDV.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE from BENHAN where MaBA=N'" + tb_MaBA.Text + "'";
            cmd.Connection = conn;cmd.ExecuteNonQuery();
            var cm = new SqlCommand("delete from BENHNHAN where MaBN=N'" + tb_MaBN.Text + "'", conn);
            cm.ExecuteNonQuery();
            HienThi();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            if (cb_find.Text == "1.Tìm theo Mã")
                cmd.CommandText = "Select * from vw_ThongTinKhamBenh where MaBN=N'" + tb_find.Text + "'";
            else if(cb_find.Text=="2.Tìm theo Tên")
                cmd.CommandText = "Select * from vw_ThongTinKhamBenh where TenBN=N'" + tb_find.Text + "'";
            cmd.Connection = conn;
            da.SelectCommand = cmd;
            table.Clear();da.Fill(table);
            dgv_KhamBenh.DataSource = table;
        }

        private void dgv_KhamBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaBN.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_TenBN.Text= dgv_KhamBenh.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gt= dgv_KhamBenh.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (gt == "Nam") rb_Nam.Checked = true; else rb_Nu.Checked = true;
            dt_NgaySinh.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_DiaChi.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_MaBA.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[6].Value.ToString();
            cb_MaNV.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[7].Value.ToString();
            cb_MaDV.Text = dgv_KhamBenh.Rows[e.RowIndex].Cells[9].Value.ToString();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new F_DONTHUOC();
            f.ShowDialog();
        }

        private void bt_HD_Click(object sender, EventArgs e)
        {
            Form HD = new F_HoaDon();
            HD.ShowDialog();
        }
    }
}
