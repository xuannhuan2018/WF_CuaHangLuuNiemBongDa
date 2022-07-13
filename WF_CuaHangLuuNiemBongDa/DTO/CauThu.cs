using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class CauThu
    {
        private string macauthu;
        private string tencauthu;
        private DateTime ngaysinh;

        public string Macauthu { get => macauthu; set => macauthu = value; }
        public string Tencauthu { get => tencauthu; set => tencauthu = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public CauThu()
        {

        }

        public CauThu(string macauthu, string tencauthu, DateTime ngaysinh)
        {
            this.macauthu = macauthu;
            this.tencauthu = tencauthu;
            this.ngaysinh = ngaysinh;
        }
    }
}
