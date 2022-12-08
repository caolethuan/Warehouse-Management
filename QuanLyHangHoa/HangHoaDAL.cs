using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class HangHoaDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HangHoaDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHangHoa()
        {
            string sql = "SELECT * FROM HANG_HOA";
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllHangHoa_DaBan()
        {
            string sql = "SELECT * FROM DA_BAN";
            SqlConnection con = dc.GetConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Add_HangHoa(HANG_HOA hh)
        {
            string sql = "INSERT INTO HANG_HOA(MaHH,TenHH,DonVi,XuatXu,SoLuong,Gia,NgayNhapKho,HSD) VALUES(@MaHH,@TenHH,@DonVI,@XuatXu,@SoLuong,@Gia,@NgayNhapKho,@HSD)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar).Value = hh.MaHH;
                cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = hh.TenHH;
                cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar).Value = hh.DonVi;
                cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar).Value = hh.XuatXu;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hh.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = hh.Gia;
                cmd.Parameters.Add("@NgayNhapKho", SqlDbType.NVarChar).Value = hh.NgayNhapKho;
                cmd.Parameters.Add("@HSD", SqlDbType.NVarChar).Value = hh.HSD;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Adj_HangHoa(HANG_HOA hh)
        {
            string sql = "UPDATE HANG_HOA SET MaHH=@MaHH, TenHH=@TenHH, DonVi=@DonVi, XuatXu=@XuatXu, SoLuong=@SoLuong, Gia=@Gia, NgayNhapKho=@NgayNhapKho, HSD=@HSD WHERE MaHH=@MaHH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar).Value = hh.MaHH;
                cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = hh.TenHH;
                cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar).Value = hh.DonVi;
                cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar).Value = hh.XuatXu;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hh.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = hh.Gia;
                cmd.Parameters.Add("@NgayNhapKho", SqlDbType.NVarChar).Value = hh.NgayNhapKho;
                cmd.Parameters.Add("@HSD", SqlDbType.NVarChar).Value = hh.HSD;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Del_HangHoa(HANG_HOA hh)
        {
            string sql = "DELETE HANG_HOA WHERE MaHH=@MaHH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar).Value = hh.MaHH;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Add_HangHoa_DaBan(HANG_HOA_DABAN hh)
        {
            string sql = "INSERT INTO DA_BAN(MaHH,TenHH,DonVi,SoLuongBan,ThuVe,NgayBan) VALUES(@MaHH,@TenHH,@DonVi,@SoLuongBan,@ThuVe,@NgayBan)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar).Value = hh.MaHH;
                cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = hh.TenHH;
                cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar).Value = hh.DonVi;
                cmd.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = hh.SoLuongBan;
                cmd.Parameters.Add("@ThuVe", SqlDbType.Int).Value = hh.ThuVe;
                cmd.Parameters.Add("@NgayBan", SqlDbType.NVarChar).Value = hh.NgayBan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
