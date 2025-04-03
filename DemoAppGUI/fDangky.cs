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
    public partial class fDangky: Form
    {
        public fDangky()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void ckHTMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatkhau.UseSystemPasswordChar = false;
        }
    }
}
