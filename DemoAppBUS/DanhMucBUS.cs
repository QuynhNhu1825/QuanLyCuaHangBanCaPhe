using DemoAppDAO;
using DemoAppDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppBUS
{
    public class DanhMucBUS
    {
        private DanhMucDAO dm = new DanhMucDAO();

        public List<DanhMucDTO> LoadDanhmuc()
        {
            return dm.LoadDanhmuc();
        }

        public void LayDanhmucBangID(int id)
        {
            dm.LayDanhMucBangID(id);
        }
        public bool ThemDanhMuc(string tenDM)
        {
            return dm.ThemDanhMuc(tenDM);
        }
        public bool AnDanhMuc(int maDM)
        {
            return dm.AnDanhMuc(maDM);
        }
        public bool SuaDanhMuc(int maDM, string tenDM)
        {
            return dm.SuaDanhMuc(maDM, tenDM);
        }
    }
}
