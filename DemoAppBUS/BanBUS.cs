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
       
        private BanDAO ban=new BanDAO();
        public List<BanDTO> LoadDSBan()
        {
            return ban.LoadDSBan();
        }
        public void ChuyenBan(char idban, char idbanmoi)
        {
            ban.ChuyenBan(idban, idbanmoi);
        }

    }
}
