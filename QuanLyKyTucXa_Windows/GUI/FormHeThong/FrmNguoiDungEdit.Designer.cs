namespace GUI.FromHeThong
{
    partial class FrmNguoiDungEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaND = new System.Windows.Forms.TextBox();
            this.txtTenND = new System.Windows.Forms.TextBox();
            this.usctrLuuHuy = new GUI.usctrLuuHuy();
            this.chkKichHoat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Người Dùng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Người Dùng :";
            // 
            // txtMaND
            // 
            this.txtMaND.Location = new System.Drawing.Point(118, 32);
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.ReadOnly = true;
            this.txtMaND.Size = new System.Drawing.Size(138, 21);
            this.txtMaND.TabIndex = 1;
            // 
            // txtTenND
            // 
            this.txtTenND.Location = new System.Drawing.Point(118, 61);
            this.txtTenND.Name = "txtTenND";
            this.txtTenND.Size = new System.Drawing.Size(138, 21);
            this.txtTenND.TabIndex = 1;
            // 
            // usctrLuuHuy
            // 
            this.usctrLuuHuy.BackColor = System.Drawing.Color.Transparent;
            this.usctrLuuHuy.Location = new System.Drawing.Point(118, 129);
            this.usctrLuuHuy.Name = "usctrLuuHuy";
            this.usctrLuuHuy.Size = new System.Drawing.Size(138, 32);
            this.usctrLuuHuy.TabIndex = 2;
            // 
            // chkKichHoat
            // 
            this.chkKichHoat.AutoSize = true;
            this.chkKichHoat.Location = new System.Drawing.Point(118, 98);
            this.chkKichHoat.Name = "chkKichHoat";
            this.chkKichHoat.Size = new System.Drawing.Size(71, 17);
            this.chkKichHoat.TabIndex = 3;
            this.chkKichHoat.Text = "Kích Hoạt";
            this.chkKichHoat.UseVisualStyleBackColor = true;
            // 
            // FrmNguoiDungEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 173);
            this.Controls.Add(this.chkKichHoat);
            this.Controls.Add(this.usctrLuuHuy);
            this.Controls.Add(this.txtTenND);
            this.Controls.Add(this.txtMaND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNguoiDungEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Người Dùng ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaND;
        private System.Windows.Forms.TextBox txtTenND;
        private usctrLuuHuy usctrLuuHuy;
        private System.Windows.Forms.CheckBox chkKichHoat;
        
    }
}