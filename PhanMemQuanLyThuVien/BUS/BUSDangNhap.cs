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


        //hàm lấy nhân viên đăng nhập
        public List<LayNVLoginResult> LayNVLogin(string username)
        {
            List<LayNVLoginResult> nv = new List<LayNVLoginResult>();
            nv = thuvien.LayNVLogin(username).ToList();
            return nv;
        }

        //thêm tài khoản
        public bool ThemTaiKhoan(string username, string password, int status)
        {
            try
            {
                thuvien.ThemTaiKhoan(username, password, status);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //kiemtra trung user
        public int KiemTraUser(string user)
        {

            using (ThuVienDataContext thuvien2 = new ThuVienDataContext())
            {
                var q = thuvien2.KiemTraTonTaiDangNhap(user);
                return q;
            }
        }


        //cập nhật đăng nhập
        public bool CapNhatTaiKhoan(string username, string password, int status)
        {
            try
            {
                thuvien.CapNhatTaiKhoan(username, password, status);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //lấy status đăng nhâp
        public int GetStatusLogin(string user)
        {

            using (ThuVienDataContext thuvien2 = new ThuVienDataContext())
            {
                var q = thuvien2.GetStatusLogin(user);
                return q;
            }
        }

        // lấy tài khoản nhân viênn
        public List<GetTaiKhoanUserResult> GetTaiKhoanUser(int ma)
        {
            List<GetTaiKhoanUserResult> nv = new List<GetTaiKhoanUserResult>();
            nv = thuvien.GetTaiKhoanUser(ma).ToList();
            return nv;
        }

        //phan quyen
        public bool PhanQuyen(string username, int status)
        {
            try
            {
                thuvien.PhanQuyen(username, status);
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
            return false;
        }
    }
}
