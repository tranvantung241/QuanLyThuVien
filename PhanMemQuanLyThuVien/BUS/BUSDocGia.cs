using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSDocGia
    {
        ThuVienDataContext thuvien = new ThuVienDataContext(); 
        public List<NGUOIDOC> LayToanBoDocGia()
        {
            List<NGUOIDOC> docgia = new List<NGUOIDOC>();
            docgia = thuvien.NGUOIDOCs.ToList();
            return docgia;
        }

        public String ThemDocGia(string tendocgia, DateTime ngaysinh, string gioitinh,
            string  diachi, string sdt)
        { 
            try
            {
                thuvien.ThemNguoiDoc(tendocgia, ngaysinh, gioitinh, diachi, sdt);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
