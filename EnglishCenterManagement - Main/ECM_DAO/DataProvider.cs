using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM_DAO
{
    public class DataProvider
    {
        private static string strKetNoi  = @"Data Source=.;Initial Catalog=TTNN;Integrated Security=True";
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection connect = new SqlConnection(strKetNoi);
            connect.Open();
            return connect;
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, connect);
            return cmd.ExecuteReader();
        }
        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlParameter[] arrayPara, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, connect);
            cmd.Parameters.AddRange(arrayPara);
            return cmd.ExecuteReader();
        }
        public static bool ThucThiCauLenh(string strTruyVan, SqlParameter[] arrayPara, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, connect);
            cmd.Parameters.AddRange(arrayPara);
            int iKQ = cmd.ExecuteNonQuery();
            return iKQ > 0;
        }
        public static int ExecuteUpdateQuery(string strTruyVan, SqlParameter[] parameter, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, connect);
            int rowsAffected;
            try
            {                            
                cmd.Parameters.AddRange(parameter);
                adapter.UpdateCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }
        public static int ExecuteInsertQuery(string strTruyVan, SqlParameter[] parameter, SqlConnection connect)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, connect);
            int rowsAffected;
            try
            {
                cmd.Parameters.AddRange(parameter);
                adapter.InsertCommand = cmd;
                rowsAffected = cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (SqlException e)
            {
                return 0;
            }
            return rowsAffected;
        }
    }
}
