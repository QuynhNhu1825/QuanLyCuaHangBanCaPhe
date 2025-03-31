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
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan f = new fThongTinCaNhan();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            f.ShowDialog();
        }
    }
}
