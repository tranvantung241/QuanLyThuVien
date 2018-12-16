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

namespace PhanMemQuanLyThuVien
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {

        BUSDangNhap BUSDangNhap = new BUSDangNhap();
        string userTaiKhan = "";
        int a = -1;
        public frmRegister()
        {
            InitializeComponent();
            txtPass.Properties.PasswordChar = '\u25CF';
            txtPass2.Properties.PasswordChar = '\u25CF'; 
             
        }

         

        private void ckhHienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = ckhHienThi.Checked ? '\0' : '\u25CF';
            txtPass2.Properties.PasswordChar = ckhHienThi.Checked ? '\0' : '\u25CF';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            int loainhanvien = 0; 
            bool ktranhap = KiemTraNhap();
            if(ktranhap == false)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông Báo");
            }
            else
            {
                if (string.Equals(txtPass.Text, txtPass2.Text) == false)
                {
                    XtraMessageBox.Show("Mật khẩu không trùng khớp.", "Thông Báo");
                }
                else
                {
                    switch (comboBox1.Text)
                    {
                        case "Giám Đốc":
                            loainhanvien = 1;
                            break;
                        case "Nhân Viên":
                            loainhanvien = 2;
                            break;
                    }

                    //tiến hành thêm tài khoản
                    int kt = BUSDangNhap.KiemTraUser(txtusername.Text);
                    if (kt == 1) // đã tồn tại trong database
                    {
                        DialogResult =  XtraMessageBox.Show("User đã tồn tại.\nTiến hành cập nhật.", "Thông Báo", MessageBoxButtons.OKCancel);
                        if(DialogResult == DialogResult.OK)
                        { 
                            bool ktThem = BUSDangNhap.CapNhatTaiKhoan(txtusername.Text, txtPass.Text, loainhanvien);

                            if (ktThem == true)
                            {
                                XtraMessageBox.Show("Cập nhật khoản thành công.", "Thông Báo");
                                Reset();
                            }
                            else
                            {
                                XtraMessageBox.Show("Cập nhật khoản thất bại.", "Thông Báo");
                            }
                        }
                        
                    }
                    else
                    {
                        bool ktThem = BUSDangNhap.ThemTaiKhoan(txtusername.Text, txtPass.Text, loainhanvien);

                        if (ktThem == true)
                        {
                            XtraMessageBox.Show("Thêm tài khoản thành công.", "Thông Báo");
                            Reset();
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm tài khoản thất bại.", "Thông Báo");
                        }
                    }
                   
                }
            }
            
        }

        private void Reset()
        {
            txtPass.Text = "";
            txtPass2.Text = "";
            txtusername.Text = "";
            comboBox1.SelectedText = "";
        }

        private bool KiemTraNhap()
        {
            if(txtPass.Text.Length <= 0 || txtPass2.Text.Length<= 0 || txtusername.Text.Length<=0 || comboBox1.Text.Length<=0)
            {
                return false;
            }
            return true;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
             
        }
    }
}