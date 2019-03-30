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
    public partial class usctrTXS : UserControl
    {
        public delegate void Them();
        public delegate void Xoa();
        public delegate void Sua();
        public event Them them;
        public event Xoa xoa;
        public event Sua sua;
        public usctrTXS()
        {
            InitializeComponent();
            SuKien();
        }

        private void SuKien()
        {
            btnSua.Click += btnSua_Click;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            them();
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            sua();
        }
    }
}
