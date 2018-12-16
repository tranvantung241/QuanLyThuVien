using System;
using System.Linq;

namespace PhanMemQuanLyThuVien
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.Properties.PasswordChar = '\u25CF';
        }

        private void chkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = chkHienPass.Checked ? '\0' : '\u25CF';
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frmRegister register = null;
            if (register == null || register.IsDisposed)
            {
                register = new frmRegister();
            }

            register.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoginOK;
        }
    }
}