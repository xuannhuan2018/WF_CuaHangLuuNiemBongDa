using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WF_CuaHangLuuNiemBongDa.DAL;

namespace WF_CuaHangLuuNiemBongDa.BUS
{
    class BUS_XacThuc
    {
        static string CHECK_DANGNHAP = "SELECT count(*) FROM tblNHANVIEN WHERE tendangnhap = @tendangnhap and matkhau = @matkhau";
        static string GET_QUYEN = "SELECT maquyen FROM tblNHANVIEN WHERE tendangnhap = @tendangnhap";

        public static int KiemTraDangNhap(string taikhoan, string matkhau)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(CHECK_DANGNHAP, conn);

            cmd.Parameters.Add(new SqlParameter("@tendangnhap", taikhoan));
            cmd.Parameters.Add(new SqlParameter("@matkhau", matkhau));

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            // Done
            return total;
        }

        public static string LayPhanQuyen(string taikhoan)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(GET_QUYEN, conn);

            cmd.Parameters.Add(new SqlParameter("@tendangnhap", taikhoan));

            String kq = Convert.ToString(cmd.ExecuteScalar());

            return kq;
        }
    }
}
