using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS; 
using DevExpress.XtraEditors;

namespace PhanMemQuanLyThuVien
{
    public partial class USLoaiSach : UserControl
    {
        public static string TenLoaiSach = "";
        public static int MaLoaiSach = -1;
        public USLoaiSach()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            HienThiDanLoaiSach();
        }

        public void HienThiDanLoaiSach()
        {
            BUSLoaiSach busLoaiSach = new BUSLoaiSach();
            gridLoaiSach.DataSource = busLoaiSach.LayToanBoLoaiSach();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frmThemLoaiSach frmThemLoaiSach = new frmThemLoaiSach();
            frmThemLoaiSach.ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            HienThiDanLoaiSach();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            int a = gridView1.GetSelectedRows().Length;
            if (a <= 0)
            {
                XtraMessageBox.Show("Chưa có dòng dữ liệu vào được chọn!", "Thông Báo");
            }
            else
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo") == DialogResult.OK)
                {
                    BUSLoaiSach busLoaiSach = new BUSLoaiSach();

                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        if (i >= 0)
                        {
                            var cellValue = gridView1.GetRowCellValue(i, "maloaisach");
                            bool kt = busLoaiSach.XoaLoaiSach(int.Parse(cellValue.ToString()));
                            if (kt == true)
                            {
                                XtraMessageBox.Show("Xóa sách thành công !", "Thông Báo");
                                HienThiDanLoaiSach();
                            }
                            else
                                XtraMessageBox.Show("Xóa sách thất bại !\n Vui Lòng kiểm tra lại !", "Thông Báo");
                        }

                    }
                }
            }
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            int a = gridView1.GetSelectedRows().Length;
            if (a <= 0)
            {
                XtraMessageBox.Show("Chưa có dòng dữ liệu vào được chọn!", "Thông Báo");
            }
            else
            {
                foreach (int i in gridView1.GetSelectedRows())
                {
                    var tenloaisach = gridView1.GetRowCellValue(i, "tenloaisach");
                    var maloaisach = gridView1.GetRowCellValue(i, "maloaisach");
                    MaLoaiSach = int.Parse(maloaisach.ToString());
                    TenLoaiSach = tenloaisach.ToString(); 
                }
                frmCapNhatLoaiSach frmCapNhatLoaiSach = new frmCapNhatLoaiSach();
                frmCapNhatLoaiSach.ShowDialog();
            }
        }
    }
}
