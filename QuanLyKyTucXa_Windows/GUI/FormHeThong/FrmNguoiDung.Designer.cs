namespace GUI.FromHeThong
{
    partial class FrmNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvND = new DevExpress.XtraGrid.GridControl();
            this.gvND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userCRUD1 = new Common.UserCRUD();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvND)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvND
            // 
            this.dgvND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvND.Location = new System.Drawing.Point(3, 45);
            this.dgvND.MainView = this.gvND;
            this.dgvND.Name = "dgvND";
            this.dgvND.Size = new System.Drawing.Size(1178, 413);
            this.dgvND.TabIndex = 0;
            this.dgvND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvND});
            // 
            // gvND
            // 
            this.gvND.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvND.GridControl = this.dgvND;
            this.gvND.Name = "gvND";
            this.gvND.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Người Dùng";
            this.gridColumn1.FieldName = "MAND";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Người Dùng";
            this.gridColumn2.FieldName = "TENND";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trạng Thái";
            this.gridColumn3.FieldName = "TRANGTHAIND";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvND, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userCRUD1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.174312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.82569F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 461);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // userCRUD1
            // 
            this.userCRUD1.Location = new System.Drawing.Point(3, 3);
            this.userCRUD1.Name = "userCRUD1";
            this.userCRUD1.Size = new System.Drawing.Size(324, 30);
            this.userCRUD1.TabIndex = 1;
            this.userCRUD1.VisiableCancel = true;
            this.userCRUD1.VisiableDelete = true;
            this.userCRUD1.VisiableEdit = true;
            this.userCRUD1.VisiableInsert = true;
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmNguoiDung";
            this.Text = "Người Dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvND)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvND;
        private DevExpress.XtraGrid.Views.Grid.GridView gvND;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private Common.UserCRUD userCRUD1;
      
    }
}