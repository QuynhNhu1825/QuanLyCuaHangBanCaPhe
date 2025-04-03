using DemoAppDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppGUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dr == DialogResult.OK) { 
                Close();
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtName.Text;
            string matKhau = txtPass.Text;

            if (Login(tenTK, matKhau))
            {
                fQuanLyBan f = new fQuanLyBan();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên TK hoặc MK!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Login(string tenTK,string matKhau)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTK = @tenTK AND MatKhau = @matKhau";

            DataTable kq = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTK, matKhau });

            return kq.Rows.Count > 0;
        }

        private void ckHienthiMK_CheckedChanged(object sender, EventArgs e)
        {
            if(ckHienthiMK.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
