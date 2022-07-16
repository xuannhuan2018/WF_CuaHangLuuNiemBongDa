using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_CuaHangLuuNiemBongDa.DAL;

namespace WF_CuaHangLuuNiemBongDa.BUS
{
    class BUS_DanhMucSP
    {
        static string GET_DANHMUC = "SELECT * FROM tblDANHMUC";

        public static DataTable LayDanhMucSanPham()
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(GET_DANHMUC, conn);

            SqlDataReader oda = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(oda);

            return dt;
        }
    }
}
