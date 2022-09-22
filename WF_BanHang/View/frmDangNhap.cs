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

namespace WF_BanHang
{
    public partial class frmDangNhap : Form
    {
        private DAL_TaiKhoan tk;
        public frmDangNhap()
        {
            InitializeComponent();
            tk = new DAL_TaiKhoan();
            txtUsername.Text = "thanhkhoa";
            txtPassword.Text = "12345678";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
             if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                DTO_TaiKhoan.UserName = txtUsername.Text;
                DTO_TaiKhoan.PassWord = txtPassword.Text;

                if (tk.checkLoginAndGetRoleInDB(DTO_TaiKhoan.UserName, DTO_TaiKhoan.PassWord) != null)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập không chính xác. Vui lòng kiểm tra lại!");
                }    
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
