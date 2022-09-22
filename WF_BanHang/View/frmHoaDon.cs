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
using WF_BanHang.View.KhachHang;

namespace WF_BanHang.View
{
    public partial class frmHoaDon : Form
    {
        private DAL_HoaDon hd;
        private string flag = null;

        public frmHoaDon()
        {
            InitializeComponent();
            hd = new DAL_HoaDon();
            LayThongTinHoaDon();
        }

        private void dgvHoaDon_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            flag = dgvHoaDon.Rows[numrow].Cells[0].Value.ToString();
        }

        public void LayThongTinHoaDon()
        {
            DataTable dt = new DataTable();
            dt = hd.LayTatCaHoaDon();
            dgvHoaDon.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
            LayThongTinHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LayThongTinHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(flag == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin hóa đơn cần xóa!");
            }
            else
            {
                if(hd.XoaChiTietHoaDon(flag) == true && hd.XoaHoaDon(flag) == true)
                {
                    MessageBox.Show("Xóa thành công hóa đơn!");
                }

                LayThongTinHoaDon();
                flag = null;
            }    
        }
    }
}
