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
    public partial class fNhanVien: Form
    {
        public fNhanVien()
        {
            InitializeComponent();
            LoadDSKH();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {

        }

        void LoadDSKH()
        {
            string query = "SELECT * FROM KhachHang ";

            dgvKh.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
