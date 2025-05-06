using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO tk = new TaiKhoanDAO();
        public bool Login(string tenTK, string matKhau)
        {
            return tk.Login(tenTK, matKhau);
        }
        public TaiKhoanDTO LayTKBangTenTK(string tenTK)
        {
            return tk.LayTKBangTenTK(tenTK);
        }
        public bool CapNhatTK(string tenTK, string tenHT, string matKhau, string mkmoi)
        {
            return tk.CapNhatTK(tenTK, tenHT, matKhau, mkmoi);
        }
        public List<TaiKhoanDTO> LoadDSTK()
        {
            return tk.LoadDSTK();
        }
        public bool ThemTaiKhoan(string tenTK, string tenHT, string matKhau, int loai)
        {
            return tk.ThemTaiKhoan(tenTK, tenHT, matKhau, loai);
        }
        public bool XoaTaiKhoan(string tenTK)
        {
            return tk.XoaTaiKhoan(tenTK);
        }
        public bool SuaTaiKhoan(string tenTK, string tenHT, string matKhau, int loai)
        {
            return tk.SuaTaiKhoan(tenTK, tenHT, matKhau, loai);

        }
    }
}
