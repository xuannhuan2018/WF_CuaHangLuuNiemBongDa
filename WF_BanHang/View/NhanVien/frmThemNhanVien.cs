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

namespace WF_BanHang.View.NhanVien
{
    public partial class frmThemNhanVien : Form
    {
        private DAL_NhanVien nv;

        public frmThemNhanVien()
        {
            InitializeComponent();
            nv = new DAL_NhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtDienThoai.Text = "";
            txtTen.Text = "";
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
                if(nv.ThemNhanVien(txtTen.Text, txtDiaChi.Text, txtDienThoai.Text, cmbGioiTinh.Text, cmbMaQuyen.Text) == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
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
