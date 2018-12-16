using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using System.Text.RegularExpressions;

namespace PhanMemQuanLyThuVien
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public static int a = 0;
        public frmThemNhanVien()
        {
            InitializeComponent();
            HienThiTaiKhoan(); 
        }

        private void HienThiTaiKhoan()
        {
            BUSNhanVien BUSNhanVien = new BUSNhanVien();
            cboTaiKhoan.DataSource = BUSNhanVien.LayTaiKhoan();
            cboTaiKhoan.ValueMember = "id";
            cboTaiKhoan.DisplayMember = "username";
            

        }

        private void btnCapNhatDocGia_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Length <= 0 || txtDiaChiNhanVien.Text.Length <=0 || dateNgaySinhNhanVien.Text.Length <=0
                || cboGioiTinhNhanVien.Text.Length<=0 || cboTaiKhoan.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên nhân viên!", "Thông Báo");
            }
            else
            {
                if(txtSDTNhanVien.Text.Length>=1 && txtSDTNhanVien.Text.Length>=11)
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Thông Báo");
                }
                else
                {
                    string ngaysinh = dateNgaySinhNhanVien.Text;
                    DateTime Date = Convert.ToDateTime(ngaysinh);
                    int taikhoan = taikhoan = int.Parse(cboTaiKhoan.SelectedValue.ToString());

                    //XtraMessageBox.Show(Date.ToString(), "Thông Báo");
                    //thêm vào database
                    BUSNhanVien BUSNhanVien = new BUSNhanVien();
                    bool kt = BUSNhanVien.ThemNhanVien(txtTenNhanVien.Text, cboGioiTinhNhanVien.Text, Date,
                        txtDiaChiNhanVien.Text, txtSDTNhanVien.Text, cboChucVu.Text, taikhoan);
                    if (kt == true)
                    {
                        XtraMessageBox.Show("Thêm Nhân Viên Thành Công", "Thông Báo");
                        USNhanVien uSNhanVien = new USNhanVien();
                        uSNhanVien.HienThiDanhSachNhanVien();
                    }
                    else
                        XtraMessageBox.Show("Thêm Nhân Viên Thất Bại", "Thông Báo");
                }
            }
            
        }

        private void btnCancleUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmMain.TaiKhoan = "";
            frmRegister.ShowDialog();
        }

         

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void txtSDTNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            Regex regex;
            //regex = new Regex("^[098-]+^[099-]+$");
            regex = new Regex(@"^[0-]\d+$"); 
            Control ctrl = (Control)sender;
            if (!regex.IsMatch(ctrl.Text))
                dxErrorProvider1.SetError(ctrl,
                "Số điện thoại chưa hợp lệ");
            else
                dxErrorProvider1.SetError(ctrl, "");
        }
    }
}