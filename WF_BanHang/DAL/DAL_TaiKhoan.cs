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
    public class DAL_TaiKhoan
    {
        private Common conn;

        private const string CHECK_LOGIN_QUERY= "SELECT * FROM tblNHANVIEN WHERE tendangnhap = @tk and matkhau = @mk";

        public DAL_TaiKhoan()
        {
            conn = new Common();
        }

        public string checkLoginAndGetRoleInDB(string username, string password)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tk", SqlDbType.NVarChar);
            sqlParameters[0].Value = username;
            sqlParameters[1] = new SqlParameter("@mk", SqlDbType.NVarChar);
            sqlParameters[1].Value = password;

            DataTable result = conn.executeSelectQueryWithParams(CHECK_LOGIN_QUERY, sqlParameters);
            
            if (result.Rows.Count != 0)
            {
                DTO_TaiKhoan.MaNhanVien = result.Rows[0].Field<string>("manhanvien");
                return result.Rows[0].Field<String>("tendangnhap");
            }
            return null;  
        }

    }
}
