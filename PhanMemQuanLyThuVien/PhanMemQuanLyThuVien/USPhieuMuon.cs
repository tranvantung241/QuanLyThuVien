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
using DevExpress.CodeParser;
using DAL;
using System.Reflection;
using System.Data.OleDb;

namespace PhanMemQuanLyThuVien
{
    public partial class USPhieuMuon : DevExpress.XtraEditors.XtraUserControl
    {
        public string username = "";
        public DateTime today;
        public DateTime endDate;
        public int maphieumuon;
        BUSPhieuMuon BUSPhieuMuon = new BUSPhieuMuon();


        public USPhieuMuon()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void USPhieuMuon_Load_1(object sender, EventArgs e)
        {
            //var query = BUSPhieuMuon.GetPhieuMuon();
            //DataTable dt = LINQResultToDataTable(query);

            //DataTable a = new DataTable();
            //a = DataTable (BUSPhieuMuon.GetPhieuMuon());

            //DataSet dataSet11 = new DataSet();
            //OleDbDataAdapter AdapterCategories = new OleDbDataAdapter(BUSPhieuMuon.GetPhieuMuon());

            this.pHIEUMUONTableAdapter.Fill(quanLiThuVienDataSet1.PHIEUMUON);
            chitietphieumuonTableAdapter1.Fill(quanLiThuVienDataSet1.CHITIETPHIEUMUON);

            username = frmMain.TaiKhoan;
            HienThiNhanVienLogin(username);
            HienThiDocGiaCbo();
            HienThiSachCbo();

            cboNgayMuon.Enabled = false;
            cboNgayTra.Enabled = false;
            today = DateTime.Today;
            cboNgayMuon.Text = today.ToString("dd/MM/yyyy");
            endDate = today.AddDays(30);
            cboNgayTra.Text = endDate.ToString("dd/MM/yyyy");

            maphieumuon = BUSPhieuMuon.LayMaPhieuMuon();
            maphieumuon++;

        }
         

        public void HienThiNhanVienLogin(string username)
        {
            BUSDangNhap bUSDangNhap = new BUSDangNhap();
            cboNVLogin.DataSource = bUSDangNhap.LayNVLogin(username);
            cboNVLogin.ValueMember = "manv";
            cboNVLogin.DisplayMember = "tennhanvien";
            cboNVLogin.Enabled = false;
        }

        public void HienThiDocGiaCbo()
        {
            BUSDocGia BUSDocGia = new BUSDocGia();
            lookUpDocGia.Properties.DataSource = BUSDocGia.LayToanBoDocGia();
        }

        public void HienThiSachCbo()
        {
            BUSSach BUSSach = new BUSSach();
            lookUpTenSach.Properties.DataSource = BUSSach.LayToanBoSach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDocGia = new frmThemDocGia();
            frmThemDocGia.ShowDialog();


            //XtraMessageBox.Show(maphieumuon.ToString(), "Thông Báo");
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            //kiểm tra=======================================================
            if (lookUpTenSach.EditValue == null || lookUpDocGia.EditValue == null || cboNgayMuon.Text == null || cboNgayTra.Text==null)
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

                string date1 = cboNgayMuon.Text;
                DateTime ngaymuon = Convert.ToDateTime(date1);

                string date2 = cboNgayTra.Text;
                DateTime ngaytra = Convert.ToDateTime(date2);

                int manv = int.Parse(cboNVLogin.SelectedValue.ToString());


                //thêm phiếu mượn=======================================================
                bool lapphieumuon = BUSPhieuMuon.ThemPhieuMuong(maphieumuon,
                    manv, int.Parse(docgia.ToString()), int.Parse(masach.ToString()), ngaymuon, ngaytra);

                if (lapphieumuon == true)
                {
                    XtraMessageBox.Show("Lập phiếu mượn thành công", "Thông Báo");
                    this.pHIEUMUONTableAdapter.Fill(quanLiThuVienDataSet1.PHIEUMUON);
                    chitietphieumuonTableAdapter1.Fill(quanLiThuVienDataSet1.CHITIETPHIEUMUON);
                }
                else
                {
                    XtraMessageBox.Show("Lập phiếu mượn thất bại", "Thông Báo");
                }
            }
            
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            cboNgayMuon.Enabled = false;
            cboNgayTra.Enabled = false;

            lookUpDocGia.EditValue = null;
            lookUpTenSach.EditValue = null;

            today = DateTime.Today;
            cboNgayMuon.Text = today.ToString("dd/MM/yyyy");
            endDate = today.AddDays(30);
            cboNgayTra.Text = endDate.ToString("dd/MM/yyyy");

            maphieumuon = BUSPhieuMuon.LayMaPhieuMuon();
            maphieumuon++;
        }

         
    }
}
