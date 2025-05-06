using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public bool KhachHangTonTai(int maKH)
        {
            string query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @maKH";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maKH });
            int count = Convert.ToInt32(result);
            return count > 0;
        }
        // Lấy danh sách khách hàng
        public List<KhachHangDTO> LayDSKH()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();

            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO(item);
                list.Add(kh);
            }

            return list;
        }
        //Thêm khách hàng
        public static bool ThemKhachHang(string tenKH, string diaChi, string sdt, DateTime ngaytao)
        {
            string query = "INSERT INTO KhachHang (TenKH, DiaChi, SDT, NgayTao) VALUES (@TenKH, @DiaChi, @SDT, @NgayTao)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKH, diaChi, sdt, ngaytao });

            return result > 0;
        }
        //tim
        public DataTable TimKiemKHTheoTen(string tuKhoa)
        {
            string query = "SELECT * FROM KhachHang WHERE  TenKH LIKE @tuKhoa";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + tuKhoa + "%" });
        }
        //sua 
        public bool SuaKhachHang(int maKH, string tenKH, string diaChi, string sdt)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH, DiaChi = @DiaChi, SDT = @SDT WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKH, diaChi, sdt, maKH });
            return result > 0;
        }
        //xoa
        public bool XoaKhachHang(int maKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH });
            return result > 0;
        }
    }
}
