
namespace WF_BanHang
{
    partial class frmDanhMucSanPham
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
            this.label15 = new System.Windows.Forms.Label();
            this.dgvDanhMucSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoiCLB = new System.Windows.Forms.Button();
            this.dgvCaulacbo = new System.Windows.Forms.DataGridView();
            this.btnXoaCLB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaCLB = new System.Windows.Forms.Button();
            this.btnThemCLB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaulacbo)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(17, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 29);
            this.label15.TabIndex = 55;
            this.label15.Text = "Danh Mục Sản Phẩm:";
            // 
            // dgvDanhMucSP
            // 
            this.dgvDanhMucSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMucSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhMucSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSP.Location = new System.Drawing.Point(23, 67);
            this.dgvDanhMucSP.Name = "dgvDanhMucSP";
            this.dgvDanhMucSP.RowHeadersWidth = 51;
            this.dgvDanhMucSP.RowTemplate.Height = 24;
            this.dgvDanhMucSP.Size = new System.Drawing.Size(478, 204);
            this.dgvDanhMucSP.TabIndex = 56;
            this.dgvDanhMucSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucSP_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dgvDanhMucSP);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(243, 32);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(739, 311);
            this.panel1.TabIndex = 57;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(583, 238);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(135, 53);
            this.btnLamMoi.TabIndex = 60;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(583, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 53);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(583, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 53);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(583, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 53);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLamMoiCLB);
            this.panel2.Controls.Add(this.dgvCaulacbo);
            this.panel2.Controls.Add(this.btnXoaCLB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSuaCLB);
            this.panel2.Controls.Add(this.btnThemCLB);
            this.panel2.Location = new System.Drawing.Point(243, 378);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(739, 311);
            this.panel2.TabIndex = 58;
            // 
            // btnLamMoiCLB
            // 
            this.btnLamMoiCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnLamMoiCLB.FlatAppearance.BorderSize = 0;
            this.btnLamMoiCLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLamMoiCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiCLB.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiCLB.Location = new System.Drawing.Point(583, 227);
            this.btnLamMoiCLB.Name = "btnLamMoiCLB";
            this.btnLamMoiCLB.Size = new System.Drawing.Size(135, 53);
            this.btnLamMoiCLB.TabIndex = 65;
            this.btnLamMoiCLB.Text = "Làm Mới";
            this.btnLamMoiCLB.UseVisualStyleBackColor = false;
            this.btnLamMoiCLB.Click += new System.EventHandler(this.btnLamMoiCLB_Click);
            // 
            // dgvCaulacbo
            // 
            this.dgvCaulacbo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaulacbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaulacbo.Location = new System.Drawing.Point(22, 67);
            this.dgvCaulacbo.Name = "dgvCaulacbo";
            this.dgvCaulacbo.RowHeadersWidth = 51;
            this.dgvCaulacbo.RowTemplate.Height = 24;
            this.dgvCaulacbo.Size = new System.Drawing.Size(479, 204);
            this.dgvCaulacbo.TabIndex = 56;
            this.dgvCaulacbo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauLacBo_Click);
            // 
            // btnXoaCLB
            // 
            this.btnXoaCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnXoaCLB.FlatAppearance.BorderSize = 0;
            this.btnXoaCLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoaCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCLB.ForeColor = System.Drawing.Color.White;
            this.btnXoaCLB.Location = new System.Drawing.Point(583, 168);
            this.btnXoaCLB.Name = "btnXoaCLB";
            this.btnXoaCLB.Size = new System.Drawing.Size(135, 53);
            this.btnXoaCLB.TabIndex = 64;
            this.btnXoaCLB.Text = "Xóa";
            this.btnXoaCLB.UseVisualStyleBackColor = false;
            this.btnXoaCLB.Click += new System.EventHandler(this.btnXoaCLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Danh Sách Câu Lạc Bộ:";
            // 
            // btnSuaCLB
            // 
            this.btnSuaCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSuaCLB.FlatAppearance.BorderSize = 0;
            this.btnSuaCLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSuaCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCLB.ForeColor = System.Drawing.Color.White;
            this.btnSuaCLB.Location = new System.Drawing.Point(583, 109);
            this.btnSuaCLB.Name = "btnSuaCLB";
            this.btnSuaCLB.Size = new System.Drawing.Size(135, 53);
            this.btnSuaCLB.TabIndex = 63;
            this.btnSuaCLB.Text = "Sửa";
            this.btnSuaCLB.UseVisualStyleBackColor = false;
            this.btnSuaCLB.Click += new System.EventHandler(this.btnSuaCLB_Click);
            // 
            // btnThemCLB
            // 
            this.btnThemCLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThemCLB.FlatAppearance.BorderSize = 0;
            this.btnThemCLB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThemCLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCLB.ForeColor = System.Drawing.Color.White;
            this.btnThemCLB.Location = new System.Drawing.Point(583, 49);
            this.btnThemCLB.Name = "btnThemCLB";
            this.btnThemCLB.Size = new System.Drawing.Size(135, 53);
            this.btnThemCLB.TabIndex = 62;
            this.btnThemCLB.Text = "Thêm";
            this.btnThemCLB.UseVisualStyleBackColor = false;
            this.btnThemCLB.Click += new System.EventHandler(this.btnThemCLB_Click);
            // 
            // frmDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhMucSanPham";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "frmDanhMucSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaulacbo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvDanhMucSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCaulacbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoiCLB;
        private System.Windows.Forms.Button btnXoaCLB;
        private System.Windows.Forms.Button btnSuaCLB;
        private System.Windows.Forms.Button btnThemCLB;
    }
}