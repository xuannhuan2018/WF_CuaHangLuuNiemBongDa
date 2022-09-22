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
using WF_BanHang.View.CauLacBo;
using WF_BanHang.View.DanhMuc;

namespace WF_BanHang
{
    public partial class frmDanhMucSanPham : Form
    {
        private DAL_CauLacBo clb;
        private DAL_DanhMucSanPham dmsp;

        public frmDanhMucSanPham()
        {
            clb = new DAL_CauLacBo();
            dmsp = new DAL_DanhMucSanPham();

            InitializeComponent();

            LoadDuLieuCLB();
            LoadDuLieuDanhMuc();

            DTO_CauLacBo.MaCLB = null;
            DTO_DanhMucSanPham.MaDanhMuc = null;
        }

        void LoadDuLieuCLB()
        {
            DataTable dt = new DataTable();
            dt = clb.getAllCauLacBo();
            dgvCaulacbo.DataSource = dt;
        }

        void LoadDuLieuDanhMuc()
        {
            DataTable dt = new DataTable();
            dt = dmsp.GetDataDanhMuc();
            dgvDanhMucSP.DataSource = dt;
        }

        private void btnThemCLB_Click(object sender, EventArgs e)
        {
            frmThemCLB frm = new frmThemCLB();
            frm.ShowDialog();
        }

        private void dgvCauLacBo_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            DTO_CauLacBo.MaCLB = dgvCaulacbo.Rows[numrow].Cells[0].Value.ToString();
            DTO_CauLacBo.TenCLB = dgvCaulacbo.Rows[numrow].Cells[1].Value.ToString();
            DTO_CauLacBo.NgayLap = Convert.ToDateTime(dgvCaulacbo.Rows[numrow].Cells[2].Value);
        }

        private void btnXoaCLB_Click(object sender, EventArgs e)
        {
            if (DTO_CauLacBo.MaCLB == null)
            {
                MessageBox.Show("Click chuột vào thông tin dòng cần xóa!");
            }
            else
            {
                try
                {
                    clb.deleteCauLacBo(DTO_CauLacBo.MaCLB);
                    MessageBox.Show("Xóa thành công!");
                }
                catch(Exception)
                {
                    MessageBox.Show("Thất bại!");
                }

                DTO_CauLacBo.MaCLB = null;
            }
        }

        private void btnSuaCLB_Click(object sender, EventArgs e)
        {
            if(DTO_CauLacBo.MaCLB == null)
            {
                MessageBox.Show("Click chuột vào thông tin dòng cần sửa!");
            }
            else
            {
                frmSuaCLB frm = new frmSuaCLB();
                frm.ShowDialog();
            }
        }

        private void btnLamMoiCLB_Click(object sender, EventArgs e)
        {
            DTO_CauLacBo.MaCLB = null;

            LoadDuLieuCLB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDanhMuc frm = new frmThemDanhMuc();
            frm.ShowDialog();
        }

        private void dgvDanhMucSP_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            DTO_DanhMucSanPham.MaDanhMuc = dgvDanhMucSP.Rows[numrow].Cells[0].Value.ToString();
            DTO_DanhMucSanPham.TenDanhMuc = dgvDanhMucSP.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DTO_DanhMucSanPham.MaDanhMuc == null)
            {
                MessageBox.Show("Click chuột vào thông tin dòng cần xóa!");
            }
            else
            {
                try
                {
                    dmsp.deleteDanhMuc(DTO_DanhMucSanPham.MaDanhMuc);
                    MessageBox.Show("Xóa thành công!");
                    LoadDuLieuDanhMuc();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thất bại!");
                }

                DTO_CauLacBo.MaCLB = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DTO_DanhMucSanPham.MaDanhMuc == null)
            {
                MessageBox.Show("Click chuột vào thông tin dòng cần sửa!");
            }
            else
            {
                frmSuaDanhMuc frm = new frmSuaDanhMuc();
                frm.ShowDialog();
                LoadDuLieuDanhMuc();
            }
        }
    }
}
