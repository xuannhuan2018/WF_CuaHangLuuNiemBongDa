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

namespace WF_BanHang.View.DanhMuc
{
    public partial class frmSuaDanhMuc : Form
    {
        private DAL_DanhMucSanPham dmps;

        public frmSuaDanhMuc()
        {
            InitializeComponent();
            dmps = new DAL_DanhMucSanPham();
            txtTenDanhMuc.Text = DTO_DanhMucSanPham.TenDanhMuc;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    dmps.updateDanhMuc(DTO_DanhMucSanPham.MaDanhMuc, txtTenDanhMuc.Text);
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thất bại!");
                }
            }
        }
    }
}
