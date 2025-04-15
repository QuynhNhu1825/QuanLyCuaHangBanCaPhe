using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class MenuDTO
    {
        public MenuDTO(int id,string ten,int sl,float gia,float thanhtien)
        {
            this.IDTU = id;
            this.TenTU = ten;
            this.SoLuong = sl;
            this.Gia = gia;
            this.ThanhTien = thanhtien;
        }
        public MenuDTO(DataRow row)
        {
            this.IDTU = (int)row["MaTU"];
            this.TenTU = row["TenTU"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString());


        }
        private int iDTU;
        private string tenTU;
        private int soLuong;
        private float gia;
        private float thanhTien;

        public int IDTU { get => iDTU; set => iDTU = value; }
        public string TenTU { get => tenTU; set => tenTU = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float Gia { get => gia; set => gia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
