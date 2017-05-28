namespace GUI.UC.Tab
{
    partial class MuonTheoNgay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.flat_Button1 = new GUI.ComponentForm.Flat_Button();
            this.dgc1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgc1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thư Viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(198, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống Kê Số Lượng Sách  Mượn Theo Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(216, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày";
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(271, 111);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(220, 20);
            this.txtngay.TabIndex = 6;
            // 
            // flat_Button1
            // 
            this.flat_Button1.Active = false;
            this.flat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.flat_Button1.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_Button1.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_Button1.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_Button1.IconAlignment = 3;
            this.flat_Button1.IconClick = null;
            this.flat_Button1.IconHover = null;
            this.flat_Button1.IconNormal = null;
            this.flat_Button1.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_Button1.IconSize = new System.Drawing.Size(0, 0);
            this.flat_Button1.LineColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.LineColorHover = System.Drawing.Color.Empty;
            this.flat_Button1.LineColorNormal = System.Drawing.Color.Green;
            this.flat_Button1.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_Button1.LineSize = 0;
            this.flat_Button1.Location = new System.Drawing.Point(744, 151);
            this.flat_Button1.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_Button1.Name = "flat_Button1";
            this.flat_Button1.Size = new System.Drawing.Size(75, 30);
            this.flat_Button1.TabIndex = 7;
            this.flat_Button1.Text = "Thống Kê";
            this.flat_Button1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.TextColorHover = System.Drawing.Color.Empty;
            this.flat_Button1.TextColorNormal = System.Drawing.Color.Black;
            this.flat_Button1.UseActive = false;
            this.flat_Button1.UseBackgroundHoverClick = true;
            this.flat_Button1.UseIconHoverClick = false;
            this.flat_Button1.UseLineHoverClick = false;
            this.flat_Button1.UseTextHoverClick = false;
            this.flat_Button1.Click += new System.EventHandler(this.flat_Button1_Click);
            // 
            // dgc1
            // 
            this.dgc1.AllowUserToAddRows = false;
            this.dgc1.AllowUserToDeleteRows = false;
            this.dgc1.AllowUserToResizeColumns = false;
            this.dgc1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgc1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgc1.Location = new System.Drawing.Point(0, 200);
            this.dgc1.Name = "dgc1";
            this.dgc1.Size = new System.Drawing.Size(822, 240);
            this.dgc1.TabIndex = 8;
            // 
            // MuonTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgc1);
            this.Controls.Add(this.flat_Button1);
            this.Controls.Add(this.txtngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MuonTheoNgay";
            this.Size = new System.Drawing.Size(822, 443);
            ((System.ComponentModel.ISupportInitialize)(this.dgc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtngay;
        private ComponentForm.Flat_Button flat_Button1;
        private System.Windows.Forms.DataGridView dgc1;
    }
}
