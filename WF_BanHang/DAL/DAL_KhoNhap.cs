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
    public class DAL_KhoNhap
    {
        private Common conn;
        private const string INSERT_NHAPKHO = "INSERT INTO tblPHIEUNHAPHANG VALUES (@maphieunhap, @ngaytao, 0, @manhanvien)";
        private const string INSERT_SANPHAM_NHAPKHOA = "INSERT INTO tblCHITIETNHAPHANG VALUES (@maphieunhap, @masanpham, @soluong, 0)";
        private const string GET_CHITIET_NHAP = "SELECT masanpham, soluong FROM tblCHITIETNHAPHANG WHERE maphieunhap = @maphieunhap";
        private const string CHECK_EXIST_SANPHAM_NHAP = "SELECT * FROM tblCHITIETNHAPHANG WHERE maphieunhap = @maphieunhap and masanpham = @masanpham";
        private const string UPDATE_SANPHAM_NHAP = "UPDATE tblCHITIETNHAPHANG SET soluong = soluong + @slvao WHERE maphieunhap = @maphieunhap and masanpham = @masanpham";
        private const string DELETE_SANPHAM_NHAP = "DELETE FROM tblCHITIETNHAPHANG WHERE maphieunhap = @maphieunhap and masanpham = @masanpham";
        private const string DELETE_CHITIETNHAP = "DELETE FROM tblCHITIETNHAPHANG WHERE maphieunhap = @maphieunhap";
        private const string DELETE_PHIEUNHAP = "DELETE FROM tblPHIEUNHAPHANG WHERE maphieunhap = @maphieunhap";

        public DAL_KhoNhap()
        {
            conn = new Common();
        }
        
        public DataTable LayChiTietPhieuNhap()
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_NhapKho.MaPhieuNhap;

            return conn.executeSelectQueryWithParams(GET_CHITIET_NHAP, sqlParameters );
        }
        public bool TaoPhieuNhapHang()
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@ngaytao", SqlDbType.DateTime);
            sqlParameters[1].Value = DateTime.Now;

            sqlParameters[2] = new SqlParameter("@manhanvien", SqlDbType.VarChar);
            sqlParameters[2].Value = DTO_TaiKhoan.MaNhanVien;

            return conn.executeInsertQuery(INSERT_NHAPKHO, sqlParameters);
        }

        public bool NhapSanPhamChoPhieuNhapHang(string masanpham, int soluong)
        {
            if(KiemTraTonTaiSanPhamTrongPhieuNhap(masanpham) == false)
            {
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
                sqlParameters[0].Value = DTO_NhapKho.MaPhieuNhap;

                sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
                sqlParameters[1].Value = masanpham;

                sqlParameters[2] = new SqlParameter("@soluong", SqlDbType.Int);
                sqlParameters[2].Value = soluong;

                return conn.executeInsertQuery(INSERT_SANPHAM_NHAPKHOA, sqlParameters);
            }
            else
            {
                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
                sqlParameters[0].Value = DTO_NhapKho.MaPhieuNhap;

                sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
                sqlParameters[1].Value = masanpham;

                sqlParameters[2] = new SqlParameter("@slvao", SqlDbType.Int);
                sqlParameters[2].Value = soluong;

                return conn.executeUpdateQuery(UPDATE_SANPHAM_NHAP, sqlParameters);
            }    
        }

        public bool KiemTraTonTaiSanPhamTrongPhieuNhap(string masanpham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_NhapKho.MaPhieuNhap;

            sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[1].Value = masanpham;


            DataTable result = conn.executeSelectQueryWithParams(CHECK_EXIST_SANPHAM_NHAP, sqlParameters);


            if (result.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool XoaSanPham(string masanpham)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = DTO_NhapKho.MaPhieuNhap;

            sqlParameters[1] = new SqlParameter("@masanpham", SqlDbType.VarChar);
            sqlParameters[1].Value = masanpham;

            return conn.executeUpdateQuery(DELETE_SANPHAM_NHAP, sqlParameters);
        }

        public bool XoaChiTietNhap(string maphieunhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = maphieunhap;

            return conn.executeUpdateQuery(DELETE_CHITIETNHAP, sqlParameters);
        }

        public bool XoaPhieuNhapHang(string maphieunhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@maphieunhap", SqlDbType.VarChar);
            sqlParameters[0].Value = maphieunhap;

            return conn.executeUpdateQuery(DELETE_PHIEUNHAP, sqlParameters);
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
            string id = "PN-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            DTO_NhapKho.MaPhieuNhap = id;

            return DTO_NhapKho.MaPhieuNhap;
        }
    }
}
