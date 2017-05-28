namespace GUI.UC
{
    partial class UCSach
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
            this.btnNXB = new GUI.ComponentForm.Flat_Button();
            this.btnTheLoai = new GUI.ComponentForm.Flat_Button();
            this.btnTacGia = new GUI.ComponentForm.Flat_Button();
            this.btnTuaSach = new GUI.ComponentForm.Flat_Button();
            this.pnlUseSach = new System.Windows.Forms.Panel();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.btnNXB);
            this.pnlToolbar.Controls.Add(this.btnTheLoai);
            this.pnlToolbar.Controls.Add(this.btnTacGia);
            this.pnlToolbar.Controls.Add(this.btnTuaSach);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(822, 35);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnNXB
            // 
            this.btnNXB.Active = false;
            this.btnNXB.BackColor = System.Drawing.Color.Transparent;
            this.btnNXB.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnNXB.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnNXB.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnNXB.IconAlignment = 3;
            this.btnNXB.IconClick = null;
            this.btnNXB.IconHover = null;
            this.btnNXB.IconNormal = null;
            this.btnNXB.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnNXB.IconSize = new System.Drawing.Size(0, 0);
            this.btnNXB.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNXB.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNXB.LineColorNormal = System.Drawing.Color.Green;
            this.btnNXB.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnNXB.LineSize = 3;
            this.btnNXB.Location = new System.Drawing.Point(240, 0);
            this.btnNXB.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Size = new System.Drawing.Size(80, 35);
            this.btnNXB.TabIndex = 3;
            this.btnNXB.TabStop = false;
            this.btnNXB.Text = "Nhà xuất bản";
            this.btnNXB.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnNXB.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnNXB.TextColorClick = System.Drawing.Color.Empty;
            this.btnNXB.TextColorHover = System.Drawing.Color.Empty;
            this.btnNXB.TextColorNormal = System.Drawing.Color.Black;
            this.btnNXB.UseActive = true;
            this.btnNXB.UseBackgroundHoverClick = false;
            this.btnNXB.UseIconHoverClick = false;
            this.btnNXB.UseLineHoverClick = true;
            this.btnNXB.UseTextHoverClick = false;
            this.btnNXB.Click += new System.EventHandler(this.btnNXB_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Active = false;
            this.btnTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.btnTheLoai.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnTheLoai.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnTheLoai.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnTheLoai.IconAlignment = 3;
            this.btnTheLoai.IconClick = null;
            this.btnTheLoai.IconHover = null;
            this.btnTheLoai.IconNormal = null;
            this.btnTheLoai.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnTheLoai.IconSize = new System.Drawing.Size(0, 0);
            this.btnTheLoai.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTheLoai.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTheLoai.LineColorNormal = System.Drawing.Color.Green;
            this.btnTheLoai.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnTheLoai.LineSize = 3;
            this.btnTheLoai.Location = new System.Drawing.Point(160, 0);
            this.btnTheLoai.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(80, 35);
            this.btnTheLoai.TabIndex = 2;
            this.btnTheLoai.TabStop = false;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnTheLoai.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnTheLoai.TextColorClick = System.Drawing.Color.Empty;
            this.btnTheLoai.TextColorHover = System.Drawing.Color.Empty;
            this.btnTheLoai.TextColorNormal = System.Drawing.Color.Black;
            this.btnTheLoai.UseActive = true;
            this.btnTheLoai.UseBackgroundHoverClick = false;
            this.btnTheLoai.UseIconHoverClick = false;
            this.btnTheLoai.UseLineHoverClick = true;
            this.btnTheLoai.UseTextHoverClick = false;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Active = false;
            this.btnTacGia.BackColor = System.Drawing.Color.Transparent;
            this.btnTacGia.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnTacGia.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnTacGia.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnTacGia.IconAlignment = 3;
            this.btnTacGia.IconClick = null;
            this.btnTacGia.IconHover = null;
            this.btnTacGia.IconNormal = null;
            this.btnTacGia.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnTacGia.IconSize = new System.Drawing.Size(0, 0);
            this.btnTacGia.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTacGia.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTacGia.LineColorNormal = System.Drawing.Color.Green;
            this.btnTacGia.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnTacGia.LineSize = 3;
            this.btnTacGia.Location = new System.Drawing.Point(80, 0);
            this.btnTacGia.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Size = new System.Drawing.Size(80, 35);
            this.btnTacGia.TabIndex = 1;
            this.btnTacGia.TabStop = false;
            this.btnTacGia.Text = "Tác Giả";
            this.btnTacGia.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnTacGia.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnTacGia.TextColorClick = System.Drawing.Color.Empty;
            this.btnTacGia.TextColorHover = System.Drawing.Color.Empty;
            this.btnTacGia.TextColorNormal = System.Drawing.Color.Black;
            this.btnTacGia.UseActive = true;
            this.btnTacGia.UseBackgroundHoverClick = false;
            this.btnTacGia.UseIconHoverClick = false;
            this.btnTacGia.UseLineHoverClick = true;
            this.btnTacGia.UseTextHoverClick = false;
            this.btnTacGia.Click += new System.EventHandler(this.btnTacGia_Click);
            // 
            // btnTuaSach
            // 
            this.btnTuaSach.Active = false;
            this.btnTuaSach.BackColor = System.Drawing.Color.Transparent;
            this.btnTuaSach.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnTuaSach.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnTuaSach.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnTuaSach.IconAlignment = 3;
            this.btnTuaSach.IconClick = null;
            this.btnTuaSach.IconHover = null;
            this.btnTuaSach.IconNormal = null;
            this.btnTuaSach.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnTuaSach.IconSize = new System.Drawing.Size(0, 0);
            this.btnTuaSach.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTuaSach.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTuaSach.LineColorNormal = System.Drawing.Color.Green;
            this.btnTuaSach.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnTuaSach.LineSize = 3;
            this.btnTuaSach.Location = new System.Drawing.Point(0, 0);
            this.btnTuaSach.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnTuaSach.Name = "btnTuaSach";
            this.btnTuaSach.Size = new System.Drawing.Size(80, 35);
            this.btnTuaSach.TabIndex = 0;
            this.btnTuaSach.TabStop = false;
            this.btnTuaSach.Text = "Tựa Sách";
            this.btnTuaSach.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnTuaSach.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnTuaSach.TextColorClick = System.Drawing.Color.Empty;
            this.btnTuaSach.TextColorHover = System.Drawing.Color.Empty;
            this.btnTuaSach.TextColorNormal = System.Drawing.Color.Black;
            this.btnTuaSach.UseActive = true;
            this.btnTuaSach.UseBackgroundHoverClick = false;
            this.btnTuaSach.UseIconHoverClick = false;
            this.btnTuaSach.UseLineHoverClick = true;
            this.btnTuaSach.UseTextHoverClick = false;
            this.btnTuaSach.Click += new System.EventHandler(this.btnTuaSach_Click);
            // 
            // pnlUseSach
            // 
            this.pnlUseSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUseSach.Location = new System.Drawing.Point(0, 35);
            this.pnlUseSach.Name = "pnlUseSach";
            this.pnlUseSach.Size = new System.Drawing.Size(822, 443);
            this.pnlUseSach.TabIndex = 1;
            // 
            // UCSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUseSach);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "UCSach";
            this.Size = new System.Drawing.Size(822, 478);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private ComponentForm.Flat_Button btnTuaSach;
        private ComponentForm.Flat_Button btnTacGia;
        private System.Windows.Forms.Panel pnlUseSach;
        private ComponentForm.Flat_Button btnTheLoai;
        private ComponentForm.Flat_Button btnNXB;
    }
}
