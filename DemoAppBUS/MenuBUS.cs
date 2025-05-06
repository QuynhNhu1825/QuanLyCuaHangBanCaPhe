using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class MenuBUS
    {
        private MenuDAO menu = new MenuDAO();
        public List<MenuDTO> LayDSMenu(char id)
        {
            return menu.DSMenu(id);
        }

    }
}
