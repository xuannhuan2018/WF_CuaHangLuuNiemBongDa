using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_CuaHangLuuNiemBongDa.BUS;
using WF_CuaHangLuuNiemBongDa.DTO;

namespace WF_CuaHangLuuNiemBongDa.GUI
{
    public partial class frmAddNhanVien : Form
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
            if(NhanVien.Manhanvien != "")
            {
                txtTen.Text = NhanVien.Hoten;
                txtDiaChi.Text = NhanVien.Diachi;
                txtDienThoai.Text = NhanVien.Sodienthoai;
                cmbGioiTinh.Text = NhanVien.Gioitinh;
                cmbQuyen.Text = NhanVien.Maquyen;
            }    
        }

        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(NhanVien.Manhanvien == "")
            {
                bool flag = BUS_NhanVien.ThemNhanVien(txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, cmbGioiTinh.Text, cmbQuyen.Text.Trim());

                if (flag)
                {
                    MessageBox.Show("Thêm Thành Công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm được!");
                }
            }
            else
            {
                bool flag = BUS_NhanVien.SuaNhanVien(NhanVien.Manhanvien, txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, cmbGioiTinh.Text, cmbQuyen.Text.Trim());
                if (flag)
                {
                    MessageBox.Show("Sửa Thành Công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa Không Được!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTen.Text = "";
            cmbGioiTinh.Text = "Nam";
            cmbQuyen.Text = "KH220712";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
