using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CauHinhDAL
    {

        public string StringConnect = DAL.Properties.Settings.Default.StringConnect;
        SqlConnection conn;
        public int CheckConfig()
        {
            if (String.IsNullOrWhiteSpace((StringConnect)))  //nếu không có chuỗi kết nối nào được lưu
                   return -1;
            using (conn = new SqlConnection(StringConnect))
            {
                try
                {
                    if(conn.State==ConnectionState.Closed)
                          conn.Open(); //thử mở kết nối, nếu kết nối được thì success
                    return 1;
                }
                catch 
                {
                    return -1;   //mở kết nối thất bại
                }
            }
        }

        public int CheckUser(string userName, string password)
        {
            try
            {
                var query = "SELECT * FROM NGUOIDUNG WHERE TENDANGNHAP = '" + userName + "'";
                var da = new SqlDataAdapter(query,StringConnect);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)  //nếu có tài khoản
                {
                    var statePass = dt.Rows[0]["MATKHAU"].ToString();
                    if (!statePass.Equals(password))
                        return -1;  //sai mật khẩu

                    var state = bool.Parse(dt.Rows[0]["TRANGTHAIND"].ToString());  //
                    if (!state)
                        return -2; // Tai khoan bị khóa
                }
                else return -3; // User không ton tai
            }
            catch
            {
                return -4; // Dang nhap that bai
            }

            return 1;
        }
        //lưu tài khoản xuồng Appconfig
        public void SaveAccount(string user, string pass)
        {
            DAL.Properties.Settings.Default.StringUser = user;
            DAL.Properties.Settings.Default.StringPass = pass;
            DAL.Properties.Settings.Default.Save();
        }

        public void SaveStateCheckLuu(bool state )
        {
            DAL.Properties.Settings.Default.CheckLuu = state;
            DAL.Properties.Settings.Default.Save();
            
        }
        public bool GetStateCheckBoxSave()
        {
            return DAL.Properties.Settings.Default.CheckLuu;
        }
        public string GetPasswordAppConfig()
        {
            return DAL.Properties.Settings.Default.StringPass;
        }
        public string GetUserNameAppconfig()
        {
            return DAL.Properties.Settings.Default.StringUser;
        }

        public List<string> GetDatabaseName(string serverName, string user, string pass)
        {
            var lst = new List<string>();  //khởi tạo list chứa các database
            var dt = new DataTable();
            try
            {
                var query = "SELECT NAME FROM  SYS.DATABASES";
                var connectString = "SERVER=" + serverName + ";DATABASE=MASTER;USER ID=" + user + ";PWD=" + pass + "";
                SqlDataAdapter da = new SqlDataAdapter(query, connectString);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                    lst.Add(row["name"].ToString());return lst;
            }
            catch
            {
                return null;
            }

        }

    }
}
