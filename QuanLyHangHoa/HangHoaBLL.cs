using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class HangHoaBLL
    {
        HangHoaDAL dalHH;
        public HangHoaBLL()
        {
            dalHH = new HangHoaDAL();
        }
        public DataTable getAllHangHoa()
        {
            return dalHH.getAllHangHoa();
        }
        public DataTable getAllHangHoaDaBan()
        {
            return dalHH.getAllHangHoa_DaBan();
        }
        public bool Add_HangHoa(HANG_HOA hh)
        {
            return dalHH.Add_HangHoa(hh);
        }
        public bool Adj_HangHoa(HANG_HOA hh)
        {
            return dalHH.Adj_HangHoa(hh);
        }
        public bool Del_HangHoa(HANG_HOA hh)
        {
            return dalHH.Del_HangHoa(hh);
        }
        public bool Add_HangHoa_DaBan(HANG_HOA_DABAN hh)
        {
            return dalHH.Add_HangHoa_DaBan(hh);
        }
    }
}
