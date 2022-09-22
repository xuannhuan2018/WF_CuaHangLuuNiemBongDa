using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DAL
{
    public class DAL_KhuyenMai
    {
        private Common conn;

        private const string UPDATE_KHUYENMAI_CLB = "UPDATE tblSANPHAM SET giamgia = giaban * @phantram * 0.01 WHERE maclb = @maclb";

        private const string UPDATE_KHUYENMAI_DANHMUC = "UPDATE tblSANPHAM SET giamgia = giaban * @phantram * 0.01 WHERE madanhmuc = @madanhmuc";

        private const string UPDATE_KHUYENMAI_SANPHAM = "UPDATE tblSANPHAM SET giamgia = giaban * @phantram * 0.01 WHERE masanpham = @masanpham";

        private const string GET_NGAYLAP_CLB = "SELECT ngaylap FROM tblCAULACBO WHERE maclb = @maclb";

        public DAL_KhuyenMai()
        {
            conn = new Common();
        }

        public bool CapNhatKhuyenMaiTheoCLB(string maclb, int phantram)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maclb", SqlDbType.VarChar);
            sqlParameters[0].Value = maclb;

            sqlParameters[1] = new SqlParameter("@phantram", SqlDbType.Int);
            sqlParameters[1].Value = phantram;

            return conn.executeInsertQuery(UPDATE_KHUYENMAI_CLB, sqlParameters);
        }

        public bool CapNhatKhuyenMaiTheoSanPham(string masanpham, int phantram)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[0].Value = masanpham;

            sqlParameters[1] = new SqlParameter("@phantram", SqlDbType.Int);
            sqlParameters[1].Value = phantram;

            return conn.executeInsertQuery(UPDATE_KHUYENMAI_SANPHAM, sqlParameters);
        }

        public bool CapNhatKhuyenMaiTheoDanhMuc(string madanhmuc, int phantram)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@madanhmuc", SqlDbType.VarChar);
            sqlParameters[0].Value = madanhmuc;

            sqlParameters[1] = new SqlParameter("@phantram", SqlDbType.Int);
            sqlParameters[1].Value = phantram;

            return conn.executeInsertQuery(UPDATE_KHUYENMAI_DANHMUC, sqlParameters);
        }

        public DateTime LayNgayLapCLB(string maclb)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maclb", SqlDbType.NVarChar);
            sqlParameters[0].Value = maclb;

            DataTable result = conn.executeSelectQueryWithParams(GET_NGAYLAP_CLB, sqlParameters);
            
            return result.Rows[0].Field<DateTime>("ngaylap");
        }
    }
}
