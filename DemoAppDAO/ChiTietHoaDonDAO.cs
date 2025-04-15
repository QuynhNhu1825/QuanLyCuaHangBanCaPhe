using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class ChiTietHoaDonDAO
    {
            private static ChiTietHoaDonDAO instance;

            public static ChiTietHoaDonDAO Instance
            {
                get { if (instance == null) instance = new ChiTietHoaDonDAO(); return ChiTietHoaDonDAO.instance; }
                private set { ChiTietHoaDonDAO.instance = value; }
            }

            private ChiTietHoaDonDAO() { }

            public List<ChiTietHoaDonDTO> LayDSCTHD(int id)
            {
                List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();

                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ChiTietHoaDon WHERE MaHD = " + id);

                foreach (DataRow item in data.Rows)
                {
                    ChiTietHoaDonDTO info = new ChiTietHoaDonDTO(item);
                    list.Add(info);
                }

                return list;
            }
    }
}
