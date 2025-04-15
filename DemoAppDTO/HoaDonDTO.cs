using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO(int idhd,DateTime tgvao,DateTime? tgra,char idban,char idkh,int status)
        {
            this.IDHD = idhd;
            this.ThoiGianVao = tgvao;
            this.ThoiGianRa = tgra;
            this.IDBan = idban;
            this.IDKH = idkh;
            this.TinhTrang = status;
        }
        public HoaDonDTO(DataRow row)
        {
            this.IDHD = (int)row["MaHD"];
            this.ThoiGianVao = (DateTime)row["ThoiGianVao"];
            this.ThoiGianRa = (DateTime?)row["ThoiGianRa"];
            this.IDBan = row["MaBan"].ToString()[0];
            this.IDKH = row["MaKH"].ToString()[0];
            this.TinhTrang = (int)row["TinhTrangHD"];
        }
        private int iDHD;
        private DateTime thoiGianVao;
        private DateTime? thoiGianRa;//? cho phep null
        private char iDBan;
        private char iDKH;
        private int tinhTrang;

        
        public DateTime ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int IDHD { get => iDHD; set => iDHD = value; }
        public char IDBan { get => iDBan; set => iDBan = value; }
        public char IDKH { get => iDKH; set => iDKH = value; }
    }
}
