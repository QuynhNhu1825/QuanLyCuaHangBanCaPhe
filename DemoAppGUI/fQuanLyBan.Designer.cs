namespace DemoAppGUI
{
    partial class fQuanLyBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyBan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBan = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbChuyenBan = new System.Windows.Forms.ComboBox();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericSL = new System.Windows.Forms.NumericUpDown();
            this.btnXoamon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbThucuong = new System.Windows.Forms.ComboBox();
            this.cbDanhmuc = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTienKhachDua = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienKD = new System.Windows.Forms.TextBox();
            this.lblTienGK = new System.Windows.Forms.Label();
            this.txtTienGK = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHienthiTen = new System.Windows.Forms.Label();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adinToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // imgBan
            // 
            this.imgBan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBan.ImageStream")));
            this.imgBan.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBan.Images.SetKeyName(0, "download (8).png");
            this.imgBan.Images.SetKeyName(1, "icons8-coffee-cup-50.png");
            this.imgBan.Images.SetKeyName(2, "Màu đào và Nâu Phông chữ Hình vẽ một nét Đơn giản Sản phẩm Cà phê Biểu trưng Cà p" +
        "hê.jpg");
            this.imgBan.Images.SetKeyName(3, "icons8-refresh-100.png");
            this.imgBan.Images.SetKeyName(4, "icons8-delete-100.png");
            this.imgBan.Images.SetKeyName(5, "icons8-add-100.png");
            this.imgBan.Images.SetKeyName(6, "icons8-add-100.png");
            this.imgBan.Images.SetKeyName(7, "icons8-coffee-shop-50.png");
            this.imgBan.Images.SetKeyName(8, "icons8-coffee-shop-64.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCTHD);
            this.panel2.Location = new System.Drawing.Point(579, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 457);
            this.panel2.TabIndex = 2;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTU,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCTHD.Location = new System.Drawing.Point(0, 3);
            this.dgvCTHD.MultiSelect = false;
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 62;
            this.dgvCTHD.RowTemplate.Height = 28;
            this.dgvCTHD.Size = new System.Drawing.Size(516, 454);
            this.dgvCTHD.TabIndex = 0;
            // 
            // MaTU
            // 
            this.MaTU.DataPropertyName = "MaTU";
            this.MaTU.FillWeight = 80F;
            this.MaTU.HeaderText = "Mã";
            this.MaTU.MinimumWidth = 8;
            this.MaTU.Name = "MaTU";
            this.MaTU.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTU";
            this.Column2.HeaderText = "Tên thức uống";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gia";
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThanhTien";
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // cbbChuyenBan
            // 
            this.cbbChuyenBan.FormattingEnabled = true;
            this.cbbChuyenBan.Location = new System.Drawing.Point(1121, 387);
            this.cbbChuyenBan.Name = "cbbChuyenBan";
            this.cbbChuyenBan.Size = new System.Drawing.Size(146, 28);
            this.cbbChuyenBan.TabIndex = 4;
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Location = new System.Drawing.Point(1125, 494);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(142, 26);
            this.nmrGiamGia.TabIndex = 4;
            this.nmrGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnChuyenBan.Location = new System.Drawing.Point(1121, 354);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(146, 42);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGiamGia.Location = new System.Drawing.Point(1125, 455);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(142, 42);
            this.btnGiamGia.TabIndex = 5;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Location = new System.Drawing.Point(1121, 615);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(142, 72);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnLammoi);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.numericSL);
            this.panel4.Controls.Add(this.btnXoamon);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbThucuong);
            this.panel4.Controls.Add(this.cbDanhmuc);
            this.panel4.Location = new System.Drawing.Point(579, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 72);
            this.panel4.TabIndex = 4;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLammoi.ImageKey = "icons8-refresh-100.png";
            this.btnLammoi.ImageList = this.imgBan;
            this.btnLammoi.Location = new System.Drawing.Point(613, 10);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(85, 56);
            this.btnLammoi.TabIndex = 5;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(312, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Số lượng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericSL
            // 
            this.numericSL.Location = new System.Drawing.Point(325, 39);
            this.numericSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSL.Name = "numericSL";
            this.numericSL.Size = new System.Drawing.Size(89, 26);
            this.numericSL.TabIndex = 3;
            this.numericSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXoamon
            // 
            this.btnXoamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoamon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoamon.ImageKey = "icons8-delete-100.png";
            this.btnXoamon.ImageList = this.imgBan;
            this.btnXoamon.Location = new System.Drawing.Point(526, 9);
            this.btnXoamon.Name = "btnXoamon";
            this.btnXoamon.Size = new System.Drawing.Size(85, 56);
            this.btnXoamon.TabIndex = 2;
            this.btnXoamon.UseVisualStyleBackColor = true;
            this.btnXoamon.Click += new System.EventHandler(this.btnXoamon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemMon.ImageKey = "icons8-add-100.png";
            this.btnThemMon.ImageList = this.imgBan;
            this.btnThemMon.Location = new System.Drawing.Point(435, 9);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(85, 57);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbThucuong
            // 
            this.cbThucuong.FormattingEnabled = true;
            this.cbThucuong.Location = new System.Drawing.Point(4, 38);
            this.cbThucuong.Name = "cbThucuong";
            this.cbThucuong.Size = new System.Drawing.Size(290, 28);
            this.cbThucuong.TabIndex = 1;
            // 
            // cbDanhmuc
            // 
            this.cbDanhmuc.FormattingEnabled = true;
            this.cbDanhmuc.Location = new System.Drawing.Point(4, 5);
            this.cbDanhmuc.Name = "cbDanhmuc";
            this.cbDanhmuc.Size = new System.Drawing.Size(290, 28);
            this.cbDanhmuc.TabIndex = 0;
            this.cbDanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhmuc_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 672);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(628, 581);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(118, 25);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTienKhachDua
            // 
            this.lblTienKhachDua.AutoSize = true;
            this.lblTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienKhachDua.ForeColor = System.Drawing.Color.Blue;
            this.lblTienKhachDua.Location = new System.Drawing.Point(578, 662);
            this.lblTienKhachDua.Name = "lblTienKhachDua";
            this.lblTienKhachDua.Size = new System.Drawing.Size(168, 25);
            this.lblTienKhachDua.TabIndex = 8;
            this.lblTienKhachDua.Text = "Tiền khách đưa:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Tomato;
            this.txtTongTien.Location = new System.Drawing.Point(764, 581);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(290, 31);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.Text = "0";
            // 
            // txtTienKD
            // 
            this.txtTienKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienKD.Location = new System.Drawing.Point(764, 655);
            this.txtTienKD.Multiline = true;
            this.txtTienKD.Name = "txtTienKD";
            this.txtTienKD.Size = new System.Drawing.Size(290, 32);
            this.txtTienKD.TabIndex = 10;
            this.txtTienKD.TextChanged += new System.EventHandler(this.txtTienKD_TextChanged);
            // 
            // lblTienGK
            // 
            this.lblTienGK.AutoSize = true;
            this.lblTienGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienGK.ForeColor = System.Drawing.Color.Blue;
            this.lblTienGK.Location = new System.Drawing.Point(585, 695);
            this.lblTienGK.Name = "lblTienGK";
            this.lblTienGK.Size = new System.Drawing.Size(161, 25);
            this.lblTienGK.TabIndex = 12;
            this.lblTienGK.Text = "Tiền gửi khách:";
            // 
            // txtTienGK
            // 
            this.txtTienGK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienGK.Location = new System.Drawing.Point(764, 695);
            this.txtTienGK.Multiline = true;
            this.txtTienGK.Name = "txtTienGK";
            this.txtTienGK.ReadOnly = true;
            this.txtTienGK.Size = new System.Drawing.Size(290, 28);
            this.txtTienGK.TabIndex = 13;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTimer.Location = new System.Drawing.Point(1158, 311);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(69, 29);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.Color.Blue;
            this.lblMaKH.Location = new System.Drawing.Point(628, 624);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(113, 25);
            this.lblMaKH.TabIndex = 7;
            this.lblMaKH.Text = "Mã khách:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Location = new System.Drawing.Point(764, 618);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(290, 32);
            this.txtMaKH.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1101, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblHienthiTen
            // 
            this.lblHienthiTen.AutoSize = true;
            this.lblHienthiTen.BackColor = System.Drawing.Color.White;
            this.lblHienthiTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienthiTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHienthiTen.Location = new System.Drawing.Point(563, 9);
            this.lblHienthiTen.Name = "lblHienthiTen";
            this.lblHienthiTen.Size = new System.Drawing.Size(95, 22);
            this.lblHienthiTen.TabIndex = 17;
            this.lblHienthiTen.Text = "Xin chào ..";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangxuat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDangxuat.Location = new System.Drawing.Point(1176, 4);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(109, 33);
            this.btnDangxuat.TabIndex = 18;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // fQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1297, 731);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.lblHienthiTen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtTienGK);
            this.Controls.Add(this.lblTienGK);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtTienKD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienKhachDua);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.nmrGiamGia);
            this.Controls.Add(this.cbbChuyenBan);
            this.Controls.Add(this.btnGiamGia);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.fQuanLyBan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericSL;
        private System.Windows.Forms.ComboBox cbThucuong;
        private System.Windows.Forms.ComboBox cbDanhmuc;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.NumericUpDown nmrGiamGia;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.ComboBox cbbChuyenBan;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ImageList imgBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTienKhachDua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienKD;
        private System.Windows.Forms.Label lblTienGK;
        private System.Windows.Forms.TextBox txtTienGK;
        private System.Windows.Forms.Button btnXoamon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblHienthiTen;
        private System.Windows.Forms.Button btnDangxuat;
    }
}