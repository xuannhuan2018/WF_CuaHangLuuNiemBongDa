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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            NhanVien.Manhanvien = "";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_NhanVien.LayThongTinNhanVien();
            dgvNhanVien.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_NhanVien.TimThongTinNhanVien(txtTimKiem.Text);
            dgvNhanVien.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";

            DataTable dt = new DataTable();
            dt = BUS_NhanVien.LayThongTinNhanVien();
            dgvNhanVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien.Manhanvien = "";
            frmAddNhanVien frm = new frmAddNhanVien();
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(NhanVien.Manhanvien == "")
            {
                MessageBox.Show("Click chuột vào thông tin nhân viên cần sửa trước khi nhấn button");
            }
            else
            {
                frmAddNhanVien frm = new frmAddNhanVien();
                frm.ShowDialog();
            }
        }

        private void dgvNhanVien_Click(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            NhanVien.Manhanvien = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
            NhanVien.Hoten = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
            NhanVien.Diachi = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
            NhanVien.Sodienthoai = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
            NhanVien.Gioitinh = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
            NhanVien.Maquyen = dgvNhanVien.Rows[numrow].Cells[8].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhanVien.Manhanvien == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
            else
            {
                try
                {
                    BUS_NhanVien.XoaNhanVien(NhanVien.Manhanvien);
                    MessageBox.Show("Xóa thành công!");
                }
                catch(Exception)
                {
                    MessageBox.Show("Không xóa được!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
