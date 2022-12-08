
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class LoginForm : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LoginForm()
        {
            InitializeComponent();
            dc = new DataConnection();
            // Set to no text.
            txt_pass.Text = "";
            // The password character is an asterisk.
            txt_pass.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txt_pass.MaxLength = 14;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cbxStaff.Checked)
            {
                string sql = "select COUNT(*) from [Staff] where TenTaiKhoan=@UserName and MatKhau='" + GenerateSHA512String(txt_pass.Text) + "'";
                SqlConnection con = dc.GetConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@UserName", txt_username.Text));
                cmd.Parameters.Add(new SqlParameter("@PassWord", txt_pass.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    //Lấy tên người đăng nhập từ database
                    sql= "select HoTen from Staff where TenTaiKhoan=@UserName and MatKhau='" + GenerateSHA512String(txt_pass.Text) + "'";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@UserName", txt_username.Text));
                    cmd.Parameters.Add(new SqlParameter("@PassWord", txt_pass.Text));
                    string userName = cmd.ExecuteScalar().ToString();
                    //MessageBox.Show(userName);
                    //
                    UIquanly f = new UIquanly(userName);
                    this.Hide();
                    f.ShowDialog();                  
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                }
                con.Close();
            }
            else if (cbxAdmin.Checked)
            {
                string sql = "select COUNT(*) from [Admin_Account] where adname=@adName and adpass=@adPass";
                SqlConnection con = dc.GetConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@adName", txt_username.Text));
                cmd.Parameters.Add(new SqlParameter("@adPass", txt_pass.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    //
                    string userName = "Admin";
                    //
                    UIquanly ad = new UIquanly(userName);
                    this.Hide();
                    ad.ShowDialog();
                    this.Show();                  
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
                }
                con.Close();
            }
            else
                MessageBox.Show("Bạn chưa chọn quyền truy cập!", "Thông báo");
        }
        //ham bam sha512
        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        //ham bam sha512
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        private void lb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_Exit_MouseEnter(object sender, EventArgs e)
        {
            lb_Exit.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
        }

        private void lb_Exit_MouseLeave(object sender, EventArgs e)
        {
            lb_Exit.ForeColor = System.Drawing.Color.FromArgb(254, 168, 111);
        }

        private void lb_register_Click(object sender, EventArgs e)
        {
            CreateUN RS = new CreateUN();
            this.Hide();
            RS.ShowDialog();
            this.Show();

        }

        private void btn_register_Click_Click(object sender, EventArgs e)
        {
            if (cbxAdmin.Checked)
            {
                string sql = "select COUNT(*) from [Admin_Account] where adname=@adName and adpass=@adPass";
                SqlConnection con = dc.GetConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@adName", txt_username.Text));
                cmd.Parameters.Add(new SqlParameter("@adPass", txt_pass.Text));
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    CreateUN RS = new CreateUN();
                    this.Hide();
                    RS.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ!", "Thông báo");
                }
                con.Close();
            }
            else
                MessageBox.Show("Chức năng chỉ được dùng cho người quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAdmin.Checked == true)
                cbxStaff.Checked = false;
        }

        private void cbxStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxStaff.Checked == true)
                cbxAdmin.Checked = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
