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

namespace PhanMemQuanLyThuVien
{
    public partial class USTienPhat : DevExpress.XtraEditors.XtraUserControl
    {
        public USTienPhat()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; 
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            this.hoaDonTableAdapter.Fill(quanLiThuVienDataSet1.HoaDon);
        }
    }
}
