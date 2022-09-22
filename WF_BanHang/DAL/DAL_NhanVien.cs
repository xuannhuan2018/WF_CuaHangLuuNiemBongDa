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
    public class DAL_NhanVien
    {
        private Common conn;

        private const string GET_INFOR_EMPLOYEE_BY_USERNAME = "SELECT * FROM tblNHANVIEN WHERE tendangnhap = @ten";
        private const string UPDATE_INFOR_USER = "UPDATE tblNHANVIEN SET hovaten = @hoten, diachi = @diachi, sodienthoai = @sdt WHERE tendangnhap = @tendangnhap";
        private const string UPDATE_PASS_USER = "UPDATE tblNHANVIEN SET matkhau = @matkhau WHERE tendangnhap = @tendangnhap";

        public DAL_NhanVien()
        {
            conn = new Common();
        }
        public void LayThongTinNhanVienTheoTenDangNhap(string tendangnhap)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ten", SqlDbType.NVarChar);
            sqlParameters[0].Value = tendangnhap;

            DataTable dt = conn.executeSelectQueryWithParams(GET_INFOR_EMPLOYEE_BY_USERNAME, sqlParameters);

            //Gán giá trị thông tin lấy được vào bộ nhớ tạm
            DTO_NhanVien.HoVaTen = dt.Rows[0].Field<string>("hovaten");
            DTO_NhanVien.DiaChi = dt.Rows[0].Field<string>("diachi");
            DTO_NhanVien.SoDienThoai = dt.Rows[0].Field<string>("sodienthoai");
        }

        public bool CapNhatThongTinCaNhan(string tendangnhap, string diachi, string hoten, string sdt)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@hoten", SqlDbType.NVarChar);
            sqlParameters[0].Value = hoten;

            sqlParameters[1] = new SqlParameter("@diachi", SqlDbType.NVarChar);
            sqlParameters[1].Value = diachi;

            sqlParameters[2] = new SqlParameter("@sdt", SqlDbType.NVarChar);
            sqlParameters[2].Value = sdt;

            sqlParameters[3] = new SqlParameter("@tendangnhap", SqlDbType.VarChar);
            sqlParameters[3].Value = tendangnhap;

            return conn.executeUpdateQuery(UPDATE_INFOR_USER, sqlParameters);
        }

        public bool CapNhatMatKhau(string tendangnhap, string matkhau)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tendangnhap", SqlDbType.NVarChar);
            sqlParameters[0].Value = tendangnhap;

            sqlParameters[1] = new SqlParameter("@matkhau", SqlDbType.NVarChar);
            sqlParameters[1].Value = matkhau;

            return conn.executeUpdateQuery(UPDATE_PASS_USER, sqlParameters);
        }

        private const string GET_ALL_NHANVIEN = "SELECT * FROM tblNHANVIEN WHERE trangthai = '1'";

        public DataTable LayTatCaNhanVien()
        {
            return conn.executeSelectQuery(GET_ALL_NHANVIEN);
        }

        private const string DELETE_NHANVIEN = "UPDATE tblNHANVIEN SET trangthai = '0' WHERE manhanvien = @manhanvien";

        public bool XoaNhanVien(string manhanvien)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@manhanvien", SqlDbType.NVarChar);
            sqlParameters[0].Value = manhanvien;

            return conn.executeUpdateQuery(DELETE_NHANVIEN, sqlParameters);
        }

        private const string INSERT_NHANVIEN = "INSERT INTO tblNHANVIEN VALUES (@manhanvien, @hovaten, @diachi, @dienthoai, @gioitinh, @tendangnhap, @matkhau, @trangthai, @quyen)";
        public bool ThemNhanVien(string hoten, string diachi, string dienthoai, string gioitinh, string quyen)
        {
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@manhanvien", SqlDbType.VarChar);
            sqlParameters[0].Value = taoMaTuDong(DateTime.Now);

            sqlParameters[1] = new SqlParameter("@hovaten", SqlDbType.NVarChar);
            sqlParameters[1].Value = hoten;

            sqlParameters[2] = new SqlParameter("@diachi", SqlDbType.NVarChar);
            sqlParameters[2].Value = diachi;

            sqlParameters[3] = new SqlParameter("@dienthoai", SqlDbType.VarChar);
            sqlParameters[3].Value = dienthoai;

            sqlParameters[4] = new SqlParameter("@gioitinh", SqlDbType.NVarChar);
            sqlParameters[4].Value = gioitinh;

            sqlParameters[5] = new SqlParameter("@quyen", SqlDbType.VarChar);
            sqlParameters[5].Value = quyen;

            sqlParameters[6] = new SqlParameter("@trangthai", SqlDbType.VarChar);
            sqlParameters[6].Value = 1;

            sqlParameters[7] = new SqlParameter("@tendangnhap", SqlDbType.VarChar);
            sqlParameters[7].Value = TaoTaiKhoanTuDong();

            sqlParameters[8] = new SqlParameter("@matkhau", SqlDbType.VarChar);
            sqlParameters[8].Value = TaoTaiKhoanTuDong();

            return conn.executeInsertQuery(INSERT_NHANVIEN, sqlParameters);
        }

        private const string UPDATE_NHANVIEN = "UPDATE tblNHANVIEN SET hovaten = @hovaten, diachi = @diachi, sodienthoai = @dienthoai, gioitinh = @gioitinh, maquyen = @quyen WHERE manhanvien = @manhanvien";
        public  bool SuaNhanVien(string manhanvien, string hoten, string diachi, string dienthoai, string gioitinh, string quyen)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@manhanvien", SqlDbType.VarChar);
            sqlParameters[0].Value = manhanvien;

            sqlParameters[1] = new SqlParameter("@hovaten", SqlDbType.NVarChar);
            sqlParameters[1].Value = hoten;

            sqlParameters[2] = new SqlParameter("@diachi", SqlDbType.NVarChar);
            sqlParameters[2].Value = diachi;

            sqlParameters[3] = new SqlParameter("@dienthoai", SqlDbType.VarChar);
            sqlParameters[3].Value = dienthoai;

            sqlParameters[4] = new SqlParameter("@gioitinh", SqlDbType.NVarChar);
            sqlParameters[4].Value = gioitinh;

            sqlParameters[5] = new SqlParameter("@quyen", SqlDbType.NVarChar);
            sqlParameters[5].Value = quyen;

            return conn.executeUpdateQuery(UPDATE_NHANVIEN, sqlParameters);
        }

        public string taoMaTuDong(DateTime a)
        {
            string p_year = Convert.ToString(a.Year);
            string p_month = Convert.ToString(a.Month);
            string p_day = Convert.ToString(a.Day);
            string p_hour = Convert.ToString(a.Hour);
            string p_minute = Convert.ToString(a.Minute);
            string p_second = Convert.ToString(a.Second);
            string id = "NV-" + p_year + p_month + p_day + p_hour + p_minute + p_second;

            return id;
        }

        public static string TaoTaiKhoanTuDong()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return Convert.ToString(new String(stringChars));
        }
    }
}
