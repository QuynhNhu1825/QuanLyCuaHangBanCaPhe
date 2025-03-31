namespace DemoAppGUI
{
    partial class fDangky
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangky = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTenHT = new System.Windows.Forms.Label();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ckHTMK = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ckXNMK = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXacnhan = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangky);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 534);
            this.panel1.TabIndex = 1;
            // 
            // btnDangky
            // 
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Location = new System.Drawing.Point(255, 484);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(148, 43);
            this.btnDangky.TabIndex = 4;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTenHT);
            this.panel3.Controls.Add(this.txtTenHT);
            this.panel3.Location = new System.Drawing.Point(17, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 88);
            this.panel3.TabIndex = 3;
            // 
            // lblTenHT
            // 
            this.lblTenHT.AutoSize = true;
            this.lblTenHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHT.ForeColor = System.Drawing.Color.Blue;
            this.lblTenHT.Location = new System.Drawing.Point(39, 27);
            this.lblTenHT.Name = "lblTenHT";
            this.lblTenHT.Size = new System.Drawing.Size(143, 26);
            this.lblTenHT.TabIndex = 0;
            this.lblTenHT.Text = "Tên hiển thị:";
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(203, 16);
            this.txtTenHT.Multiline = true;
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(377, 38);
            this.txtTenHT.TabIndex = 2;
            this.txtTenHT.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenTK);
            this.panel2.Controls.Add(this.lblTenTK);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 83);
            this.panel2.TabIndex = 2;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(202, 16);
            this.txtTenTK.Multiline = true;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(378, 38);
            this.txtTenTK.TabIndex = 1;
            this.txtTenTK.UseSystemPasswordChar = true;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.ForeColor = System.Drawing.Color.Blue;
            this.lblTenTK.Location = new System.Drawing.Point(13, 28);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(169, 26);
            this.lblTenTK.TabIndex = 0;
            this.lblTenTK.Text = "Tên tài khoản: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ckHTMK);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtMatkhau);
            this.panel4.Location = new System.Drawing.Point(17, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(612, 88);
            this.panel4.TabIndex = 3;
            // 
            // ckHTMK
            // 
            this.ckHTMK.AutoSize = true;
            this.ckHTMK.Location = new System.Drawing.Point(491, 29);
            this.ckHTMK.Name = "ckHTMK";
            this.ckHTMK.Size = new System.Drawing.Size(89, 24);
            this.ckHTMK.TabIndex = 3;
            this.ckHTMK.Text = "Hiển thị";
            this.ckHTMK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(203, 16);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(265, 38);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ckXNMK);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtXacnhan);
            this.panel5.Location = new System.Drawing.Point(17, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(612, 88);
            this.panel5.TabIndex = 3;
            // 
            // ckXNMK
            // 
            this.ckXNMK.AutoSize = true;
            this.ckXNMK.Location = new System.Drawing.Point(491, 29);
            this.ckXNMK.Name = "ckXNMK";
            this.ckXNMK.Size = new System.Drawing.Size(89, 24);
            this.ckXNMK.TabIndex = 3;
            this.ckXNMK.Text = "Hiển thị";
            this.ckXNMK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacnhan
            // 
            this.txtXacnhan.Location = new System.Drawing.Point(203, 16);
            this.txtXacnhan.Multiline = true;
            this.txtXacnhan.Name = "txtXacnhan";
            this.txtXacnhan.Size = new System.Drawing.Size(265, 38);
            this.txtXacnhan.TabIndex = 2;
            this.txtXacnhan.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Location = new System.Drawing.Point(17, 390);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(612, 88);
            this.panel6.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(102, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 28);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(377, 38);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // fDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 550);
            this.Controls.Add(this.panel1);
            this.Name = "fDangky";
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox ckXNMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXacnhan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ckHTMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTenHT;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
    }
}