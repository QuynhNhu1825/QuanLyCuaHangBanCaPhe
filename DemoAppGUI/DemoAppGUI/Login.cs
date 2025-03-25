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
            fQuanLyBan f=new fQuanLyBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
