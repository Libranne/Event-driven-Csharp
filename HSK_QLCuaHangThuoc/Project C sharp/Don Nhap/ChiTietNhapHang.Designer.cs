
namespace Project_C_sharp
{
    partial class ChiTietNhapHang
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
            this.lbNhapHang = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.dgvCTDonNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbDonNhap = new System.Windows.Forms.TextBox();
            this.cbbTenthuoc = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInDon = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhapHang
            // 
            this.lbNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNhapHang.AutoSize = true;
            this.lbNhapHang.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNhapHang.Location = new System.Drawing.Point(357, 9);
            this.lbNhapHang.Name = "lbNhapHang";
            this.lbNhapHang.Size = new System.Drawing.Size(381, 40);
            this.lbNhapHang.TabIndex = 3;
            this.lbNhapHang.Text = "Chi Tiết Đơn Nhập Hàng";
            // 
            // grb1
            // 
            this.grb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grb1.Controls.Add(this.dgvCTDonNhap);
            this.grb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(66, 292);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(953, 254);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            this.grb1.Text = "Chi Tiết Nhập Hàng";
            // 
            // dgvCTDonNhap
            // 
            this.dgvCTDonNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCTDonNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDonNhap.Location = new System.Drawing.Point(26, 33);
            this.dgvCTDonNhap.Name = "dgvCTDonNhap";
            this.dgvCTDonNhap.ReadOnly = true;
            this.dgvCTDonNhap.RowHeadersWidth = 51;
            this.dgvCTDonNhap.RowTemplate.Height = 24;
            this.dgvCTDonNhap.Size = new System.Drawing.Size(756, 221);
            this.dgvCTDonNhap.TabIndex = 0;
            this.dgvCTDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTDonNhap_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.cbbDonNhap);
            this.groupBox1.Controls.Add(this.cbbTenthuoc);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đơn Nhập";
            // 
            // cbbDonNhap
            // 
            this.cbbDonNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbDonNhap.Enabled = false;
            this.cbbDonNhap.Location = new System.Drawing.Point(283, 53);
            this.cbbDonNhap.Name = "cbbDonNhap";
            this.cbbDonNhap.Size = new System.Drawing.Size(127, 34);
            this.cbbDonNhap.TabIndex = 15;
            // 
            // cbbTenthuoc
            // 
            this.cbbTenthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenthuoc.FormattingEnabled = true;
            this.cbbTenthuoc.Location = new System.Drawing.Point(283, 116);
            this.cbbTenthuoc.Name = "cbbTenthuoc";
            this.cbbTenthuoc.Size = new System.Drawing.Size(233, 34);
            this.cbbTenthuoc.TabIndex = 14;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGia.Location = new System.Drawing.Point(786, 120);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(127, 34);
            this.txtGia.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSoluong.Location = new System.Drawing.Point(786, 53);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(127, 34);
            this.txtSoluong.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thuốc";
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
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(120, 239);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 42);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(289, 239);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 42);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(466, 239);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 42);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInDon
            // 
            this.btnInDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInDon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDon.Location = new System.Drawing.Point(655, 239);
            this.btnInDon.Name = "btnInDon";
            this.btnInDon.Size = new System.Drawing.Size(153, 42);
            this.btnInDon.TabIndex = 9;
            this.btnInDon.Text = "In Đơn Nhập";
            this.btnInDon.UseVisualStyleBackColor = false;
            this.btnInDon.Click += new System.EventHandler(this.btnInDon_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoad.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(876, 239);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 42);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Làm mới";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 558);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnInDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.lbNhapHang);
            this.Name = "ChiTietNhapHang";
            this.Text = "ChiTietNhapHang";
            this.Load += new System.EventHandler(this.ChiTietNhapHang_Load);
            this.grb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapHang;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.DataGridView dgvCTDonNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInDon;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbTenthuoc;
        private System.Windows.Forms.TextBox cbbDonNhap;
    }
}