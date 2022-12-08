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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyHangHoa
{
    public partial class Chart : Form
    {
        List<HANG_HOA_DABAN> list_HangHoa_DaBan = new List<HANG_HOA_DABAN>();
        HangHoaBLL bllHH;
        private string Tostring(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }
        private int ToInt(DataRow row, int i)
        {
            return int.Parse(row.ItemArray[i].ToString());
        }
        public Chart()
        {
            InitializeComponent();
            bllHH = new HangHoaBLL();
            DataTable dt = bllHH.getAllHangHoaDaBan();
            foreach (DataRow row in dt.Rows)
            {
                HANG_HOA_DABAN beta = new HANG_HOA_DABAN(); //chưa hiểu
                beta.MaHH = Tostring(row, 0);
                beta.TenHH = Tostring(row, 1);
                beta.DonVi = Tostring(row, 2);
                beta.SoLuongBan = ToInt(row, 3);
                beta.ThuVe = ToInt(row, 4);
                beta.NgayBan = Tostring(row, 5);
                list_HangHoa_DaBan.Add(beta);
            }
            dataGridView_DoanhThu.DataSource = null;
            dataGridView_DoanhThu.DataSource = ConvertListToDataTable(list_HangHoa_DaBan);
        }
        private DataTable ConvertListToDataTable(List<HANG_HOA_DABAN> listHH)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Hàng");
            dt.Columns.Add("Tên Hàng");
            dt.Columns.Add("Đơn Vị");
            dt.Columns.Add("Số Lượng Bán");
            dt.Columns.Add("Thu Về");
            dt.Columns.Add("Ngày Bán");
            foreach (HANG_HOA_DABAN hh in listHH)
            {
                dt.Rows.Add(hh.MaHH, hh.TenHH, hh.DonVi, hh.SoLuongBan, hh.ThuVe, hh.NgayBan);
            }
            return dt;
        }
        private string date()
        {                      
               return dateTimePicker0.Value.Month + "/" + dateTimePicker0.Value.Day + "/" + dateTimePicker0.Value.Year;         
        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            int Total = 0;
            string Date = date();
            List<HANG_HOA_DABAN> hhdb = new List<HANG_HOA_DABAN>();
            foreach (var m in list_HangHoa_DaBan)
            {
                if (m.NgayBan == Date)
                {
                    hhdb.Add(m);
                    Total += m.ThuVe;
                }
            }
            Total_0.Text = Total.ToString();
            ConvertListToDataTable(hhdb);
            dataGridView_DoanhThu.DataSource = null;
            dataGridView_DoanhThu.DataSource = ConvertListToDataTable(hhdb);
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            //dataGridView_DoanhThu.BorderStyle = BorderStyle.None;
            dataGridView_DoanhThu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_DoanhThu.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_DoanhThu.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_DoanhThu.BackgroundColor = Color.White;

            dataGridView_DoanhThu.EnableHeadersVisualStyles = false;
            dataGridView_DoanhThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_DoanhThu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(252, 122, 0);
            dataGridView_DoanhThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
