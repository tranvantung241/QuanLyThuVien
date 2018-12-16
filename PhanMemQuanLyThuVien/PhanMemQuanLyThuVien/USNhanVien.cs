using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace PhanMemQuanLyThuVien
{
    public partial class USNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public static string TenNhanVien = "";
        public static string GioiTinh = "";
        public static string DiaChi = "";
        public static string ChucVu = "";
        public static string SDT = "";
        public static DateTime NgaySinh;
        public static int MaNhanVien;
        public static string TaiKhoan = "";
        public USNhanVien()
        {
            InitializeComponent();
            HienThiDanhSachNhanVien();
        }

        public void HienThiDanhSachNhanVien()
        {
            BUSNhanVien bUSNhan = new BUSNhanVien();
            gridSach.DataSource = bUSNhan.LayToanBoLoaiSach();
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
                    BUSNhanVien BUSNhanVien = new BUSNhanVien();

                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        if (i >= 0)
                        {
                            var cellValue = gridView1.GetRowCellValue(i, "manv");
                            bool kt = BUSNhanVien.XoaNhanVien(int.Parse(cellValue.ToString()));
                            if (kt == true)
                            {
                                XtraMessageBox.Show("Xóa sách thành công !", "Thông Báo");
                                HienThiDanhSachNhanVien();
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
            HienThiDanhSachNhanVien();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.StartPosition = FormStartPosition.Manual;
            frmThemNhanVien.Left = 500;
            frmThemNhanVien.Top = 120;
            frmThemNhanVien.ShowDialog();
            HienThiDanhSachNhanVien();
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
                    var tennhanvien = gridView1.GetRowCellValue(i, "tennhanvien");
                    var gioitinh = gridView1.GetRowCellValue(i, "gioitinh");
                    var diachi = gridView1.GetRowCellValue(i, "diachi");
                    var chucvu = gridView1.GetRowCellValue(i, "chucvu");
                    var sdt = gridView1.GetRowCellValue(i, "sdt");
                    var ngaysinh = gridView1.GetRowCellValue(i, "ngaysinh");
                    var manv = gridView1.GetRowCellValue(i, "manv");
                    var taikhoan = gridView1.GetRowCellValue(i, "username");

                    MaNhanVien = int.Parse(manv.ToString());
                    TenNhanVien = tennhanvien.ToString();
                    GioiTinh = gioitinh.ToString();
                    DiaChi = diachi.ToString();
                    SDT = sdt.ToString();
                    NgaySinh = DateTime.Parse(ngaysinh.ToString());
                    ChucVu = chucvu.ToString() ;
                    TaiKhoan = taikhoan.ToString();

                }
                frmCapNhatNhanVien frmCapNhatNhanVien = new frmCapNhatNhanVien();
                frmCapNhatNhanVien.StartPosition = FormStartPosition.Manual;
                frmCapNhatNhanVien.Left = 500;
                frmCapNhatNhanVien.Top = 120;
                frmCapNhatNhanVien.ShowDialog();
                HienThiDanhSachNhanVien();
            }
        }
    }
}
