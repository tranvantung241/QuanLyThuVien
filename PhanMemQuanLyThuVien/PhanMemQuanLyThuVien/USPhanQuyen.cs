using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace PhanMemQuanLyThuVien
{
    public partial class USPhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        BUSNhanVien BUSNhanVien = new BUSNhanVien();
        BUSDangNhap BUSDangNhap = new BUSDangNhap();
        public USPhanQuyen()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            HienThiNhanVien();
        }

        private void HienThiNhanVien()
        {

            lookNhanVien.Properties.DataSource = BUSNhanVien.HienThiNhanVienPhanQuyen();
        }

        private void lookNhanVien_EditValueChanged(object sender, EventArgs e)
        {

            if (lookNhanVien.EditValue != null)
            {
                object manv = lookNhanVien.EditValue;
                HienThiTaiKhoan(int.Parse(manv.ToString()));
            }
        }

        private void HienThiTaiKhoan(int v)
        { 
            string a = BUSDangNhap.GetTaiKhoanUser(v)[0].username; 
            txtTaiKhoan.Text = a; 
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void ckhGiamDoc_CheckedChanged(object sender, EventArgs e)
        {
            chkNhanVien.Checked = false;
        }

        private void chkNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            ckhGiamDoc.Checked = false;
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            int status = -1;
            if(chkNhanVien.Checked)
            {
                status = 2; 
            }
            if(ckhGiamDoc.Checked)
            {
                status = 3;
            }
            bool Ktra = BUSDangNhap.PhanQuyen(username, status);

            if(Ktra == true)
            {
                XtraMessageBox.Show("Phân quyền thành công.", "Thông Báo");
            }
            else
            {
                XtraMessageBox.Show("Phân quyền thất bại.", "Thông Báo");
            }
        }
    }
}
