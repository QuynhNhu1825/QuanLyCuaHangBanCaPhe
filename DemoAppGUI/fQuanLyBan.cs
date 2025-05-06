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
using System.Security.Claims;

namespace DemoAppGUI
{
    public partial class fQuanLyBan : Form
    {
        private Timer timer;
        private List<BanDTO> dsBan;
        private BanBUS ban = new BanBUS();

        private HoaDonBUS hd = new HoaDonBUS();

        private KhachHangBUS kh = new KhachHangBUS();

        private BanDTO banDangChon; // biến lưu bàn đang chọn
        private TaiKhoanDTO taiKhoan; // biến lưu tài khoản đang đăng nhập
        public TaiKhoanDTO TaiKhoan
        {
            get => taiKhoan;
            set
            {
                taiKhoan = value;
                ThayDoiTK(taiKhoan.Loai); 
            }
        }

        public fQuanLyBan(TaiKhoanDTO tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
            if (TaiKhoan != null)
            {
                lblHienthiTen.Text = $"Xin chào {TaiKhoan.TenHT}";
            }
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += timer1_Tick;
            timer.Start();
            LoadBan();
            LoadDanhmuc();
            LoadComboxTable(cbbChuyenBan, dsBan);

        }

        #region Methods
        void ThayDoiTK(int loai)
        {
            adminToolStripMenuItem.Enabled = loai == 1;
        }
        void LoadBan()
        {

            flowLayoutPanel1.Controls.Clear(); // Xóa các button cũ trong flowLayoutPanel1

            dsBan = ban.LoadDSBan();

            foreach (BanDTO item in dsBan)
            {
                Button btn = new Button() 
                {   Width = BanDAO.width, 
                    Height = BanDAO.height,
                    TextAlign = ContentAlignment.BottomCenter,
                    ImageAlign = ContentAlignment.MiddleCenter,
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_BanClick;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.Image = imgBan.Images[7];// Hình ảnh bàn trống
                        btn.BackColor = Color.White;

                        break;
                    default:
                        btn.Image = imgBan.Images[8]; // Hình ảnh bàn có khách
                        btn.BackColor = Color.White;
                        break;
                }
                

                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        void btn_BanClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.Tag == null)
                return;

            BanDTO ban = btn.Tag as BanDTO;
            if (ban == null)
                return;

            // Gán bàn đang chọn để dùng trong các thao tác khác
            banDangChon = ban;

            // Gán vào Tag của dgvCTHD (nếu bạn vẫn sử dụng nó)
            dgvCTHD.Tag = ban;

            // Gọi hàm hiển thị hóa đơn theo mã bàn
            HTHoaDon(ban.ID);
        }
        void HTHoaDon(char id)
        {
            float tongtien = 0;
            dgvCTHD.Rows.Clear(); // Xóa dòng cũ 
            dgvCTHD.Columns.Clear(); // Xóa cột cũ 

            dgvCTHD.Columns.Add("MaTU", "Mã TU");
            dgvCTHD.Columns.Add("TenTU", "Tên thức uống");
            dgvCTHD.Columns.Add("SoLuong", "Số lượng");
            dgvCTHD.Columns.Add("Gia", "Giá");
            dgvCTHD.Columns.Add("ThanhTien", "Thành tiền");

            List<MenuDTO> list = MenuDAO.Instance.DSMenu(id);

            foreach (MenuDTO item in list)
            {
                tongtien += item.ThanhTien;
                dgvCTHD.Rows.Add(
                    item.MaTU.ToString(),
                    item.TenTU,
                    item.SoLuong,
                    item.Gia,
                    item.ThanhTien
                );
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongTien.Text = tongtien.ToString("c", culture);

        }

        void LoadDanhmuc()
        {
            List<DanhMucDTO> listDM = DanhMucDAO.Instance.LoadDanhmuc();

            cbDanhmuc.DataSource = listDM;
            cbDanhmuc.DisplayMember = "TenDM";
            cbDanhmuc.ValueMember = "MaDM";

        }
        void LoadDSTUBangMaDM(int id)
        {

            List<ThucUongDTO> dsTU = ThucUongDAO.Instance.LayDSTUTheoDanhMuc(id);
            cbThucuong.DataSource = dsTU;
            cbThucuong.DisplayMember = "TenTU";  
            cbThucuong.ValueMember = "MaTU";
        }
        void LoadComboxTable(ComboBox cb, List<BanDTO> list)
        {
            cb.DataSource = list;
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        void f_CapNhatTaiKhoan(object sender, AccountEvent e)
        {
            lblHienthiTen.Text = $"Xin chào {e.TaiKhoan.TenHT}";
        }

        #endregion

        #region Events
        private void fQuanLyBan_Load(object sender, EventArgs e)
        {
            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.Columns.Clear();

        }
        
        private void adinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan f = new fThongTinCaNhan(TaiKhoan);
            f.CapNhatTaiKhoan += f_CapNhatTaiKhoan;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        

        private void cbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DanhMucDTO selected = cb.SelectedItem as DanhMucDTO;
            int id = selected.MaDM;

            // Chỉ load khi danh mục hợp lệ
            if (id > 0)
            {
                LoadDSTUBangMaDM(id);

                // Tự động chọn món đầu tiên nếu có
                if (cbThucuong.Items.Count > 0)
                    cbThucuong.SelectedIndex = 0;
            }


        }

        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cbDanhmuc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục thức uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbThucuong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thức uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BanDTO ban = dgvCTHD.Tag as BanDTO;
            if (ban == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHD = HoaDonDAO.Instance.LayHDTuMaBan(ban.ID);
            int idTU = (cbThucuong.SelectedItem as ThucUongDTO).MaTU;
            int sl = (int)numericSL.Value;
            float gia = (cbThucuong.SelectedItem as ThucUongDTO).Gia;
            float thanhtien = sl * gia;
            

            if (idHD == -1)
            {
                // Chưa có hóa đơn => tạo mới
                HoaDonDAO.Instance.ThemHD(ban.ID);
                idHD = HoaDonDAO.Instance.LayHDTuMaBan(ban.ID); // Lấy lại id hóa đơn mới tạo
            }

            ChiTietHoaDonDAO.Instance.ThemCTHD(idHD, idTU, sl,gia,thanhtien);

            // Cập nhật lại giao diện hóa đơn
            
            HTHoaDon(ban.ID);
            LoadBan(); // Cập nhật lại trạng thái bàn

        }

        private void btnXoamon_Click(object sender, EventArgs e)
        {
            if (banDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn một bàn có khách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCTHD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chi tiết hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maTU = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["MaTU"].Value);
            int maHD = HoaDonDAO.Instance.LayHDTuMaBan(banDangChon.ID);

            if (maHD == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            bool deleted = ChiTietHoaDonDAO.Instance.XoaCTHD(maHD, maTU);

            if (deleted)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại hóa đơn + tổng tiền
                HTHoaDon(banDangChon.ID);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            if (banDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn một bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHD = HoaDonDAO.Instance.LayHDTuMaBan(banDangChon.ID);

            if (maHD == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả chi tiết trong hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            bool success = ChiTietHoaDonDAO.Instance.XoaTatCaCTHD(maHD);

            if (success)
            {
                MessageBox.Show("Đã làm mới hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HTHoaDon(banDangChon.ID); // Load lại chi tiết hóa đơn
            }
            else
            {
                MessageBox.Show("Làm mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DateTime tgra = DateTime.Now;
            int maHD = hd.LayHDTuMaBan(banDangChon.ID);
            int km = (int)nmrGiamGia.Value;

            CultureInfo culture = new CultureInfo("vi-VN");

            // Xử lý tổng tiền
            string rawText = txtTongTien.Text.Replace("₫", "").Replace(".", "").Trim();
            if (!double.TryParse(rawText, NumberStyles.Number, culture, out double tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tongTienSauKM = tongTien - (tongTien / 100) * km;

            // Xử lý mã khách hàng
            int? makh = null;

            if (!string.IsNullOrEmpty(txtMaKH.Text.Trim()))
            {
                if (!int.TryParse(txtMaKH.Text.Trim(), out int makhTmp))
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!kh.KhachHangTonTai(makhTmp))
                {
                    MessageBox.Show("Không tìm thấy khách hàng với mã đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                makh = makhTmp;
            }

            if (maHD == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xử lý tiền khách đưa
            string rawTienKhachDua = txtTienKD.Text.Replace("₫", "").Replace(".", "").Trim();
            if (!double.TryParse(rawTienKhachDua, NumberStyles.Number, culture, out double tienKhachDua))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tienKhachDua < tongTienSauKM)
            {
                MessageBox.Show("Số tiền khách đưa không đủ để thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính tiền thối lại
            double tienThoiLai = tienKhachDua - tongTienSauKM;

            DialogResult result = MessageBox.Show(string.Format(
                "Bạn có chắc chắn muốn thanh toán hóa đơn cho bàn {0}?" +
                "\n Mã khách hàng: {1}" +
                "\n Tổng tiền: {2:N0} VND" +
                "\n Giảm giá: {3}%" +
                "\n Thành tiền: {4:N0} VND" +
                "\n Tiền khách đưa: {5:N0} VND" +
                "\n Tiền gửi khách: {6:N0} VND",
                banDangChon.Name,
                makh,
                tongTien,
                km,
                tongTienSauKM,
                tienKhachDua,
                tienThoiLai),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            // Cập nhật hóa đơn và giao diện
            hd.CapNhatHDcheckout(maHD, km, tgra, makh,(float)tongTienSauKM);
            LoadBan();
            HTHoaDon(banDangChon.ID);

            txtTienGK.Text = tienThoiLai.ToString("N0", culture) + " ₫";

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset các ô nhập liệu
            txtTienGK.Text = "";
            txtTienKD.Text = "";
            txtMaKH.Text = "";
            nmrGiamGia.Value = 0;
        }

        private void txtTienKD_TextChanged(object sender, EventArgs e)
        {
            txtTienKD.TextChanged -= txtTienKD_TextChanged; // Tạm ngắt kết nối sự kiện để tránh vòng lặp

            string raw = txtTienKD.Text.Replace(".", "").Replace("₫", "").Trim();
            if (double.TryParse(raw, out double value))
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                txtTienKD.Text = value.ToString("N0", culture) + " ₫";
                txtTienKD.SelectionStart = txtTienKD.Text.Length - 2; // Đặt con trỏ trước " ₫"
            }

            txtTienKD.TextChanged += txtTienKD_TextChanged; // Kết nối lại sự kiện

            // Đồng thời xử lý tiền thối
            UpdateTienThoi();
        }

        private void UpdateTienThoi()
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            string rawTong = txtTongTien.Text.Replace("₫", "").Trim();
            if (!double.TryParse(rawTong, NumberStyles.Number, culture, out double tongTien)) return;

            int km = (int)nmrGiamGia.Value;
            double tongTienSauKM = tongTien - (tongTien * km / 100);

            string rawTienKhachDua = txtTienKD.Text.Replace(".", "").Replace("₫", "").Trim();
            if (!double.TryParse(rawTienKhachDua, NumberStyles.Number, culture, out double tienKhachDua))
            {
                txtTienGK.Text = "";
                return;
            }

            if (tienKhachDua >= tongTienSauKM)
            {
                double tienThoi = tienKhachDua - tongTienSauKM;
                txtTienGK.Text = tienThoi.ToString("N0", culture) + " ₫";
            }
            else
            {
                txtTienGK.Text = "";
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            char ban1 = (dgvCTHD.Tag as BanDTO).ID;
            char ban2 = (cbbChuyenBan.SelectedItem as BanDTO).ID;
            if (ban1 == ban2)
            {
                MessageBox.Show("Vui lòng chọn bàn khác để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbChuyenBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (banDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn có khách trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn chuyển bàn {0} sang bàn {1}?",
                (dgvCTHD.Tag as BanDTO).Name, (cbbChuyenBan.SelectedItem as BanDTO).Name), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            ban.ChuyenBan(ban1, ban2);
            LoadBan();
        }




        #endregion

        
    }
}
