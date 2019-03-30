using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace Common
{
    public partial class UserCRUD : UserControl
    {
        private bool[] _arrPosition = { true, true, true, true };
        public event EventHandler OnClickInsert,OnClickDelete,OnClickEdit,OnClickCancel;
        #region  Property visable
        public bool VisiableInsert
        {
            get { return btnInsert.Visible; }
            set
            {
                btnInsert.Visible = value;
                _arrPosition[0] = value;
                ChangePercentButton();
            }
        }
        public bool VisiableDelete
        {
            get { return btnDelete.Visible; }
            set
            {
                btnDelete.Visible = value;
                _arrPosition[2] = value;
                ChangePercentButton();
            }
        }
        public bool VisiableEdit
        {
            get { return btnEdit.Visible; }
            set
            {
                btnEdit.Visible = value;
                _arrPosition[1] = value;
                ChangePercentButton();
            }
        }
        public bool VisiableCancel
        {
            get { return btnCancel.Visible; }
            set
            {
                btnCancel.Visible = value;
                _arrPosition[3] = value;
                ChangePercentButton();
            }
        }


#endregion

        #region Property Image
        public Image ImageInsert
        {
            get { return btnInsert.Image; }
            set { btnInsert.Image = value; }
        }
        public Image ImageDelete
        {
            get { return btnDelete.Image; }
            set { btnDelete.Image = value; }
        }
        public Image ImageEdit
        {
            get { return btnEdit.Image; }
            set { btnEdit.Image = value; }
        }
        public Image ImageCancel
        {
            get { return btnCancel.Image; }
            set { btnCancel.Image = value; }
        }
#endregion

        public UserCRUD()
        {
            InitializeComponent();

            btnDelete.Visible = true;
            btnInsert.Visible = true;
            btnEdit.Visible = true;
            btnCancel.Visible = true;
            //
            btnEdit.Click -= OnButtonClick;
            btnDelete.Click -= OnButtonClick;
            btnCancel.Click -= OnButtonClick;
            btnInsert.Click -= OnButtonClick;
            //
            btnEdit.Click += OnButtonClick;
            btnDelete.Click += OnButtonClick;
            btnCancel.Click += OnButtonClick;
            btnInsert.Click += OnButtonClick;
        }

        private void ChangePercentButton()
        {
           //count control visable
            int countTrue=0;
            for (int i = 0; i < _arrPosition.Length; i++)
                if (_arrPosition[i])
                      countTrue++;

            var precent = 100 / countTrue;
            //set prcent
            for (int i = 0; i < _arrPosition.Length; i++)
                if (_arrPosition[i])
                    tableLayout.ColumnStyles[i] = (new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, precent));
                else
                    tableLayout.ColumnStyles[i] = (new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0));

        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            try
            {
                var button = sender as SimpleButton;
                switch (button.Name)
                {
                    case "btnEdit": OnClickEdit(sender, e); break;
                    case "btnDelete": OnClickDelete(sender, e); break;
                    case "btnCancel": OnClickCancel(sender, e); break;
                    case "btnInsert": OnClickInsert(sender, e); break;
                }
            }
            catch { }
            
            
        }
    }
}
