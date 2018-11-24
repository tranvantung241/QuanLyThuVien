using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSDangNhap
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();

        //hàm kiểm tra đăng nhập
        public bool KiemTraDangNhap(string username, string password)
        {
            DANGNHAP dn =  thuvien.DANGNHAPs.FirstOrDefault(x => x.username == username);
             
            if (dn != null)
            {
                if (dn.password == password)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

            return false;

        }
    }
}
