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
            this.adinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBan = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbbChuyenBan = new System.Windows.Forms.ComboBox();
            this.nmrGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTienKhachDua = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienKD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTienGK = new System.Windows.Forms.Label();
            this.txtTienGK = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adinToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adinToolStripMenuItem
            // 
            this.adinToolStripMenuItem.Name = "adinToolStripMenuItem";
            this.adinToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adinToolStripMenuItem.Text = "Admin";
            this.adinToolStripMenuItem.Click += new System.EventHandler(this.adinToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(579, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 457);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 451);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cbbChuyenBan
            // 
            this.cbbChuyenBan.FormattingEnabled = true;
            this.cbbChuyenBan.Location = new System.Drawing.Point(1101, 176);
            this.cbbChuyenBan.Name = "cbbChuyenBan";
            this.cbbChuyenBan.Size = new System.Drawing.Size(146, 28);
            this.cbbChuyenBan.TabIndex = 4;
            // 
            // nmrGiamGia
            // 
            this.nmrGiamGia.Location = new System.Drawing.Point(1104, 334);
            this.nmrGiamGia.Name = "nmrGiamGia";
            this.nmrGiamGia.Size = new System.Drawing.Size(143, 26);
            this.nmrGiamGia.TabIndex = 4;
            this.nmrGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChuyenBan.Location = new System.Drawing.Point(1101, 138);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(146, 41);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGiamGia.Location = new System.Drawing.Point(1104, 298);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(143, 41);
            this.btnGiamGia.TabIndex = 5;
            this.btnGiamGia.Text = "Giảm giá";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Location = new System.Drawing.Point(1104, 492);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(143, 72);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbb2);
            this.panel4.Controls.Add(this.cbb1);
            this.panel4.Location = new System.Drawing.Point(579, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 73);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(440, 24);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemMon.Location = new System.Drawing.Point(317, 11);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(117, 51);
            this.btnThemMon.TabIndex = 2;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            // 
            // cbb2
            // 
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(4, 38);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(290, 28);
            this.cbb2.TabIndex = 1;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(4, 4);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(290, 28);
            this.cbb1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(549, 672);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(628, 594);
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
            this.lblTienKhachDua.Location = new System.Drawing.Point(578, 637);
            this.lblTienKhachDua.Name = "lblTienKhachDua";
            this.lblTienKhachDua.Size = new System.Drawing.Size(168, 25);
            this.lblTienKhachDua.TabIndex = 8;
            this.lblTienKhachDua.Text = "Tiền khách đưa:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Location = new System.Drawing.Point(764, 594);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(289, 37);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtTienKD
            // 
            this.txtTienKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienKD.Location = new System.Drawing.Point(764, 637);
            this.txtTienKD.Multiline = true;
            this.txtTienKD.Name = "txtTienKD";
            this.txtTienKD.Size = new System.Drawing.Size(289, 37);
            this.txtTienKD.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoAppGUI.Properties.Resources.download__9_1;
            this.pictureBox1.Location = new System.Drawing.Point(1127, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTienGK
            // 
            this.lblTienGK.AutoSize = true;
            this.lblTienGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienGK.ForeColor = System.Drawing.Color.Blue;
            this.lblTienGK.Location = new System.Drawing.Point(578, 677);
            this.lblTienGK.Name = "lblTienGK";
            this.lblTienGK.Size = new System.Drawing.Size(161, 25);
            this.lblTienGK.TabIndex = 12;
            this.lblTienGK.Text = "Tiền gửi khách:";
            // 
            // txtTienGK
            // 
            this.txtTienGK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienGK.Location = new System.Drawing.Point(764, 681);
            this.txtTienGK.Multiline = true;
            this.txtTienGK.Name = "txtTienGK";
            this.txtTienGK.Size = new System.Drawing.Size(289, 37);
            this.txtTienGK.TabIndex = 13;
            // 
            // fQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1259, 725);
            this.Controls.Add(this.txtTienGK);
            this.Controls.Add(this.lblTienGK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTienKD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienKhachDua);
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
            this.Text = "QuanLyBan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbb2;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTienGK;
        private System.Windows.Forms.TextBox txtTienGK;
    }
}