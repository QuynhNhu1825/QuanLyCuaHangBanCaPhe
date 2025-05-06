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

        public HoaDonDAO() { }

        public int LayHDTuMaBan(char id)
        {
            string query = "SELECT * FROM HoaDon WHERE maBan = @id AND TinhTrangHD = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (data.Rows.Count > 0)
            {
                HoaDonDTO bill = new HoaDonDTO(data.Rows[0]);
                return bill.IDHD;
            }

            return -1;
        }
        public void ThemHD(char idban)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_THEMHD @maBan ", new object[] { idban});
        }
        
        public int LayMaxMaHD()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(" SELECT MAX(MaHD) FROM HoaDon ");
            }
            catch
            {
                return 1;
            }
        }

        public void CapNhatHDcheckout(int idhd, int km, DateTime tgra, int? makh,float tongtien)
        {
            string query = @"UPDATE HoaDon 
                     SET TinhTrangHD = 1, 
                         KhuyenMai = @km, 
                         ThoiGianRa = @tgra, 
                         MaKH = @makh,
                         TongTien = @tongtien
                     WHERE MaHD = @idhd";

            object maKhValue = makh.HasValue ? (object)makh.Value : DBNull.Value;
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { km, tgra, maKhValue, tongtien,idhd });
        }

        public List<HoaDonDTO> LayDSHD()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            string query = "SELECT * FROM HoaDon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                HoaDonDTO bill = new HoaDonDTO(item);
                list.Add(bill);
            }
            return list;
        }
        public DataTable LayDSHDBangNgay(DateTime ngayVao, DateTime ngayRa)
        {
            string query = "SELECT hd.MaHD, TenBan, hd.TongTien, hd.ThoiGianVao, hd.ThoiGianRa, hd.KhuyenMai " +
                           "FROM Ban, HoaDon AS hd " +
                           "WHERE Ban.MaBan = hd.MaBan " +
                           "AND hd.ThoiGianVao >= @ngayVao " +
                           "AND hd.ThoiGianRa < @ngayRa " +
                           "AND hd.TinhTrangHD = 1";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { ngayVao, ngayRa });
        }


    }
}
