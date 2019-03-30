using GUI.FromHeThong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {

        public static FrmMain frmMain;
        //public static FrmDoiMatkhau frmDoiMK;
        public static GUI.FromHeThong.FrmDangNhap frmDangNhap;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new GUI.FromHeThong.FrmDangNhap();
            Application.Run( frmDangNhap);  
        }
    }
}
