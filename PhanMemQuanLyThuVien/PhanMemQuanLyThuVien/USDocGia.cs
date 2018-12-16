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
using DevExpress.XtraExport;
using DevExpress.XtraEditors;

namespace PhanMemQuanLyThuVien
{
    public partial class USDocGia : UserControl
    {
        public static string TenDocGia = "";
        public static string GioiTinh = "";
        public static string DiaChi = "";
        public static string SDT = "";
        public static  DateTime NgaySinh;
        public static int MaDocGia;

        public USDocGia()
        {
            InitializeComponent();
            HienThiDocGia();
        }

        private void HienThiDocGia()
        {
            BUSDocGia busSach = new BUSDocGia();
            gridDocGia.DataSource = busSach.LayToanBoDocGia();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDocGia = new frmThemDocGia();
            frmThemDocGia.StartPosition = FormStartPosition.Manual;
            frmThemDocGia.Left = 500;
            frmThemDocGia.Top = 200;
            frmThemDocGia.ShowDialog();
            HienThiDocGia();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            HienThiDocGia();
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
                    BUSDocGia docgia = new BUSDocGia(); 

                    foreach (int i in gridView1.GetSelectedRows())
                    {
                        if (i >= 0)
                        { 
                            var cellValue = gridView1.GetRowCellValue(i, "madocgia");
                             
                            bool kt = docgia.XoaDocGia(int.Parse(cellValue.ToString()));
                            if (kt == true)
                            {
                                    XtraMessageBox.Show("Xóa độc giả thành công !", "Thông Báo");
                                    HienThiDocGia();
                            }
                            else
                                    XtraMessageBox.Show("Xóa độc giả thất bại !\n Vui Lòng kiểm tra lại !", "Thông Báo");
                   
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
                    var tendocgia = gridView1.GetRowCellValue(i, "tendocgia");
                    var gioitinh = gridView1.GetRowCellValue(i, "gioitinh");
                    var diachi = gridView1.GetRowCellValue(i, "diachi");
                    var trinhtrangsach = gridView1.GetRowCellValue(i, "tinhtrangsach");
                    var sdt = gridView1.GetRowCellValue(i, "sdt");
                    var ngaysinh = gridView1.GetRowCellValue(i, "ngaysinh");
                    var madocgia = gridView1.GetRowCellValue(i, "madocgia");

                    MaDocGia = int.Parse(madocgia.ToString());
                    TenDocGia = tendocgia.ToString(); 
                    GioiTinh = gioitinh.ToString();
                    DiaChi = diachi.ToString();
                    SDT = sdt.ToString();
                    NgaySinh = DateTime.Parse(ngaysinh.ToString());

                }
                frmCapNhatDocGia frmCapNhatDocGia = new frmCapNhatDocGia();
                frmCapNhatDocGia.StartPosition = FormStartPosition.Manual;
                frmCapNhatDocGia.Left = 500;
                frmCapNhatDocGia.Top = 200;
                frmCapNhatDocGia.ShowDialog();
                HienThiDocGia();


            }
        }
    }
}
