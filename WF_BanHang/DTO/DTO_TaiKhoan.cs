using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public class DTO_TaiKhoan
    {
        private static string userName;
        private static string passWord;
        private static string maNhanVien;

        public static string UserName { get => userName; set => userName = value; }
        public static string PassWord { get => passWord; set => passWord = value; }
        public static string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
    }
}
