using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_BanHang.DAL;
using WF_BanHang.DTO;
using WF_BanHang.View.SanPham;
using WF_BanHang.View.KhuyenMai;

namespace WF_BanHang.View
{
    public partial class frmSanPham : Form
    {
        private DAL_SanPham sp;
        private DAL_KhoNhap nk;

        public frmSanPham()
        {
            InitializeComponent();
            sp = new DAL_SanPham();
            nk = new DAL_KhoNhap();
            dgvSanPham.AutoResizeColumns();
            LayThongTinSanPham();

            DTO_SanPham.MaSanPham = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham frm = new frmThemSanPham();
            frm.ShowDialog();
            LayThongTinSanPham();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LayThongTinSanPham();
        }

        private void dgvSanPham_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            DTO_SanPham.MaSanPham = dgvSanPham.Rows[numrow].Cells[0].Value.ToString();
            DTO_SanPham.TenSanPham = dgvSanPham.Rows[numrow].Cells[1].Value.ToString();
            DTO_SanPham.GiaNhap = Convert.ToInt32(dgvSanPham.Rows[numrow].Cells[2].Value);
            DTO_SanPham.GiaBan = Convert.ToInt32(dgvSanPham.Rows[numrow].Cells[3].Value);
            DTO_SanPham.GhiChu = dgvSanPham.Rows[numrow].Cells[6].Value.ToString();
            DTO_SanPham.Maclb = dgvSanPham.Rows[numrow].Cells[7].Value.ToString();
            DTO_SanPham.MaDanhMuc = dgvSanPham.Rows[numrow].Cells[8].Value.ToString();
            DTO_SanPham.AnhSanPham = (byte[])dgvSanPham.Rows[numrow].Cells[9].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DTO_SanPham.MaSanPham == null)
            {
                MessageBox.Show("Click chuột vào dòng chứa thông tin sản phẩm cần có!");
            }
            else
            {
                if(sp.XoaSanPham(DTO_SanPham.MaSanPham) == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa sản phẩm!");
                }

                LayThongTinSanPham();

                DTO_SanPham.MaSanPham = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(DTO_SanPham.MaSanPham == null)
            {
                MessageBox.Show("Click chuột vào dòng thông tin sản phẩm cần sửa!");
            }
            else
            {
                frmSuaSanPham frm = new frmSuaSanPham();
                frm.ShowDialog();
                LayThongTinSanPham();
            }    
        }

        /*Function: Lấy thông tin tất cả sản phẩm để load vào datagrid view*/
        void LayThongTinSanPham()
        {
            DataTable dt = new DataTable();
            dt = sp.LayTatCaSanPham();
            dgvSanPham.DataSource = dt;

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvSanPham.Columns[9];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            nk.TaoPhieuNhapHang();
            frmNhapSanPham frm = new frmNhapSanPham();
            frm.ShowDialog();
            LayThongTinSanPham();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            frmKhuyenMai frm = new frmKhuyenMai();
            frm.ShowDialog();
            LayThongTinSanPham();
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            LoadSanPhamTimKiem();
        }

        private void LoadSanPhamTimKiem()
        {
            DataTable dt = new DataTable();
            dt = sp.TimKiemSanPham(txtTimSP.Text);
            dgvSanPham.DataSource = dt;

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvSanPham.Columns[9];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
