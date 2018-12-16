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
using DevExpress.XtraReports.UI;

namespace PhanMemQuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string idLogin;
        public static string TaiKhoan = "";
        int status = 1;
        public frmMain()
        {

            InitializeComponent();
            disEnableMenuLogin(true, status);
            navigationFrame1.SelectedPage = pageMain;
            this.IsMdiContainer = true;
        }

        public void disEnableMenuLogin(bool e, int id_login)
        {
           switch (id_login)
            {
                case 1: // admin
                    btnLogin.Enabled = e;
                    btnLogout.Enabled = !e; 
                    btnChangePass.Enabled = !e;
                    btnPhanQuyen.Enabled = !e; 
                    btnSach.Enabled = !e;
                    btnDanhSachSach.Enabled = !e;
                    btnListTypeSach.Enabled = !e;
                    btnQLDocGia.Enabled = !e;
                    btnQLVN.Enabled = !e;
                    btnMuonSach.Enabled = !e;
                    btnBaoCao.Enabled = !e;
                    break;
                case 2: // nhân viên
                    btnLogin.Enabled = e;
                    btnLogout.Enabled = !e; 
                    btnChangePass.Enabled = !e;
                    btnPhanQuyen.Enabled = !e; 
                    btnSach.Enabled = !e;
                    btnDanhSachSach.Enabled = !e;
                    btnListTypeSach.Enabled = !e;
                    btnQLDocGia.Enabled = !e;
                    btnMuonSach.Enabled = !e;
                    btnTraSach.Enabled = !e;
                    break;
                case 3: // giám đốc
                    btnLogin.Enabled = e;
                    btnLogout.Enabled = !e;
                    btnChangePass.Enabled = !e;
                    btnPhanQuyen.Enabled = !e;
                    btnSach.Enabled = !e;
                    btnDanhSachSach.Enabled = !e;
                    btnListTypeSach.Enabled = !e;
                    btnQLDocGia.Enabled = !e;
                    btnQLVN.Enabled = !e;
                    btnMuonSach.Enabled = !e;
                    btnBaoCao.Enabled = !e;
                    btnPhanQuyen.Enabled = e;
                    break;
            }
            
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
                frmMain.TaiKhoan = "";
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
            pageNhanVien.Controls.Add(new USNhanVien());
            pagePhieuMuon.Controls.Add(new USPhieuMuon());
            pagePhieuTra.Controls.Add(new USPhieuTra());
            pageBaoCao.Controls.Add(new USBaoCao());
            pageThongKe.Controls.Add(new USThongKe());
            pagePhanQuyen.Controls.Add(new USPhanQuyen());
            pageTienPhat.Controls.Add(new USTienPhat());
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
                status = bus.GetStatusLogin(taikhoan);
                if (kt == true)
                { 
                    disEnableMenuLogin(false, status);
                    TaiKhoan = taikhoan;
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
            frmRegister frmRegister = new frmRegister();
            frmRegister.StartPosition = FormStartPosition.Manual;
            frmRegister.Left = 500;
            frmRegister.Top = 200;
            frmRegister.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
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

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageNhanVien;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pagePhieuMuon;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pagePhieuTra;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            navigationFrame1.SelectedPage = pageBaoCao;

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageThongKe;
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pagePhanQuyen;
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame1.SelectedPage = pageTienPhat;
        }
    }
}
