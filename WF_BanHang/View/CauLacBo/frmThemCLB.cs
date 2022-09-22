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

namespace WF_BanHang.View.CauLacBo
{
    public partial class frmThemCLB : Form
    {
        private DAL_CauLacBo clb;
        public frmThemCLB()
        {
            InitializeComponent();
            clb = new DAL_CauLacBo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenCLB.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    clb.insertCauLacBo(txtTenCLB.Text, Convert.ToDateTime(dtNgayLap.Text));
                    MessageBox.Show("Thêm thành công!");
                }
                catch(Exception)
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }   
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenCLB.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenCLB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
