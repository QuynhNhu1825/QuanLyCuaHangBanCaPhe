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
        public ThucUongDTO(int ma,string ten,int madm,float gia,int trangthai)
        {
            this.MaTU = ma;
            this.TenTU = ten;
            this.MaDM = madm;
            this.Gia = gia;
            this.TrangThaiTU = trangthai;

            
        }
        public ThucUongDTO(DataRow row)
        {
            MaTU = (int)row["MaTU"];
            TenTU = row["TenTU"].ToString();
            MaDM = (int)row["MaDM"];
            Gia = Convert.ToSingle(row["Gia"]);
            TrangThaiTU= (int)row["TrangThaiTU"];
        }
        private int trangThaiTU;
        private int maTU;
        private string tenTU;
        private int maDM;
        private float gia;

        public int MaTU { get => maTU; set => maTU = value; }
        public string TenTU { get => tenTU; set => tenTU = value; }
        public int MaDM { get => maDM; set => maDM = value; }
        public float Gia { get => gia; set => gia = value; }
        public int TrangThaiTU { get => trangThaiTU; set => trangThaiTU = value; }
    }
}
