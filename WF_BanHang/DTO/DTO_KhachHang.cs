using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    class DTO_KhachHang
    {
        private static string maKhachHang;
        private static string tenKhachHang;
        private static string soDienThoai;

        public static string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public static string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public static string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
