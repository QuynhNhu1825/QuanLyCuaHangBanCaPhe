using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO(int makh,string tenkh,string dc,string sdt,DateTime ngaytao) 
        {
            this.maKH = makh;
            this.tenKH = tenkh;
            this.diaChi = dc;
            this.sdt = sdt;
            this.ngayTao = ngaytao;
        }
        public KhachHangDTO(DataRow row)
        {
            this.maKH = (int)row["MaKH"];
            this.tenKH = row["TenKH"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.sdt = row["SDT"].ToString();
            this.ngayTao = (DateTime)row["NgayTao"];
        }
        private int maKH;
        private string tenKH;
        private string diaChi;
        private string sdt;
        private DateTime ngayTao;

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
