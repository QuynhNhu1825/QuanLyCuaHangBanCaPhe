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
        public HoaDonDTO(int idhd,DateTime tgvao,DateTime? tgra,char idban,int idkh,int status,int km,float tt)
        {
            this.IDHD = idhd;
            this.ThoiGianVao = tgvao;
            this.ThoiGianRa = tgra;
            this.IDBan = idban;
            this.IDKH = idkh;
            this.TinhTrang = status;
            this.KhuyenMai = km;
            this.TongTien = tt;
        }
        public HoaDonDTO(DataRow row)
        {
            this.IDHD = (int)row["MaHD"];
            this.ThoiGianVao = (DateTime)row["ThoiGianVao"];
            this.ThoiGianRa = row["ThoiGianRa"] == DBNull.Value ? (DateTime?)null : (DateTime?)row["ThoiGianRa"];
            this.IDBan = row["MaBan"].ToString()[0];
            this.IDKH = row["MaKH"] == DBNull.Value ? 0 : (int)row["MaKH"];
            this.TinhTrang = (int)row["TinhTrangHD"];
            this.KhuyenMai = row["KhuyenMai"] == DBNull.Value ? 0 : (int)row["KhuyenMai"];
            this.TongTien = row["TongTien"] == DBNull.Value ? 0 : (float)row["TongTien"];
        }
        private int iDHD;
        private DateTime thoiGianVao;
        private DateTime? thoiGianRa;//? cho phep null
        private char iDBan;
        private int iDKH;
        private int tinhTrang;
        private int khuyenMai;
        private float tongTien;

        public DateTime ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int IDHD { get => iDHD; set => iDHD = value; }
        public char IDBan { get => iDBan; set => iDBan = value; }
        public int IDKH { get => iDKH; set => iDKH = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
