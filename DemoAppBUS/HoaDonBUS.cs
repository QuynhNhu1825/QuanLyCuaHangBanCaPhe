using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class HoaDonBUS
    {

        private HoaDonDAO hd = new HoaDonDAO();
        
        public int LayHDTuMaBan(char id)
        {
            return hd.LayHDTuMaBan(id);
        }
        public void ThemHD(char idban)
        {
            hd.ThemHD(idban);
        }
        public int LayMaxMaHD()
        {
            return hd.LayMaxMaHD();
        }
        public void CapNhatHDcheckout(int idhd,int km,DateTime tgra,int? makh,float tongtien)
        {
            hd.CapNhatHDcheckout(idhd,km,tgra,makh,tongtien);
        }
        public List<HoaDonDTO> LayDSHD()
        {
            return hd.LayDSHD();
        }
    }
}
