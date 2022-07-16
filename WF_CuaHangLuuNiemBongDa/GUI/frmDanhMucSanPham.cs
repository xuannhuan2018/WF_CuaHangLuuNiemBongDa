using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_CuaHangLuuNiemBongDa.BUS;
using WF_CuaHangLuuNiemBongDa.DTO;

namespace WF_CuaHangLuuNiemBongDa.GUI
{
    public partial class frmDanhMucSanPham : Form
    {
        public frmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void frmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_DanhMucSP.LayDanhMucSanPham();
            dgvDanhMuc.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DanhMucSP.Tendanhmuc = "";
            frmAddDanhMuc frm = new frmAddDanhMuc();
            frm.ShowDialog();
        }
    }
}
