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
using WF_BanHang.View.HoaDon;

namespace WF_BanHang.View.KhachHang
{
    public partial class frmThemKhachHang : Form
    {
        private DAL_KhachHang kh;
        public frmThemKhachHang()
        {
            InitializeComponent();
            kh = new DAL_KhachHang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "" || txtDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
            }
            else if(KiemTraSoNhapVao(txtDienThoai.Text) == false| txtDienThoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
            }
            else
            {
                if(kh.KiemTraKhachHangTheoSoDienThoai(txtDienThoai.Text) != null)
                {
                    DTO_KhachHang.MaKhachHang = kh.LayMaKhachHang(txtDienThoai.Text);
                    frmThemHoaDon frm = new frmThemHoaDon();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    if(kh.ThemKhachHang(txtTen.Text, txtDienThoai.Text) == true)
                    {
                        frmThemHoaDon frm = new frmThemHoaDon();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin khách hàng thất bại!");
                    }    
                }    
            }
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            if(kh.KiemTraKhachHangTheoSoDienThoai(txtDienThoai.Text) != null)
            {
                txtTen.Text = kh.KiemTraKhachHangTheoSoDienThoai(txtDienThoai.Text);
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
