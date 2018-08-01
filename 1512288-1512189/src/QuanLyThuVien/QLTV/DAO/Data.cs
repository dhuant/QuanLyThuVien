using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLTV.DAO
{
    public class Data
    {
        string cnStr = @"Data Source=DESKTOP-G72575G;Initial Catalog=QLTV1;Integrated Security=True";

        public DataTable getData(string sql)
        {
            try
            {
                SqlConnection Connect = new SqlConnection(cnStr);

                SqlDataAdapter views = new SqlDataAdapter(sql, Connect);

                DataTable table = new DataTable();
                views.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int add(string sql)
        {
            SqlConnection Connect = new SqlConnection(cnStr);
            SqlCommand process = new SqlCommand(sql, Connect);
            Connect.Open();

            int kq = (int)process.ExecuteNonQuery();

            Connect.Close();

            return kq;
        }

        public int Delete(string sql)
        {
            SqlConnection connct = new SqlConnection(cnStr);
            connct.Open();

            SqlCommand scmd = new SqlCommand(sql, connct);
            int res = (int)scmd.ExecuteNonQuery();
            connct.Close();
            return res;
        }

        public int Edit(string sql)
        {
            SqlConnection connct = new SqlConnection(cnStr);
            connct.Open();
            SqlCommand scmd = new SqlCommand(sql, connct);
            int res = (int)scmd.ExecuteNonQuery();
            connct.Close();
            return res;
        }

        public bool checkID(string sql)
        {
            SqlConnection connct = new SqlConnection(cnStr);
            connct.Open();
            //string sql = "select maSV from SinhVien where maSV ='" + masv + "'";
            SqlCommand scmd = new SqlCommand(sql, connct);
            SqlDataReader sdr = scmd.ExecuteReader();
            if (sdr.Read() == true)
            {
                connct.Close();
                return true;
            }
            connct.Close();
            return false;
        }
    }
}
