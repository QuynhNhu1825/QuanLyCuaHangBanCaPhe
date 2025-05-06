using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO kh = new KhachHangDAO();
        public bool KhachHangTonTai(int maKH)
        {
            return kh.KhachHangTonTai(maKH);
        }
        public List<KhachHangDTO> LayDSKH()
        {
            return kh.LayDSKH();
        }
        public static bool ThemKhachHang(string tenKH, string diaChi, string sdt, DateTime ngaytao)
        {
            return KhachHangDAO.ThemKhachHang(tenKH, diaChi, sdt, ngaytao);
        }
        public DataTable TimKiemKHTheoTen(string tuKhoa)
        {
            return kh.TimKiemKHTheoTen(tuKhoa);
        }
        public bool SuaKhachHang(int maKH, string tenKH, string diaChi, string sdt)
        {
            return kh.SuaKhachHang(maKH, tenKH, diaChi, sdt);
        }
        public bool XoaKhachHang(int maKH)
        {
            return kh.XoaKhachHang(maKH);
        }

    }
}
