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

namespace WF_BanHang.View.SanPham
{
    public partial class frmNhapSanPham : Form
    {
        private DAL_SanPham sp;
        private DAL_KhoNhap kn;
        private string flag;
        public frmNhapSanPham()
        {
            InitializeComponent();
            sp = new DAL_SanPham();
            kn = new DAL_KhoNhap();

            LoadDuLieuVaoComboBoxSp();
            LoadDuLieuVaoBang();
        }

        private void LoadDuLieuVaoComboBoxSp()
        {
            DataTable dt = new DataTable();
            dt = sp.LayTenSanPham();
            cmbSanPham.DataSource = dt;

            cmbSanPham.DisplayMember = "tensanpham";
            cmbSanPham.ValueMember = "masanpham";
        }

        private void LoadDuLieuVaoBang()
        {
            DataTable dt = new DataTable();
            dt = kn.LayChiTietPhieuNhap();
            dgvChiTietNhap.DataSource = dt;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            kn.XoaChiTietNhap(DTO_NhapKho.MaPhieuNhap);
            kn.XoaPhieuNhapHang(DTO_NhapKho.MaPhieuNhap);
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(bmdSoluong.Value) < 1)
            {
                MessageBox.Show("Giá trị nhập vào phải lớn hơn 0");
            }
            else
            {
                kn.NhapSanPhamChoPhieuNhapHang(cmbSanPham.SelectedValue.ToString(), Convert.ToInt32(bmdSoluong.Value));
                LoadDuLieuVaoBang();
            }    
        }

        private void dgvChiTietNhap_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            flag = dgvChiTietNhap.Rows[numrow].Cells[1].Value.ToString();

            if (kn.XoaSanPham(flag) == true)
            {
                MessageBox.Show("Xóa thành công!");
                LoadDuLieuVaoBang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập kho thành công!");
            this.Close();
        }
    }
}
