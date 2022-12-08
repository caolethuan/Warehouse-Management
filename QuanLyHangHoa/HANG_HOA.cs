using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class HANG_HOA:IComparable<HANG_HOA>
    {
        public HANG_HOA()
        {

        }
        public string MaHH { set; get; }  
        public string TenHH { set; get; }
        public string DonVi { set; get; }
        public string XuatXu { set; get; }
        public int SoLuong { set; get; }    
        public int Gia { set; get; }
        public string NgayNhapKho { set; get; }
        public string HSD { set; get; }
        public int GiaTri { set; get;}
        public int CompareTo(HANG_HOA obj)
        {
            return this.GiaTri.CompareTo(obj.GiaTri);
        }
    }
}
