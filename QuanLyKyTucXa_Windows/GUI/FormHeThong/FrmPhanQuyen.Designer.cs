namespace GUI.FormHeThong
{
    partial class FrmPhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboNhomND = new System.Windows.Forms.ComboBox();
            this.trv = new System.Windows.Forms.TreeView();
            this.usctrLuuHuy = new GUI.usctrLuuHuy();
            this.chkToanQuyen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm Người Dùng  : ";
            // 
            // cboNhomND
            // 
            this.cboNhomND.FormattingEnabled = true;
            this.cboNhomND.Location = new System.Drawing.Point(115, 12);
            this.cboNhomND.Name = "cboNhomND";
            this.cboNhomND.Size = new System.Drawing.Size(121, 21);
            this.cboNhomND.TabIndex = 1;
            this.cboNhomND.Text = "Quản lý";
            // 
            // trv
            // 
            this.trv.CheckBoxes = true;
            this.trv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trv.Location = new System.Drawing.Point(6, 51);
            this.trv.Name = "trv";
            this.trv.Size = new System.Drawing.Size(375, 360);
            this.trv.TabIndex = 2;
            // 
            // usctrLuuHuy
            // 
            this.usctrLuuHuy.BackColor = System.Drawing.Color.Transparent;
            this.usctrLuuHuy.Location = new System.Drawing.Point(102, 417);
            this.usctrLuuHuy.Name = "usctrLuuHuy";
            this.usctrLuuHuy.Size = new System.Drawing.Size(190, 32);
            this.usctrLuuHuy.TabIndex = 3;
            // 
            // chkToanQuyen
            // 
            this.chkToanQuyen.AutoSize = true;
            this.chkToanQuyen.Location = new System.Drawing.Point(271, 16);
            this.chkToanQuyen.Name = "chkToanQuyen";
            this.chkToanQuyen.Size = new System.Drawing.Size(83, 17);
            this.chkToanQuyen.TabIndex = 4;
            this.chkToanQuyen.Text = "Toàn quyền";
            this.chkToanQuyen.UseVisualStyleBackColor = true;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 461);
            this.Controls.Add(this.chkToanQuyen);
            this.Controls.Add(this.usctrLuuHuy);
            this.Controls.Add(this.trv);
            this.Controls.Add(this.cboNhomND);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPhanQuyen";
            this.Text = "Phân Quyền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhomND;
        private System.Windows.Forms.TreeView trv;
        private usctrLuuHuy usctrLuuHuy;
        private System.Windows.Forms.CheckBox chkToanQuyen;
    }
}