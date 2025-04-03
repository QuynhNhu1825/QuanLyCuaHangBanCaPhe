namespace DemoAppGUI
{
    partial class fQuenMK
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
            this.btnLaylaimk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmailDK = new System.Windows.Forms.TextBox();
            this.lblEmailDK = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLaylaimk);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 292);
            this.panel1.TabIndex = 0;
            // 
            // btnLaylaimk
            // 
            this.btnLaylaimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLaylaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaylaimk.Location = new System.Drawing.Point(167, 214);
            this.btnLaylaimk.Name = "btnLaylaimk";
            this.btnLaylaimk.Size = new System.Drawing.Size(266, 40);
            this.btnLaylaimk.TabIndex = 6;
            this.btnLaylaimk.Text = "Lấy lại mật khẩu";
            this.btnLaylaimk.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblKetqua);
            this.panel3.Location = new System.Drawing.Point(12, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 88);
            this.panel3.TabIndex = 5;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetqua.Location = new System.Drawing.Point(65, 28);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(101, 26);
            this.lblKetqua.TabIndex = 0;
            this.lblKetqua.Text = "Kết quả:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmailDK);
            this.panel2.Controls.Add(this.lblEmailDK);
            this.panel2.Location = new System.Drawing.Point(12, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 83);
            this.panel2.TabIndex = 4;
            // 
            // txtEmailDK
            // 
            this.txtEmailDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEmailDK.Location = new System.Drawing.Point(198, 16);
            this.txtEmailDK.Multiline = true;
            this.txtEmailDK.Name = "txtEmailDK";
            this.txtEmailDK.Size = new System.Drawing.Size(378, 38);
            this.txtEmailDK.TabIndex = 1;
            this.txtEmailDK.UseSystemPasswordChar = true;
            // 
            // lblEmailDK
            // 
            this.lblEmailDK.AutoSize = true;
            this.lblEmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDK.ForeColor = System.Drawing.Color.Blue;
            this.lblEmailDK.Location = new System.Drawing.Point(13, 28);
            this.lblEmailDK.Name = "lblEmailDK";
            this.lblEmailDK.Size = new System.Drawing.Size(153, 26);
            this.lblEmailDK.TabIndex = 0;
            this.lblEmailDK.Text = "Email đã DK:";
            // 
            // fQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(669, 336);
            this.Controls.Add(this.panel1);
            this.Name = "fQuenMK";
            this.Text = "fQuenMK";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLaylaimk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmailDK;
        private System.Windows.Forms.Label lblEmailDK;
    }
}