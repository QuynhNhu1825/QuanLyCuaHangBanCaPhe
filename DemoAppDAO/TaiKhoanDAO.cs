using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        public TaiKhoanDAO(){}

        public bool Login(string tenTK, string matKhau)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTK = @tenTK AND MatKhau = @matKhau";

            DataTable kq = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTK, matKhau });

            return kq.Rows.Count > 0;
        }
        public TaiKhoanDTO LayTKBangTenTK(string tenTK)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTK = @tenTK";
            DataTable kq = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTK });
            if (kq.Rows.Count > 0)
            {
                return new TaiKhoanDTO(kq.Rows[0]);
            }
            return null;
        }
        public bool CapNhatTK(string tenTK,string tenHT,string matKhau,string mkmoi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_CapNhatTK @tenTK , @tenHT , @matKhau,@matKhauMoi", new object[] { tenTK,tenHT, matKhau,mkmoi });
            return result > 0;
        }
        //Load DS Tài khoản
        public List<TaiKhoanDTO> LoadDSTK()
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();

            string query = "SELECT * FROM TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                list.Add(tk);
            }
            return list;
        }

        //Thêm tài khoản
        public bool ThemTaiKhoan(string tenTK, string tenHT, string matKhau, int loai)
        {
            string query = "INSERT INTO TaiKhoan (TenTK, TenHT, MatKhau, Loai) VALUES (@tenTK, @tenHT, @matKhau, @loai)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTK, tenHT, matKhau, loai });
            return result > 0;
        }
        //Xóa tài khoản
        public bool XoaTaiKhoan(string tenTK)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenTK = @tenTK";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenTK });
            return result > 0;
        }
        //Sửa tài khoản
        public bool SuaTaiKhoan(string tenTK, string tenHT, string matKhau, int loai)
        {
            string query = "UPDATE TaiKhoan SET TenHT = @tenHT , MatKhau = @matKhau , Loai = @loai WHERE TenTK = @tenTK";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenHT, matKhau, loai, tenTK });
            return result > 0;
        }
    }
}
