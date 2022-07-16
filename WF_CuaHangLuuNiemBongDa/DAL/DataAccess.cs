using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DAL
{
    public class DataAccess
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private const string CONN_STRING = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=SHOPLUUNIEM;Integrated Security=True";

        /// <summary>
        ///  SqlConnection
        /// </summary>
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(CONN_STRING);
            return conn;
        }

        /// <summary>
        /// GetSqlCommand
        /// </summary>
        /// <param name="query"></param>
        /// <param name="conn"></param>
        /// <returns>cmd</returns>
        public static SqlCommand GetSqlCommand(string query, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd;
        }
    }
}
