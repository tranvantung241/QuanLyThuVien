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
    public partial class frmCapNhatLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        int MaLoaiSach = -1;
        public frmCapNhatLoaiSach()
        {
            InitializeComponent();
            txtTenLoaiSachUpdate.Text = USLoaiSach.TenLoaiSach;
            MaLoaiSach = int.Parse(USLoaiSach.MaLoaiSach.ToString());
        }

        private void btnCapNhatLoaiSach_Click(object sender, EventArgs e)
        {
             
            if (txtTenLoaiSachUpdate.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên loại sách!", "Thông Báo");
            } 
            else
            { 
                //thêm vào database
                BUSLoaiSach loaisach = new BUSLoaiSach();
                String kt = loaisach.CapNhatLoaiSach(MaLoaiSach, txtTenLoaiSachUpdate.Text);
                if (kt.Equals("OK"))
                {
                    XtraMessageBox.Show("Cập nhật loại sách thành công.", "Thông Báo");
                    txtTenLoaiSachUpdate.Text = "";
                    MaLoaiSach = -1;
                }
                else
                    XtraMessageBox.Show("Cập nhật loại thất bại.", "Thông Báo");
            }
        }

        private void btnCancleUpdateLoaiSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}