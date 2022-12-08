using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKGT_Nhom7
{
    class NguoiDung
    {
        private string HoTen, Email, SDT, taiKhoan, matKhau;
        private object txtHoTen;

        public NguoiDung()
        {
            HoTen = Email = SDT = taiKhoan = matKhau = "";
        }
        public NguoiDung(string ten, string mail, string sdt, string tk, string mk)
        {
            HoTen = ten;
            Email = mail;
            SDT = sdt;
            taiKhoan = tk;
            matKhau = mk;
        }
        //public bool KiemTraDinhDangMK() // tối thiểu 5 ký tự có cả chữ và số
        //{

        //    //if (matKhau.Length < 5)
        //    //{
        //    //    return false;

        //    //}
        //    ////kiem tra ca chu va so
        //    //bool KiemTraChu = false; // chưa có chữ
        //    //bool KiemTraSo = false; // chưa có số 
        //    //for (int i = 0; i < matKhau.Length; i++)
        //    //{
        //    //    if (KiemTraChu == true && KiemTraSo == true)
        //    //    {
        //    //        break;
        //    //    }
        //    //    if (matKhau[i] >= 'A' && matKhau[i] <= 'Z' || (matKhau[i] >= 'a' && matKhau[i] <= 'z'))
        //    //    {
        //    //        KiemTraChu = true;

        //    //    }
        //    //    if (matKhau[i] >= '0' && matKhau[i] <= '9')
        //    //    {
        //    //        KiemTraSo = true;
        //    //    }
        //    //}
        //    //if (KiemTraSo == false || KiemTraChu == false)
        //    //{
        //    //    return false;
        //    //}


        //    return true;

        //}
        public bool KiemTraDinhDangEmail()
        {
            //các trường hợp sai
            if (!Email.Contains("@"))
            {
                return false;
            }
            if (!Email.Contains(".com"))
            {
                return false;
            }
            int index1 = Email.IndexOf("@");
            int index2 = Email.IndexOf(".com");
            string s = Email.Substring(index1 + 1, index2 - index1 - 1);

            if (s != "gmail" && s!= "yahoo")
            {
                return false;
            }    
            if (s != "yahoo")
            {
                if (Email.Contains(".vn"))
                {
                    return false;
                }
            }
            return true;
        }

        public string ChuanHoaHoTen()
        {
            string 
            hoten = HoTen.Trim(); //bỏ khoảng cách 

            for(int i=0; i< hoten.Length; ++i)
            {
                if(hoten[i] == ' ' && hoten[i+1] == ' ')
                {
                    hoten = hoten.Remove(i, 1);
                    i--;
                }
            }
            hoten = hoten.ToLower();
            char c = hoten[0];
            hoten = hoten.Remove(0, 1);
            hoten = hoten.Insert(0, c.ToString().ToUpper());
            for(int i=1; i < hoten.Length; ++i)
            {
                if(hoten[i]==' ') //i+1 sẽ viết hoa
                {
                    char c1 = hoten[i + 1];
                    hoten = hoten.Remove(i + 1, 1);
                    hoten = hoten.Insert(i + 1, c1.ToString().ToUpper());
                }    
            }
            return hoten;
        }
    }
}
