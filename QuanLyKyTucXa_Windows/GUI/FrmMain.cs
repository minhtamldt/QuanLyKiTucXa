using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DAL;

namespace GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string ten = string.Empty;
        public FrmMain(string PMa)
        {
            InitializeComponent();
            ten = PMa;


        }
    
     
        //kiểm tra form có đang tồn tại
        public int KiemTraFrom_TonTai(string frmName)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == frmName)
                {
                    child.Activate();
                    return 1;
                }
            }
            return -1;
        }


        //show form
        private void ShowFrom(Form form)
        {
            Type typef = form.GetType();
            object f = Activator.CreateInstance(typef);
            Form frm = (Form)f;
            if (KiemTraFrom_TonTai(frm.Name) > 0) return;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblTENND.Caption = ten;
        }
    }
}