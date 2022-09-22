using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public class DTO_NhapKho
    {
        private static string maPhieuNhap;
        private static DateTime ngayNhap;
        private static int tongTien;
        private static string maSanPham;
        private static int soLuong;
        private static int donGia;

        public static string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public static DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public static int TongTien { get => tongTien; set => tongTien = value; }
        public static string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public static int SoLuong { get => soLuong; set => soLuong = value; }
        public static int DonGia { get => donGia; set => donGia = value; }
    }
}
