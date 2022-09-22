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
using WF_BanHang.View.NhanVien;

namespace WF_BanHang
{
    public partial class frmNhanVien : Form
    {
        private DAL_NhanVien nv;
        public frmNhanVien()
        {
            InitializeComponent();
            nv = new DAL_NhanVien();
            LoadNhanVien();

            DTO_NhanVien.MaNhanVien = null;
        }

        void LoadNhanVien()
        {
            DataTable dt = new DataTable();
            dt = nv.LayTatCaNhanVien();
            dgvNhanVien.DataSource = dt;
        }

        private void dgvNhanVien_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            DTO_NhanVien.MaNhanVien = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
            DTO_NhanVien.HoVaTen = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
            DTO_NhanVien.DiaChi = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
            DTO_NhanVien.SoDienThoai = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
            DTO_NhanVien.GioiTinh = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
            DTO_NhanVien.MaQuyen = dgvNhanVien.Rows[numrow].Cells[8].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DTO_NhanVien.MaNhanVien == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin nhân viên cần xóa!");
            }
            else
            {
                bool flag = nv.XoaNhanVien(DTO_NhanVien.MaNhanVien);
                if ( flag== true)
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }

            DTO_NhanVien.MaNhanVien = null;
            LoadNhanVien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
            LoadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DTO_NhanVien.MaNhanVien == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin nhân viên cần sửa!");
            }
            else
            {
                frmSuaNhanVien frm = new frmSuaNhanVien();
                frm.ShowDialog();
                LoadNhanVien();
                DTO_NhanVien.MaNhanVien = null;
            }
            
        }
    }
}
