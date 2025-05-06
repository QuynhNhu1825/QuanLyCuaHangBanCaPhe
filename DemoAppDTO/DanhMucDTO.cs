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
        public DanhMucDTO(int ma,string ten,int trangthai)
        {
            this.MaDM = ma;
            this.TenDM = ten;
            this.TrangThaiDM = trangthai;
        }
        public DanhMucDTO(DataRow row)
        {
            this.MaDM = (int)row["MaDM"];
            this.TenDM = row["TenDM"].ToString();
            this.TrangThaiDM= (int)row["TrangThaiDM"];
        }
        private int maDM;
        private string tenDM;
        private int trangThaiDM;
        public int MaDM { get => maDM; set => maDM = value; }
        public string TenDM { get => tenDM; set => tenDM = value; }
        public int TrangThaiDM { get => trangThaiDM; set => trangThaiDM = value; }
    }
}
