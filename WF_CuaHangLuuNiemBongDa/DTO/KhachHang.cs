using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class KhachHang
    {
        private string makhachhang;
        private string tenkhachhang;
        private DateTime ngaysinh;
        private string sodienthoai;
        private int diem;

        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public int Diem { get => diem; set => diem = value; }

        public KhachHang()
        {

        }

        public KhachHang(string makhachhang, string tenkhachhang, DateTime ngaysinh, string sodienthoai, int diem)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.diem = diem;
        }
    }
}
