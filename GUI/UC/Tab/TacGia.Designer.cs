namespace GUI.UC.Tab
{
    partial class TacGia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnam = new System.Windows.Forms.RadioButton();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCapNhat = new GUI.ComponentForm.Thin_Button();
            this.btnXoa = new GUI.ComponentForm.Thin_Button();
            this.btnSua = new GUI.ComponentForm.Thin_Button();
            this.btnThem = new GUI.ComponentForm.Thin_Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttentg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatg = new System.Windows.Forms.TextBox();
            this.dgvtacgia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtquequan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttentg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmatg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 154);
            this.panel1.TabIndex = 0;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(300, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnam);
            this.groupBox1.Controls.Add(this.rdbnu);
            this.groupBox1.Location = new System.Drawing.Point(300, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 40);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdbnam
            // 
            this.rdbnam.AutoSize = true;
            this.rdbnam.Location = new System.Drawing.Point(6, 15);
            this.rdbnam.Name = "rdbnam";
            this.rdbnam.Size = new System.Drawing.Size(47, 17);
            this.rdbnam.TabIndex = 22;
            this.rdbnam.Text = "Nam";
            this.rdbnam.UseVisualStyleBackColor = true;
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(76, 15);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(39, 17);
            this.rdbnu.TabIndex = 23;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày sinh";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Active = false;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat.BorderColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat.BorderColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat.BorderColorNomal = System.Drawing.Color.Green;
            this.btnCapNhat.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCapNhat.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhat.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnCapNhat.Location = new System.Drawing.Point(426, 117);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.SizeBorder = 1;
            this.btnCapNhat.TabIndex = 19;
            this.btnCapNhat.TabStop = false;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnCapNhat.TextColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat.TextColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat.TextColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat.TextColorNomal = System.Drawing.Color.Black;
            this.btnCapNhat.UseActive = false;
            this.btnCapNhat.UseBorderColorHoverClick = false;
            this.btnCapNhat.UseInnerColorHoverClick = true;
            this.btnCapNhat.UseTextColorHoverClick = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Active = false;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXoa.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXoa.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(294, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.SizeBorder = 1;
            this.btnXoa.TabIndex = 18;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXoa.TextColorClick = System.Drawing.Color.Empty;
            this.btnXoa.TextColorDisable = System.Drawing.Color.Empty;
            this.btnXoa.TextColorHover = System.Drawing.Color.Empty;
            this.btnXoa.TextColorNomal = System.Drawing.Color.Black;
            this.btnXoa.UseActive = false;
            this.btnXoa.UseBorderColorHoverClick = false;
            this.btnXoa.UseInnerColorHoverClick = true;
            this.btnXoa.UseTextColorHoverClick = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_click);
            // 
            // btnSua
            // 
            this.btnSua.Active = false;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BoderColorDisable = System.Drawing.Color.Red;
            this.btnSua.BorderColorClick = System.Drawing.Color.Empty;
            this.btnSua.BorderColorHover = System.Drawing.Color.Empty;
            this.btnSua.BorderColorNomal = System.Drawing.Color.Green;
            this.btnSua.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnSua.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(146, 117);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.SizeBorder = 1;
            this.btnSua.TabIndex = 17;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSua.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSua.TextColorClick = System.Drawing.Color.Empty;
            this.btnSua.TextColorDisable = System.Drawing.Color.Black;
            this.btnSua.TextColorHover = System.Drawing.Color.Empty;
            this.btnSua.TextColorNomal = System.Drawing.Color.Black;
            this.btnSua.UseActive = true;
            this.btnSua.UseBorderColorHoverClick = false;
            this.btnSua.UseInnerColorHoverClick = true;
            this.btnSua.UseTextColorHoverClick = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Active = false;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BoderColorDisable = System.Drawing.Color.Red;
            this.btnThem.BorderColorClick = System.Drawing.Color.Empty;
            this.btnThem.BorderColorHover = System.Drawing.Color.Empty;
            this.btnThem.BorderColorNomal = System.Drawing.Color.Green;
            this.btnThem.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnThem.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(21, 117);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.SizeBorder = 1;
            this.btnThem.TabIndex = 16;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnThem.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnThem.TextColorClick = System.Drawing.Color.Empty;
            this.btnThem.TextColorDisable = System.Drawing.Color.Black;
            this.btnThem.TextColorHover = System.Drawing.Color.Empty;
            this.btnThem.TextColorNomal = System.Drawing.Color.Black;
            this.btnThem.UseActive = true;
            this.btnThem.UseBorderColorHoverClick = false;
            this.btnThem.UseInnerColorHoverClick = true;
            this.btnThem.UseTextColorHoverClick = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quê quán";
            // 
            // txtquequan
            // 
            this.txtquequan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquequan.Location = new System.Drawing.Point(576, 30);
            this.txtquequan.MaximumSize = new System.Drawing.Size(250, 24);
            this.txtquequan.MaxLength = 50;
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(200, 21);
            this.txtquequan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tác giả";
            // 
            // txttentg
            // 
            this.txttentg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentg.Location = new System.Drawing.Point(20, 78);
            this.txttentg.MaximumSize = new System.Drawing.Size(250, 24);
            this.txttentg.MaxLength = 30;
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(200, 21);
            this.txttentg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tác giả";
            // 
            // txtmatg
            // 
            this.txtmatg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatg.Location = new System.Drawing.Point(20, 30);
            this.txtmatg.MaximumSize = new System.Drawing.Size(250, 24);
            this.txtmatg.MaxLength = 10;
            this.txtmatg.Name = "txtmatg";
            this.txtmatg.Size = new System.Drawing.Size(200, 21);
            this.txtmatg.TabIndex = 0;
            // 
            // dgvtacgia
            // 
            this.dgvtacgia.AllowUserToAddRows = false;
            this.dgvtacgia.AllowUserToDeleteRows = false;
            this.dgvtacgia.AllowUserToResizeRows = false;
            this.dgvtacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtacgia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtacgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtacgia.Location = new System.Drawing.Point(0, 154);
            this.dgvtacgia.MultiSelect = false;
            this.dgvtacgia.Name = "dgvtacgia";
            this.dgvtacgia.ReadOnly = true;
            this.dgvtacgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtacgia.Size = new System.Drawing.Size(822, 289);
            this.dgvtacgia.TabIndex = 1;
            this.dgvtacgia.TabStop = false;
            this.dgvtacgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtacgia_CellClick);
            // 
            // TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvtacgia);
            this.Controls.Add(this.panel1);
            this.Name = "TacGia";
            this.Size = new System.Drawing.Size(822, 443);
            this.Load += new System.EventHandler(this.TacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttentg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatg;
        private ComponentForm.Thin_Button btnCapNhat;
        private ComponentForm.Thin_Button btnXoa;
        private ComponentForm.Thin_Button btnSua;
        private ComponentForm.Thin_Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbnam;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.DateTimePicker date;
    }
}
