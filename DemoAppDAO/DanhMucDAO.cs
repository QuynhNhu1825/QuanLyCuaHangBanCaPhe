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

        private DanhMucDAO() { }

        public List<DanhMucDTO> LoadDanhmuc()
        {
            List<DanhMucDTO> list = new List<DanhMucDTO>();

            string query = "SELECT * FROM DanhMucThucUong" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DanhMucDTO danhmuc = new DanhMucDTO(item);
                list.Add(danhmuc);
            }

            return list;
        }
    }
}
