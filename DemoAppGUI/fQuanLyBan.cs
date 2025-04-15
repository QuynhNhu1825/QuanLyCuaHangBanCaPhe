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
using System.Globalization;
using DemoAppBUS;

namespace DemoAppGUI
{
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();

            LoadBan();
            LoadDanhmuc();
        }
        BanBUS ban = new BanBUS();
        List<BanDTO> dsBan;
        #region Method

        void LoadBan()
        {

            List<BanDTO> dsBan = BanDAO.Instance.LoadDSBan();

            foreach (BanDTO item in dsBan)
            {
                Button btn = new Button() { Width = BanDAO.width, Height = BanDAO.height };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        btn.Image = Properties.Resources.download__9_;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                

                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        void HTHoaDon(char id)
        {
            float tongtien = 0;
            lsvCTHD.Items.Clear();
            List<MenuDTO> list = MenuDAO.Instance.DSMenu(id);

            foreach (MenuDTO item in list)
            {
                ListViewItem lsvItem = new ListViewItem(item.IDTU.ToString());
                lsvItem.SubItems.Add(item.TenTU.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                tongtien += item.ThanhTien;
                lsvCTHD.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN"); //chuyen doi van hoa qua tieng viet

            txtTongTien.Text = tongtien.ToString("c",culture);
        }
        void LoadDanhmuc()
        {

        }
        void LoadDSTU(int id)
        {

        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            char maBan = ((sender as Button).Tag as BanDTO).ID;
            HTHoaDon(maBan);
        }
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
        #endregion

        private void nmrGiamGia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            LoadDSTU(id);
        }
    }
}
