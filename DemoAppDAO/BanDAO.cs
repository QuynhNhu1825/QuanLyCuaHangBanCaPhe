﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAppDTO;
namespace DemoAppDAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }
        }

        public static int width = 100;
        public static int height = 100;

        public BanDAO() { }

        public List<BanDTO> LoadDSBan()
        {
            List<BanDTO> tableList = new List<BanDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_LAYDSBAN");

            foreach (DataRow item in data.Rows) 
            {
                BanDTO table = new BanDTO(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
