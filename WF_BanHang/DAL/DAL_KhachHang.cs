using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_BanHang.DTO;

namespace WF_BanHang.DAL
{
    public class DAL_KhachHang
    {
        private Common conn;

        private const string CHECK_PHONE_KHACH = "SELECT * FROM tblKHACHHANG WHERE sodienthoai = @sodienthoai";
        private const string THEM_KHACH = "INSERT INTO tblKHACHHANG VALUES (@makhachhang, @tenkhachhang, @sodienthoai, 0)";

        public DAL_KhachHang()
        {
            conn = new Common();
        }

        public string KiemTraKhachHangTheoSoDienThoai(string sodienthoai)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sodienthoai", SqlDbType.VarChar);
            sqlParameters[0].Value = sodienthoai;

            DataTable result = conn.executeSelectQueryWithParams(CHECK_PHONE_KHACH, sqlParameters);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<string>("tenkhachhang");
            }
            return null;
        }

        public string LayMaKhachHang(string sodienthoai)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@sodienthoai", SqlDbType.VarChar);
            sqlParameters[0].Value = sodienthoai;

            DataTable result = conn.executeSelectQueryWithParams(CHECK_PHONE_KHACH, sqlParameters);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<string>("makhachhang");
            }
            return null;
        }

        public bool ThemKhachHang(string tenkhachhang, string sodienthoai)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@makhachhang", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);
            sqlParameters[1] = new SqlParameter("@tenkhachhang", SqlDbType.VarChar);
            sqlParameters[1].Value = tenkhachhang;
            sqlParameters[2] = new SqlParameter("@sodienthoai", SqlDbType.VarChar);
            sqlParameters[2].Value = sodienthoai;

            return conn.executeInsertQuery(THEM_KHACH, sqlParameters);
        }
        /*Tạo một số mã tự động cho id*/
        public string taoMaTuDong(DateTime a)
        {
            string p_year = Convert.ToString(a.Year);
            string p_month = Convert.ToString(a.Month);
            string p_day = Convert.ToString(a.Day);
            string p_hour = Convert.ToString(a.Hour);
            string p_minute = Convert.ToString(a.Minute);
            string p_second = Convert.ToString(a.Second);
            string id = "KH-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            DTO_KhachHang.MaKhachHang = id;

            return DTO_KhachHang.MaKhachHang;
        }
    }
}
