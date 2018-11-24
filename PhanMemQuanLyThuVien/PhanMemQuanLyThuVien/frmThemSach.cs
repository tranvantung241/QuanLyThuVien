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
using DAL;
using System.IO;
using PhanMemQuanLyThuVien;

namespace PhanMemQuanLyThuVien
{
    public partial class frmThemSach : DevExpress.XtraEditors.XtraForm
    { 
        String imgLocation = "";
        String tensach = "";
        String gia = "";
        int loaisach = -1;
        int tinhtrang = -1;

        public frmThemSach()
        {
            InitializeComponent();
            HienThiLoaiSach();
            cboTinhTrang.SelectedIndex = cboTinhTrang.Items.IndexOf("Mới");
            //cboTinhTrang.Enabled = false; 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void HienThiLoaiSach()
        {
            BUSLoaiSach loaisach = new BUSLoaiSach();
            cboLoaiSach.DataSource = loaisach.GetLoaiSach();
            cboLoaiSach.ValueMember = "maloaisach";
            cboLoaiSach.DisplayMember = "tenloaisach";

        }

        //xử lý click btn Chọn Ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(* .png)| *.png|jpg file(*. jpg)|*.jpg|All file(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation; 
            }
        }

        //convert byte[] to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //xử lý sự kiện click btn Thêm Sách
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(txtGia.Text, out n);

            if (txtTenSach.Text.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng điền tên sách!", "Thông Báo");
            }
            else if(txtGia.Text.Length <= 0)
            { 
                    XtraMessageBox.Show("Vui lòng điền giá sách!", "Thông Báo");
            }
            else if(isNumeric  == false)
            {
                XtraMessageBox.Show("Giá chưa hợp lệ", "Thông Báo");
            }
            else { 
                //ảnh
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                tensach = txtTenSach.Text;
                loaisach = int.Parse(cboLoaiSach.SelectedValue.ToString());
                tinhtrang = KiemTraTinhTrangSach(cboTinhTrang.Text);
                gia = txtGia.Text;
                Decimal money = Decimal.Parse(gia);


                //thêm vào database
                BUSSach sach = new BUSSach();
                String kt = sach.ThemSach(tensach, loaisach, money, tinhtrang, images);
                if (kt.Equals("OK"))
                {
                    MessageBox.Show("Thêm Sách Thành Công", "Thông Báo");
                    XoaTextFile();
                }
                else
                    MessageBox.Show("Thêm Sách Thất Bại", "Thông Báo");
            }

        }

        //hàm xóa các ổ nhập sau khi thêm thành công
        private void XoaTextFile()
        {
            txtGia.Text = "";
            txtTenSach.Text = "";
            imgLocation = "";
        }

        //hàm kiểm tra tình trạng sách khi chọn combbox
        private int KiemTraTinhTrangSach(string text)
        {
            if( text.Equals("Mới"))
            {
                return 1;
            }
            return -1;
        }


        //xử lý sự kiện click btn Canclea
        private void btnCancleThemSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}