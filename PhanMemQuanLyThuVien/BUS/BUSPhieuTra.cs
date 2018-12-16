using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSPhieuTra
    {
        ThuVienDataContext thuVien = new ThuVienDataContext();

        public bool LapPhieuTra(int madocgia, int manv, int masach , DateTime ngaytra) 
        {
            try
            {
                thuVien.LapPhieuTra(madocgia, manv, masach, ngaytra);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            return false;
        }

        public List<GetPhieuTraResult> GetPhieuTra()
        {
            List<GetPhieuTraResult> listPhieuTra = new List<GetPhieuTraResult>();
            listPhieuTra = thuVien.GetPhieuTra().ToList();
            return listPhieuTra;
        }

        public int KiemTraNgayTra(int madocgia, int masach, DateTime ngaytra)
        {
            //string ngaytrakq = thuVien.KiemTraNgayTra(madocgia, masach, ngaytra).ToString();
            //return int.Parse(ngaytrakq);

            using (ThuVienDataContext thuvien2 = new ThuVienDataContext())
            {
                //For Stored Procedure with Return value (for Integer)
                //returns Int
                var q = thuvien2.KiemTraNgayTra(madocgia, masach, ngaytra);
                return q;
            }
        }
    }
}
