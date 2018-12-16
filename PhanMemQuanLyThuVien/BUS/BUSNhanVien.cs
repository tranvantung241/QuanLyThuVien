using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSNhanVien
    {
        ThuVienDataContext thuvien = new ThuVienDataContext();
         

        public List<LayToanBoNhanVienResult> LayToanBoLoaiSach()
        {
            List<LayToanBoNhanVienResult> nhanvien = new List<LayToanBoNhanVienResult>();
            nhanvien = thuvien.LayToanBoNhanVien().ToList();
            return nhanvien;
        }

        public List<DANGNHAP> LayTaiKhoan()
        {
            List<DANGNHAP> DANGNHAP = new List<DANGNHAP>();
            DANGNHAP = thuvien.DANGNHAPs.ToList();
            return DANGNHAP;
        }


        public bool ThemNhanVien(string tennhanvien, string gioitinh, DateTime ngaysinh, string diachi,
            string sdt, string chucvu, int taikhoan) 
        {
             
            try
            {
                thuvien.ThemNhanVien(tennhanvien, gioitinh, ngaysinh, diachi,sdt, chucvu, taikhoan);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public bool XoaNhanVien(int manhanvien)
        {
            try
            {
                thuvien.XoaNhanVien(manhanvien);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }


        public bool CapNhatNhanVien(int manhavien, string tennhanvien, string gioitinh, DateTime ngaysinh, string diachi,
            string sdt, string chucvu, int taikhoan)
        {

            try
            {
                thuvien.CapNhatNhanVien(manhavien, tennhanvien, gioitinh, ngaysinh, diachi, sdt, chucvu, taikhoan);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public List<HienThiNhanVienPQResult> HienThiNhanVienPhanQuyen()
        {
            List<HienThiNhanVienPQResult> list = new List<HienThiNhanVienPQResult>();
            list = thuvien.HienThiNhanVienPQ().ToList();
            return list;
        }
                            
    }
}
