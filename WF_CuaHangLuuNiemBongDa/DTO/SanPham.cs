using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{ 
    class SanPham
    {
        private string masanpham;
        private string tensanpham;
        private string anhsanpham;
        private int gianhap;
        private int giaban;
        private int giamgia;
        private int soluongton;
        private string ghichu;
        private string maclb;
        private string madanhmuc;

        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Anhsanpham { get => anhsanpham; set => anhsanpham = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
        public int Soluongton { get => soluongton; set => soluongton = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Maclb { get => maclb; set => maclb = value; }
        public string Madanhmuc { get => madanhmuc; set => madanhmuc = value; }


        public SanPham()
        {

        }

        public SanPham(string masanpham, string tensanpham, string anhsanpham, int gianhap, int giaban, int giamgia, int soluongton, string ghichu, string maclb, string madanhmuc)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.anhsanpham = anhsanpham;
            this.gianhap = gianhap;
            this.giaban = giaban;
            this.giamgia = giamgia;
            this.soluongton = soluongton;
            this.ghichu = ghichu;
            this.maclb = maclb;
            this.madanhmuc = madanhmuc;
        }
    }
}
