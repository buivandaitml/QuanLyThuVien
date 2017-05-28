namespace GUI.UC
{
    partial class UCNhap
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
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                ctrl.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnNCC = new GUI.ComponentForm.Flat_Button();
            this.btnPhieuNhap = new GUI.ComponentForm.Flat_Button();
            this.pnlUseNhap = new System.Windows.Forms.Panel();
            this.btnSCN = new GUI.ComponentForm.Flat_Button();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.btnSCN);
            this.pnlToolbar.Controls.Add(this.btnNCC);
            this.pnlToolbar.Controls.Add(this.btnPhieuNhap);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(822, 35);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnNCC
            // 
            this.btnNCC.Active = false;
            this.btnNCC.BackColor = System.Drawing.Color.Transparent;
            this.btnNCC.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnNCC.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnNCC.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnNCC.IconAlignment = 3;
            this.btnNCC.IconClick = null;
            this.btnNCC.IconHover = null;
            this.btnNCC.IconNormal = null;
            this.btnNCC.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnNCC.IconSize = new System.Drawing.Size(0, 0);
            this.btnNCC.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNCC.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNCC.LineColorNormal = System.Drawing.Color.Green;
            this.btnNCC.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnNCC.LineSize = 3;
            this.btnNCC.Location = new System.Drawing.Point(80, 0);
            this.btnNCC.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(80, 35);
            this.btnNCC.TabIndex = 1;
            this.btnNCC.TabStop = false;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnNCC.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnNCC.TextColorClick = System.Drawing.Color.Empty;
            this.btnNCC.TextColorHover = System.Drawing.Color.Empty;
            this.btnNCC.TextColorNormal = System.Drawing.Color.Black;
            this.btnNCC.UseActive = true;
            this.btnNCC.UseBackgroundHoverClick = false;
            this.btnNCC.UseIconHoverClick = false;
            this.btnNCC.UseLineHoverClick = true;
            this.btnNCC.UseTextHoverClick = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Active = false;
            this.btnPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnPhieuNhap.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnPhieuNhap.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnPhieuNhap.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnPhieuNhap.IconAlignment = 3;
            this.btnPhieuNhap.IconClick = null;
            this.btnPhieuNhap.IconHover = null;
            this.btnPhieuNhap.IconNormal = null;
            this.btnPhieuNhap.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnPhieuNhap.IconSize = new System.Drawing.Size(0, 0);
            this.btnPhieuNhap.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPhieuNhap.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPhieuNhap.LineColorNormal = System.Drawing.Color.Green;
            this.btnPhieuNhap.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnPhieuNhap.LineSize = 3;
            this.btnPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.btnPhieuNhap.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(80, 35);
            this.btnPhieuNhap.TabIndex = 0;
            this.btnPhieuNhap.TabStop = false;
            this.btnPhieuNhap.Text = "Phiếu nhập";
            this.btnPhieuNhap.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnPhieuNhap.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnPhieuNhap.TextColorClick = System.Drawing.Color.Empty;
            this.btnPhieuNhap.TextColorHover = System.Drawing.Color.Empty;
            this.btnPhieuNhap.TextColorNormal = System.Drawing.Color.Black;
            this.btnPhieuNhap.UseActive = true;
            this.btnPhieuNhap.UseBackgroundHoverClick = false;
            this.btnPhieuNhap.UseIconHoverClick = false;
            this.btnPhieuNhap.UseLineHoverClick = true;
            this.btnPhieuNhap.UseTextHoverClick = false;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // pnlUseNhap
            // 
            this.pnlUseNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUseNhap.Location = new System.Drawing.Point(0, 35);
            this.pnlUseNhap.Name = "pnlUseNhap";
            this.pnlUseNhap.Size = new System.Drawing.Size(822, 443);
            this.pnlUseNhap.TabIndex = 1;
            // 
            // btnSCN
            // 
            this.btnSCN.Active = false;
            this.btnSCN.BackColor = System.Drawing.Color.Transparent;
            this.btnSCN.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnSCN.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnSCN.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnSCN.IconAlignment = 3;
            this.btnSCN.IconClick = null;
            this.btnSCN.IconHover = null;
            this.btnSCN.IconNormal = null;
            this.btnSCN.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnSCN.IconSize = new System.Drawing.Size(0, 0);
            this.btnSCN.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSCN.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSCN.LineColorNormal = System.Drawing.Color.Green;
            this.btnSCN.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnSCN.LineSize = 3;
            this.btnSCN.Location = new System.Drawing.Point(160, 0);
            this.btnSCN.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnSCN.Name = "btnSCN";
            this.btnSCN.Size = new System.Drawing.Size(80, 35);
            this.btnSCN.TabIndex = 2;
            this.btnSCN.TabStop = false;
            this.btnSCN.Text = "Sách cần nhập";
            this.btnSCN.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSCN.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSCN.TextColorClick = System.Drawing.Color.Empty;
            this.btnSCN.TextColorHover = System.Drawing.Color.Empty;
            this.btnSCN.TextColorNormal = System.Drawing.Color.Black;
            this.btnSCN.UseActive = true;
            this.btnSCN.UseBackgroundHoverClick = false;
            this.btnSCN.UseIconHoverClick = false;
            this.btnSCN.UseLineHoverClick = true;
            this.btnSCN.UseTextHoverClick = false;
            this.btnSCN.Click += new System.EventHandler(this.btnSCN_Click);
            // 
            // UCNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUseNhap);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "UCNhap";
            this.Size = new System.Drawing.Size(822, 478);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private ComponentForm.Flat_Button btnPhieuNhap;
        private ComponentForm.Flat_Button btnNCC;
        private System.Windows.Forms.Panel pnlUseNhap;
        private ComponentForm.Flat_Button btnSCN;
    }
}
