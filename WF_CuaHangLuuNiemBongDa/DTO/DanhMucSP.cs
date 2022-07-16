using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class DanhMucSP
    {
        static string madanhmuc;
        static string tendanhmuc;

        public static string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }
        public static string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }

        public DanhMucSP()
        {

        }
    }
}
