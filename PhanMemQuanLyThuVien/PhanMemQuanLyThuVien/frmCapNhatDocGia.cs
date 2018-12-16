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
    public partial class frmCapNhatDocGia : DevExpress.XtraEditors.XtraForm
    {
        int madocgia;
        public frmCapNhatDocGia()
        {
            InitializeComponent();
            txtTenDocGiaUpdate.Text = USDocGia.TenDocGia;
            txtDiaChiUpdate.Text = USDocGia.DiaChi;
            txtSDTUpdate.Text = USDocGia.SDT;
            dateNgaySinhUpadte.Text = USDocGia.NgaySinh.ToString();
            cboGioiTinhUpdate.Text = USDocGia.GioiTinh;
            madocgia = USDocGia.MaDocGia;


        }

        private void btnCapNhatDocGia_Click(object sender, EventArgs e)
        {

            if (txtTenDocGiaUpdate.Text.Length <= 0 || txtDiaChiUpdate.Text.Length <= 0 || dateNgaySinhUpadte.Text.Length <=0) 
            {
                XtraMessageBox.Show("Vui lòng điền tên sách!", "Thông Báo");
            }
            else
            {
                if (txtSDTUpdate.Text.Length >= 1 && txtSDTUpdate.Text.Length >= 11)
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Thông Báo");
                }
                else
                {
                    string ngaysinh = dateNgaySinhUpadte.Text;
                    DateTime Date = Convert.ToDateTime(ngaysinh);

                    //thêm vào database
                    BUSDocGia docgia = new BUSDocGia();
                    bool kt = docgia.CapNhatDocGia(madocgia, txtTenDocGiaUpdate.Text,
                        cboGioiTinhUpdate.Text, txtDiaChiUpdate.Text, txtSDTUpdate.Text,
                        Date);
                    if (kt = true)
                    {
                        XtraMessageBox.Show("Cập nhật đọc giả thành công.", "Thông Báo");

                    }
                    else
                        XtraMessageBox.Show("Cập nhật độc giả thất bại.", "Thông Báo");
                }
            }
            
        }

        private void btnCancleUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTUpdate_EditValueChanged(object sender, EventArgs e)
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