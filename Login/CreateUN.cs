using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PTTKGT_Nhom7
{
    
    public partial class CreateUN : Form
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CreateUN()
        {
            InitializeComponent();
            dc = new DataConnection();
            
        }
       
        private bool CheckData()
        {
            if (txtHoTen.Text == "")
            {
                
                MessageBox.Show("Bạn chưa nhập vào họ tên", "Thông báo");
                txtHoTen.Focus(); // đưa trỏ chuột vào ô này
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Email", "Thông báo");
                txtEmail.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào số điện thoại", "Thông báo");
                txtSDT.Focus();
                return false;
            }
            if (txtTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào tên tài khoản", "Thông báo");
                txtTK.Focus();
                return false;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mật khẩu", "Thông báo");
                txtMK.Focus();
                return false;
                
            }
            if (txtXNMK.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu", "Thông báo");
                txtXNMK.Focus();
                return false;
            }
            if (txtMK.Text != txtXNMK.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không giống nhau!", "Thông báo");
                txtXNMK.Focus();
                txtXNMK.SelectAll();
                return false;
            }
            //kiểm tra Email và mật khẩu phải hợp lệ theo đúng định dạng
            NguoiDung nd = new NguoiDung(txtHoTen.Text, txtEmail.Text, txtSDT.Text, txtTK.Text, txtMK.Text);

            if (!nd.KiemTraDinhDangEmail())
            {
                MessageBox.Show("Email sai định dạng");
                txtEmail.Focus();
                return false;
            }
            //if (nd.KiemTraDinhDangMK())
            //    {

            //    //    MessageBox.Show("Đăng ký tài khoản thành công" + "\n\nTên: " + nd.ChuanHoaHoTen() + "\nEmail: " + txtEmail.Text + "\nPhone: " + txtSDT.Text + "\nTên tài khoản: " + txtTK.Text, "Thông báo");

            //    //}
            //    //else
            //    //{
            //        MessageBox.Show("Mật khẩu sai định dạng!", "Thông báo");
            //        txtMK.Focus();
            //        txtMK.SelectAll();
            //    return false;
            //    }          
            return true;
        }
        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
        // kiểm tra nếu sdt là chữ thì không nhập được
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && (Keys)e.KeyChar != Keys.Space)
            {
                e.Handled = true;
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();        
        }

        private void lb_DNhapTK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lb_DNhapTK_MouseEnter(object sender, EventArgs e)
        {
            lb_DNhapTK.ForeColor = System.Drawing.Color.FromArgb(255, 157, 1);
        }

        private void lb_DNhapTK_MouseLeave(object sender, EventArgs e)
        {
            lb_DNhapTK.ForeColor = System.Drawing.Color.FromArgb(20, 21, 24);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string sql = "select COUNT(*) from [Staff] where TenTaiKhoan=@namestaff";
                SqlConnection con = dc.getConnect();
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@namestaff", txtTK.Text));
                //cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text               
                int x = (int)cmd.ExecuteScalar();
                if (x == 0)
                {
                    string sql2 = "INSERT INTO [Staff] VALUES (N'"+ txtHoTen.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "','" + txtTK.Text + "','" + GenerateSHA512String(txtMK.Text) + "')";                  
                    cmd = new SqlCommand(sql2, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtHoTen.Text = "";
                    txtEmail.Text = "";
                    txtSDT.Text = "";
                    txtTK.Text = "";
                    txtMK.Text = "";
                    txtXNMK.Text = "";
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã có người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
