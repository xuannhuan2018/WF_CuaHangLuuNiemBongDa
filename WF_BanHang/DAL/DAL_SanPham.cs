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
    public class DAL_SanPham
    {
        private Common conn;

        private const string GET_ALL_PRODUCT = "SELECT * FROM tblSANPHAM";

        private const string INSERT_PRODUCT = "INSERT  INTO tblSANPHAM VALUES ( @masanpham, @tensanpham, @gianhap, @giaban, @giamgia, @soluongton, @ghichu, @maclb, @madanhmuc, @anhsanpham)";
        
        private const string DELETE_SANPHAM = "DELETE FROM tblSANPHAM WHERE masanpham = @masp";
        
        private const string UPDATE_SANPHAM = "UPDATE tblSANPHAM SET tensanpham = @tensp, gianhap = @nhap, giaban = @ban, ghichu = @ghichu, anhsanpham = @anhsp WHERE masanpham = @msp";
        
        private const string GET_NAME_SANPHAM = "SELECT masanpham, tensanpham FROM tblSANPHAM";
       
        private const string GET_SANPHAM_SAPHET = "SELECT tensanpham, anhsanpham, soluongton FROM tblSANPHAM WHERE soluongton <= 5";

        private const string SEARCH_SANPHAM = "SELECT * FROM tblSANPHAM WHERE masanpham LIKE @keyword OR tensanpham LIKE @keyword";

        public DAL_SanPham()
        {
            conn = new Common();
        }  

        public DataTable LayTatCaSanPham()
        {
            return conn.executeSelectQuery(GET_ALL_PRODUCT);
        }

        public DataTable LaySanPhamSapHetHang()
        {
            return conn.executeSelectQuery(GET_SANPHAM_SAPHET);
        }    

        public DataTable TimKiemSanPham(string keyword)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@keyword", SqlDbType.VarChar);
            sqlParameters[0].Value = keyword;

            return conn.executeSelectQueryWithParams(SEARCH_SANPHAM, sqlParameters);
        }
        public DataTable LayTenSanPham()
        {
            return conn.executeSelectQuery(GET_NAME_SANPHAM);
        }

        public bool ThemSanPham( string tensp, byte[] anhsanpham, int gianhap, int giaban, string ghichu, string maclb, string madanhmuc)
        {
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@tensanpham", SqlDbType.NVarChar);
            sqlParameters[1].Value = tensp;

            sqlParameters[2] = new SqlParameter("@gianhap", SqlDbType.Int);
            sqlParameters[2].Value = gianhap;

            sqlParameters[3] = new SqlParameter("@giaban", SqlDbType.Int);
            sqlParameters[3].Value = giaban;

            sqlParameters[4] = new SqlParameter("@giamgia", SqlDbType.Int);
            sqlParameters[4].Value = 0;
            
            sqlParameters[5] = new SqlParameter("@soluongton", SqlDbType.Int);
            sqlParameters[5].Value = 0;
            
            sqlParameters[6] = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            sqlParameters[6].Value = ghichu;
            
            sqlParameters[7] = new SqlParameter("@maclb", SqlDbType.NVarChar);
            sqlParameters[7].Value = maclb;
            
            sqlParameters[8] = new SqlParameter("@madanhmuc", SqlDbType.VarChar);
            sqlParameters[8].Value = madanhmuc;

            sqlParameters[9] = new SqlParameter("@anhsanpham", SqlDbType.Image);
            sqlParameters[9].Value = anhsanpham;

            return conn.executeInsertQuery(INSERT_PRODUCT, sqlParameters);
        }

        public bool XoaSanPham(string masp)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@masp", SqlDbType.VarChar);
            sqlParameters[0].Value = masp;

            try
            {
                return conn.executeUpdateQuery(DELETE_SANPHAM, sqlParameters);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CapNhatSanPham(string masp, string tensp, int gianhap, int giaban, string ghichu, byte [] anhsp)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@tensp", SqlDbType.VarChar);
            sqlParameters[0].Value = tensp;

            sqlParameters[1] = new SqlParameter("@nhap", SqlDbType.Int);
            sqlParameters[1].Value = gianhap;

            sqlParameters[2] = new SqlParameter("@ban", SqlDbType.Int);
            sqlParameters[2].Value = giaban;

            sqlParameters[3] = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            sqlParameters[3].Value = ghichu;

            sqlParameters[4] = new SqlParameter("@anhsp", SqlDbType.Image);
            sqlParameters[4].Value = anhsp;

            sqlParameters[5] = new SqlParameter("@msp", SqlDbType.NVarChar);
            sqlParameters[5].Value = masp;

            return conn.executeInsertQuery(UPDATE_SANPHAM, sqlParameters);
        }
        /* Tạo mã sản phẩm tự động */
        public string taoMaTuDong(DateTime a)
        {
            string p_year = Convert.ToString(a.Year);
            string p_month = Convert.ToString(a.Month);
            string p_day = Convert.ToString(a.Day);
            string p_hour = Convert.ToString(a.Hour);
            string p_minute = Convert.ToString(a.Minute);
            string p_second = Convert.ToString(a.Second);
            string id = "SP-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            return id;
        }
    }
}
