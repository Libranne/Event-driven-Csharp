
namespace Project_C_sharp
{
    partial class DSDonNhap
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
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoDN = new System.Windows.Forms.TextBox();
            this.rdbSoDN = new System.Windows.Forms.RadioButton();
            this.btnInDN = new System.Windows.Forms.Button();
            this.dtThangnam = new System.Windows.Forms.DateTimePicker();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.rdbNgayLap = new System.Windows.Forms.RadioButton();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.crystalDonNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rdbTrangthai = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(144, 19);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(147, 22);
            this.txtTrangThai.TabIndex = 19;
            // 
            // txtSoDN
            // 
            this.txtSoDN.Location = new System.Drawing.Point(895, 19);
            this.txtSoDN.Name = "txtSoDN";
            this.txtSoDN.Size = new System.Drawing.Size(147, 22);
            this.txtSoDN.TabIndex = 18;
            // 
            // rdbSoDN
            // 
            this.rdbSoDN.AutoSize = true;
            this.rdbSoDN.Location = new System.Drawing.Point(775, 19);
            this.rdbSoDN.Name = "rdbSoDN";
            this.rdbSoDN.Size = new System.Drawing.Size(114, 21);
            this.rdbSoDN.TabIndex = 17;
            this.rdbSoDN.TabStop = true;
            this.rdbSoDN.Text = "Số Đơn Nhập";
            this.rdbSoDN.UseVisualStyleBackColor = true;
            this.rdbSoDN.CheckedChanged += new System.EventHandler(this.rdbSoDN_CheckedChanged);
            // 
            // btnInDN
            // 
            this.btnInDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInDN.Location = new System.Drawing.Point(1190, 527);
            this.btnInDN.Name = "btnInDN";
            this.btnInDN.Size = new System.Drawing.Size(155, 35);
            this.btnInDN.TabIndex = 16;
            this.btnInDN.Text = "In Don Nhap";
            this.btnInDN.UseVisualStyleBackColor = false;
            this.btnInDN.Click += new System.EventHandler(this.btnInDN_Click);
            // 
            // dtThangnam
            // 
            this.dtThangnam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtThangnam.Location = new System.Drawing.Point(1190, 19);
            this.dtThangnam.Name = "dtThangnam";
            this.dtThangnam.Size = new System.Drawing.Size(200, 22);
            this.dtThangnam.TabIndex = 15;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(606, 19);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(147, 22);
            this.txtNhanVien.TabIndex = 14;
            this.txtNhanVien.TextChanged += new System.EventHandler(this.txtNhanVien_TextChanged);
            // 
            // rdbNgayLap
            // 
            this.rdbNgayLap.AutoSize = true;
            this.rdbNgayLap.Location = new System.Drawing.Point(1070, 19);
            this.rdbNgayLap.Name = "rdbNgayLap";
            this.rdbNgayLap.Size = new System.Drawing.Size(90, 21);
            this.rdbNgayLap.TabIndex = 13;
            this.rdbNgayLap.TabStop = true;
            this.rdbNgayLap.Text = "Ngày Lập";
            this.rdbNgayLap.UseVisualStyleBackColor = true;
            this.rdbNgayLap.CheckedChanged += new System.EventHandler(this.rdbNgayLap_CheckedChanged);
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(482, 19);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(95, 21);
            this.rdbNhanVien.TabIndex = 12;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân Viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            this.rdbNhanVien.CheckedChanged += new System.EventHandler(this.rdbNhanVien_CheckedChanged);
            // 
            // crystalDonNhap
            // 
            this.crystalDonNhap.ActiveViewIndex = -1;
            this.crystalDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalDonNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalDonNhap.Location = new System.Drawing.Point(12, 78);
            this.crystalDonNhap.Name = "crystalDonNhap";
            this.crystalDonNhap.Size = new System.Drawing.Size(1403, 443);
            this.crystalDonNhap.TabIndex = 11;
            // 
            // rdbTrangthai
            // 
            this.rdbTrangthai.AutoSize = true;
            this.rdbTrangthai.Location = new System.Drawing.Point(27, 19);
            this.rdbTrangthai.Name = "rdbTrangthai";
            this.rdbTrangthai.Size = new System.Drawing.Size(99, 21);
            this.rdbTrangthai.TabIndex = 21;
            this.rdbTrangthai.TabStop = true;
            this.rdbTrangthai.Text = "Trạng Thái";
            this.rdbTrangthai.UseVisualStyleBackColor = true;
            this.rdbTrangthai.CheckedChanged += new System.EventHandler(this.rdbTrangthai_CheckedChanged);
            // 
            // DSDonNhap
            // 
            this.ClientSize = new System.Drawing.Size(1470, 578);
            this.Controls.Add(this.rdbTrangthai);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtSoDN);
            this.Controls.Add(this.rdbSoDN);
            this.Controls.Add(this.btnInDN);
            this.Controls.Add(this.dtThangnam);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.rdbNgayLap);
            this.Controls.Add(this.rdbNhanVien);
            this.Controls.Add(this.crystalDonNhap);
            this.Name = "DSDonNhap";
            this.Load += new System.EventHandler(this.DSDonNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSoDN;
        private System.Windows.Forms.RadioButton rdbSoDN;
        private System.Windows.Forms.Button btnInDN;
        private System.Windows.Forms.DateTimePicker dtThangnam;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.RadioButton rdbNgayLap;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalDonNhap;
        private System.Windows.Forms.RadioButton rdbTrangthai;
    }
}