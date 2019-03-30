using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usctrLuuHuy : UserControl
    {

        public delegate void Luu();
        public delegate void Huy();
        public event Luu luu;
        public event Huy huy;
        public usctrLuuHuy()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {
            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            huy();
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }
    }
}
