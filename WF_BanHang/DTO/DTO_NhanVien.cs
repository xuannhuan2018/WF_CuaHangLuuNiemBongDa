using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public class DTO_NhanVien
    {
        private static string hoVaTen;
        private static string diaChi;
        private static string soDienThoai;
        private static string tenDangNhap;
        private static string matKhau;
        private static string maNhanVien;
        private static string gioiTinh;
        private static string maQuyen;

        public static string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public static string DiaChi { get => diaChi; set => diaChi = value; }
        public static string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public static string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public static string MatKhau { get => matKhau; set => matKhau = value; }
        public static string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public static string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public static string MaQuyen { get => maQuyen; set => maQuyen = value; }
    }
}
