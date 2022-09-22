using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DAL
{
    public class DAL_DanhMucSanPham
    {
        private Common conn;

        private const string GET_DANHMUC = "SELECT * FROM tblDANHMUC";
        private const string INSERT_DANHMUC = "INSERT INTO tblDANHMUC  VALUES (@madanhmuc, @tendanhmuc)";
        private const string UPDATE_DANHMUC = "UPDATE tblDANHMUC SET tendanhmuc = @ten WHERE madanhmuc = @ma";
        private const string DELETE_DANHMUC = "DELETE FROM tblDANHMUC WHERE madanhmuc = @ma";
        private const string GET_NAME_DANHMUC = "SELECT madanhmuc, tendanhmuc FROM tblDANHMUC";

        public DAL_DanhMucSanPham()
        {
            conn = new Common();
        }
        public  DataTable GetDataDanhMuc()
        {
            return conn.executeSelectQuery(GET_DANHMUC);
        }

        public DataTable GetNameDanhMuc()
        {
            return conn.executeSelectQuery(GET_NAME_DANHMUC);
        }
        public bool insertDanhMuc(string ten)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@madanhmuc", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@tendanhmuc", SqlDbType.NVarChar);
            sqlParameters[1].Value = ten;
            return conn.executeInsertQuery(INSERT_DANHMUC, sqlParameters);
        }

        public bool deleteDanhMuc(string ma)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            sqlParameters[0].Value = ma;

            return conn.executeUpdateQuery(DELETE_DANHMUC, sqlParameters);
        }

        public bool updateDanhMuc(string ma, string ten)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            sqlParameters[0].Value = ma;

            sqlParameters[1] = new SqlParameter("@ten", SqlDbType.VarChar);
            sqlParameters[1].Value = ten;

            return conn.executeUpdateQuery(UPDATE_DANHMUC, sqlParameters);
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
            string id = "DMSP-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            return id;
        }
    }
}
