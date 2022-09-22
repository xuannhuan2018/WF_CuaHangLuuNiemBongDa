using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_BanHang.DTO;
using WF_BanHang.View;
using WF_BanHang.View;

namespace WF_BanHang
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            AbrirFormEnPanel(new frmBodyMain());
            lblUsername.Text = DTO_TaiKhoan.UserName;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss ");
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDanhMucSanPham());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmNhanVien());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmBodyMain());
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            frmCapNhatThongTin frm = new frmCapNhatThongTin();
            frm.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmSanPham());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmHoaDon());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
