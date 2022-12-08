using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace QuanLyHangHoa
{
    public partial class UIthanhtoan : Form
    {
        List<HANG_HOA> list_HangHoa = new List<HANG_HOA>();
        List<HANG_HOA> list_HangHoa_Bill = new List<HANG_HOA>();
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
        string user;
        public UIthanhtoan(string userName)
        {
            InitializeComponent();
            bllHH = new HangHoaBLL();
            DataTable dt = bllHH.getAllHangHoa();
            foreach (DataRow row in dt.Rows)
            {
                HANG_HOA beta = new HANG_HOA(); //chưa hiểu
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
            user = userName;
            sanPhamHetHSD(list_HangHoa);
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
        public void ShowAllHangHoa(int i)
        {
            //DataTable dt = bllHH.getAllHangHoa();
            //dataGridView_HangHoa.DataSource = dt;
            if (i == 0)//list hang hoa
            {
                list_HangHoa.Clear();
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
                dataGridView_listHH.DataSource = null;
                dataGridView_listHH.DataSource = ConvertListToDataTable(list_HangHoa);
            }
            else // list hang hoa trong hoa đơn
            {               
                dataGridView_bill.DataSource = null;
                dataGridView_bill.DataSource = ConvertListToDataTable(list_HangHoa_Bill);
            }

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

                if (TotalDay == 5)
                    list_HangGiamGia.Add(list[i]);
            }
        }
        private List<HANG_HOA> SequenceSearch(List<HANG_HOA> list, string name)
        {
            List<HANG_HOA> tmp = new List<HANG_HOA>();
            foreach (var m in list)
            {
                if (m.TenHH.ToLower().Contains(name.ToLower()) || m.MaHH.ToLower().Contains(name.ToLower()))
                    tmp.Add(m);
            }
            return tmp;
        }
        private void search()
        {
            string value = txt_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                List<HANG_HOA> ds = SequenceSearch(list_HangHoa, value);
                dataGridView_listHH.DataSource = null;
                dataGridView_listHH.DataSource = ConvertListToDataTable(ds);
            }
            else
                ShowAllHangHoa(0);
        }

        private void dataGridView_listHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_maHang.Text = dataGridView_listHH.Rows[index].Cells["Mã Hàng"].Value.ToString();
                txt_tenHang.Text = dataGridView_listHH.Rows[index].Cells["Tên Hàng"].Value.ToString();
                txt_donVi.Text = dataGridView_listHH.Rows[index].Cells["Đơn Vị"].Value.ToString();
                txt_xuatXu.Text = dataGridView_listHH.Rows[index].Cells["Xuất Xứ"].Value.ToString();
                txt_soLuong.Text = dataGridView_listHH.Rows[index].Cells["Số Lượng"].Value.ToString();
                txt_gia.Text = dataGridView_listHH.Rows[index].Cells["Giá"].Value.ToString();
                dateTimePicker_ngayNhapKho.Text = dataGridView_listHH.Rows[index].Cells["Nhập Kho"].Value.ToString();
                dateTimePicker_HSD.Text = dataGridView_listHH.Rows[index].Cells["HSD"].Value.ToString();
                txt_soLuong.Focus();
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            if ((txt_search.Text == "Nhập tên hoặc mã hàng"))
            {
                txt_search.Text = "";
                txt_search.ForeColor = Color.Black;
                txt_search.Font = new Font("Arial", 8);
            }
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if ((txt_search.Text == ""))
            {
                txt_search.ForeColor = Color.Silver;
                txt_search.Font = new Font("Arial", 8, System.Drawing.FontStyle.Italic);
                txt_search.Text = "Nhập tên hoặc mã hàng";
                ShowAllHangHoa(0);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void UIthanhtoan_Load(object sender, EventArgs e)
        {
            //dataGridView_listHH.BorderStyle = BorderStyle.None;
            dataGridView_listHH.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_listHH.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_listHH.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_listHH.BackgroundColor = Color.White;

            dataGridView_listHH.EnableHeadersVisualStyles = false;
            dataGridView_listHH.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_listHH.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 122, 0);
            dataGridView_listHH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ShowAllHangHoa(0);

            //dataGridView_bill.BorderStyle = BorderStyle.None;
            dataGridView_bill.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_bill.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_bill.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_bill.BackgroundColor = Color.White;

            dataGridView_bill.EnableHeadersVisualStyles = false;
            dataGridView_bill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_bill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 122, 0);
            dataGridView_bill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        int total_bill = 0;
        private void button_addToCart_Click(object sender, EventArgs e)
        {
            HANG_HOA hh = new HANG_HOA();//hàng hóa để thêm vào bill
            HANG_HOA_DABAN hhdb = new HANG_HOA_DABAN();
            if (string.IsNullOrEmpty(txt_maHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Thực hiện lưu dữ liệu để tiến hành kiểm tra
            hh.MaHH = txt_maHang.Text;
            hh.TenHH = txt_tenHang.Text;
            hh.DonVi = txt_donVi.Text;
            hh.XuatXu = txt_xuatXu.Text;
            hh.SoLuong = int.Parse(txt_soLuong.Text);

            bool check = false;
            foreach (var m in list_HangGiamGia)
                if (m.MaHH.ToLower().Contains(txt_maHang.Text.ToLower()))
                {
                    hh.Gia = int.Parse(txt_gia.Text) / 2;
                    check = true;
                    break;
                }

            if (!check) hh.Gia = int.Parse(txt_gia.Text);
            hh.NgayNhapKho = dateTimePicker_ngayNhapKho.Value.Year + "/" + dateTimePicker_ngayNhapKho.Value.Month + "/" + dateTimePicker_ngayNhapKho.Value.Day;
            hh.HSD = dateTimePicker_HSD.Value.Year + "/" + dateTimePicker_HSD.Value.Month + "/" + dateTimePicker_HSD.Value.Day;
            //
            //
            hhdb.MaHH = hh.MaHH;
            hhdb.TenHH = hh.TenHH;
            hhdb.DonVi = hh.DonVi;
            hhdb.SoLuongBan = hh.SoLuong;
            hhdb.ThuVe = hh.SoLuong * hh.Gia;
            hhdb.NgayBan = DateTime.Now.ToShortDateString();
            //
            foreach (var m in list_HangHoa)
            {
                if (m.MaHH.ToLower().Contains(txt_maHang.Text.ToLower()))
                {
                    if ((m.SoLuong - int.Parse(txt_soLuong.Text) > 0))
                    {
                        m.SoLuong -= int.Parse(txt_soLuong.Text);
                        bllHH.Adj_HangHoa(m);//cập nhật vào database
                        bllHH.Add_HangHoa_DaBan(hhdb);
                        list_HangHoa_Bill.Add(hh);//thêm vào hóa đơn
                        total_bill += int.Parse(txt_soLuong.Text) * hh.Gia;//tổng tiền phải trả
                        label_total.Text = total_bill.ToString();
                        ShowAllHangHoa(0);//hiện danh sách hàng hóa
                        ShowAllHangHoa(1);//hiện danh sách hàng hóa đã mua
                        break;
                    }
                    else if ((m.SoLuong - int.Parse(txt_soLuong.Text) == 0))
                    {
                        m.SoLuong -= int.Parse(txt_soLuong.Text);
                        bllHH.Del_HangHoa(m);//cập nhật vào database
                        bllHH.Add_HangHoa_DaBan(hhdb);
                        list_HangHoa_Bill.Add(hh);
                        total_bill += int.Parse(txt_soLuong.Text) * int.Parse(txt_gia.Text);
                        label_total.Text = total_bill.ToString();
                        ShowAllHangHoa(0);
                        ShowAllHangHoa(1);
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Quá số lượng hiện có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_soLuong.Focus();
                        break;
                    }
                }
            }
            //


        }

        private void txt_soLuong_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false; // Đặt trạng thái cho ứng dụng từ là hiển thị hay không

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                //
                string date= DateTime.Now.Day.ToString()+"/"+ DateTime.Now.Month.ToString() + "/"+ DateTime.Now.Year.ToString();
                this.FindAndReplace(wordApp, "<Ngay>", date);
                this.FindAndReplace(wordApp, "<NhanVien>", user);
                for (int i=0;i< list_HangHoa_Bill.Count;i++)
                {
                    string TenHang = "<TenHang" + i + ">";
                    string SoLuong = "<SoLuong" + i + ">";
                    string DonVi = "<DonVi" + i + ">";
                    string Gia = "<Gia" + i + ">";
                    string ThanhTien = "<ThanhTien" + i + ">";
                    //
                    string ThanhTien_Replace = (list_HangHoa_Bill[i].Gia * list_HangHoa_Bill[i].SoLuong).ToString();
                    this.FindAndReplace(wordApp, TenHang, list_HangHoa_Bill[i].TenHH);
                    this.FindAndReplace(wordApp, SoLuong, list_HangHoa_Bill[i].SoLuong.ToString());
                    this.FindAndReplace(wordApp, DonVi, list_HangHoa_Bill[i].DonVi);
                    this.FindAndReplace(wordApp, Gia, list_HangHoa_Bill[i].Gia.ToString());
                    this.FindAndReplace(wordApp, ThanhTien, ThanhTien_Replace);
                    //

                }
                this.FindAndReplace(wordApp,"<Total>",total_bill.ToString());
                //
            }
            else
            {
                MessageBox.Show("File Not Found!");
            }
            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Đã xuất hóa đơn!");
            list_HangHoa_Bill.Clear();
            ShowAllHangHoa(1);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            string filename = "TNT";
            if (list_HangHoa_Bill.Count == 0) MessageBox.Show("Hóa đơn trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string FormWord = "TNT";
                FormWord += list_HangHoa_Bill.Count - 1;
                FormWord += ".docx";
                string FileInput= "C:\\Users\\Lenovo\\source\\repos\\QuanLyHangHoa\\QuanLyHangHoa\\FormBill\\", FileOutput= "C:\\Users\\Lenovo\\Desktop\\tuần 1\\dayne.docx";
                FileInput += FormWord;
                CreateWordDocument(FileInput, FileOutput);
            }
        }
    }
}
