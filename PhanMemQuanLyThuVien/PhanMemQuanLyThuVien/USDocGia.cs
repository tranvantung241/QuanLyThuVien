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

namespace PhanMemQuanLyThuVien
{
    public partial class USDocGia : UserControl
    {
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
            frmThemDocGia.ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            HienThiDocGia();
        }
    }
}
