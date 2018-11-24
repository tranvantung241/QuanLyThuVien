using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace PhanMemQuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string idLogin;
        public frmMain()
        {

            InitializeComponent();
            disEnableMenuLogin(true, idLogin);
            navigationFrame1.SelectedPage = pageMain;
        }

        public void disEnableMenuLogin(bool e, String id_login)
        {
            btnLogin.Enabled = e;
            btnLogout.Enabled = !e;
            btnKhoiPhucDuLieu.Enabled = !e;
            btnChangePass.Enabled = !e;
            btnPhanQuyen.Enabled = !e;
            btnSaoDuLieu.Enabled = !e;
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Office 2007 Green";
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((XtraMessageBox.Show("Bạn có chắc chắn muốn thoát ra?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skins();
            pageQuanLySach.Controls.Add(new USSach());
            pageMain.Controls.Add(new USMain());
            pageListSach.Controls.Add(new USListSach());
            pageLoaiSach.Controls.Add(new USLoaiSach());
            pageDocGia.Controls.Add(new USDocGia()); 
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageMain;
            frmLogin login = null;
            Check_Login:
            if (login == null || login.IsDisposed)
            {
                login = new frmLogin();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtTaiKhoan.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập tài khoản !");
                    goto Check_Login;
                }
                if (login.txtTaiKhoan.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập mật khẩu !");
                    goto Check_Login;
                }

                BUSDangNhap bus = new BUSDangNhap();
                string taikhoan = login.txtTaiKhoan.Text;
                string matkhau = login.txtPass.Text;

                bool kt = bus.KiemTraDangNhap(taikhoan, matkhau);

                if (kt == true)
                {
                    XtraMessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                    disEnableMenuLogin(false, idLogin);
                }
                else
                {
                    XtraMessageBox.Show("Đăng Nhập Thất Bại. \nVui Lòng Kiểm Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Check_Login;
                }

            }

        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmSach sach = new frmSach();
            //sach.MdiParent = this;
            //sach.Show();
            navigationFrame1.SelectedPage = pageQuanLySach;
        }

        private void btnDanhSachSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageListSach;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageLoaiSach;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageDocGia;
        }
    }
}
