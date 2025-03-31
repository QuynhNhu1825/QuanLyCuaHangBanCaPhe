using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAppDAO;

namespace DemoAppGUI
{
    public partial class fAdmin: Form
    {

        public fAdmin()
        {
            InitializeComponent();
            LoadDSTK();
            LoadDSBan();
            LoadDSThucUong();
            LoadDSDMThucUong();
        }

        void LoadDSTK()
        {
            string query = "SELECT * FROM TaiKhoan ";

            dgvTK.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadDSBan()
        {
            string query = "SELECT * FROM Ban ";

            dgvBan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadDSThucUong()
        {
            string query = "SELECT * FROM ThucUong ";

            dgvThucuong.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadDSDMThucUong()
        {
            string query = "SELECT * FROM DanhMucThucUong ";

            dgvDanhmuc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
