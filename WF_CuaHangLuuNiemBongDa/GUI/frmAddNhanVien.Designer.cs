
namespace WF_CuaHangLuuNiemBongDa.GUI
{
    partial class frmAddNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.tblNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHOPLUUNIEMDataSet1 = new WF_CuaHangLuuNiemBongDa.SHOPLUUNIEMDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sHOPLUUNIEMDataSet = new WF_CuaHangLuuNiemBongDa.SHOPLUUNIEMDataSet();
            this.tblQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQUYENTableAdapter = new WF_CuaHangLuuNiemBongDa.SHOPLUUNIEMDataSetTableAdapters.tblQUYENTableAdapter();
            this.tblNHANVIENTableAdapter = new WF_CuaHangLuuNiemBongDa.SHOPLUUNIEMDataSet1TableAdapters.tblNHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPLUUNIEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPLUUNIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(506, 421);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 45);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(381, 421);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 45);
            this.btnLamMoi.TabIndex = 39;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(253, 421);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 45);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(101, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 3);
            this.panel2.TabIndex = 38;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(242, 206);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(293, 33);
            this.txtDienThoai.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(242, 145);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 33);
            this.txtDiaChi.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(242, 89);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(293, 33);
            this.txtTen.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Họ và Tên:";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblNHANVIENBindingSource, "maquyen", true));
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "KH220712",
            "NV220712"});
            this.cmbQuyen.Location = new System.Drawing.Point(242, 327);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(190, 24);
            this.cmbQuyen.TabIndex = 44;
            // 
            // tblNHANVIENBindingSource
            // 
            this.tblNHANVIENBindingSource.DataMember = "tblNHANVIEN";
            this.tblNHANVIENBindingSource.DataSource = this.sHOPLUUNIEMDataSet1;
            // 
            // sHOPLUUNIEMDataSet1
            // 
            this.sHOPLUUNIEMDataSet1.DataSetName = "SHOPLUUNIEMDataSet1";
            this.sHOPLUUNIEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Chức Vụ:";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(242, 272);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(190, 24);
            this.cmbGioiTinh.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Giới tính:";
            // 
            // sHOPLUUNIEMDataSet
            // 
            this.sHOPLUUNIEMDataSet.DataSetName = "SHOPLUUNIEMDataSet";
            this.sHOPLUUNIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQUYENBindingSource
            // 
            this.tblQUYENBindingSource.DataMember = "tblQUYEN";
            this.tblQUYENBindingSource.DataSource = this.sHOPLUUNIEMDataSet;
            // 
            // tblQUYENTableAdapter
            // 
            this.tblQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // tblNHANVIENTableAdapter
            // 
            this.tblNHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 491);
            this.Controls.Add(this.cmbQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Name = "frmAddNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNhanVien";
            this.Load += new System.EventHandler(this.frmAddNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPLUUNIEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPLUUNIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQUYENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label1;
        private SHOPLUUNIEMDataSet sHOPLUUNIEMDataSet;
        private System.Windows.Forms.BindingSource tblQUYENBindingSource;
        private SHOPLUUNIEMDataSetTableAdapters.tblQUYENTableAdapter tblQUYENTableAdapter;
        private SHOPLUUNIEMDataSet1 sHOPLUUNIEMDataSet1;
        private System.Windows.Forms.BindingSource tblNHANVIENBindingSource;
        private SHOPLUUNIEMDataSet1TableAdapters.tblNHANVIENTableAdapter tblNHANVIENTableAdapter;
    }
}