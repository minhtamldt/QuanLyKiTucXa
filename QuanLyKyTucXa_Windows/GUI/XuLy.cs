using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  public  class XuLy
    {


      public string AutoID5(string strMA, string strMaTop)
      {

          if (strMaTop == null)
          {
              return strMA + "001";
          }
          else
          {
              string[] str0 = { "0", "00" };
              int intTam = int.Parse(strMaTop.Substring(2));
              return TinhToanID(strMA, str0, intTam);
          }
      }

      public string AutoID13(string strMA, string strMaTop)
      {
          DateTime t = DateTime.Now;

          string strDate = strMA + t.ToString("dd/MM/yyyy").Replace("/", "");
          t = new DateTime(t.Year, t.Month, t.Day, 0, 0, 0);
          if (strMaTop == null)
              return strDate + "001";
          else
          {
              string strTam = strMaTop;  //lấy mã đầu tiên trong bảng sau khi sx
              strTam = strTam.Substring(2, 8);   //lấy ngày trong chuỗi ra

              //lay tung thoi gian
              int ngay = int.Parse(strTam.Substring(0, 2));
              int thang = int.Parse(strTam.Substring(2, 2));
              int nam = int.Parse(strTam.Substring(strTam.Length - 4));
              DateTime date = new DateTime(nam, thang, ngay);
              TimeSpan ts = t - date;
              string[] str0 = { "0", "00" };

              //nếu nó bằng time hiện tại
              if (ts.Days == 0)
              {
                  strTam = strMaTop.Trim();
                  strTam = strTam.Substring(strTam.Length - 3);
                  int intTam = int.Parse(strTam);
                  return TinhToanID(strDate, str0, intTam);

              }
              //nếu nó bằng time hiện tại
              else if (ts.Days > 0)
              {
                  strTam = strMaTop;
                  strTam = strTam.Substring(strTam.Length - 3);
                  int intTam = int.Parse(strTam);

                  return TinhToanID(strDate, str0, intTam);
              }
              else
              {
                  return strDate + "001";
              }

          }

      }

      private string TinhToanID(string strHead, string[] str0, int intTam)
      {
          String strID = null;
          if (intTam > 0 && intTam < 9)
              strID = strHead + str0[1] + (intTam + 1);
          else if (intTam >= 9 && intTam < 99)
              strID = strHead + str0[0] + (intTam + 1);
          else
              strID = strHead + (intTam + 1);
          return strID;
      }


      //Các MessageBox Thông Dụng
      public DialogResult MessageBoxCanhBao(string message)
      {
          return MessageBox.Show(message, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      }
      public void MessageBoxThongBaoEror(string message)
      {
          MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      public DialogResult MessageBoxThongBao(string message)
      {
          return MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      public DialogResult MessageBoxThongBaoXacNhan(string message)
      {
          return MessageBox.Show(message, "Xác Nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
      }


    }
}
