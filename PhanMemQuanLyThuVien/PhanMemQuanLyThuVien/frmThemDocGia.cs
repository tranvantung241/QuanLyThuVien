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
    public partial class frmThemDocGia : DevExpress.XtraEditors.XtraForm
    { 
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        { 

            if (txtTenDocGia.Text.Length <= 0 || txtDiaChi.Text.Length <=0 || dateNgaySinh.Text.Length <=0 )
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo");
            }
            else
            {
                if (txtSDT.Text.Length >= 1 && txtSDT.Text.Length >= 11)
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ!", "Thông Báo");
                }
                else
                {
                    string ngaysinh = dateNgaySinh.Text;
                    DateTime Date = Convert.ToDateTime(ngaysinh);

                    //thêm vào database
                    BUSDocGia docgia = new BUSDocGia();
                    String kt = docgia.ThemDocGia(txtTenDocGia.Text, Date, cboGioiTinh.Text, txtDiaChi.Text, txtSDT.Text);
                    if (kt.Equals("OK"))
                    {
                        MessageBox.Show("Thêm Độc Giả Thành Công", "Thông Báo");
                    }
                    else
                        MessageBox.Show("Thêm Độc Giả Thất Bại", "Thông Báo");
                }
            }
            
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
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