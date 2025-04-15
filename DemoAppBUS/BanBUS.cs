using DemoAppDTO;
using DemoAppDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class BanBUS
    {
       
        public List<BanDTO> LoadDSBan()
        {
            BanDAO dsban = new BanDAO();
            return dsban.LoadDSBan();
        }
    }
}
