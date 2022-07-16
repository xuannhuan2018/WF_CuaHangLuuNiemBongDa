using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WF_CuaHangLuuNiemBongDa.DAL;
using System.Data.SqlClient;
using WF_CuaHangLuuNiemBongDa.DTO;

namespace WF_CuaHangLuuNiemBongDa.BUS
{
    class BUS_NhanVien
    {
        static string GET_NHANVIEN = "SELECT * FROM tblNHANVIEN";
        static string SEARCH_NHANVIEN = "SELECT * FROM tblNHANVIEN WHERE hovaten like '%" + "@hovaten" + "%'";
        static string INSERT_NHANVIEN = "INSERT INTO tblNHANVIEN VALUES (@manhanvien, @hovaten, @diachi, @dienthoai, @gioitinh, @tendangnhap, @matkhau, @trangthai, @quyen)";
        static string UPDATE_NHANVIEN = "UPDATE tblNHANVIEN SET hovaten = @hovaten, diachi = @diachi, sodienthoai = @dienthoai, gioitinh = @gioitinh, maquyen = @quyen WHERE manhanvien = @manhanvien";
        static string DELETE_NHANVIEN = "DELETE FROM tblNHANVIEN WHERE manhanvien = @manhanvien";
        public static DataTable LayThongTinNhanVien()
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(GET_NHANVIEN, conn);

            SqlDataReader oda = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(oda);

            return dt;
        }

        public static DataTable TimThongTinNhanVien(string hoten)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(SEARCH_NHANVIEN, conn);

            cmd.Parameters.Add(new SqlParameter("@hovaten", hoten));

            SqlDataReader oda = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(oda);

            return dt;
        }

        public static bool ThemNhanVien(string hoten, string diachi, string dienthoai, string gioitinh, string quyen)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(INSERT_NHANVIEN, conn);

            cmd.Parameters.Add(new SqlParameter("@manhanvien", TaoMaTuDong(DateTime.Now)));
            cmd.Parameters.Add(new SqlParameter("@hovaten", hoten));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@tendangnhap", TaoTaiKhoanTuDong()));
            cmd.Parameters.Add(new SqlParameter("@matkhau", TaoTaiKhoanTuDong()));
            cmd.Parameters.Add(new SqlParameter("@trangthai", 1));
            cmd.Parameters.Add(new SqlParameter("@quyen", quyen));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public static bool SuaNhanVien(string manhanvien, string hoten, string diachi, string dienthoai, string gioitinh, string quyen)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(UPDATE_NHANVIEN, conn);

            cmd.Parameters.Add(new SqlParameter("@manhanvien", manhanvien));
            cmd.Parameters.Add(new SqlParameter("@hovaten", hoten));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@dienthoai", dienthoai));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@quyen", quyen));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public static bool XoaNhanVien(string manhanvien)
        {
            SqlConnection conn = DataAccess.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = DataAccess.GetSqlCommand(DELETE_NHANVIEN, conn);

            cmd.Parameters.Add(new SqlParameter("@manhanvien", manhanvien));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        // Tạo một số hàm để tạo mã tự động sử dụng trong việc tạo id cho các bảng
        public static string TaoMaTuDong(DateTime a)
        {
            string p_year = Convert.ToString(a.Year);
            string p_month = Convert.ToString(a.Month);
            string p_day = Convert.ToString(a.Day);
            string p_hour = Convert.ToString(a.Hour);
            string p_minute = Convert.ToString(a.Minute);
            string p_second = Convert.ToString(a.Second);
            string id = "NV" + p_year + p_month + p_day + p_hour + p_minute + p_second;

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
