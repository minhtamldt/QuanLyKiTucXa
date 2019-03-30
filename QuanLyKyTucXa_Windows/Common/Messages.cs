using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class Messages
    {
        public static DialogResult MessageBoxCanhBao(string message)
        {
            return MessageBox.Show(message, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static void MessageBoxEror(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MessageBoxThongBao(string message)
        {
            return MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult MessageBoxTXacNhan(string message)
        {
            return MessageBox.Show(message, "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
