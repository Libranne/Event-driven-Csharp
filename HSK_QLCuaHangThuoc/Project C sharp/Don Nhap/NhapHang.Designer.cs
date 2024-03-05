
namespace Project_C_sharp
{
    partial class NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.dgvDonNhap = new System.Windows.Forms.DataGridView();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lbNhapHang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbNgayNhap = new System.Windows.Forms.MaskedTextBox();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.txtDonNhap = new System.Windows.Forms.TextBox();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChitietDN = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInDon = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.rtbThongTin = new System.Windows.Forms.RichTextBox();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNhap)).BeginInit();
            this.grb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonNhap
            // 
            this.dgvDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonNhap.Location = new System.Drawing.Point(0, 33);
            this.dgvDonNhap.Name = "dgvDonNhap";
            this.dgvDonNhap.ReadOnly = true;
            this.dgvDonNhap.RowHeadersWidth = 51;
            this.dgvDonNhap.RowTemplate.Height = 24;
            this.dgvDonNhap.Size = new System.Drawing.Size(994, 246);
            this.dgvDonNhap.TabIndex = 0;
            this.dgvDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonNhap_CellClick);
            // 
            // grb1
            // 
            this.grb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grb1.Controls.Add(this.dgvDonNhap);
            this.grb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(551, 154);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(1034, 286);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            this.grb1.Text = "Danh Sách Đơn Nhập Hàng";
            // 
            // lbNhapHang
            // 
            this.lbNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNhapHang.AutoSize = true;
            this.lbNhapHang.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNhapHang.Location = new System.Drawing.Point(622, 12);
            this.lbNhapHang.Name = "lbNhapHang";
            this.lbNhapHang.Size = new System.Drawing.Size(389, 40);
            this.lbNhapHang.TabIndex = 2;
            this.lbNhapHang.Text = "Quản Lý Đơn Nhập Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.cbbTrangthai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mtbNgayNhap);
            this.groupBox1.Controls.Add(this.cbbTenNCC);
            this.groupBox1.Controls.Add(this.txtDonNhap);
            this.groupBox1.Controls.Add(this.cbbTenNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 413);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Nhập";
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Location = new System.Drawing.Point(278, 294);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(170, 34);
            this.cbbTrangthai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng Thái";
            // 
            // mtbNgayNhap
            // 
            this.mtbNgayNhap.Location = new System.Drawing.Point(278, 238);
            this.mtbNgayNhap.Mask = "00/00/0000";
            this.mtbNgayNhap.Name = "mtbNgayNhap";
            this.mtbNgayNhap.Size = new System.Drawing.Size(124, 34);
            this.mtbNgayNhap.TabIndex = 10;
            this.mtbNgayNhap.Validating += new System.ComponentModel.CancelEventHandler(this.mtbNgayNhap_Validating);
            this.mtbNgayNhap.Validated += new System.EventHandler(this.mtbNgayNhap_Validated);
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbTenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(278, 185);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(170, 34);
            this.cbbTenNCC.TabIndex = 9;
            // 
            // txtDonNhap
            // 
            this.txtDonNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDonNhap.Location = new System.Drawing.Point(278, 57);
            this.txtDonNhap.Name = "txtDonNhap";
            this.txtDonNhap.Size = new System.Drawing.Size(127, 34);
            this.txtDonNhap.TabIndex = 4;
            this.txtDonNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtDonNhap_Validating);
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbbTenNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(278, 120);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(229, 34);
            this.cbbTenNV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Đơn Nhập";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(118, 746);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(323, 746);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 51);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(560, 746);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 51);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChitietDN
            // 
            this.btnChitietDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChitietDN.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietDN.Location = new System.Drawing.Point(762, 746);
            this.btnChitietDN.Name = "btnChitietDN";
            this.btnChitietDN.Size = new System.Drawing.Size(224, 51);
            this.btnChitietDN.TabIndex = 7;
            this.btnChitietDN.Text = "Xem chi tiết ĐN";
            this.btnChitietDN.UseVisualStyleBackColor = false;
            this.btnChitietDN.Click += new System.EventHandler(this.btnChitietDN_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1059, 746);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 51);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Làm mới";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1251, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(917, 96);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(127, 25);
            this.txtTimKiem.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhập tên nhân viên";
            // 
            // btnInDon
            // 
            this.btnInDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInDon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDon.Location = new System.Drawing.Point(1251, 746);
            this.btnInDon.Name = "btnInDon";
            this.btnInDon.Size = new System.Drawing.Size(153, 51);
            this.btnInDon.TabIndex = 12;
            this.btnInDon.Text = "In Đơn Nhập";
            this.btnInDon.UseVisualStyleBackColor = false;
            this.btnInDon.Click += new System.EventHandler(this.btnInDon_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1073, 96);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(72, 25);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rtbThongTin
            // 
            this.rtbThongTin.Location = new System.Drawing.Point(817, 500);
            this.rtbThongTin.Name = "rtbThongTin";
            this.rtbThongTin.Size = new System.Drawing.Size(405, 188);
            this.rtbThongTin.TabIndex = 15;
            this.rtbThongTin.Text = "";
            this.rtbThongTin.TextChanged += new System.EventHandler(this.rtbThongTin_TextChanged);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(190, 514);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.Size = new System.Drawing.Size(391, 174);
            this.dgvThongTin.TabIndex = 16;
            this.dgvThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTin_CellContentClick);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1799, 809);
            this.Controls.Add(this.dgvThongTin);
            this.Controls.Add(this.rtbThongTin);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnInDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnChitietDN);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNhapHang);
            this.Controls.Add(this.grb1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapHang_FormClosing);
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNhap)).EndInit();
            this.grb1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonNhap;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lbNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChitietDN;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbTenNCC;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.MaskedTextBox mtbNgayNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnInDon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbbTrangthai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbThongTin;
        private System.Windows.Forms.DataGridView dgvThongTin;
    }
}