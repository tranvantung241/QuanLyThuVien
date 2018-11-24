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
    public partial class frmThemDocGia : DevExpress.XtraEditors.XtraForm
    { 
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        { 

            if (txtTenDocGia.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên độc giả!", "Thông Báo");
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
}