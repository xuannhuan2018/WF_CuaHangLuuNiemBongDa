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

namespace WF_BanHang.View.KhuyenMai
{
    public partial class frmKhuyenMai : Form
    {
        private DAL_CauLacBo clb;
        private DAL_DanhMucSanPham dmsp;
        private DAL_SanPham sp;
        private DAL_KhuyenMai km;

        public frmKhuyenMai()
        {
            InitializeComponent();

            clb = new DAL_CauLacBo();
            dmsp = new DAL_DanhMucSanPham();
            sp = new DAL_SanPham();
            km = new DAL_KhuyenMai();

            ra_clb.Checked = true;
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            if(ra_clb.Checked == true)
            {
                DataTable dt = new DataTable();
                dt = clb.getNamCauLacBo();
                cmbLoaiKhuyenMai.DataSource = dt;

                cmbLoaiKhuyenMai.DisplayMember = "tenclb";
                cmbLoaiKhuyenMai.ValueMember = "maclb";
            }
            
            if(ra_dm.Checked == true)
            {
                DataTable tb = new DataTable();
                tb = dmsp.GetNameDanhMuc();
                cmbLoaiKhuyenMai.DataSource = tb;

                cmbLoaiKhuyenMai.DisplayMember = "tendanhmuc";
                cmbLoaiKhuyenMai.ValueMember = "madanhmuc";
            }

            if(rasp.Checked == true)
            {
                DataTable dt = new DataTable();
                dt = sp.LayTenSanPham();
                cmbLoaiKhuyenMai.DataSource = dt;

                cmbLoaiKhuyenMai.DisplayMember = "tensanpham";
                cmbLoaiKhuyenMai.ValueMember = "masanpham";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(bmdSoluong.Value) < 0 | Convert.ToInt32(bmdSoluong.Value) > 100)
            {
                MessageBox.Show("Phần trăm khuyến mãi không hợp lệ!");
            }
            else
            {
                if (ra_clb.Checked == true)
                {
                    string datenow = DateTime.Now.ToString("dd-MM");
                    string ngaylap = km.LayNgayLapCLB(cmbLoaiKhuyenMai.SelectedValue.ToString()).ToString("dd-MM");

                    if (datenow != ngaylap)
                    {
                        MessageBox.Show("Hình thức khuyến mãi này chỉ áp dụng vào kỷ niệm thành lập của các câu lạc bộ. Vui lòng thử lại sau!");
                    }
                    else
                    {
                        km.CapNhatKhuyenMaiTheoCLB(cmbLoaiKhuyenMai.SelectedValue.ToString(), Convert.ToInt32(bmdSoluong.Value));
                        MessageBox.Show("Cập nhật khuyến mãi thành công!");
                    }
                }

                if (ra_dm.Checked == true)
                {
                    km.CapNhatKhuyenMaiTheoDanhMuc(cmbLoaiKhuyenMai.SelectedValue.ToString(), Convert.ToInt32(bmdSoluong.Value));
                    MessageBox.Show("Cập nhật khuyến mãi thành công!");
                }

                if (rasp.Checked == true)
                {
                    km.CapNhatKhuyenMaiTheoSanPham(cmbLoaiKhuyenMai.SelectedValue.ToString(), Convert.ToInt32(bmdSoluong.Value));
                    MessageBox.Show("Cập nhật khuyến mãi thành công!");
                }
            }    
        }

        private void ra_clb_CheckedChanged(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void ra_dm_CheckedChanged(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void rasp_CheckedChanged(object sender, EventArgs e)
        {
            LoadCombobox();
        }
    }
}
