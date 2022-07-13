using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class HoaDon
    {
        private string mahoadon;
        private DateTime ngaytao;
        private int giamgia;
        private int tongtien;
        private string makhachhang;
        private string manhanvien;
        private string masanpham;
        private int soluong;
        private int dongia;

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }


        public HoaDon()
        {

        }

        public HoaDon(string mahoadon, DateTime ngaytao, int giamgia, int tongtien, string manhanvien, string makhachhang)
        {
            this.mahoadon = mahoadon;
            this.ngaytao = ngaytao;
            this.giamgia = giamgia;
            this.tongtien = tongtien;
            this.manhanvien = manhanvien;
            this.makhachhang = makhachhang;
        }
        
        public HoaDon(string mahoadon, string masanpham, int soluong, int dongia)
        {
            this.mahoadon = mahoadon;
            this.masanpham = masanpham;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
