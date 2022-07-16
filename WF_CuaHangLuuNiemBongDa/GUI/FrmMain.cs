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

namespace WF_CuaHangLuuNiemBongDa
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LogoutToolStripMenuItem.Enabled = false;
            /*if(BUS_XacThuc.LayPhanQuyen(NhanVien.Tendangnhap) == "AD220712")
            {
                menuStrip1.Items.
            } */
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            body.Controls.Add(childForm);
            body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmDangNhap frm = new GUI.frmDangNhap();
            frm.ShowDialog();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK!");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.frmNhanVien());
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.frmNhanVien());
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.frmDanhMucSanPham());
        }
    }
}
