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
    public class DAL_HoaDon
    {
        private Common conn;

        private const string GET_ALL_HOADON = "SELECT mahoadon as [Mã Hóa Đơn], ngaytao as [Ngày Tạo], manhanvien as [Mã Nhân Viên], makhachhang as [Mã Khách Hàng], tongtien as [Tổng Tiền] FROM tblHOADON ORDER BY ngaytao";

        private const string GET_GIABAN = "SELECT (giaban - giamgia) as dongia FROM tblSANPHAM WHERE masanpham = @masanpham";

        private const string INSERT_HOADON = "INSERT INTO tblHOADON VALUES (@mahoadon, @ngaytao, @tongtien, @manhanvien, @makhachhang)";

        private const string GET_CHITIETHOADON = "SELECT * FROM tblCHITIETHOADON WHERE mahoadon = @mahoadon";

        private const string DELETE_SANPHAM_HOADON = "DELETE FROM tblCHITIETHOADON WHERE mahoadon = @mahoadon and masanpham = @masanpham";

        private const string DELETE_CHITIETHOADON = "DELETE FROM tblCHITIETHOADON WHERE mahoadon = @mahoadon";

        private const string DELETE_HOADON = "DELETE FROM tblHOADON WHERE mahoadon = @mahoadon";

        private const string CHECK_EXIST_SANPHAM_HOADON = "SELECT * FROM tblCHITIETHOADON WHERE mahoadon = @mahoadon and masanpham = @masanpham";

        private const string UPDATE_SOLUONG_SANPHAM_HOADON = "UPDATE tblCHITIETHOADON SET soluong = soluong + @slvao WHERE mahoadon = @mahoadon and masanpham = @masanpham";
        public DAL_HoaDon()
        {
            conn = new Common();
        }

        public DataTable LayTatCaHoaDon()
        {
            return conn.executeSelectQuery(GET_ALL_HOADON);
        }
        
        public DataTable LayChiTietHoaDon()
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_HoaDon.MaHoaDon;

            return conn.executeSelectQueryWithParams(GET_CHITIETHOADON, sqlParameters);
        }

        public bool KiemTraTonTaiSanPhamTrongHoaDon(string masanpham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_HoaDon.MaHoaDon;

            sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[1].Value = masanpham;


            DataTable result = conn.executeSelectQueryWithParams(CHECK_EXIST_SANPHAM_HOADON, sqlParameters);


            if (result.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }


        public bool ThemHoaDon()
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@ngaytao", SqlDbType.DateTime);
            sqlParameters[1].Value = DateTime.Now;

            sqlParameters[2] = new SqlParameter("@tongtien", SqlDbType.Int);
            sqlParameters[2].Value = 0;

            sqlParameters[3] = new SqlParameter("@manhanvien", SqlDbType.VarChar);
            sqlParameters[3].Value = DTO_TaiKhoan.MaNhanVien;

            sqlParameters[4] = new SqlParameter("@makhachhang", SqlDbType.VarChar);
            sqlParameters[4].Value = DTO_KhachHang.MaKhachHang;

            return conn.executeInsertQuery(INSERT_HOADON, sqlParameters);
        }
        public bool ThemSanPhamVaoHoaDon(string masanpham, int soluong)
        {
            return false;
        }

        public int LayDonGiaSanPhamChoHoaDon(string masanpham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[0].Value = masanpham;

            DataTable result = conn.executeSelectQueryWithParams(GET_GIABAN, sqlParameters);

            if (result.Rows.Count != 0)
            {
                return result.Rows[0].Field<int>("dongia");
            }
            return 0;
        }

        private const string INSERT_SANPHAM_HD = "INSERT INTO tblCHITIETHOADON VALUES (@mahoadon, @masanpham, @soluong, @dongia)";
        public bool ThemChiTietSanPham(string masanpham, int soluong)
        {
            if(KiemTraTonTaiSanPhamTrongHoaDon(masanpham) == true)
            {
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
                sqlParameters[0].Value = DTO_HoaDon.MaHoaDon;

                sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
                sqlParameters[1].Value = masanpham;

                sqlParameters[2] = new SqlParameter("@slvao", SqlDbType.Int);
                sqlParameters[2].Value = soluong;

                return conn.executeUpdateQuery(UPDATE_SOLUONG_SANPHAM_HOADON, sqlParameters);
            }
            else
            {
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
                sqlParameters[0].Value = DTO_HoaDon.MaHoaDon;

                sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
                sqlParameters[1].Value = masanpham;

                sqlParameters[2] = new SqlParameter("@soluong", SqlDbType.Int);
                sqlParameters[2].Value = soluong;

                sqlParameters[3] = new SqlParameter("@dongia", SqlDbType.Int);
                sqlParameters[3].Value = LayDonGiaSanPhamChoHoaDon(masanpham);

                return conn.executeInsertQuery(INSERT_SANPHAM_HD, sqlParameters);
            }    
        }

        public bool XoaSanPham(string masanpham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_HoaDon.MaHoaDon;

            sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[1].Value = masanpham;

            return conn.executeUpdateQuery(DELETE_SANPHAM_HOADON, sqlParameters);
        }

        public bool XoaChiTietHoaDon(string mahoadon)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = mahoadon;

            return conn.executeUpdateQuery(DELETE_CHITIETHOADON, sqlParameters);
        }

        public bool XoaHoaDon(string mahoadon)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@mahoadon", SqlDbType.VarChar);
            sqlParameters[0].Value = mahoadon;

            return conn.executeUpdateQuery(DELETE_HOADON, sqlParameters);
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
            string id = "HD-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            DTO_HoaDon.MaHoaDon = id;

            return DTO_HoaDon.MaHoaDon;
        }
    }
}
