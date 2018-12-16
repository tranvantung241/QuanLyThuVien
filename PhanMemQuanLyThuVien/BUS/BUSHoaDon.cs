using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUSHoaDon
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();

        //thêm hóa đơn phạt quá hạn mượn sách
        public bool ThemHoaDon(string ten, int madocgia, int masach, int soluong,
            Decimal sotien, string lydo, DateTime ngayhd)
        {
            try
            {
                thuvien.ThemHoaDon(ten, madocgia, masach, soluong, sotien, lydo, ngayhd);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            return false;
        }
    }
}
