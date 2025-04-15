using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }

        public int LayHDTuMaBan(char id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE MaBan = " + id + " AND TinhTrang = 0");

            if (data.Rows.Count > 0)
            {
                HoaDonDTO bill = new HoaDonDTO(data.Rows[0]);
                return bill.IDBan;
            }

            return -1;
        }
    }
}
