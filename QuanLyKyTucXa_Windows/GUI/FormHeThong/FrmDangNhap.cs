using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DevExpress.XtraEditors;
using DAL;
using DevExpress.XtraExport.Xls;
using DevExpress.XtraSplashScreen;

namespace GUI.FromHeThong
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private CauHinhDAL _cauHinh;
        public FrmDangNhap()
        {
            InitializeComponent();
            _cauHinh=new CauHinhDAL();
            Events();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (_cauHinh.GetStateCheckBoxSave())
            {
                txtTenTK.Text = _cauHinh.GetUserNameAppconfig();
                txtMK.Text = _cauHinh.GetPasswordAppConfig();
                chkLuuMK.Checked = true;
            }
            else
            {
                txtTenTK.Text = string.Empty;
                txtMK.Text = string.Empty;
                chkLuuMK.Checked = false;
            }

        }
        private void Events()
        {
            this.btnThoat.Click += btnThoat_Click;
            this.btnDN.Click += btnDN_Click;
            chkLuuMK.CheckedChanged += OnCheckedChanged;
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            _cauHinh.SaveStateCheckLuu(chkLuuMK.Checked);
        }


        #region button Click
        private void PerformLogin()
        {
            if (string.IsNullOrWhiteSpace(txtTenTK.Text) && string.IsNullOrWhiteSpace(txtMK.Text))
            {
                Messages.MessageBoxEror("Bạn chưa nhập tên đăng nhập và mật khẩu.");
                return;
            }

            var stateConfig = _cauHinh.CheckConfig();
            var stateUser = _cauHinh.CheckUser(txtTenTK.Text, txtMK.Text);


            switch (stateConfig)
            {
                case -1:
                {
                    FrmCauHinh frmCauHinh = new FrmCauHinh();
                    this.Hide();
                    frmCauHinh.ShowDialog();
                    this.Show();
                    
                    
                }break;
                case 1:
                {
                    switch (stateUser)
                    {
                        case 1:
                        {
                            if (chkLuuMK.Checked)
                                _cauHinh.SaveAccount(txtTenTK.Text, txtMK.Text);
                            if (Program.frmMain == null || Program.frmMain.IsDisposed)
                            {
                                Properties.Settings.Default.strMANV = txtTenTK.Text;
                                DAL.Properties.Settings.Default.CheckLuu = chkLuuMK.Checked;
                                Properties.Settings.Default.Save();
                            }
                            Program.frmMain = new FrmMain(txtTenTK.Text);
                            Program.frmDangNhap.Hide();
                            Program.frmMain.ShowDialog();
                            Program.frmDangNhap.Show();
                        }
                            break;
                        case -1:
                            Messages.MessageBoxEror("Mật khẩu không đúng !");
                            break;
                        case -2:
                            Messages.MessageBoxEror("Tài khoản này đã bị khóa !");
                            break;
                        case -3:
                            Messages.MessageBoxEror("Tài khoản này không tồn tại !");
                            break;
                        case -4:
                            Messages.MessageBoxEror("Lỗi kết nối!");break;

                    }
                }break;
            }

        }
        void btnDN_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Vui lòng đợi","Đang xử lý.....");
            PerformLogin();
            SplashScreenManager.CloseDefaultWaitForm();
        }
        void btnThoat_Click(object sender, EventArgs e)
        {
            var result = Messages.MessageBoxTXacNhan("Bạn có chắc muốn thoát không ?");
            if(result == DialogResult.Yes)
                Application.Exit();
        }
        #endregion





    }
}