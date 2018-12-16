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

       //Hiển thị danh sách sách mượn
       public List<HienThiSachMuonResult> HienThiSachMuon()
       {
            List<HienThiSachMuonResult> sachmuon = thuvien.HienThiSachMuon().ToList();
            return sachmuon;
       }

        //hiển thị sách mượn theo độc giả

        public List<LaySachTheoDocGiaMuonResult> LaySachTheoDocGiaMuon (int madocgia)
        {
            List<LaySachTheoDocGiaMuonResult> sachmuon = thuvien.LaySachTheoDocGiaMuon(madocgia).ToList();
            return sachmuon;
        }
    }


}
