using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang.DTO
{
    public class DTO_CauLacBo
    {
        private static string maCLB;
        private static string tenCLB;
        private static DateTime ngayLap;

        public static string MaCLB { get => maCLB; set => maCLB = value; }
        public static string TenCLB { get => tenCLB; set => tenCLB = value; }
        public static DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
    }
}
