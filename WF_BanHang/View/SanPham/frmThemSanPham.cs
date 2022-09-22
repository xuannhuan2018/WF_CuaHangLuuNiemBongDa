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

namespace WF_BanHang.View.SanPham
{
    public partial class frmThemSanPham : Form
    {
        private DAL_CauLacBo clb;
        private DAL_DanhMucSanPham dmsp;
        private DAL_SanPham sp;

        /*Function: Khởi tạo form Thêm sản phẩm*/
        public frmThemSanPham()
        {
            InitializeComponent();
            clb = new DAL_CauLacBo();
            dmsp = new DAL_DanhMucSanPham();
            sp = new DAL_SanPham();

            LayGiaTriChoCmbCLB();
            LayGiaTriChoCmbDanhMuc();
            pictureBox1.Image = null;
        }

        /*Envent: Xử lý button Hủy */
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtGhiChu.Text = "";
            pictureBox1.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh!");
            }
            else if (txtTenSP.Text == "" | txtGiaNhap.Text == "" | txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if(KiemTraSoNhapVao(txtGiaNhap.Text) == false | KiemTraSoNhapVao (txtGiaBan.Text) == false)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng. Vui lòng xem mẫu!");
            }
            else if(Convert.ToInt32(txtGiaNhap.Text) > Convert.ToInt32(txtGiaBan.Text))
            {
                MessageBox.Show("Mức giá nhập phải nhỏ hơn giá bán!");
            }    
            else
            {
                byte[] anhsp = ImageToByteArray(pictureBox1);
                sp.ThemSanPham(txtTenSP.Text, anhsp, Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), txtGhiChu.Text, cmbClb.SelectedValue.ToString(), cmbDanhMucSP.SelectedValue.ToString());
                MessageBox.Show("Thêm sản phẩm thành công!");
                this.Close();
            }    
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn Ảnh Sản Phẩm";
            open.Filter = "Image Files (*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        /*Function: Kiểm tra chuỗi nhập vào có toàn số hay không*/
        private bool KiemTraSoNhapVao(string a)
        {
            foreach (char c in a)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        /*Function: Chuyển đổi ảnh đầu vào thành dạng byte*/
        private byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memory = new MemoryStream();
            picture.Image.Save(memory, picture.Image.RawFormat);

            return memory.ToArray();
        }

        /*Function: Load dữ liệu vào combobox Câu lạc bộ */
        public void LayGiaTriChoCmbCLB()
        {
            DataTable dt = new DataTable();
            dt = clb.getNamCauLacBo();
            cmbClb.DataSource = dt;

            cmbClb.DisplayMember = "tenclb";
            cmbClb.ValueMember = "maclb";
        }

        /*Function: Load dữ liệu vào combobox Danh mục */
        public void LayGiaTriChoCmbDanhMuc()
        {
            DataTable tb = new DataTable();
            tb = dmsp.GetNameDanhMuc();
            cmbDanhMucSP.DataSource = tb;

            cmbDanhMucSP.DisplayMember = "tendanhmuc";
            cmbDanhMucSP.ValueMember = "madanhmuc";
        }
    }
}
