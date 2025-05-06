using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public ChiTietHoaDonDAO() { }

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
        public void ThemCTHD(int idhd, int idtu, int sl,float gia,float thanhtien)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_THEMCTHD @maHD, @maTU, @sl,@gia,@thanhtien", new object[] { idhd, idtu, sl,gia,thanhtien});
        }
        public bool XoaCTHD(int idhd, int idtu)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaHD = @maHD AND MaTU = @maTU";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhd, idtu });
            return result > 0;
        }
        public bool XoaTatCaCTHD(int idhd)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaHD = @maHD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhd });
            return result > 0;
        }
    }
}
