namespace GUI.FromHeThong
{
    partial class FrmNhomNDEdit
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
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.usctrLuuHuy = new GUI.usctrLuuHuy();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhóm : ";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(106, 37);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(100, 21);
            this.txtTenNhom.TabIndex = 1;
            // 
            // usctrLuuHuy
            // 
            this.usctrLuuHuy.BackColor = System.Drawing.Color.Transparent;
            this.usctrLuuHuy.Location = new System.Drawing.Point(41, 89);
            this.usctrLuuHuy.Name = "usctrLuuHuy";
            this.usctrLuuHuy.Size = new System.Drawing.Size(190, 32);
            this.usctrLuuHuy.TabIndex = 2;
            // 
            // FrmNhomNDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.usctrLuuHuy);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhomNDEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhóm Người Dùng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhom;
        private usctrLuuHuy usctrLuuHuy;
    }
}