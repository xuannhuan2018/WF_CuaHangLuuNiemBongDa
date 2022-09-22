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

namespace WF_BanHang.View.SanPham
{
    public partial class frmSuaSanPham : Form
    {
        private DAL_SanPham sp;

        public frmSuaSanPham()
        {
            InitializeComponent();
            sp = new DAL_SanPham();

            LoadDuLieuLenForm();
        }


        public void LoadDuLieuLenForm()
        {
            if(DTO_SanPham.AnhSanPham.ToString() != "")
            {
                MemoryStream memory = new MemoryStream(DTO_SanPham.AnhSanPham);
                pictureBox1.Image = Image.FromStream(memory);
            }
            else
            {
                pictureBox1.Image = null;
            }

            txtTenSP.Text = DTO_SanPham.TenSanPham;
            txtGhiChu.Text = DTO_SanPham.GhiChu;
            txtGiaBan.Text = DTO_SanPham.GiaBan.ToString();
            txtGiaNhap.Text = DTO_SanPham.GiaNhap.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh!");
            }
            else if(txtTenSP.Text == "" | txtGiaNhap.Text == "" | txtGiaBan.Text == "" | txtGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (KiemTraSoNhapVao(txtGiaNhap.Text) == false | KiemTraSoNhapVao(txtGiaBan.Text) == false)
            {
                MessageBox.Show("Dữ liệu nhập vào không đúng. Vui lòng xem mẫu!");
            }
            else
            {
                byte[] anhsp = ImageToByteArray(pictureBox1);
                if (sp.CapNhatSanPham(DTO_SanPham.MaSanPham, txtTenSP.Text, Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), txtGhiChu.Text, anhsp) == true)
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }    
            }    
        }

        /*Function: Chuyển ảnh sang dạng byte */
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

            DTO_SanPham.MaSanPham = null;
        }
    }
}
