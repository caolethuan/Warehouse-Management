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
    public partial class Form1 : Form
    {
        List<HANG_HOA> list_HangHoa = new List<HANG_HOA>();       
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
        public Form1()
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
        public void ShowAllHangHoa()
        {
            //DataTable dt = bllHH.getAllHangHoa();
            //dataGridView_HangHoa.DataSource = dt;
            dataGridView_HangHoa.DataSource = null;
            dataGridView_HangHoa.DataSource = ConvertListToDataTable(list_HangHoa);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView_HangHoa.BorderStyle = BorderStyle.None;
            dataGridView_HangHoa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_HangHoa.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_HangHoa.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_HangHoa.BackgroundColor = Color.White;

            dataGridView_HangHoa.EnableHeadersVisualStyles = false;
            dataGridView_HangHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_HangHoa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 122, 0);
            dataGridView_HangHoa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ShowAllHangHoa();
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(txt_maHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_maHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_tenHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tenHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_donVi.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_donVi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_xuatXu.Text))
            {
                MessageBox.Show("Bạn chưa nhập xuất xứ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_xuatXu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_soLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_soLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_gia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá hàng hóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_gia.Focus();
                return false;
            }
            return true;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                HANG_HOA hh = new HANG_HOA();
                hh.MaHH = txt_maHang.Text;
                hh.TenHH = txt_tenHang.Text;
                hh.DonVi = txt_donVi.Text;
                hh.XuatXu = txt_xuatXu.Text;
                hh.SoLuong = Int32.Parse(txt_soLuong.Text);
                hh.Gia = Int32.Parse(txt_gia.Text);
                hh.NgayNhapKho = dateTimePicker_ngayNhapKho.Value.Year + "/" + dateTimePicker_ngayNhapKho.Value.Month + "/" + dateTimePicker_ngayNhapKho.Value.Day;
                hh.HSD = dateTimePicker_HSD.Value.Year + "/" + dateTimePicker_HSD.Value.Month + "/" + dateTimePicker_HSD.Value.Day;
                if (bllHH.Add_HangHoa(hh))
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
                    ShowAllHangHoa();
                }
                else
                    MessageBox.Show("There is something wrong, please check again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không? ", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HANG_HOA hh = new HANG_HOA();
                hh.MaHH = txt_maHang.Text;
                if (bllHH.Del_HangHoa(hh))
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
                    ShowAllHangHoa();
                }
                else
                    MessageBox.Show("There is something wrong, please check again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_adj_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                HANG_HOA hh = new HANG_HOA();
                hh.MaHH = txt_maHang.Text;
                hh.TenHH = txt_tenHang.Text;
                hh.DonVi = txt_donVi.Text;
                hh.XuatXu = txt_xuatXu.Text;
                hh.SoLuong = Int32.Parse(txt_soLuong.Text);
                hh.Gia = Int32.Parse(txt_gia.Text);
                hh.NgayNhapKho = dateTimePicker_ngayNhapKho.Value.Year + "/" + dateTimePicker_ngayNhapKho.Value.Month + "/" + dateTimePicker_ngayNhapKho.Value.Day;
                hh.HSD = dateTimePicker_HSD.Value.Year + "/" + dateTimePicker_HSD.Value.Month + "/" + dateTimePicker_HSD.Value.Day;
                if (bllHH.Adj_HangHoa(hh))
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
                    ShowAllHangHoa();
                }

                else
                    MessageBox.Show("There is something wrong, please check again!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void button_sort_Click(object sender, EventArgs e)
        //{
        //    if (select == -1)
        //        MessageBox.Show("Vui lòng chọn cách sắp xếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    else
        //    {
        //        MergeSort(list_HangHoa, 0, list_HangHoa.Count - 1);
        //        dataGridView_HangHoa.DataSource = null;
        //        dataGridView_HangHoa.DataSource = ConvertListToDataTable(list_HangHoa);
        //    }
        //}

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = txt_search.Text;
            select = comboBox_select.SelectedIndex;
            if (value != "Nhập tên hoặc mã hàng")
            {
                List<HANG_HOA> ds = SequenceSearch(list_HangHoa, value);
                MergeSort(ds, 0, ds.Count - 1);
                dataGridView_HangHoa.DataSource = null;
                dataGridView_HangHoa.DataSource = ConvertListToDataTable(ds);
            }
            else
            {               
                MergeSort(list_HangHoa, 0, list_HangHoa.Count - 1);
                dataGridView_HangHoa.DataSource = null;
                dataGridView_HangHoa.DataSource = ConvertListToDataTable(list_HangHoa);
            }
        }
        private void search()
        {
            string value = txt_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                List<HANG_HOA> ds = SequenceSearch(list_HangHoa, value);
                dataGridView_HangHoa.DataSource = null;
                dataGridView_HangHoa.DataSource = ConvertListToDataTable(ds);
            }
            else
                ShowAllHangHoa();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
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
                ShowAllHangHoa();
            }
        }
        private void dataGridView_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index>=0)
            {
                txt_maHang.Text = dataGridView_HangHoa.Rows[index].Cells["Mã Hàng"].Value.ToString();
                txt_tenHang.Text = dataGridView_HangHoa.Rows[index].Cells["Tên Hàng"].Value.ToString();
                txt_donVi.Text = dataGridView_HangHoa.Rows[index].Cells["Đơn Vị"].Value.ToString();
                txt_xuatXu.Text = dataGridView_HangHoa.Rows[index].Cells["Xuất Xứ"].Value.ToString();
                txt_soLuong.Text = dataGridView_HangHoa.Rows[index].Cells["Số Lượng"].Value.ToString();
                txt_gia.Text = dataGridView_HangHoa.Rows[index].Cells["Giá"].Value.ToString();
                dateTimePicker_ngayNhapKho.Text = dataGridView_HangHoa.Rows[index].Cells["Nhập Kho"].Value.ToString();
                dateTimePicker_HSD.Text= dataGridView_HangHoa.Rows[index].Cells["HSD"].Value.ToString();
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
        // Xây dựng hàm sắp xếp và các phương thức sắp xếp
        int select=-1;//biến lưu cách chọn sắp xếp tăng hay giảm theo tên hoặc mã hàng

        private void Merge(List<HANG_HOA> list, int left, int middle, int right)
        {
            List<HANG_HOA> leftArray = new List<HANG_HOA>(middle - left + 1);
            List<HANG_HOA> rightArray = new List<HANG_HOA>(right - middle);          
            for (int i = 0; i < middle - left + 1; i++)// N/2 đơn vị tgian
            {
                leftArray.Add(list[left + i]);
            }
            for (int j = 0; j < right - middle; j++)  // N/2 đơn vị tgian
            {
                rightArray.Add(list[middle + 1 + j]);
            }
            int x = 0;
            int y = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (x == leftArray.Count)
                {
                    list[k] = rightArray[y];
                    y++;
                }
                else if (y == rightArray.Count)
                {
                    list[k] = leftArray[x];
                    x++;
                }
                else
                {
                    if (select == 0)
                    {
                        if (string.Compare(leftArray[x].TenHH, rightArray[y].TenHH) <= 0)
                        {
                            list[k] = leftArray[x];
                            x++;
                        }
                        else
                        {
                            list[k] = rightArray[y];
                            y++;
                        }
                    }
                    else
                    if (select == 1)
                    {
                        if (string.Compare(leftArray[x].TenHH, rightArray[y].TenHH) >= 0)
                        {
                            list[k] = leftArray[x];
                            x++;
                        }
                        else
                        {
                            list[k] = rightArray[y];
                            y++;
                        }
                    }
                    else 
                    if (select==2)
                    {
                        if (string.Compare(leftArray[x].MaHH, rightArray[y].MaHH) <= 0)
                        {
                            list[k] = leftArray[x];
                            x++;
                        }
                        else
                        {
                            list[k] = rightArray[y];
                            y++;
                        }
                    }
                    else
                    if (select == 3)
                    {
                        if (string.Compare(leftArray[x].MaHH, rightArray[y].MaHH) >= 0)
                        {
                            list[k] = leftArray[x];
                            x++;
                        }
                        else
                        {
                            list[k] = rightArray[y];
                            y++;
                        }
                    }
                }
            }
        }

        private void MergeSort(List<HANG_HOA> list, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(list, left, middle);
                MergeSort(list, middle + 1, right);

                Merge(list, left, middle, right);
            }
        }     
        private List<HANG_HOA> SequenceSearch(List<HANG_HOA> list, string name)// n đơn vị tgian
        {
            List<HANG_HOA> tmp = new List<HANG_HOA>(); // 1 đơn vị tgian
            foreach (var m in list) // n đơn vị tgian
            {
                if (m.TenHH.ToLower().Contains(name.ToLower()) || m.MaHH.ToLower().Contains(name.ToLower()))
                    tmp.Add(m); // 1 đơn vị tgian
            }
            return tmp;
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

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
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
