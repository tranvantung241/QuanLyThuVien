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
    public partial class frmCapNhatNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int manhanvien;
        public frmCapNhatNhanVien()
        {
            InitializeComponent();

            txtTenNhanVienUpdate.Text = USNhanVien.TenNhanVien;
            txtDiaChiNhanVienUpdate.Text = USNhanVien.DiaChi;
            txtSDTNhanVienUpdate.Text = USNhanVien.SDT;
            dateNgaySinhNhanVienUpdate.Text = USNhanVien.NgaySinh.ToString();
            cboGioiTinhNhanVienUpdate.Text = USNhanVien.GioiTinh;
            manhanvien = USNhanVien.MaNhanVien;
            cboChucVuUpdate.Text = USNhanVien.ChucVu;
            cboTaiKhoanUpdate.Text = USNhanVien.TaiKhoan.ToString();

            HienThiTaiKhoan();
        }

        private void HienThiTaiKhoan()
        {
            BUSNhanVien BUSNhanVien = new BUSNhanVien();
            cboTaiKhoanUpdate.DataSource = BUSNhanVien.LayTaiKhoan();
            cboTaiKhoanUpdate.ValueMember = "id";
            cboTaiKhoanUpdate.DisplayMember = "username";


        }

        private void btnCapNhatDocGia_Click(object sender, EventArgs e)
        {

            if (txtTenNhanVienUpdate.Text.Length <= 0 || txtDiaChiNhanVienUpdate.Text.Length <=0
                || dateNgaySinhNhanVienUpdate.Text.Length<=0 || cboTaiKhoanUpdate.Text.Length <= 0
                || cboChucVuUpdate.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên sách!", "Thông Báo");
            }
            else
            {
                if (txtSDTNhanVienUpdate.Text.Length >= 1 && txtSDTNhanVienUpdate.Text.Length >= 11)
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Thông Báo");
                }
                else
                {
                    string ngaysinh = dateNgaySinhNhanVienUpdate.Text;
                    DateTime Date = Convert.ToDateTime(ngaysinh);
                    int taikhoan = taikhoan = int.Parse(cboTaiKhoanUpdate.SelectedValue.ToString());

                    //thêm vào database
                    BUSNhanVien BUSNhanVien = new BUSNhanVien();
                    bool kt = BUSNhanVien.CapNhatNhanVien(manhanvien, txtTenNhanVienUpdate.Text,
                        cboGioiTinhNhanVienUpdate.Text, Date, txtDiaChiNhanVienUpdate.Text, txtSDTNhanVienUpdate.Text,
                        cboChucVuUpdate.Text, taikhoan);
                    if (kt = true)
                    {
                        XtraMessageBox.Show("Cập nhật nhân viên thành công.", "Thông Báo");
                        USNhanVien uSNhanVien = new USNhanVien();
                        uSNhanVien.HienThiDanhSachNhanVien();

                    }
                    else
                        XtraMessageBox.Show("Cập nhật nhân viên thất bại.", "Thông Báo");
                }
            }
            
        }

        private void btnCancleUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTNhanVienUpdate_EditValueChanged(object sender, EventArgs e)
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