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
using DevExpress.XtraEditors.Filtering.Templates;

namespace PhanMemQuanLyThuVien
{
    public partial class USPhieuTra : DevExpress.XtraEditors.XtraUserControl
    {
        public string username = "";
        public DateTime today;

        BUSPhieuTra BUSPhieuTra = new BUSPhieuTra();
        public USPhieuTra()
        {
            InitializeComponent(); 
            this.Dock = DockStyle.Fill;
            treeList1.DataSource = BUSPhieuTra.GetPhieuTra();
        }

        

        private void USPhieuTra_Load(object sender, EventArgs e)
        {
            username = frmMain.TaiKhoan;
            HienThiNhanVienLogin(username);
            HienThiDocGiaCbo();
            SetVisible(false);
            

            cboNgayTra.Enabled = false;
            today = DateTime.Today;
            cboNgayTra.Text = today.ToString("dd/MM/yyyy"); 
        }

        private void SetVisible(bool e)
        {
            lblSoTien.Visible = e;
            cboThanhToan.Visible = e;
            btnThanhToan.Visible = e;
        }

        public void HienThiNhanVienLogin(string username)
        {
            BUSDangNhap bUSDangNhap = new BUSDangNhap();
            comboBoxEdit1.DataSource = bUSDangNhap.LayNVLogin(username);
            comboBoxEdit1.ValueMember = "manv";
            comboBoxEdit1.DisplayMember = "tennhanvien";
            comboBoxEdit1.Enabled = false;
        }
        public void HienThiDocGiaCbo()
        {
            BUSDocGia BUSDocGia = new BUSDocGia();
            lookUpDocGia.Properties.DataSource = BUSDocGia.HienDocGiaPhieuMuon();
        }

        public void HienThiSachMuon(int madocgia)
        {
            BUSSach bUSSach = new BUSSach();
            lookUpTenSach.Properties.DataSource = bUSSach.LaySachTheoDocGiaMuon(madocgia);
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            //kiểm tra=======================================================
            if (lookUpTenSach.EditValue == null || lookUpDocGia.EditValue == null || cboNgayTra.Text == null || cboNgayTra.Text == null)
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông Báo");
            }
            else
            {
                // lấy dữ liệu=======================================================
                object docgia = lookUpDocGia.EditValue;
                //string docgia = lookUpDocGia.Text;

                object masach = lookUpTenSach.EditValue;
                //string masach = lookUpTenSach.Text;

                string date1 = cboNgayTra.Text;
                DateTime ngaytra = Convert.ToDateTime(date1);


                int manv = int.Parse(comboBoxEdit1.SelectedValue.ToString());


                //thêm phiếu mượn=======================================================
                BUSPhieuTra bUSPhieu = new BUSPhieuTra();
                bool lapphieutra = bUSPhieu.LapPhieuTra(int.Parse(docgia.ToString()), manv,
                    int.Parse(masach.ToString()), ngaytra);

                if (lapphieutra == true)
                {
                    XtraMessageBox.Show("Lập phiếu trả thành công", "Thông Báo");
                    treeList1.DataSource = BUSPhieuTra.GetPhieuTra();
                }
                else
                {
                    XtraMessageBox.Show("Lập phiếu trả thất bại", "Thông Báo");
                }
            }
        }

        private void lookUpDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if(lookUpDocGia.EditValue != null)
            {
                object docgia = lookUpDocGia.EditValue;
                HienThiSachMuon(int.Parse(docgia.ToString()));
            }
            
        }

        private void lookUpTenSach_EditValueChanged(object sender, EventArgs e)
        {
            if(lookUpDocGia.EditValue != null)
            {
                object docgia = lookUpDocGia.EditValue;
                int madocgia = int.Parse(docgia.ToString());

                object masach = lookUpTenSach.EditValue;
                int massach = int.Parse(masach.ToString());

                string date1 = cboNgayTra.Text;
                DateTime ngaytra = Convert.ToDateTime(date1);

                BUSPhieuTra bUSPhieuTra = new BUSPhieuTra();
                int ngaytrakq = bUSPhieuTra.KiemTraNgayTra(madocgia, massach, ngaytra);

                if (ngaytrakq < 0)
                {
                    DialogResult lkResult = XtraMessageBox.Show("Bạn đã quá hạn trả sách " + ngaytrakq.ToString() + " ngày.");


                    if (lkResult == DialogResult.OK)
                    {
                        long tien = ngaytrakq * 10000 * -1;
                        cboThanhToan.Text = tien.ToString();
                        cboThanhToan.Enabled = false;
                        SetVisible(true);
                        accordionControlElement2.Enabled = false;
                    }

                }
            }
           
            
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            cboNgayTra.Enabled = false;
            cboThanhToan.Enabled = false;

            lookUpDocGia.EditValue = null;
            lookUpTenSach.EditValue = null;

            SetVisible(false);
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lookUpTenSach.EditValue == null || lookUpDocGia.EditValue == null || cboNgayTra.Text == null || cboNgayTra.Text == null)
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông Báo");
            }
            else
            {
                // lấy dữ liệu=======================================================
                object docgia = lookUpDocGia.EditValue;
                //string docgia = lookUpDocGia.Text;

                object masach = lookUpTenSach.EditValue;
                //string masach = lookUpTenSach.Text;

                string date1 = cboNgayTra.Text;
                DateTime ngaytra = Convert.ToDateTime(date1);

                int soluong = 0;

                DateTime today = DateTime.Today; 


                Decimal sotien = decimal.Parse(cboThanhToan.Text);

                string lydo = "Phạt";
;



                //thêm hóa đơn=======================================================
                // BUSPhieuTra bUSPhieu = new BUSPhieuTra();
                //bool lapphieutra = bUSPhieu.LapPhieuTra(int.Parse(docgia.ToString()), manv,
                //    int.Parse(masach.ToString()), ngaytra);

                BUSHoaDon bUSHoaDon = new BUSHoaDon();
                bool kq = bUSHoaDon.ThemHoaDon(docgia.ToString(), int.Parse(docgia.ToString()), int.Parse(masach.ToString()),
                    soluong, sotien, lydo, today);

                if (kq == true)
                {
                    XtraMessageBox.Show("Thanh toán thành công", "Thông báo");
                    btnThanhToan.Visible = false;
                    accordionControlElement2.Enabled = true;

                }
                else
                    XtraMessageBox.Show("Thanh toán thất bại.\n Vui lòng kiểm tra lại thông tin", "Thông Báo");
                
            }
            
        }
    }
}
