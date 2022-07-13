using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class CauLacBo
    {
        private string maclb;
        private string tenclb;

        public string Maclb { get => maclb; set => maclb = value; }
        public string Tenclb { get => tenclb; set => tenclb = value; }

        public CauLacBo()
        {

        }

        public CauLacBo(string maclb, string tenclb)
        {
            this.maclb = maclb;
            this.tenclb = tenclb;
        }
    }
}
