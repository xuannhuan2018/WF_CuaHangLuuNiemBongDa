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

namespace WF_BanHang.View.HoaDon
{
    public partial class frmThemHoaDon : Form
    {
        private DAL_HoaDon hd;
        private DAL_SanPham sp;
        private string flag;

        public frmThemHoaDon()
        {
            InitializeComponent();
            hd = new DAL_HoaDon();
            sp = new DAL_SanPham();

            TaoMoiHoaDon();
            LoadDuLieuVaoComboBoxSp();
            LoadChiTiet();
        }

        private void TaoMoiHoaDon()
        {
            hd.ThemHoaDon();
        }

        private void LoadDuLieuVaoComboBoxSp()
        {
            DataTable dt = new DataTable();
            dt = sp.LayTenSanPham();
            cmbSanPham.DataSource = dt;

            cmbSanPham.DisplayMember = "tensanpham";
            cmbSanPham.ValueMember = "masanpham";
        }

        private void LoadChiTiet()
        {
            DataTable dt = new DataTable();
            dt = hd.LayChiTietHoaDon();
            dgvChiTietHoaDon.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hd.ThemChiTietSanPham(cmbSanPham.SelectedValue.ToString(), Convert.ToInt32(bmdSoluong.Value));
            LoadChiTiet();
        }

        private void dgvChiTietHoaDon_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            flag = dgvChiTietHoaDon.Rows[numrow].Cells[1].Value.ToString();

            if (hd.XoaSanPham(flag) == true)
            {
                MessageBox.Show("Xóa thành công!");
                LoadChiTiet();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            hd.XoaChiTietHoaDon(DTO_HoaDon.MaHoaDon);
            hd.XoaHoaDon(DTO_HoaDon.MaHoaDon);
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất hóa đơn thành công!");
            this.Close();
        }
    }
}
