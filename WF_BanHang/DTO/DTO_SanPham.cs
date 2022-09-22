using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public class DTO_SanPham
    {
        private static string maSanPham;
        private static string tenSanPham;
        private static int giaNhap;
        private static int giaBan;
        private static string ghiChu;
        private static byte[] anhSanPham;
        private static string maclb;
        private static string maDanhMuc;

        public static string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public static string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public static int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public static int GiaBan { get => giaBan; set => giaBan = value; }
        public static string GhiChu { get => ghiChu; set => ghiChu = value; }
        public static byte[] AnhSanPham { get => anhSanPham; set => anhSanPham = value; }
        public static string Maclb { get => maclb; set => maclb = value; }
        public static string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
    }
}
