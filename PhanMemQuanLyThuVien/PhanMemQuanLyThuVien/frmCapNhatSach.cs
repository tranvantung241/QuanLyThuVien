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
using System.IO;

namespace PhanMemQuanLyThuVien
{
    public partial class frmCapNhatSach : DevExpress.XtraEditors.XtraForm
    {
        String imgLocation = "";
        String tensach = "";
        String gia = "";
        int loaisach = -1;
        int tinhtrang = -1;
        int masach = -1;
        public frmCapNhatSach()
        {
            InitializeComponent();
            txtTenSachUpdate.Text = USSach.TenSach;
            txtGiaUpdate.Text = USSach.TriGia.ToString();
            cboLoaiSachUpdate.Text = USSach.TenLoaiSach;
            cboTinhTrangUpdate.Text = USSach.TinhTrangSach.ToString();
            masach = USSach.MaSach;
            HienThiLoaiSach();
            
            pictureBox1Update.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void HienThiLoaiSach()
        {
            BUSLoaiSach loaisach = new BUSLoaiSach();
            cboLoaiSachUpdate.DataSource = loaisach.GetLoaiSach();
            cboLoaiSachUpdate.ValueMember = "maloaisach";
            cboLoaiSachUpdate.DisplayMember = "tenloaisach"; 
        }
         

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnChonAnhUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(* .png)| *.png|jpg file(*. jpg)|*.jpg|All file(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1Update.ImageLocation = imgLocation;
            }
        }

        private void btnCancleUpdateSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtGiaUpdate.Text, out n);

            if (txtTenSachUpdate.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên sách!", "Thông Báo");
            }
            else if (txtGiaUpdate.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền giá sách!", "Thông Báo");
            }
            else if (isNumeric == false)
            {
                XtraMessageBox.Show("Giá chưa hợp lệ", "Thông Báo");
            }
            else
            {//ảnh
                byte[] images = null;
                if (imgLocation == "")
                {
                    images = null;
                    //FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    //BinaryReader brs = new BinaryReader(stream);
                    //images = brs.ReadBytes((int)stream.Length);
                }
                else
                {
                    images = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                }

                tensach = txtTenSachUpdate.Text;
                loaisach = int.Parse(cboLoaiSachUpdate.SelectedValue.ToString());
                tinhtrang = KiemTraTinhTrangSach(cboTinhTrangUpdate.Text);
                gia = txtGiaUpdate.Text;
                Decimal money = Decimal.Parse(gia);


                //thêm vào database
                BUSSach sach = new BUSSach();
                String kt = sach.CapNhatSach(masach, tensach, loaisach, money, tinhtrang, images);
                if (kt.Equals("OK"))
                {
                    XtraMessageBox.Show("Cập nhật sách thành công.", "Thông Báo");

                }
                else
                    XtraMessageBox.Show("Cập nhật sách thất bại.", "Thông Báo");
            }
        }

        private int KiemTraTinhTrangSach(string text)
        {
            if (text.Equals("Mới"))
            {
                return 1;
            }
            return -1;
        }
    }
}