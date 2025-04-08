using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDTO
{
    public class BanDTO
    {
        public BanDTO(char id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public BanDTO(DataRow row)
        {
            this.ID = row["MaBan"].ToString()[0];
            this.Name = row["TenBan"].ToString();
            this.Status = row["TinhTrangBan"].ToString();
        }
        private char iD;
        public char ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }



    }
}
