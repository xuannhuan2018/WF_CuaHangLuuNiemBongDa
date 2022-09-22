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
    public class DAL_CauLacBo
    {
        private Common conn;

        private const string GET_ALL_CAULACBO = "SELECT * FROM tblCAULACBO";
        private const string INSERT_CAULACBO = "INSERT INTO tblCAULACBO VALUES (@ma, @ten, @ngaylap)";
        private const string DELETE_CAULACBO = "DELETE FROM tblCAULACBO WHERE maclb = @ma";
        private const string UPDATE_CAULACBO = "UPDATE tblCAULACBO SET tenclb = @ten, ngaylap = @ngaylap WHERE maclb = @ma";
        private const string GET_NAME_CAULACBO = "SELECT maclb, tenclb FROM tblCAULACBO";

        public DAL_CauLacBo()
        {
            conn = new Common();
        }

        public DataTable getAllCauLacBo()
        {
            return conn.executeSelectQuery(GET_ALL_CAULACBO);
        }

        public DataTable getNamCauLacBo()
        {
            return conn.executeSelectQuery(GET_NAME_CAULACBO);
        }

        public  bool insertCauLacBo(string ten, DateTime ngaylap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@ten", SqlDbType.NVarChar);
            sqlParameters[1].Value = ten;

            sqlParameters[2] = new SqlParameter("@ngaylap", SqlDbType.Date);
            sqlParameters[2].Value = ngaylap;

            return conn.executeInsertQuery(INSERT_CAULACBO, sqlParameters);
        }

        public  bool deleteCauLacBo(string ma)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            sqlParameters[0].Value = ma;

            return conn.executeUpdateQuery(DELETE_CAULACBO, sqlParameters);
        }

        public bool updateCauLacBo(string ma, string ten, DateTime ngaylap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@ten", SqlDbType.NVarChar);
            sqlParameters[1].Value = ten;

            sqlParameters[2] = new SqlParameter("@ngaylap", SqlDbType.Date);
            sqlParameters[2].Value = ngaylap;

            return conn.executeUpdateQuery(UPDATE_CAULACBO, sqlParameters);
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
            string id = "CLB-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            return id;
        }
    }
}
