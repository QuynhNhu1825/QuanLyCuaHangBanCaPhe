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
    public class ThucUongBUS
    {
        private ThucUongDAO tu=new ThucUongDAO();

        public List<ThucUongDTO> LoadThucUongTheoDM(int id)
        {
            return tu.LayDSTUTheoDanhMuc(id);
        }
        public List<ThucUongDTO> LoadThucUong()
        {
            return tu.LayDSTU();
        }
        public bool KiemTraTenTUTonTai(string tenTU)
        {
            return tu.KiemTraTenTUTonTai(tenTU);
        }

        
        public bool ThemThucUong(string ten, int maDM, float gia)
        {
            return tu.ThemThucUong(ten, maDM, gia);
        }
        public bool SuaThucUong(string tenTU, int maDM, float gia, int idTU)
        {
            return tu.SuaThucUong(tenTU, maDM, gia, idTU);
        }
        public bool AnThucUong(int idTU)
        {
            return tu.AnThucUong(idTU);
        }
        public DataTable TimKiemThucUongTheoTen(string tuKhoa)
        {
            return tu.TimKiemThucUongTheoTen(tuKhoa);
        }
    }
}
