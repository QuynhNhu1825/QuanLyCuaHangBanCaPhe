using DemoAppDTO;
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
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();

            LoadBan();
        }
        #region Method

        void LoadBan()
        {
            List<BanDTO> dsBan = BanDAO.Instance.LoadDSBan();

            foreach (BanDTO item in dsBan)
            {
                Button btn = new Button() { Width = BanDAO.width, Height = BanDAO.height };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                btn.Click += (sender, e) =>
                {
                    MessageBox.Show($"Bạn đã chọn bàn: {item.Name}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        #endregion

        private void adinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
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
