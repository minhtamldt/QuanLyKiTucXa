﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace GUI.FromHeThong
{
    public partial class FrmNguoiDungEdit : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmNguoiDungEdit()
        {
            InitializeComponent();
            
        }
        public FrmNguoiDungEdit(string MaND,string TENND,int TRANGTHAIND)
        {
            InitializeComponent();

        }

    }
}