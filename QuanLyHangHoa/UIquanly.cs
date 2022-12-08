using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class UIquanly : Form
    {
        public UIquanly(string userName)
        {
            InitializeComponent();
            customizeDesign();
            label_staffName.Text = userName;
        }
        private void customizeDesign()
        {
            panel_hangHoa.Visible = false;
            panel_thuNgan.Visible = false;
            panel_doanhThu.Visible = false;
            // cham ba cham
        }
        private void hideSubMenu()
        {
            if (panel_hangHoa.Visible)
                panel_hangHoa.Visible = false;
            if (panel_thuNgan.Visible)
                panel_thuNgan.Visible = false;
            if (panel_doanhThu.Visible)
                panel_doanhThu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region HàngHóa
        private void button_hangHoa_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_hangHoa);
        }
        #endregion
        #region ThuNgân
        private void button_thuNgan_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_thuNgan);
        }
        #endregion
        #region DoanhThu
        private void button_doanhThu_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_doanhThu);
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
               activeForm.Close();        
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childForm.Controls.Add(childForm);
            panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_dshh_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void button_giamGia_Click(object sender, EventArgs e)
        {
            openChildForm(new HangGiamGia());
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            // panel_childForm.Controls.Remove(activeForm);//cách 1
            if (activeForm != null)
                activeForm.Close();//cách 2
            hideSubMenu();
        }

        private void button_tinhTien_Click(object sender, EventArgs e)
        {
            openChildForm(new UIthanhtoan(label_staffName.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new Chart());
        }

        private void pictureBox_support_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Thuan.Le.10201/");
        }

        private void panel_childForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UIquanly_Load(object sender, EventArgs e)
        {

        }
    }
}
