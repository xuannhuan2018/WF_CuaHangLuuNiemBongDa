using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_BanHang.DAL;
using WF_BanHang.DTO;

namespace WF_BanHang.View.NhanVien
{
    public partial class frmSuaNhanVien : Form
    {
        private DAL_NhanVien nv;
        public frmSuaNhanVien()
        {
            InitializeComponent();
            LoadThongTinCanSua();

            nv = new DAL_NhanVien();
        }

        void LoadThongTinCanSua()
        {
            txtTen.Text = DTO_NhanVien.HoVaTen;
            txtDiaChi.Text = DTO_NhanVien.DiaChi;
            txtDienThoai.Text = DTO_NhanVien.SoDienThoai;
            cmbGioiTinh.Text = DTO_NhanVien.GioiTinh;
            cmbMaQuyen.Text = DTO_NhanVien.MaQuyen;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" | txtDienThoai.Text == "" | txtTen.Text == "" | cmbGioiTinh.Text == "" | cmbMaQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (KiemTraSoNhapVao(txtDienThoai.Text) == false | txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
            }
            else
            {
                if (nv.SuaNhanVien(DTO_NhanVien.MaNhanVien, txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, cmbGioiTinh.Text, cmbMaQuyen.Text) == true)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        private bool KiemTraSoNhapVao(string a)
        {
            foreach (char c in a)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
