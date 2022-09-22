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

namespace WF_BanHang.View
{
    public partial class frmCapNhatThongTin : Form
    {
        private DAL_NhanVien nv;
        public frmCapNhatThongTin()
        {
            InitializeComponent();
            nv = new DAL_NhanVien();
            LayGiaTriChoForm();
        }

        public void LayGiaTriChoForm()
        {
            nv.LayThongTinNhanVienTheoTenDangNhap(DTO_TaiKhoan.UserName);

            txtHoTen.Text = DTO_NhanVien.HoVaTen;
            txtDiaChi.Text = DTO_NhanVien.DiaChi;
            txtSoDienThoai.Text = DTO_NhanVien.SoDienThoai;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    nv.CapNhatThongTinCaNhan(DTO_TaiKhoan.UserName, txtDiaChi.Text, txtHoTen.Text, txtSoDienThoai.Text);
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thất bại!");
                }
            }
        }

        private void btnChangPass_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
