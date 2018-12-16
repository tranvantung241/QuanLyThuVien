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
using DevExpress.XtraReports.UI;

namespace PhanMemQuanLyThuVien
{
    public partial class USBaoCao : DevExpress.XtraEditors.XtraUserControl
    {
        public USBaoCao()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptMuonSachThang2 report = new rptMuonSachThang2();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}
