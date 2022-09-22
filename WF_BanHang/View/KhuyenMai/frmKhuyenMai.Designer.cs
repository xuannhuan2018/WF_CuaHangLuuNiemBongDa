
namespace WF_BanHang.View.KhuyenMai
{
    partial class frmKhuyenMai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ra_clb = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rasp = new System.Windows.Forms.RadioButton();
            this.ra_dm = new System.Windows.Forms.RadioButton();
            this.cmbLoaiKhuyenMai = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bmdSoluong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmdSoluong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ra_clb
            // 
            this.ra_clb.AutoSize = true;
            this.ra_clb.Location = new System.Drawing.Point(41, 35);
            this.ra_clb.Name = "ra_clb";
            this.ra_clb.Size = new System.Drawing.Size(136, 29);
            this.ra_clb.TabIndex = 0;
            this.ra_clb.TabStop = true;
            this.ra_clb.Text = "Câu Lạc Bộ";
            this.ra_clb.UseVisualStyleBackColor = true;
            this.ra_clb.CheckedChanged += new System.EventHandler(this.ra_clb_CheckedChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(68, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 51);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rasp);
            this.groupBox1.Controls.Add(this.ra_dm);
            this.groupBox1.Controls.Add(this.ra_clb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức khuyến mãi";
            // 
            // rasp
            // 
            this.rasp.AutoSize = true;
            this.rasp.Location = new System.Drawing.Point(41, 112);
            this.rasp.Name = "rasp";
            this.rasp.Size = new System.Drawing.Size(125, 29);
            this.rasp.TabIndex = 2;
            this.rasp.TabStop = true;
            this.rasp.Text = "Sản Phẩm";
            this.rasp.UseVisualStyleBackColor = true;
            this.rasp.CheckedChanged += new System.EventHandler(this.rasp_CheckedChanged);
            // 
            // ra_dm
            // 
            this.ra_dm.AutoSize = true;
            this.ra_dm.Location = new System.Drawing.Point(41, 74);
            this.ra_dm.Name = "ra_dm";
            this.ra_dm.Size = new System.Drawing.Size(123, 29);
            this.ra_dm.TabIndex = 1;
            this.ra_dm.TabStop = true;
            this.ra_dm.Text = "Danh Mục";
            this.ra_dm.UseVisualStyleBackColor = true;
            this.ra_dm.CheckedChanged += new System.EventHandler(this.ra_dm_CheckedChanged);
            // 
            // cmbLoaiKhuyenMai
            // 
            this.cmbLoaiKhuyenMai.FormattingEnabled = true;
            this.cmbLoaiKhuyenMai.Location = new System.Drawing.Point(41, 55);
            this.cmbLoaiKhuyenMai.Name = "cmbLoaiKhuyenMai";
            this.cmbLoaiKhuyenMai.Size = new System.Drawing.Size(206, 33);
            this.cmbLoaiKhuyenMai.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(213, 430);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 51);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bmdSoluong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbLoaiKhuyenMai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 166);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khuyến Mãi";
            // 
            // bmdSoluong
            // 
            this.bmdSoluong.Location = new System.Drawing.Point(41, 113);
            this.bmdSoluong.Name = "bmdSoluong";
            this.bmdSoluong.Size = new System.Drawing.Size(48, 30);
            this.bmdSoluong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 513);
            this.panel1.TabIndex = 6;
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmdSoluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ra_clb;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rasp;
        private System.Windows.Forms.RadioButton ra_dm;
        private System.Windows.Forms.ComboBox cmbLoaiKhuyenMai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bmdSoluong;
        private System.Windows.Forms.Panel panel1;
    }
}