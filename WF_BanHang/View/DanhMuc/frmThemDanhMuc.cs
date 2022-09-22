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

namespace WF_BanHang.View.DanhMuc
{
    public partial class frmThemDanhMuc : Form
    {
        private DAL_DanhMucSanPham dmps;
        public frmThemDanhMuc()
        {
            InitializeComponent();
            dmps = new DAL_DanhMucSanPham();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDanhMuc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    dmps.insertDanhMuc(txtTenDanhMuc.Text);
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }    
        }
    }
}
