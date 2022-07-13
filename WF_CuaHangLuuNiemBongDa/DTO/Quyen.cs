using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class Quyen
    {
        private string maquyen;
        private string tenquyen;

        public string Maquyen { get => maquyen; set => maquyen = value; }
        public string Tenquyen { get => tenquyen; set => tenquyen = value; }

        public Quyen()
        {
            
        }

        public Quyen(string maquyen, string tenquyen)
        {
            this.maquyen = maquyen;
            this.tenquyen = tenquyen;
        }
    }
}
