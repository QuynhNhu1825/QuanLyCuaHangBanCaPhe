using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class ThucUongDAO
    {

        private static ThucUongDAO instance;

        public static ThucUongDAO Instance
        {
            get { if (instance == null) instance = new ThucUongDAO(); return ThucUongDAO.instance; }
            private set { ThucUongDAO.instance = value; }
        }

        private ThucUongDAO() { }

        public List<ThucUongDTO> LoadThucuong(int id)
        {
            List<ThucUongDTO> list = new List<ThucUongDTO>();

            string query = "SELECT * FROM Thucuong WHERE MaDM = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThucUongDTO thucuong = new ThucUongDTO(item);
                list.Add(thucuong);
            }

            return list;
        }

    }
}
