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
    public partial class F_Login : Form
    {
        SqlConnection conn;
        public F_Login()
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-2K03V7E;Initial Catalog=QuanLyBenhVien;User ID=" 
                          + tb_TaiKhoan.Text + ";Password=" + tb_MatKhau.Text;
            conn = new SqlConnection(str);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Form f = new F_MainUD();
                    f.ShowDialog();
                    
                }      
            }
            catch(Exception)
            {
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Đăng Nhập Thất Bại!!");
            }
        }

        private void tb_MatKhau_TextChanged(object sender, EventArgs e)
        {
            this.tb_MatKhau.UseSystemPasswordChar = true;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
