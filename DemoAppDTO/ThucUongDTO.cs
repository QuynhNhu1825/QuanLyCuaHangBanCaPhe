using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class ThucUongDTO
    {
        public ThucUongDTO(int ma,string ten,int madm,float gia)
        {
            this.MaTU = ma;
            this.TenTU = ten;
            this.MaDM = madm;
            this.Gia = gia;
        }
        public ThucUongDTO(DataRow row)
        {
            this.MaTU = (int)row["MaTU"];
            this.TenTU = row["TenTU"].ToString();
            this.MaTU = (int)row["MaDM"];
            this.Gia= (float)Convert.ToDouble(row["Gia"].ToString());
        }
        private int maTU;
        private string tenTU;
        private int maDM;
        private float gia;

        public int MaTU { get => maTU; set => maTU = value; }
        public string TenTU { get => tenTU; set => tenTU = value; }
        public int MaDM { get => maDM; set => maDM = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
