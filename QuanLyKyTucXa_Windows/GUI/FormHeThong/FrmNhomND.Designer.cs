namespace GUI.FromHeThong
{
    partial class FrmNhomND
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

            private void InitializeComponent()
        {
            this.trv = new System.Windows.Forms.TreeView();
            this.usctrTXS = new GUI.usctrTXS();
            this.SuspendLayout();
            // 
            // trv
            // 
            this.trv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.trv.Location = new System.Drawing.Point(0, 42);
            this.trv.Name = "trv";
            this.trv.Size = new System.Drawing.Size(298, 304);
            this.trv.TabIndex = 0;
            // 
            // usctrTXS
            // 
            this.usctrTXS.BackColor = System.Drawing.Color.Transparent;
            this.usctrTXS.Dock = System.Windows.Forms.DockStyle.Top;
            this.usctrTXS.Location = new System.Drawing.Point(0, 0);
            this.usctrTXS.Name = "usctrTXS";
            this.usctrTXS.Size = new System.Drawing.Size(298, 36);
            this.usctrTXS.TabIndex = 1;
            // 
            // FrmNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 346);
            this.Controls.Add(this.usctrTXS);
            this.Controls.Add(this.trv);
            this.Name = "FrmNhomND";
            this.Text = "Người Dùng";
            this.ResumeLayout(false);

        }

      

        private System.Windows.Forms.TreeView trv;
        private usctrTXS usctrTXS;

    }
}