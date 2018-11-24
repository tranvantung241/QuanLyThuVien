using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSSach
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();

        //public List<SACH> HienThiSach()
        //{
        //    List<SACH> sach = new List<SACH>();
        //    sach = thuvien.SACHes.ToList();
        //    return sach;
        //}

        public List<HienThiSachResult> LayToanBoSach()
        {
            List<HienThiSachResult> sach = thuvien.HienThiSach().ToList();
            return sach;
        }

        public String ThemSach(String tensach, int loaisach, Decimal trigia,
            int tinhtrang, byte[] hinhanh)
        {
            SqlCommand command = new SqlCommand();
            command.Parameters.Add(new SqlParameter("@anh", hinhanh));
            try
            {
                thuvien.ThemSach(tensach, loaisach, trigia, tinhtrang, hinhanh);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool XoaSach(int masach)
        {
            try
            {
                thuvien.XoaSach(masach);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            return false;
        }


        public String CapNhatSach(int masach,String tensach, int loaisach, Decimal trigia,
           int tinhtrang, byte[] hinhanh)
        {
            SqlCommand command = new SqlCommand();
            command.Parameters.Add(new SqlParameter("@anh", hinhanh));
            try
            {
                thuvien.CapNhatSact(masach, tensach, loaisach, trigia, tinhtrang, hinhanh);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }


}
