using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DemoAppDTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tenTK, string tenHT, string matKhau, int loai)
        {
            this.TenTK = tenTK;
            this.TenHT = tenHT;
            this.MatKhau = matKhau;
            this.Loai = loai;
        }
        public TaiKhoanDTO(DataRow row)
        {
            this.TenTK = row["TenTK"].ToString();
            this.TenHT = row["TenHT"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.Loai = (int)row["Loai"];
        }
        private string tenTK;
        private string tenHT;
        private string matKhau;
        private int loai;

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenHT { get => tenHT; set => tenHT = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Loai { get => loai; set => loai = value; }
    }
}
