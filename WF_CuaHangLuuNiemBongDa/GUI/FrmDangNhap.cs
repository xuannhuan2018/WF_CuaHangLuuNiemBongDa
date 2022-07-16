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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                NhanVien.Tendangnhap = txtTaiKhoan.Text;
                NhanVien.Matkhau = txtMatKhau.Text;

                int kq = BUS_XacThuc.KiemTraDangNhap(NhanVien.Tendangnhap, NhanVien.Matkhau);

                if (kq > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác. Vui lòng kiểm tra lại!");
                }
            }    
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
