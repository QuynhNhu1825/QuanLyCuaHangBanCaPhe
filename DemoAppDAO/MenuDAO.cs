using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppDTO;
namespace DemoAppDAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        public MenuDAO() { }

        public List<MenuDTO> DSMenu(char id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            string query = "SELECT tu.MaTU,tu.TenTU,cthd.SoLuong,tu.Gia,tu.Gia*cthd.SoLuong as ThanhTien FROM HoaDon as hd,ChiTietHoaDon as cthd,ThucUong as tu WHERE hd.MaHD=cthd.MaHD and cthd.MaTU=tu.MaTU and hd.TinhTrangHD=0 and hd.MaBan='" + id+ "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        
    }
}
