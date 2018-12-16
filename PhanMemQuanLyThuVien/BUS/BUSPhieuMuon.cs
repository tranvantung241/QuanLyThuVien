using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSPhieuMuon
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();   
        public int LayMaPhieuMuon()
        {
            var dsPhieuMuon = from x in thuvien.PHIEUMUONs
                              orderby x.maphieumuon descending
                              select x;
            var phieumuon = dsPhieuMuon.First();

            return phieumuon.maphieumuon;
        }

        public bool ThemPhieuMuong(int maphieumuon,  int manv, int madocgia, int masach,
            DateTime ngaymuon, DateTime ngaytra)
        {
            try
            {
                thuvien.ThemPhieuMuon(maphieumuon, manv, madocgia, masach, ngaymuon, ngaytra);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        

        public List<GetPhieuMuonResult> GetPhieuMuon()
        {
            List<GetPhieuMuonResult> listPhieuMuon = new List<GetPhieuMuonResult>();
            listPhieuMuon = thuvien.GetPhieuMuon().ToList();
            return listPhieuMuon;
        }
    }
}
