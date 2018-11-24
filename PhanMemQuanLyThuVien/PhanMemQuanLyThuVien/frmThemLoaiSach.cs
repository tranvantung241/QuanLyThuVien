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
    public partial class frmThemLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        public frmThemLoaiSach()
        {
            InitializeComponent();
        }

        private void btnCancleThemSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         

        private void btnThemLoaiSach_Click_1(object sender, EventArgs e)
        {
            BUSLoaiSach loaisach = new BUSLoaiSach();
            String kt = loaisach.ThemLoaiSach(txtTenLoaiSach.Text);
            if (kt.Equals("OK"))
            {
                XtraMessageBox.Show("Thêm Loại Sách Thành Công", "Thông Báo");
                txtTenLoaiSach.Text = "";

            }
            else
                XtraMessageBox.Show("Thêm Loại Sách Thất Bại", "Thông Báo");
        }
    }
}