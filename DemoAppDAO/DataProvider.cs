using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppDAO
{
    public class DataProvider
    {
        private static DataProvider instance;//Ctrl+R+E
        private string strChuoiKetNoi = "Data Source=.\\;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";

        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider();return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] panameter=null)
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
        public int ExecuteNonQuery(string query, object[] panameter = null)
        {
            int data = 0;

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
                data = com.ExecuteNonQuery();
                conn.Close();
            }
            return data;

        }
        public object ExecuteScalar(string query, object[] panameter = null)
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
