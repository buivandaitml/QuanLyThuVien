namespace GUI.UC.Tab
{
    partial class PhieuNhap
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
            this.components = new System.ComponentModel.Container();
            this.pnlPN = new System.Windows.Forms.Panel();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.grbToolPN = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cbxncc = new System.Windows.Forms.ComboBox();
            this.cbxthuthu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtspn1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlCTN = new System.Windows.Forms.Panel();
            this.dgvCTN = new System.Windows.Forms.DataGridView();
            this.grbToolCTN = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtspn2 = new System.Windows.Forms.TextBox();
            this.cmsPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.suaCTN = new System.Windows.Forms.ToolStripMenuItem();
            this.tongTienPN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCapNhat2 = new GUI.ComponentForm.Thin_Button();
            this.btnXoa2 = new GUI.ComponentForm.Thin_Button();
            this.btnSua2 = new GUI.ComponentForm.Thin_Button();
            this.btnThem2 = new GUI.ComponentForm.Thin_Button();
            this.btnCapNhat1 = new GUI.ComponentForm.Thin_Button();
            this.btnXoa1 = new GUI.ComponentForm.Thin_Button();
            this.btnSua1 = new GUI.ComponentForm.Thin_Button();
            this.btnThem1 = new GUI.ComponentForm.Thin_Button();
            this.pnlPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.grbToolPN.SuspendLayout();
            this.pnlCTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTN)).BeginInit();
            this.grbToolCTN.SuspendLayout();
            this.cmsPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPN
            // 
            this.pnlPN.AutoSize = true;
            this.pnlPN.Controls.Add(this.dgvPN);
            this.pnlPN.Controls.Add(this.grbToolPN);
            this.pnlPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPN.Location = new System.Drawing.Point(0, 0);
            this.pnlPN.MaximumSize = new System.Drawing.Size(411, 0);
            this.pnlPN.MinimumSize = new System.Drawing.Size(411, 443);
            this.pnlPN.Name = "pnlPN";
            this.pnlPN.Size = new System.Drawing.Size(411, 443);
            this.pnlPN.TabIndex = 0;
            // 
            // dgvPN
            // 
            this.dgvPN.AllowUserToAddRows = false;
            this.dgvPN.AllowUserToDeleteRows = false;
            this.dgvPN.AllowUserToResizeRows = false;
            this.dgvPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPN.Location = new System.Drawing.Point(0, 157);
            this.dgvPN.MultiSelect = false;
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.ReadOnly = true;
            this.dgvPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPN.Size = new System.Drawing.Size(411, 286);
            this.dgvPN.TabIndex = 3;
            this.dgvPN.TabStop = false;
            this.dgvPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellClick);
            this.dgvPN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPN_MouseClick);
            // 
            // grbToolPN
            // 
            this.grbToolPN.Controls.Add(this.date);
            this.grbToolPN.Controls.Add(this.cbxncc);
            this.grbToolPN.Controls.Add(this.cbxthuthu);
            this.grbToolPN.Controls.Add(this.label4);
            this.grbToolPN.Controls.Add(this.label3);
            this.grbToolPN.Controls.Add(this.label2);
            this.grbToolPN.Controls.Add(this.btnCapNhat1);
            this.grbToolPN.Controls.Add(this.btnXoa1);
            this.grbToolPN.Controls.Add(this.btnSua1);
            this.grbToolPN.Controls.Add(this.btnThem1);
            this.grbToolPN.Controls.Add(this.label1);
            this.grbToolPN.Controls.Add(this.txtspn1);
            this.grbToolPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbToolPN.Location = new System.Drawing.Point(0, 0);
            this.grbToolPN.Name = "grbToolPN";
            this.grbToolPN.Size = new System.Drawing.Size(411, 157);
            this.grbToolPN.TabIndex = 2;
            this.grbToolPN.TabStop = false;
            this.grbToolPN.Text = "Phiếu nhập";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(223, 40);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(175, 20);
            this.date.TabIndex = 29;
            // 
            // cbxncc
            // 
            this.cbxncc.FormattingEnabled = true;
            this.cbxncc.Location = new System.Drawing.Point(223, 89);
            this.cbxncc.Name = "cbxncc";
            this.cbxncc.Size = new System.Drawing.Size(175, 21);
            this.cbxncc.TabIndex = 28;
            // 
            // cbxthuthu
            // 
            this.cbxthuthu.FormattingEnabled = true;
            this.cbxthuthu.Location = new System.Drawing.Point(16, 89);
            this.cbxthuthu.Name = "cbxthuthu";
            this.cbxthuthu.Size = new System.Drawing.Size(175, 21);
            this.cbxthuthu.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên thủ thư xác nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số phiếu nhập";
            // 
            // txtspn1
            // 
            this.txtspn1.Location = new System.Drawing.Point(16, 40);
            this.txtspn1.Name = "txtspn1";
            this.txtspn1.Size = new System.Drawing.Size(175, 20);
            this.txtspn1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(411, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 443);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // pnlCTN
            // 
            this.pnlCTN.Controls.Add(this.dgvCTN);
            this.pnlCTN.Controls.Add(this.grbToolCTN);
            this.pnlCTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCTN.Location = new System.Drawing.Point(414, 0);
            this.pnlCTN.Name = "pnlCTN";
            this.pnlCTN.Size = new System.Drawing.Size(408, 443);
            this.pnlCTN.TabIndex = 3;
            // 
            // dgvCTN
            // 
            this.dgvCTN.AllowUserToAddRows = false;
            this.dgvCTN.AllowUserToDeleteRows = false;
            this.dgvCTN.AllowUserToResizeRows = false;
            this.dgvCTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTN.Location = new System.Drawing.Point(0, 157);
            this.dgvCTN.MultiSelect = false;
            this.dgvCTN.Name = "dgvCTN";
            this.dgvCTN.ReadOnly = true;
            this.dgvCTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTN.Size = new System.Drawing.Size(408, 286);
            this.dgvCTN.TabIndex = 7;
            this.dgvCTN.TabStop = false;
            this.dgvCTN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTN_CellClick);
            // 
            // grbToolCTN
            // 
            this.grbToolCTN.Controls.Add(this.label5);
            this.grbToolCTN.Controls.Add(this.label6);
            this.grbToolCTN.Controls.Add(this.label7);
            this.grbToolCTN.Controls.Add(this.btnCapNhat2);
            this.grbToolCTN.Controls.Add(this.btnXoa2);
            this.grbToolCTN.Controls.Add(this.btnSua2);
            this.grbToolCTN.Controls.Add(this.btnThem2);
            this.grbToolCTN.Controls.Add(this.txtdongia);
            this.grbToolCTN.Controls.Add(this.txtsoluong);
            this.grbToolCTN.Controls.Add(this.txtmats);
            this.grbToolCTN.Controls.Add(this.label8);
            this.grbToolCTN.Controls.Add(this.txtspn2);
            this.grbToolCTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbToolCTN.Location = new System.Drawing.Point(0, 0);
            this.grbToolCTN.Name = "grbToolCTN";
            this.grbToolCTN.Size = new System.Drawing.Size(408, 157);
            this.grbToolCTN.TabIndex = 6;
            this.grbToolCTN.TabStop = false;
            this.grbToolCTN.Text = "Chi tiết nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mã tựa sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số lượng";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(222, 89);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(175, 20);
            this.txtdongia.TabIndex = 31;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(15, 89);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(175, 20);
            this.txtsoluong.TabIndex = 30;
            // 
            // txtmats
            // 
            this.txtmats.Location = new System.Drawing.Point(222, 40);
            this.txtmats.Name = "txtmats";
            this.txtmats.Size = new System.Drawing.Size(175, 20);
            this.txtmats.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Số phiếu nhập";
            // 
            // txtspn2
            // 
            this.txtspn2.Location = new System.Drawing.Point(15, 40);
            this.txtspn2.Name = "txtspn2";
            this.txtspn2.Size = new System.Drawing.Size(175, 20);
            this.txtspn2.TabIndex = 27;
            // 
            // cmsPN
            // 
            this.cmsPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suaCTN,
            this.tongTienPN});
            this.cmsPN.Name = "cmsPN";
            this.cmsPN.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsPN.Size = new System.Drawing.Size(202, 48);
            // 
            // suaCTN
            // 
            this.suaCTN.Name = "suaCTN";
            this.suaCTN.Size = new System.Drawing.Size(201, 22);
            this.suaCTN.Text = "Sửa chi tiết nhập";
            this.suaCTN.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // tongTienPN
            // 
            this.tongTienPN.Name = "tongTienPN";
            this.tongTienPN.Size = new System.Drawing.Size(201, 22);
            this.tongTienPN.Text = "Tổng số tiền thanh toán";
            this.tongTienPN.Click += new System.EventHandler(this.tongTien_Click);
            // 
            // btnCapNhat2
            // 
            this.btnCapNhat2.Active = false;
            this.btnCapNhat2.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat2.BoderColorDisable = System.Drawing.Color.Red;
            this.btnCapNhat2.BorderColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat2.BorderColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat2.BorderColorNomal = System.Drawing.Color.Green;
            this.btnCapNhat2.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCapNhat2.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat2.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhat2.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnCapNhat2.Location = new System.Drawing.Point(322, 121);
            this.btnCapNhat2.Name = "btnCapNhat2";
            this.btnCapNhat2.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat2.SizeBorder = 1;
            this.btnCapNhat2.TabIndex = 35;
            this.btnCapNhat2.TabStop = false;
            this.btnCapNhat2.Text = "Cập nhật";
            this.btnCapNhat2.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnCapNhat2.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnCapNhat2.TextColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat2.TextColorDisable = System.Drawing.Color.Black;
            this.btnCapNhat2.TextColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat2.TextColorNomal = System.Drawing.Color.Black;
            this.btnCapNhat2.UseActive = false;
            this.btnCapNhat2.UseBorderColorHoverClick = false;
            this.btnCapNhat2.UseInnerColorHoverClick = true;
            this.btnCapNhat2.UseTextColorHoverClick = false;
            this.btnCapNhat2.Click += new System.EventHandler(this.btnCapNhat2_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Active = false;
            this.btnXoa2.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa2.BoderColorDisable = System.Drawing.Color.Red;
            this.btnXoa2.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXoa2.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXoa2.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXoa2.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa2.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnXoa2.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa2.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXoa2.Location = new System.Drawing.Point(222, 121);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(75, 23);
            this.btnXoa2.SizeBorder = 1;
            this.btnXoa2.TabIndex = 34;
            this.btnXoa2.TabStop = false;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXoa2.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXoa2.TextColorClick = System.Drawing.Color.Empty;
            this.btnXoa2.TextColorDisable = System.Drawing.Color.Black;
            this.btnXoa2.TextColorHover = System.Drawing.Color.Empty;
            this.btnXoa2.TextColorNomal = System.Drawing.Color.Black;
            this.btnXoa2.UseActive = false;
            this.btnXoa2.UseBorderColorHoverClick = false;
            this.btnXoa2.UseInnerColorHoverClick = true;
            this.btnXoa2.UseTextColorHoverClick = false;
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnSua2
            // 
            this.btnSua2.Active = false;
            this.btnSua2.BackColor = System.Drawing.Color.Transparent;
            this.btnSua2.BoderColorDisable = System.Drawing.Color.Red;
            this.btnSua2.BorderColorClick = System.Drawing.Color.Empty;
            this.btnSua2.BorderColorHover = System.Drawing.Color.Empty;
            this.btnSua2.BorderColorNomal = System.Drawing.Color.Green;
            this.btnSua2.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua2.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnSua2.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua2.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnSua2.Location = new System.Drawing.Point(115, 123);
            this.btnSua2.Name = "btnSua2";
            this.btnSua2.Size = new System.Drawing.Size(75, 23);
            this.btnSua2.SizeBorder = 1;
            this.btnSua2.TabIndex = 33;
            this.btnSua2.TabStop = false;
            this.btnSua2.Text = "Sửa";
            this.btnSua2.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSua2.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSua2.TextColorClick = System.Drawing.Color.Empty;
            this.btnSua2.TextColorDisable = System.Drawing.Color.Black;
            this.btnSua2.TextColorHover = System.Drawing.Color.Empty;
            this.btnSua2.TextColorNomal = System.Drawing.Color.Black;
            this.btnSua2.UseActive = true;
            this.btnSua2.UseBorderColorHoverClick = false;
            this.btnSua2.UseInnerColorHoverClick = true;
            this.btnSua2.UseTextColorHoverClick = false;
            this.btnSua2.Click += new System.EventHandler(this.btnSua2_Click);
            // 
            // btnThem2
            // 
            this.btnThem2.Active = false;
            this.btnThem2.BackColor = System.Drawing.Color.Transparent;
            this.btnThem2.BoderColorDisable = System.Drawing.Color.Red;
            this.btnThem2.BorderColorClick = System.Drawing.Color.Empty;
            this.btnThem2.BorderColorHover = System.Drawing.Color.Empty;
            this.btnThem2.BorderColorNomal = System.Drawing.Color.Green;
            this.btnThem2.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem2.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnThem2.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem2.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnThem2.Location = new System.Drawing.Point(15, 123);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(75, 23);
            this.btnThem2.SizeBorder = 1;
            this.btnThem2.TabIndex = 32;
            this.btnThem2.TabStop = false;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnThem2.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnThem2.TextColorClick = System.Drawing.Color.Empty;
            this.btnThem2.TextColorDisable = System.Drawing.Color.Black;
            this.btnThem2.TextColorHover = System.Drawing.Color.Empty;
            this.btnThem2.TextColorNomal = System.Drawing.Color.Black;
            this.btnThem2.UseActive = true;
            this.btnThem2.UseBorderColorHoverClick = false;
            this.btnThem2.UseInnerColorHoverClick = true;
            this.btnThem2.UseTextColorHoverClick = false;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // btnCapNhat1
            // 
            this.btnCapNhat1.Active = false;
            this.btnCapNhat1.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat1.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat1.BorderColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat1.BorderColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat1.BorderColorNomal = System.Drawing.Color.Green;
            this.btnCapNhat1.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCapNhat1.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat1.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhat1.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnCapNhat1.Location = new System.Drawing.Point(323, 121);
            this.btnCapNhat1.Name = "btnCapNhat1";
            this.btnCapNhat1.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat1.SizeBorder = 1;
            this.btnCapNhat1.TabIndex = 23;
            this.btnCapNhat1.TabStop = false;
            this.btnCapNhat1.Text = "Cập nhật";
            this.btnCapNhat1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnCapNhat1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnCapNhat1.TextColorClick = System.Drawing.Color.Empty;
            this.btnCapNhat1.TextColorDisable = System.Drawing.Color.Empty;
            this.btnCapNhat1.TextColorHover = System.Drawing.Color.Empty;
            this.btnCapNhat1.TextColorNomal = System.Drawing.Color.Black;
            this.btnCapNhat1.UseActive = false;
            this.btnCapNhat1.UseBorderColorHoverClick = false;
            this.btnCapNhat1.UseInnerColorHoverClick = true;
            this.btnCapNhat1.UseTextColorHoverClick = false;
            this.btnCapNhat1.Click += new System.EventHandler(this.btnCapNhat1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Active = false;
            this.btnXoa1.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa1.BoderColorDisable = System.Drawing.Color.Empty;
            this.btnXoa1.BorderColorClick = System.Drawing.Color.Empty;
            this.btnXoa1.BorderColorHover = System.Drawing.Color.Empty;
            this.btnXoa1.BorderColorNomal = System.Drawing.Color.Green;
            this.btnXoa1.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa1.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnXoa1.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa1.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnXoa1.Location = new System.Drawing.Point(223, 121);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 23);
            this.btnXoa1.SizeBorder = 1;
            this.btnXoa1.TabIndex = 22;
            this.btnXoa1.TabStop = false;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnXoa1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnXoa1.TextColorClick = System.Drawing.Color.Empty;
            this.btnXoa1.TextColorDisable = System.Drawing.Color.Empty;
            this.btnXoa1.TextColorHover = System.Drawing.Color.Empty;
            this.btnXoa1.TextColorNomal = System.Drawing.Color.Black;
            this.btnXoa1.UseActive = false;
            this.btnXoa1.UseBorderColorHoverClick = false;
            this.btnXoa1.UseInnerColorHoverClick = true;
            this.btnXoa1.UseTextColorHoverClick = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.Active = false;
            this.btnSua1.BackColor = System.Drawing.Color.Transparent;
            this.btnSua1.BoderColorDisable = System.Drawing.Color.Red;
            this.btnSua1.BorderColorClick = System.Drawing.Color.Empty;
            this.btnSua1.BorderColorHover = System.Drawing.Color.Empty;
            this.btnSua1.BorderColorNomal = System.Drawing.Color.Green;
            this.btnSua1.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua1.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnSua1.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua1.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnSua1.Location = new System.Drawing.Point(116, 123);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(75, 23);
            this.btnSua1.SizeBorder = 1;
            this.btnSua1.TabIndex = 21;
            this.btnSua1.TabStop = false;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnSua1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSua1.TextColorClick = System.Drawing.Color.Empty;
            this.btnSua1.TextColorDisable = System.Drawing.Color.Black;
            this.btnSua1.TextColorHover = System.Drawing.Color.Empty;
            this.btnSua1.TextColorNomal = System.Drawing.Color.Black;
            this.btnSua1.UseActive = true;
            this.btnSua1.UseBorderColorHoverClick = false;
            this.btnSua1.UseInnerColorHoverClick = true;
            this.btnSua1.UseTextColorHoverClick = false;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.Active = false;
            this.btnThem1.BackColor = System.Drawing.Color.Transparent;
            this.btnThem1.BoderColorDisable = System.Drawing.Color.Red;
            this.btnThem1.BorderColorClick = System.Drawing.Color.Empty;
            this.btnThem1.BorderColorHover = System.Drawing.Color.Empty;
            this.btnThem1.BorderColorNomal = System.Drawing.Color.Green;
            this.btnThem1.InnerColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem1.InnerColorDisable = System.Drawing.Color.Empty;
            this.btnThem1.InnerColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem1.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btnThem1.Location = new System.Drawing.Point(16, 123);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(75, 23);
            this.btnThem1.SizeBorder = 1;
            this.btnThem1.TabIndex = 20;
            this.btnThem1.TabStop = false;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnThem1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnThem1.TextColorClick = System.Drawing.Color.Empty;
            this.btnThem1.TextColorDisable = System.Drawing.Color.Black;
            this.btnThem1.TextColorHover = System.Drawing.Color.Empty;
            this.btnThem1.TextColorNomal = System.Drawing.Color.Black;
            this.btnThem1.UseActive = true;
            this.btnThem1.UseBorderColorHoverClick = false;
            this.btnThem1.UseInnerColorHoverClick = true;
            this.btnThem1.UseTextColorHoverClick = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCTN);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlPN);
            this.Name = "PhieuNhap";
            this.Size = new System.Drawing.Size(822, 443);
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            this.pnlPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.grbToolPN.ResumeLayout(false);
            this.grbToolPN.PerformLayout();
            this.pnlCTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTN)).EndInit();
            this.grbToolCTN.ResumeLayout(false);
            this.grbToolCTN.PerformLayout();
            this.cmsPN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlCTN;
        private System.Windows.Forms.GroupBox grbToolPN;
        private System.Windows.Forms.GroupBox grbToolCTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtspn1;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentForm.Thin_Button btnCapNhat1;
        private ComponentForm.Thin_Button btnXoa1;
        private ComponentForm.Thin_Button btnSua1;
        private ComponentForm.Thin_Button btnThem1;
        private System.Windows.Forms.DataGridView dgvCTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ComponentForm.Thin_Button btnCapNhat2;
        private ComponentForm.Thin_Button btnXoa2;
        private ComponentForm.Thin_Button btnSua2;
        private ComponentForm.Thin_Button btnThem2;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtspn2;
        private System.Windows.Forms.ComboBox cbxncc;
        private System.Windows.Forms.ComboBox cbxthuthu;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ContextMenuStrip cmsPN;
        private System.Windows.Forms.ToolStripMenuItem suaCTN;
        private System.Windows.Forms.ToolStripMenuItem tongTienPN;
    }
}
