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
    public partial class frmSuaCLB : Form
    {
        private DAL_CauLacBo clb;

        public frmSuaCLB()
        {
            InitializeComponent();
            clb = new DAL_CauLacBo();
            loaThongTinCu();
        }

        void loaThongTinCu()
        {
            txtTenCLB.Text = DTO_CauLacBo.TenCLB;
            dtNgayLap.Text = DTO_CauLacBo.NgayLap.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenCLB.Text == "" || dtNgayLap.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    clb.updateCauLacBo(DTO_CauLacBo.MaCLB, txtTenCLB.Text, Convert.ToDateTime(dtNgayLap.Text));
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
