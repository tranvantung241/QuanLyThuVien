using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DevExpress.XtraExport; 
using DevExpress.XtraEditors;

namespace PhanMemQuanLyThuVien
{
    public partial class USSach : UserControl
    {
        public static string TenSach = "";
        public static string TenLoaiSach = "";
        public static decimal TriGia = 0;
        public static int  TinhTrangSach = 0;
        public static int MaSach = -1;

        public USSach()
        {
            InitializeComponent(); 
            this.Dock = DockStyle.Fill;
            HienThiDanhSachSach();
        }

        public void HienThiDanhSachSach()
        {
            BUSSach busSach = new BUSSach();
            gridSach.DataSource = busSach.LayToanBoSach();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frmThemSach frmsach = new frmThemSach();
            frmsach.ShowDialog();
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
                    BUSSach busSach = new BUSSach();

                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        if (i >= 0)
                        {
                            var cellValue = gridView1.GetRowCellValue(i, "masach");
                            bool kt = busSach.XoaSach(int.Parse(cellValue.ToString()));
                            if (kt == true)
                            {
                                XtraMessageBox.Show("Xóa sách thành công !", "Thông Báo");
                                HienThiDanhSachSach();
                            }
                            else
                                XtraMessageBox.Show("Xóa sách thất bại !\n Vui Lòng kiểm tra lại !", "Thông Báo");
                        }

                    }
                }
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            HienThiDanhSachSach();
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
                    var tensach = gridView1.GetRowCellValue(i, "tensach");
                    var tenloaisach = gridView1.GetRowCellValue(i, "tenloaisach");
                    var trigia = gridView1.GetRowCellValue(i, "trigia");
                    var trinhtrangsach = gridView1.GetRowCellValue(i, "tinhtrangsach");
                    var hinhanh = gridView1.GetRowCellValue(i, "hinhanh");
                    var masach = gridView1.GetRowCellValue(i, "masach");
                    TenSach = tensach.ToString();
                    TenLoaiSach = tenloaisach.ToString();
                    TriGia = decimal.Parse(trigia.ToString());
                    TinhTrangSach = int.Parse(trinhtrangsach.ToString());
                    MaSach = int.Parse(masach.ToString());

                }
                frmCapNhatSach frmCapNhat = new frmCapNhatSach(); 
                frmCapNhat.ShowDialog();
            }   
        }
    }
}
