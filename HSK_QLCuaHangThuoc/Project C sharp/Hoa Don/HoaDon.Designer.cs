
namespace Project_C_sharp
{
    partial class HoaDon
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim_Click = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa_Click = new System.Windows.Forms.Button();
            this.btnSua_Click = new System.Windows.Forms.Button();
            this.btnThem_Click = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.btn_chitietHD = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbb_maKH = new System.Windows.Forms.ComboBox();
            this.cbb_maNV = new System.Windows.Forms.ComboBox();
            this.mtbNgayLap = new System.Windows.Forms.MaskedTextBox();
            this.txtsoHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1035, 287);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(232, 41);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTim_Click
            // 
            this.btnTim_Click.Location = new System.Drawing.Point(954, 287);
            this.btnTim_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim_Click.Name = "btnTim_Click";
            this.btnTim_Click.Size = new System.Drawing.Size(75, 41);
            this.btnTim_Click.TabIndex = 12;
            this.btnTim_Click.Text = "Tìm kiếm";
            this.btnTim_Click.UseVisualStyleBackColor = true;
            this.btnTim_Click.Click += new System.EventHandler(this.btnTim_Click_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(316, 349);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(772, 320);
            this.dgvHoaDon.TabIndex = 14;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa_Click);
            this.groupBox2.Controls.Add(this.btnSua_Click);
            this.groupBox2.Controls.Add(this.btnThem_Click);
            this.groupBox2.Location = new System.Drawing.Point(954, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(313, 238);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnXoa_Click
            // 
            this.btnXoa_Click.Location = new System.Drawing.Point(187, 68);
            this.btnXoa_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa_Click.Name = "btnXoa_Click";
            this.btnXoa_Click.Size = new System.Drawing.Size(119, 59);
            this.btnXoa_Click.TabIndex = 3;
            this.btnXoa_Click.Text = "Xóa";
            this.btnXoa_Click.UseVisualStyleBackColor = true;
            this.btnXoa_Click.Click += new System.EventHandler(this.btnXoa_Click_Click);
            // 
            // btnSua_Click
            // 
            this.btnSua_Click.Location = new System.Drawing.Point(61, 140);
            this.btnSua_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua_Click.Name = "btnSua_Click";
            this.btnSua_Click.Size = new System.Drawing.Size(119, 59);
            this.btnSua_Click.TabIndex = 1;
            this.btnSua_Click.Text = "Sửa";
            this.btnSua_Click.UseVisualStyleBackColor = true;
            this.btnSua_Click.Click += new System.EventHandler(this.btnSua_Click_Click);
            // 
            // btnThem_Click
            // 
            this.btnThem_Click.Location = new System.Drawing.Point(61, 68);
            this.btnThem_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem_Click.Name = "btnThem_Click";
            this.btnThem_Click.Size = new System.Drawing.Size(119, 59);
            this.btnThem_Click.TabIndex = 0;
            this.btnThem_Click.Text = "Thêm";
            this.btnThem_Click.UseVisualStyleBackColor = true;
            this.btnThem_Click.Click += new System.EventHandler(this.btnThem_Click_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_InHD);
            this.groupBox1.Controls.Add(this.btn_chitietHD);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cbb_maKH);
            this.groupBox1.Controls.Add(this.cbb_maNV);
            this.groupBox1.Controls.Add(this.mtbNgayLap);
            this.groupBox1.Controls.Add(this.txtsoHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(154, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(795, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // btn_InHD
            // 
            this.btn_InHD.Location = new System.Drawing.Point(653, 228);
            this.btn_InHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(119, 59);
            this.btn_InHD.TabIndex = 18;
            this.btn_InHD.Text = "In hóa đơn";
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_chitietHD
            // 
            this.btn_chitietHD.Location = new System.Drawing.Point(653, 49);
            this.btn_chitietHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chitietHD.Name = "btn_chitietHD";
            this.btn_chitietHD.Size = new System.Drawing.Size(119, 59);
            this.btn_chitietHD.TabIndex = 4;
            this.btn_chitietHD.Text = "Chi tiết hóa đơn";
            this.btn_chitietHD.UseVisualStyleBackColor = true;
            this.btn_chitietHD.Click += new System.EventHandler(this.btn_chitietHD_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(653, 140);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 59);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbb_maKH
            // 
            this.cbb_maKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maKH.FormattingEnabled = true;
            this.cbb_maKH.Location = new System.Drawing.Point(181, 190);
            this.cbb_maKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_maKH.Name = "cbb_maKH";
            this.cbb_maKH.Size = new System.Drawing.Size(179, 24);
            this.cbb_maKH.TabIndex = 15;
            // 
            // cbb_maNV
            // 
            this.cbb_maNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maNV.FormattingEnabled = true;
            this.cbb_maNV.Location = new System.Drawing.Point(181, 135);
            this.cbb_maNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_maNV.Name = "cbb_maNV";
            this.cbb_maNV.Size = new System.Drawing.Size(179, 24);
            this.cbb_maNV.TabIndex = 14;
            // 
            // mtbNgayLap
            // 
            this.mtbNgayLap.Location = new System.Drawing.Point(181, 242);
            this.mtbNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbNgayLap.Mask = "00/00/0000";
            this.mtbNgayLap.Name = "mtbNgayLap";
            this.mtbNgayLap.Size = new System.Drawing.Size(179, 22);
            this.mtbNgayLap.TabIndex = 9;
            this.mtbNgayLap.ValidatingType = typeof(System.DateTime);
            this.mtbNgayLap.Validating += new System.ComponentModel.CancelEventHandler(this.mtbNgayLap_Validating);
            // 
            // txtsoHD
            // 
            this.txtsoHD.Location = new System.Drawing.Point(181, 86);
            this.txtsoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoHD.Name = "txtsoHD";
            this.txtsoHD.Size = new System.Drawing.Size(179, 22);
            this.txtsoHD.TabIndex = 6;
            this.txtsoHD.Validating += new System.ComponentModel.CancelEventHandler(this.txtsoHD_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 616);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim_Click);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim_Click;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa_Click;
        private System.Windows.Forms.Button btnSua_Click;
        private System.Windows.Forms.Button btnThem_Click;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Button btn_chitietHD;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbb_maKH;
        private System.Windows.Forms.ComboBox cbb_maNV;
        private System.Windows.Forms.MaskedTextBox mtbNgayLap;
        private System.Windows.Forms.TextBox txtsoHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}