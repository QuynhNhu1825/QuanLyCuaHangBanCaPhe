using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance
        {
            get { if (instance == null) instance = new DanhMucDAO(); return DanhMucDAO.instance; }
            private set { DanhMucDAO.instance = value; }
        }

        public DanhMucDAO() { }

        public List<DanhMucDTO> LoadDanhmuc()
        {
            List<DanhMucDTO> list = new List<DanhMucDTO>();

            string query = "SELECT * FROM DanhMucThucUong WHERE TrangThaiDM=1" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DanhMucDTO danhmuc = new DanhMucDTO(item);
                list.Add(danhmuc);
            }

            return list;
        }
        public DanhMucDTO LayDanhMucBangID(int id)
        {
            DanhMucDTO danhmuc = null;
            string query = "SELECT * FROM DanhMucThucUong WHERE MaDM= @id AND TrangThaiDM=1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                danhmuc = new DanhMucDTO(item);

            }
            return danhmuc;
        }
        public bool ThemDanhMuc(string tenDM)
        {
            string query = "INSERT INTO DanhMucThucUong (TenDM) VALUES (@tenDM)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDM });
            return result > 0;
        }
        public bool AnDanhMuc(int maDM)
        {
            string query = "UPDATE DanhMucThucUong SET TrangThaiDM = 0 WHERE MaDM = @maDM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDM });
            return result > 0;
        }
        public bool SuaDanhMuc(int maDM, string tenDM)
        {
            string query = "UPDATE DanhMucThucUong SET TenDM = @tenMoi WHERE MaDM = @maDM AND TrangThaiDM = 1";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDM, maDM });
            return result > 0;
        }

    }
}
