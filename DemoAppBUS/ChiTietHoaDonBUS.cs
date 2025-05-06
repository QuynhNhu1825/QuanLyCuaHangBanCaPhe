using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAO cthd = new ChiTietHoaDonDAO();
        public List<ChiTietHoaDonDTO> LayDSCTHD(int id)
        {
            return cthd.LayDSCTHD(id);
        }
        public void ThemCTHD(int idhd, int idtu, int sl,float gia,float thanhtien)
        {
            cthd.ThemCTHD(idhd, idtu, sl,gia,thanhtien);
        }
        public void XoaCTHD(int idhd, int idtu)
        {
            cthd.XoaCTHD(idhd, idtu);
        }
    }
}
