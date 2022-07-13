using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class NhapHang
    {
        private string manhaphang;
        private DateTime ngaytao;
        private int tongtien;
        private string manhanvien;
        private string masanpham;
        private int soluong;
        private int dongia;

        public string Manhaphang { get => manhaphang; set => manhaphang = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }

        public NhapHang()
        {

        }

        public NhapHang(string manhaphang, DateTime ngaytao, int tongtien, string manhanvien)
        {
            this.manhaphang = manhaphang;
            this.ngaytao = ngaytao;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
        }

        public NhapHang(string manhaphang, string masanpham, int soluong, int dongia)
        {
            this.manhaphang = manhaphang;
            this.masanpham = masanpham;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
