using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using DevExpress.XtraEditors;
using DAL;
using DevExpress.XtraSplashScreen;

namespace GUI.FromHeThong
{
    public partial class FrmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmCauHinh()
        {
            InitializeComponent();
            
            Events();
            try
            {
                SplashScreenManager.CloseDefaultWaitForm();
            }
            catch (Exception)
            {
               
               }
        }

        public void Events(){
            btnThoat.Click += OnBtnThoatClick;cboTenServer.DropDown += OnDropDownCboServer;
            btnLuu.Click += OnClickBtnLuu;
            cboCSDL.DropDown += OnDropDownCboDatabase;
        }

        private void OnClickBtnLuu(object sender, EventArgs e)
        {
            try
            {
                var connectString = "Data Source=" + cboTenServer.Text.Trim() + ";" +
                               "Initial Catalog=" + cboCSDL.Text + ";" +
                               "User ID=" + txtTenDN.Text + ";" +
                               "Password=" + txtMK.Text;
                DAL.Properties.Settings.Default.StringConnect = connectString;
                DAL.Properties.Settings.Default.Save();
                Messages.MessageBoxThongBao("Cấu hình thành công!");
            }
            catch (Exception ex)
            {

                Messages.MessageBoxThongBao("Cấu hình thất bại! \nChi tiết :"+ex.Message);
            }
           
        }

        private void OnDropDownCboDatabase(object sender, EventArgs e)
        {
            
           if(string.IsNullOrWhiteSpace(txtMK.Text)||string.IsNullOrWhiteSpace(txtTenDN.Text))
               return;
           var cauHinh = new CauHinhDAL();
           var cbo = sender as System.Windows.Forms.ComboBox;
           cbo.DataSource = cauHinh.GetDatabaseName(cboTenServer.Text, txtTenDN.Text, txtMK.Text);
           cbo.DisplayMember = "name";
        }
        private void OnDropDownCboServer(object sender, EventArgs e)
        {

            SplashScreenManager.ShowDefaultWaitForm("Vui lòng đợi", "Đang tải máy chủ"); 
            var cbo = sender as System.Windows.Forms.ComboBox;
            cbo.Items.Clear();
            var tableServerName = SqlDataSourceEnumerator.Instance.GetDataSources();foreach (DataRow item in tableServerName.Rows)
            {
                var instaceName = item["InstanceName"].ToString();
                var serverName = item["ServerName"].ToString();
                serverName =string.IsNullOrWhiteSpace(instaceName) ? serverName : serverName + "\\" + instaceName;
                cbo.Items.Add(serverName);}
            SplashScreenManager.CloseDefaultWaitForm();

        }
        private void OnBtnThoatClick(object sender, EventArgs e)
        {
            var result = Messages.MessageBoxTXacNhan("Bạn muốn thoát ?");
            if (result == DialogResult.Yes)
            {
                Close();
                Dispose();
            }                 
        }

      

    }
}