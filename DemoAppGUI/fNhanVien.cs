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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoAppGUI
{
    public partial class fNhanVien: Form
    {
        BindingSource dskh = new BindingSource();
        public fNhanVien()
        {
            InitializeComponent();
            LoadDSKH();
            KhachHangBUS kh = new KhachHangBUS();
            dskh.DataSource = kh.LayDSKH();
            dgvKh.DataSource = dskh;
            KHBinding();
            //LoadTatCaKH();
        }

        #region Methods
        void LoadDSKH()
        {
            string query = "SELECT * FROM KhachHang ";

            dgvKh.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadTatCaKH()
        {
            string query = "SELECT * FROM KhachHang ";

            dgvKh.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void KHBinding()
        {
            txtIDKH.DataBindings.Add(new Binding("Text", dgvKh.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtTenKH.DataBindings.Add(new Binding("Text", dgvKh.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dgvKh.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvKh.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtNgaytao.DataBindings.Add(new Binding("Text", dgvKh.DataSource, "NgayTao", true, DataSourceUpdateMode.Never));

        }
        #endregion

        #region Events
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnThemKH, "Thêm");
            toolTip.SetToolTip(this.btnXoaKH, "Xóa");
            toolTip.SetToolTip(this.btnSuaKH, "Sửa");
            toolTip.SetToolTip(this.btnLammoi, "Làm mới");
            toolTip.SetToolTip(this.btnThoat, "Thoát");
        }
        private void btnTimKH_Click_1(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKH.Text.Trim();
            KhachHangBUS bus = new KhachHangBUS();
            DataTable dt = bus.TimKiemKHTheoTen(tuKhoa);
            dgvKh.DataSource = dt;
            txtIDKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtNgaytao.DataBindings.Clear();
            txtIDKH.DataBindings.Add("Text", dt, "MaKH");
            txtTenKH.DataBindings.Add("Text", dt, "TenKH");
            txtDiachi.DataBindings.Add("Text", dt, "DiaChi");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtNgaytao.DataBindings.Add("Text", dt, "NgayTao", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy");


            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }
        }

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiachi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            DateTime ngayTao;

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) ||
                !DateTime.TryParse(txtNgaytao.Text.Trim(), out ngayTao))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và định dạng ngày hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            bool kq = KhachHangBUS.ThemKhachHang(tenKH, diaChi, sdt, ngayTao);

            if (kq)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadDSKH();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKH_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                return;
            }

            int maKH = int.Parse(txtIDKH.Text);

            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                KhachHangBUS kh = new KhachHangBUS();
                bool result = kh.XoaKhachHang(maKH);
                if (result)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadDSKH(); // làm mới DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnSuaKH_Click_1(object sender, EventArgs e)
        {
            int maKH = int.Parse(txtIDKH.Text);
            string tenKH = txtTenKH.Text;
            string diaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;



            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin!");
                return;
            }

            // Thực hiện sửa
            KhachHangBUS kh = new KhachHangBUS();
            bool result = kh.SuaKhachHang(maKH, tenKH, diaChi, sdt);

            if (result)
            {
                MessageBox.Show("Sửa khách hàng thành công!");
                LoadTatCaKH(); // Load lại danh sách
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
        }

        private void btnLammoi_Click_1(object sender, EventArgs e)
        {
            LoadTatCaKH();

            KhachHangBUS bUS = new KhachHangBUS();
            List<KhachHangDTO> dt = bUS.LayDSKH();
            dgvKh.DataSource = dt;

            //
            txtIDKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtNgaytao.DataBindings.Clear();

            // Gắn binding mới
            txtIDKH.DataBindings.Add("Text", dt, "MaKH");
            txtTenKH.DataBindings.Add("Text", dt, "TenKH");
            txtDiachi.DataBindings.Add("Text", dt, "DiaChi");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtNgaytao.DataBindings.Add("Text", dt, "NgayTao", true, DataSourceUpdateMode.OnPropertyChanged, "", "dd/MM/yyyy");
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
        #endregion
    }
}
