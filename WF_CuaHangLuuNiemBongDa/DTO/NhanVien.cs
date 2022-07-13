using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_CuaHangLuuNiemBongDa.DTO
{
    class NhanVien
    {
        private string manhanvien;
        private string hoten;
        private string diachi;
        private string sodienthoai;
        private string gioitinh;
        private string tendangnhap;
        private string matkhau;
        private string trangthai;
        private string maquyen;

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string Maquyen { get => maquyen; set => maquyen = value; }

        public NhanVien()
        {

        }

        public NhanVien(string manhanvien, string hoten, string diachi, string sodienthoai, string gioitinh, string tendangnhap, string matkhau, string trangthai, string maquyen)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.gioitinh = gioitinh;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.trangthai = trangthai;
            this.maquyen = maquyen;
        }
    }
}
