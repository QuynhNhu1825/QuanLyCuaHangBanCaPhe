using DemoAppBUS;
using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppGUI
{
    public partial class frmLogin : Form
    {

        private TaiKhoanBUS tk = new TaiKhoanBUS();
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Close();
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = txtName.Text;
            string matKhau = txtPass.Text;
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (Login(tenTK, matKhau))
            {
                TaiKhoanDTO TKDN = TaiKhoanDAO.Instance.LayTKBangTenTK(tenTK);
                fQuanLyBan f = new fQuanLyBan(TKDN);

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên TK hoặc MK!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Login(string tenTK, string matKhau)
        {
            return tk.Login(tenTK, matKhau);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void ckHienthiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienthiMK.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // cho phép chữ, số và các ký tự như @, _, -
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '_' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
