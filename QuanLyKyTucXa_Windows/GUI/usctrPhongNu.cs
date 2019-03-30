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
    public partial  class usctrPhongNu : UserControl
    {

        string maPhong;

        public string MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        int slHienTai;

        public int SlHienTai
        {
            get { return slHienTai; }
            set { slHienTai = value; }
        }
        int sucChua;

        public int SucChua
        {
            get { return sucChua; }
            set { sucChua = value; }
        }

        public usctrPhongNu(string maPhong, int slhientai, int succhua)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            this.slHienTai = slhientai;
            this.sucChua = succhua;
            lblPhong.Text = maPhong;
            lblSL.Text = slHienTai + "/" + sucChua;
            
        }
        public usctrPhongNu()
        {
            InitializeComponent();
        }
    }
}
