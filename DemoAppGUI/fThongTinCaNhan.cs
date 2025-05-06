using DemoAppDAO;
using DemoAppDTO;
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
    public partial class fThongTinCaNhan : Form
    {
        TaiKhoanDAO tk = new TaiKhoanDAO();
        private TaiKhoanDTO taiKhoan; // biến lưu tài khoản đang đăng nhập
        public TaiKhoanDTO TaiKhoan
        {
            get => taiKhoan;
            set
            {
                taiKhoan = value;
                ThayDoiTK(taiKhoan);
            }
        }
        public fThongTinCaNhan(TaiKhoanDTO tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
        }
        void ThayDoiTK(TaiKhoanDTO tk)
        {
            txtTenDN.Text = tk.TenTK;
            txtTenHT.Text = tk.TenHT;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        void CapNhatTK()
        {   //doi ten HT->nhap pass
            //doi mk->nhap pass->pass moi->nhap lai pass
            string tenTK = txtTenDN.Text;
            string tenHT = txtTenHT.Text;
            string matKhau = txtMK.Text;
            string matKhauMoi = txtMKmoi.Text;
            string matKhauXacNhan = txtNhaplaimk.Text;
            if (!matKhauMoi.Equals(matKhauXacNhan))
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (matKhauMoi.Equals(matKhau))
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (tk.CapNhatTK(tenTK, tenHT, matKhau, matKhauMoi))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenHT.Text = tenHT;
                    if (capNhatTaiKhoan != null)
                    {
                        capNhatTaiKhoan?.Invoke(this, new AccountEvent(tk.LayTKBangTenTK(tenTK)));
                    }
                    txtMK.Clear();
                    txtMKmoi.Clear();
                    txtNhaplaimk.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            CapNhatTK();
        }
        private event EventHandler<AccountEvent> capNhatTaiKhoan;//xu ly cap nhat hien thi tenHT
        public event EventHandler<AccountEvent> CapNhatTaiKhoan
        {
            add { capNhatTaiKhoan += value; }
            remove { capNhatTaiKhoan -= value; }
        }
        private void ckboxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxMK.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }

        private void ckboxMKMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxMKMoi.Checked)
            {
                txtMKmoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKmoi.UseSystemPasswordChar = true;
            }
        }

        private void ckboxNhaplaiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxNhaplaiMK.Checked)
            {
                txtNhaplaimk.UseSystemPasswordChar = false;
            }
            else
            {
                txtNhaplaimk.UseSystemPasswordChar = true;
            }
        }
    }
    public class AccountEvent : EventArgs
    {
        private TaiKhoanDTO taiKhoan;
        public TaiKhoanDTO TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public AccountEvent(TaiKhoanDTO tk)
        {
            this.TaiKhoan = tk;
        }
    }
}
