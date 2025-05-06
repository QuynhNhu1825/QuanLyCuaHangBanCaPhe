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

        public ThucUongDAO() { }
        public List<ThucUongDTO> LayDSTU()
        {
            List<ThucUongDTO> list = new List<ThucUongDTO>();

            string query = "SELECT * FROM Thucuong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThucUongDTO thucuong = new ThucUongDTO(item);
                list.Add(thucuong);
            }

            return list;
        }
        public List<ThucUongDTO> LayDSTUTheoDanhMuc(int id)
        {
            List<ThucUongDTO> list = new List<ThucUongDTO>();

            string query = "SELECT * FROM ThucUong WHERE MaDM= @id AND TrangThaiTU=1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                ThucUongDTO thucuong = new ThucUongDTO(item);
                list.Add(thucuong);
            }

            return list;
        }

        public bool ThemThucUong(string ten, int maDM, float gia)
        {
            string query = string.Format(
                "INSERT INTO ThucUong (TenTU, MaDM, Gia) VALUES (N'{0}', {1}, {2})", ten, maDM, gia
            );
            int kq = DataProvider.Instance.ExecuteNonQuery(query);

            return kq > 0;
        }
        public bool KiemTraTenTUTonTai(string tenTU)
        {
            string query = "SELECT COUNT(*) FROM ThucUong WHERE TenTU = @tenTU";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenTU });

            int count = Convert.ToInt32(result);
            return count > 0;
        }


        public bool SuaThucUong(string tenTU, int maDM, float gia, int idTU)
        {
            string query = "UPDATE ThucUong SET TenTU = @tenTU, MaDM = @maDM, Gia = @gia WHERE MaTU = @idTU";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTU, maDM, gia, idTU });

            return result > 0;
        }
        public bool AnThucUong(int idTU)
        {
            string query = "UPDATE ThucUong SET TrangThaiTU = 0 WHERE MaTU = @idTU";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idTU });
            return result > 0;
        }
        public DataTable TimKiemThucUongTheoTen(string tuKhoa)
        {
            string query = "SELECT * FROM ThucUong WHERE TrangThaiTU = 1 AND TenTU LIKE @tuKhoa";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + tuKhoa + "%" });
        }

    }
}
