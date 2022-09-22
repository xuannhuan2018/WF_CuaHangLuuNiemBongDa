using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    class DTO_DanhMucSanPham
    {
        private static string maDanhMuc;
        private static string tenDanhMuc;

        public static string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public static string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
    }
}
