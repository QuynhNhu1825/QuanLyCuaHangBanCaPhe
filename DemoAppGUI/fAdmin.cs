using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAppBUS;
using DemoAppDAO;
using DemoAppDTO;
using Microsoft.Reporting.WinForms;

namespace DemoAppGUI
{
    public partial class fAdmin : Form
    {
        BindingSource dsthucuong = new BindingSource();
        BindingSource dsdanhmuc = new BindingSource();
        BindingSource dstk = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            dgvThongke.AutoGenerateColumns = true;
            dgvThucuong.DataSource = dsthucuong;
            dgvDanhmuc.DataSource = dsdanhmuc;
            dgvTK.DataSource = dstk;

            LoadDSTK();
            LoadDSThucUong();
            LoadDSDMThucUong();
            ThemTUBinding();
            DMBinding();
            TKBinding();
            LoadDMVaoCbb(cbDMTU);

            ThucUongBUS bus = new ThucUongBUS();
            List<ThucUongDTO> dstu = bus.LoadThucUong();
            this.rpvDSSP.LocalReport.ReportEmbeddedResource = "DemoAppGUI.Report1.rdlc";
            this.rpvDSSP.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dstu));
            this.rpvDSSP.RefreshReport();
        }

        #region Methods
        void LoadDSHDBangNgay(DateTime ngayVao, DateTime ngayRa)
        {
            dgvThongke.DataSource = HoaDonDAO.Instance.LayDSHDBangNgay(ngayVao, ngayRa);
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            LoadDSHDBangNgay(dtpTungay.Value.Date, dtpDenngay.Value.Date.AddDays(1));// để lấy đến cuối ngày
        }

        void LoadDSTK()
        {
            string query = "SELECT * FROM TaiKhoan ";

            dgvTK.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadDSThucUong()
        {
            string query = "SELECT * FROM ThucUong WHERE TrangThaiTU=1";

            dsthucuong.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadDSDMThucUong()
        {
            string query = "SELECT * FROM DanhMucThucUong WHERE TrangThaiDM = 1";

            dsdanhmuc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void ThemTUBinding()
        {

            txtTenmon.DataBindings.Add(new Binding("Text", dgvThucuong.DataSource, "TenTU", true, DataSourceUpdateMode.Never));
            txtID.DataBindings.Add(new Binding("Text", dgvThucuong.DataSource, "MaTU", true, DataSourceUpdateMode.Never));
            nmrGia.DataBindings.Add(new Binding("Value", dgvThucuong.DataSource, "Gia", true, DataSourceUpdateMode.Never));

        }
        void DMBinding()
        {
            txtIDDM.DataBindings.Add(new Binding("Text", dgvDanhmuc.DataSource, "MaDM", true, DataSourceUpdateMode.Never));
            txtTenDM.DataBindings.Add(new Binding("Text", dgvDanhmuc.DataSource, "TenDM", true, DataSourceUpdateMode.Never));
        }
        void TKBinding()
        {
            txtTenTK.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "TenTK", true, DataSourceUpdateMode.Never));
            txtTenHT.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "TenHT", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "MatKhau", true, DataSourceUpdateMode.Never));
            nmrLoaiTK.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "Loai", true, DataSourceUpdateMode.Never));

        }

        void LoadDMVaoCbb(ComboBox cb)
        {
            cb.DataSource = DanhMucDAO.Instance.LoadDanhmuc();
            cb.DisplayMember = "TenDM";
        }
        #endregion

        #region Events
        private void fAdmin_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnThemTU, "Thêm");
            toolTip1.SetToolTip(this.btnXoaTU, "Xóa");
            toolTip1.SetToolTip(this.btnSuaTU, "Sửa");
            toolTip1.SetToolTip(this.btnXemTU, "Xem");
            toolTip1.SetToolTip(this.btnThemDM, "Thêm");
            toolTip1.SetToolTip(this.btnXoaDM, "Xóa");
            toolTip1.SetToolTip(this.btnSuaDM, "Sửa");
            toolTip1.SetToolTip(this.btnXemDM, "Xem");
            toolTip1.SetToolTip(this.btnTim, "Tìm kiếm");
            toolTip1.SetToolTip(this.btnThemTK, "Thêm");
            toolTip1.SetToolTip(this.btnXoaTK, "Xóa");
            toolTip1.SetToolTip(this.btnSuaTK, "Sửa");
            toolTip1.SetToolTip(this.btnXemTK, "Xem");
            this.rpvDSSP.RefreshReport();
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThucuong.SelectedCells.Count > 0)
                {

                    int id = (int)dgvThucuong.SelectedCells[0].OwningRow.Cells["MaDM"].Value;
                    DanhMucDTO danhmuc = DanhMucDAO.Instance.LayDanhMucBangID(id);
                    cbDMTU.SelectedItem = danhmuc;
                    int index = -1;
                    int i = 0;
                    foreach (DanhMucDTO item in cbDMTU.Items)
                    {
                        if (danhmuc != null)
                        {
                            if (item.MaDM == danhmuc.MaDM)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                    }
                    cbDMTU.SelectedIndex = index;

                }
            }
            catch { }
        }
        private void btnThemTU_Click_1(object sender, EventArgs e)
        {
            string tenTU = txtTenmon.Text;
            int maDM = (cbDMTU.SelectedItem as DanhMucDTO).MaDM;
            float gia = float.Parse(nmrGia.Text);

            if (string.IsNullOrEmpty(tenTU) || maDM <= 0 || gia < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ các thông tin!");
                return;
            }

            ThucUongBUS thucUongBUS = new ThucUongBUS();

            // ✅ Kiểm tra trước khi thêm
            if (thucUongBUS.KiemTraTenTUTonTai(tenTU))
            {
                MessageBox.Show("Tên thức uống đã tồn tại. Vui lòng nhập tên khác!");
                return;
            }

            bool result = thucUongBUS.ThemThucUong(tenTU, maDM, gia);

            if (result)
            {
                MessageBox.Show("Thêm thức uống thành công!");
                thucUongBUS.LoadThucUongTheoDM(maDM);
            }
            else
            {
                MessageBox.Show("Thêm thức uống thất bại!");
            }
        }

        private void btnXoaTU_Click_1(object sender, EventArgs e)
        {
            int idTU = int.Parse(txtID.Text); // Hoặc lấy từ dòng đang chọn trong DataGridView

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa thức uống này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                return;

            ThucUongBUS thucUongBUS = new ThucUongBUS();
            bool result = thucUongBUS.AnThucUong(idTU);

            if (result)
            {
                MessageBox.Show("Xóa thức uống thành công!");
                LoadDSThucUong(); // Load lại danh sách
            }
            else
            {
                MessageBox.Show("Xóa thức uống thất bại!");
            }
        }

        private void btnSuaTU_Click_1(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string tenTU = txtTenmon.Text;
            int maDM = (cbDMTU.SelectedItem as DanhMucDTO).MaDM;
            float gia = (float)nmrGia.Value;
            int idTU = int.Parse(txtID.Text); // ID lấy từ datagridview hoặc textbox ẩn

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(tenTU) || maDM <= 0 || gia < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ thông tin!");
                return;
            }

            // Thực hiện sửa
            ThucUongBUS thucUongBUS = new ThucUongBUS();
            bool result = thucUongBUS.SuaThucUong(tenTU, maDM, gia, idTU);

            if (result)
            {
                MessageBox.Show("Sửa thức uống thành công!");
                LoadDSThucUong(); // Load lại danh sách
            }
            else
            {
                MessageBox.Show("Sửa thức uống thất bại!");
            }
        }

        private void btnXemTU_Click_1(object sender, EventArgs e)
        {
            LoadDSThucUong();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            ThucUongBUS bus = new ThucUongBUS();
            DataTable dt = bus.TimKiemThucUongTheoTen(tuKhoa);
            dgvThucuong.DataSource = dt;
            dgvThucuong.DataSource = dt;
            txtID.DataBindings.Clear();
            txtTenmon.DataBindings.Clear();
            cbDMTU.DataBindings.Clear();
            nmrGia.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dt, "MaTU");
            txtTenmon.DataBindings.Add("Text", dt, "TenTU");
            cbDMTU.DataBindings.Add("Text", dt, "TenDM");
            nmrGia.DataBindings.Add("Text", dt, "Gia");

        }

        private void btnThemDM_Click_1(object sender, EventArgs e)
        {
            string tenDM = txtTenDM.Text.Trim();

            if (string.IsNullOrEmpty(tenDM))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!");
                return;
            }

            DanhMucBUS bus = new DanhMucBUS();
            bool result = bus.ThemDanhMuc(tenDM);

            if (result)
            {
                MessageBox.Show("Thêm danh mục thành công!");
                LoadDSDMThucUong(); // Làm mới DataGridView 
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại!");
            }
        }

        private void btnXoaDM_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa!");
                return;
            }

            int maDM = int.Parse(txtIDDM.Text);

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn ẩn danh mục này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                DanhMucBUS bus = new DanhMucBUS();
                bool result = bus.AnDanhMuc(maDM);

                if (result)
                {
                    MessageBox.Show("Xóa(Ẩn) danh mục thành công!");
                    LoadDSDMThucUong(); // Làm mới danh sách
                }
                else
                {
                    MessageBox.Show("Xóa danh mục thất bại!");
                }
            }
        }

        private void btnSuaDM_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDDM.Text) || string.IsNullOrEmpty(txtTenDM.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục và chỉnh sửa!");
                return;
            }

            int maDM = int.Parse(txtIDDM.Text);
            string tenDM = txtTenDM.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn sửa danh mục này?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                DanhMucBUS bus = new DanhMucBUS();
                bool result = bus.SuaDanhMuc(maDM, tenDM);

                if (result)
                {
                    MessageBox.Show("Sửa danh mục thành công!");
                    LoadDSDMThucUong();
                }
                else
                {
                    MessageBox.Show("Sửa danh mục thất bại!");
                }
            }
        }

        private void btnXemDM_Click_1(object sender, EventArgs e)
        {
            LoadDSDMThucUong();
        }

        private void btnThemTK_Click_1(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            string tenHT = txtTenHT.Text;
            string matKhau = txtMatKhau.Text;
            int loai = (int)nmrLoaiTK.Value;
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            bool result = tkBUS.ThemTaiKhoan(tenTK, tenHT, matKhau, loai);


            if (string.IsNullOrWhiteSpace(tenTK) || string.IsNullOrWhiteSpace(tenHT) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            //Thêm

            if (result)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadDSTK(); // load lại danh sách tài khoản nếu có DataGridView
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }

        private void btnXoaTK_Click_1(object sender, EventArgs e)
        {
            string tenTK = dgvTK.CurrentRow.Cells["TenTK"].Value.ToString();

            if (string.IsNullOrWhiteSpace(tenTK))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                TaiKhoanBUS tkBUS = new TaiKhoanBUS();
                bool result = tkBUS.XoaTaiKhoan(tenTK);
                if (result)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    LoadDSTK();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!");
                }
            }
        }

        private void btnSuaTK_Click_1(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            string tenHT = txtTenHT.Text;
            string matKhau = txtMatKhau.Text;
            int loai = (int)nmrLoaiTK.Value;

            if (string.IsNullOrWhiteSpace(tenTK))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                TaiKhoanBUS tkBUS = new TaiKhoanBUS();
                bool result = tkBUS.SuaTaiKhoan(tenTK, tenHT, matKhau, loai);
                if (result)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    LoadDSTK(); // Hàm này reload danh sách
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private void btnXemTK_Click_1(object sender, EventArgs e)
        {
            LoadDSTK();
        }



        #endregion

       
    }
}
    

