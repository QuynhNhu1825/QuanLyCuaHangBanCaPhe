using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class DanhMucDTO
    {
        public DanhMucDTO(int ma,string ten)
        {
            this.MaDM = ma;
            this.TenDM = ten;
        }
        public DanhMucDTO(DataRow row)
        {
            this.MaDM = (int)row["MaDM"];
            this.TenDM = row["TenDM"].ToString();
        }
        private int maDM;
        private string tenDM;

        public int MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
    }
}
