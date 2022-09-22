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

namespace WF_BanHang
{
    public partial class frmBodyMain : Form
    {
        private DAL_SanPham sp;
        private DAL_ThongKe tk;

        public frmBodyMain()
        {
            InitializeComponent();
            sp = new DAL_SanPham();
            tk = new DAL_ThongKe();

            LayThongTinSanPhamSapHet();
            LayThongTinHienThi();
        }

        void LayThongTinSanPhamSapHet()
        {
            DataTable dt = new DataTable();
            dt = sp.LaySanPhamSapHetHang();
            dgvSpSapHet.DataSource = dt;

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvSpSapHet.Columns[1];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        void LayThongTinHienThi()
        {
            lblHoaDon.Text = tk.LayTongHoaDon().ToString();
            lblDoanhSo.Text = tk.LayDoanhSo().ToString();
            lblDoanhThu.Text = tk.LayDoanhThu().ToString();
            lblSanPham.Text = tk.LaySoSanPham().ToString();
        }
    }
}
