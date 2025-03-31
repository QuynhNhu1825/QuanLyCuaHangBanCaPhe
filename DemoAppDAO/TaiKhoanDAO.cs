using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO(){}

        public bool Login(string tenTK,string matKhau)
        {
            return false;
        }
    }
}
