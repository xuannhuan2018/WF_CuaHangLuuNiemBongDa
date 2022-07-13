using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class DanhMucSP
    {
        private string madanhmuc;
        private string tendanhmuc;

        public string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }
        public string Tendanhmuc { get => tendanhmuc; set => tendanhmuc = value; }

        public DanhMucSP()
        {

        }

        public DanhMucSP( string madanhmuc, string tendanhmuc)
        {
            this.madanhmuc = madanhmuc;
            this.tendanhmuc = tendanhmuc;
        }
    }
}
