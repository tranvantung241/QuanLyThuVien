using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSLoaiSach
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();
         
        public List<LOAISACH> GetLoaiSach()
        {
            List<LOAISACH> loaisach = new List<LOAISACH>();
            loaisach = thuvien.LOAISACHes.ToList();
            return loaisach;
        }

        public List<LayToanBoLoaiSachResult> LayToanBoLoaiSach()
        {
            List<LayToanBoLoaiSachResult> loaisac = new List<LayToanBoLoaiSachResult>();
            loaisac  = thuvien.LayToanBoLoaiSach().ToList();
            return loaisac; 
        }

        public String ThemLoaiSach(String tensach)
        { 
            try
            {
                thuvien.ThemLoaiSach(tensach);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool XoaLoaiSach(int maloaisach)
        {
            try
            {
                thuvien.XoaLoaiSach(maloaisach);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public String CapNhatLoaiSach(int malaoisach, String tenlaoisach)
        { 
            try
            {
                thuvien.CapNhatLoaiSach(malaoisach, tenlaoisach);
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
