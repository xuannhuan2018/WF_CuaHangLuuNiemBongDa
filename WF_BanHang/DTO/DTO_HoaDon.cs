using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public static class DTO_HoaDon
    {
        private static string maHoaDon;
        private static string maNhanVien;
        private static string maKhachHang;
        private static string ngayLap;
        private static string tongTien;
        private static string maSanPham;
        private static int soLuong;
        private static int donGia;

        public static string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public static string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public static string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public static string NgayLap { get => ngayLap; set => ngayLap = value; }
        public static string TongTien { get => tongTien; set => tongTien = value; }
        public static string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public static int SoLuong { get => soLuong; set => soLuong = value; }
        public static int DonGia { get => donGia; set => donGia = value; }
    }
}
