using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class DataProvider
    {
        private static DataProvider instance;//Ctrl+R+E
        private string strChuoiKetNoi = "Data Source=.\\;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";

        public static DataProvider Instance //singleton dam bao truy cap dung doi tuong
        { 
            get { if (instance == null) instance = new DataProvider();return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] panameter=null)//tra dong kq 
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                if (panameter!=null)
                {
                    string[] listPara = query.Split(' ');
                    int i=0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, panameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(data);
                conn.Close();
            }
            return data;

        }
        public int ExecuteNonQuery(string query, object[] parameters = null)//so dong thuc thi (insert/delete/update)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        // Dùng Regex để tìm tất cả tham số trong query (bắt đầu bằng @)
                        MatchCollection matches = Regex.Matches(query, @"@\w+");
                        int i = 0;

                        foreach (Match match in matches)
                        {
                            string paramName = match.Value;

                            // Tránh lỗi khi số lượng parameters không khớp
                            if (i < parameters.Length)
                            {
                                cmd.Parameters.AddWithValue(paramName, parameters[i]);
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteNonQuery();
                }
            }

            return data;
        }
        public object ExecuteScalar(string query, object[] panameter = null)//tra 1 kq(count,sum,...)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(strChuoiKetNoi))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                if (panameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            com.Parameters.AddWithValue(item, panameter[i]);
                            i++;
                        }
                    }
                }
                data = com.ExecuteScalar();
                conn.Close();
            }
            return data;

        }
    }
}
