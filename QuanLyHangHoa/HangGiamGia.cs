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
    public partial class HangGiamGia : Form
    {
        List<HANG_HOA> list_HangHoa = new List<HANG_HOA>();
        List<HANG_HOA> list_HangGiamGia = new List<HANG_HOA>();    
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        private int ToInt(DataRow row, int i)
        {
            return int.Parse(row.ItemArray[i].ToString());
        }
        private float ToFloat(DataRow row, int i)
        {
            return float.Parse(row.ItemArray[i].ToString());
        }
        HangHoaBLL bllHH;
        public HangGiamGia()
        {
            InitializeComponent();
            bllHH = new HangHoaBLL();
            DataTable dt = bllHH.getAllHangHoa();
            foreach (DataRow row in dt.Rows)
            {
                HANG_HOA beta = new HANG_HOA();
                beta.MaHH = Tostring(row, 0);
                beta.TenHH = Tostring(row, 1);
                beta.DonVi = Tostring(row, 2);
                beta.XuatXu = Tostring(row, 3);
                beta.SoLuong = ToInt(row, 4);
                beta.Gia = ToInt(row, 5);
                beta.NgayNhapKho = Tostring(row, 6);
                beta.HSD = Tostring(row, 7);
                list_HangHoa.Add(beta);
            }
        }
        private DataTable ConvertListToDataTable(List<HANG_HOA> listHH)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Hàng");
            dt.Columns.Add("Tên Hàng");
            dt.Columns.Add("Đơn Vị");
            dt.Columns.Add("Xuất Xứ");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Nhập Kho");
            dt.Columns.Add("HSD");
            foreach (HANG_HOA hh in listHH)
            {
                dt.Rows.Add(hh.MaHH, hh.TenHH, hh.DonVi, hh.XuatXu, hh.SoLuong, hh.Gia, hh.NgayNhapKho, hh.HSD);
            }
            return dt;
        }

        private void sanPhamHetHSD(List<HANG_HOA> list)
        {
            DateTime t1 = DateTime.Today;
            TimeSpan t;
            list_HangGiamGia.Clear();
            for (int i = 0; i < list.Count(); i++)
            {
                DateTime t2 = Convert.ToDateTime(list[i].HSD);
                t = t2 - t1;
                int TotalDay = t.Days;

                if (TotalDay <= 10)
                    list_HangGiamGia.Add(list[i]);
            }
        }
        //Tham Lam/////////////////////////
        int[] c=new int[1000];
        int [,]f=new int[1000,1000];
        int w;
        int[] PhuongAn = new int[1000] ;
        private void ThamLam()
        {
            w = int.Parse(txt_w.Text);                //1 đơn vị tgian
            for (int i=0;i<list_HangGiamGia.Count;i++)//n đơn vị tgian
            {
                if (w >= list_HangGiamGia[i].SoLuong) //1 đơn vị tgian
                {
                    PhuongAn[i] = list_HangGiamGia[i].SoLuong;//1 đơn vị tgian
                    w -= list_HangGiamGia[i].SoLuong;//1 đơn vị tgian
                }
                else
                {
                    PhuongAn[i] = w;                 //1 đơn vị tgian
                    break;
                }              
            }                                        //=>O(n)
        }
        private List<HANG_HOA> TruyVet()
        {
            List<HANG_HOA> temp = new List<HANG_HOA>();
            for (int i=0; i<list_HangGiamGia.Count; i++)//n đơn vị tgian
            {
                temp.Add(list_HangGiamGia[i]);          //1 đơn vị tgian
                temp[i].SoLuong=PhuongAn[i];            //1 đơn vị tgian
            }
            return temp;                                //=>O(n)
        }
        private void button_sale_Click(object sender, EventArgs e)
        {
            if (list_HangGiamGia.Count == 0) 
                MessageBox.Show("Không có hàng hóa để giảm giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (string.IsNullOrEmpty(txt_w.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_w.Focus();
                }
                else
                {
                    ThamLam();
                    TruyVet();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ConvertListToDataTable(TruyVet());
                }
            }                
        }

        private void HangGiamGia_Load(object sender, EventArgs e)
        {
            //dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 122, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            sanPhamHetHSD(list_HangHoa);
            //
            foreach (var m in list_HangGiamGia)
            {
                m.GiaTri = m.SoLuong * m.Gia;
            }
            list_HangGiamGia.Sort();//sắp xếp tăng dần (overload phương thức CompareTo)
            list_HangGiamGia.Reverse();//đảo ngược list thành sx giảm dần
            //
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConvertListToDataTable(list_HangGiamGia);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            list_HangHoa.Clear();
            bllHH = new HangHoaBLL();
            DataTable dt = bllHH.getAllHangHoa();
            foreach (DataRow row in dt.Rows)
            {
                HANG_HOA beta = new HANG_HOA();
                beta.MaHH = Tostring(row, 0);
                beta.TenHH = Tostring(row, 1);
                beta.DonVi = Tostring(row, 2);
                beta.XuatXu = Tostring(row, 3);
                beta.SoLuong = ToInt(row, 4);
                beta.Gia = ToInt(row, 5);
                beta.NgayNhapKho = Tostring(row, 6);
                beta.HSD = Tostring(row, 7);
                list_HangHoa.Add(beta);
            }
            dataGridView1.DataSource = null;
            sanPhamHetHSD(list_HangHoa);
            foreach (var m in list_HangGiamGia)
            {
                m.GiaTri = m.SoLuong * m.Gia;
            }
            list_HangGiamGia.Sort();//sắp xếp tăng dần (overload phương thức CompareTo)
            list_HangGiamGia.Reverse();//đảo ngược list để sx giảm dần
            dataGridView1.DataSource = ConvertListToDataTable(list_HangGiamGia);         
            txt_w.Clear();
            txt_w.Focus();
        }

        private void txt_w_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
