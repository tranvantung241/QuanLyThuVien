using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Drawing;

namespace PhanMemQuanLyThuVien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new Font("Courier New", 11);
            BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}
