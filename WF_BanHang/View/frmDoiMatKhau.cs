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
    public partial class frmDoiMatKhau : Form
    {
        private DAL_NhanVien nv;

        public frmDoiMatKhau()
        {
            InitializeComponent();
            nv = new DAL_NhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtPass.Text.Length < 8 || txtPass.Text.Length > 20)
            {
                MessageBox.Show("Tên đăng nhập phải từ 8 - 20 ký tự");
            }
            else
            {
                if (txtPass.Text == "" || txtConfirmPass.Text == "")
                {
                    MessageBox.Show("Vui lòng cung cấp đủ thông tin!");
                }
                else if (txtPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không trùng nhau!");
                }
                else
                {
                    nv.CapNhatMatKhau(DTO_TaiKhoan.UserName, txtPass.Text);
                    MessageBox.Show("Cập nhật mật khẩu thành công!");
                    this.Close();
                }
            }
        }
    }
}
