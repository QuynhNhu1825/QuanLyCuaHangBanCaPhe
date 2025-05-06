using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class ChiTietHoaDonDTO
    {
        public ChiTietHoaDonDTO(int idhd,int idtu,int sl,float gia,float thanhtien)
        {
            this.IDHD = idhd;
            this.IDTU = idtu;
            this.SoLuong = sl;
            this.DonGia = gia;
            this.ThanhTien = thanhtien;
            
        }
        public ChiTietHoaDonDTO(DataRow row)
        {
            this.IDHD = (int)row["MaHD"];
            this.IDTU = (int)row["MaTU"];
            this.SoLuong = (int)row["SoLuong"];
            this.DonGia = (float)Convert.ToDouble(row["DonGia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString());
            
        }
        private int iDHD;
        private int iDTU;
        private int soLuong;
        private float donGia;
        private float thanhTien;
        

        public int IDHD { get => iDHD; set => iDHD = value; }
        public int IDTU { get => iDTU; set => iDTU = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        
    }
}
