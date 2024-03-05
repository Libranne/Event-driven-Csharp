
namespace Project_C_sharp
{
    partial class CTHoaDon
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
            this.btn_loadclick = new System.Windows.Forms.Button();
            this.cbb_sohd = new System.Windows.Forms.ComboBox();
            this.txt_tittle = new System.Windows.Forms.Label();
            this.cbb_mathuoc = new System.Windows.Forms.ComboBox();
            this.btnXoaHDThuoc_Click = new System.Windows.Forms.Button();
            this.btnSuaHDThuoc_Click = new System.Windows.Forms.Button();
            this.btnThemHDThuoc_Click = new System.Windows.Forms.Button();
            this.txtTimKiemHDThuoc = new System.Windows.Forms.TextBox();
            this.btnTimHDThuoc_Click = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mathuoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDThuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loadclick
            // 
            this.btn_loadclick.Location = new System.Drawing.Point(556, 183);
            this.btn_loadclick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_loadclick.Name = "btn_loadclick";
            this.btn_loadclick.Size = new System.Drawing.Size(119, 59);
            this.btn_loadclick.TabIndex = 56;
            this.btn_loadclick.Text = "Làm mới";
            this.btn_loadclick.UseVisualStyleBackColor = true;
            this.btn_loadclick.Click += new System.EventHandler(this.btn_loadclick_Click);
            // 
            // cbb_sohd
            // 
            this.cbb_sohd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sohd.FormattingEnabled = true;
            this.cbb_sohd.Location = new System.Drawing.Point(251, 97);
            this.cbb_sohd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_sohd.Name = "cbb_sohd";
            this.cbb_sohd.Size = new System.Drawing.Size(188, 24);
            this.cbb_sohd.TabIndex = 55;
            // 
            // txt_tittle
            // 
            this.txt_tittle.AutoSize = true;
            this.txt_tittle.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tittle.Location = new System.Drawing.Point(464, 24);
            this.txt_tittle.Name = "txt_tittle";
            this.txt_tittle.Size = new System.Drawing.Size(357, 31);
            this.txt_tittle.TabIndex = 54;
            this.txt_tittle.Text = "Quản lí chi tiết hóa đơn thuốc";
            // 
            // cbb_mathuoc
            // 
            this.cbb_mathuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_mathuoc.FormattingEnabled = true;
            this.cbb_mathuoc.Location = new System.Drawing.Point(251, 151);
            this.cbb_mathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_mathuoc.Name = "cbb_mathuoc";
            this.cbb_mathuoc.Size = new System.Drawing.Size(188, 24);
            this.cbb_mathuoc.TabIndex = 53;
            // 
            // btnXoaHDThuoc_Click
            // 
            this.btnXoaHDThuoc_Click.Location = new System.Drawing.Point(991, 101);
            this.btnXoaHDThuoc_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaHDThuoc_Click.Name = "btnXoaHDThuoc_Click";
            this.btnXoaHDThuoc_Click.Size = new System.Drawing.Size(119, 59);
            this.btnXoaHDThuoc_Click.TabIndex = 51;
            this.btnXoaHDThuoc_Click.Text = "Xóa";
            this.btnXoaHDThuoc_Click.UseVisualStyleBackColor = true;
            this.btnXoaHDThuoc_Click.Click += new System.EventHandler(this.btnXoaHDThuoc_Click_Click);
            // 
            // btnSuaHDThuoc_Click
            // 
            this.btnSuaHDThuoc_Click.Location = new System.Drawing.Point(556, 101);
            this.btnSuaHDThuoc_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaHDThuoc_Click.Name = "btnSuaHDThuoc_Click";
            this.btnSuaHDThuoc_Click.Size = new System.Drawing.Size(119, 59);
            this.btnSuaHDThuoc_Click.TabIndex = 49;
            this.btnSuaHDThuoc_Click.Text = "Sửa";
            this.btnSuaHDThuoc_Click.UseVisualStyleBackColor = true;
            this.btnSuaHDThuoc_Click.Click += new System.EventHandler(this.btnSuaHDThuoc_Click_Click);
            // 
            // btnThemHDThuoc_Click
            // 
            this.btnThemHDThuoc_Click.Location = new System.Drawing.Point(784, 101);
            this.btnThemHDThuoc_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHDThuoc_Click.Name = "btnThemHDThuoc_Click";
            this.btnThemHDThuoc_Click.Size = new System.Drawing.Size(119, 59);
            this.btnThemHDThuoc_Click.TabIndex = 48;
            this.btnThemHDThuoc_Click.Text = "Thêm";
            this.btnThemHDThuoc_Click.UseVisualStyleBackColor = true;
            this.btnThemHDThuoc_Click.Click += new System.EventHandler(this.btnThemHDThuoc_Click_Click);
            // 
            // txtTimKiemHDThuoc
            // 
            this.txtTimKiemHDThuoc.Location = new System.Drawing.Point(891, 230);
            this.txtTimKiemHDThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemHDThuoc.Multiline = true;
            this.txtTimKiemHDThuoc.Name = "txtTimKiemHDThuoc";
            this.txtTimKiemHDThuoc.Size = new System.Drawing.Size(232, 41);
            this.txtTimKiemHDThuoc.TabIndex = 52;
            // 
            // btnTimHDThuoc_Click
            // 
            this.btnTimHDThuoc_Click.Location = new System.Drawing.Point(809, 230);
            this.btnTimHDThuoc_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimHDThuoc_Click.Name = "btnTimHDThuoc_Click";
            this.btnTimHDThuoc_Click.Size = new System.Drawing.Size(75, 41);
            this.btnTimHDThuoc_Click.TabIndex = 50;
            this.btnTimHDThuoc_Click.Text = "Tìm kiếm";
            this.btnTimHDThuoc_Click.UseVisualStyleBackColor = true;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(251, 202);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(188, 22);
            this.txt_soluong.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số lượng";
            // 
            // mathuoc
            // 
            this.mathuoc.AutoSize = true;
            this.mathuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathuoc.Location = new System.Drawing.Point(123, 151);
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Size = new System.Drawing.Size(83, 20);
            this.mathuoc.TabIndex = 45;
            this.mathuoc.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số hóa đơn";
            // 
            // dgvHDThuoc
            // 
            this.dgvHDThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDThuoc.Location = new System.Drawing.Point(127, 277);
            this.dgvHDThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHDThuoc.Name = "dgvHDThuoc";
            this.dgvHDThuoc.RowHeadersWidth = 51;
            this.dgvHDThuoc.RowTemplate.Height = 24;
            this.dgvHDThuoc.Size = new System.Drawing.Size(995, 386);
            this.dgvHDThuoc.TabIndex = 43;
            this.dgvHDThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDThuoc_CellClick);
            // 
            // CTHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 686);
            this.Controls.Add(this.btn_loadclick);
            this.Controls.Add(this.cbb_sohd);
            this.Controls.Add(this.txt_tittle);
            this.Controls.Add(this.cbb_mathuoc);
            this.Controls.Add(this.btnXoaHDThuoc_Click);
            this.Controls.Add(this.btnSuaHDThuoc_Click);
            this.Controls.Add(this.btnThemHDThuoc_Click);
            this.Controls.Add(this.txtTimKiemHDThuoc);
            this.Controls.Add(this.btnTimHDThuoc_Click);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mathuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHDThuoc);
            this.Name = "CTHoaDon";
            this.Text = "CTHoaDon";
            this.Load += new System.EventHandler(this.CTHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadclick;
        private System.Windows.Forms.ComboBox cbb_sohd;
        private System.Windows.Forms.Label txt_tittle;
        private System.Windows.Forms.ComboBox cbb_mathuoc;
        private System.Windows.Forms.Button btnXoaHDThuoc_Click;
        private System.Windows.Forms.Button btnSuaHDThuoc_Click;
        private System.Windows.Forms.Button btnThemHDThuoc_Click;
        private System.Windows.Forms.TextBox txtTimKiemHDThuoc;
        private System.Windows.Forms.Button btnTimHDThuoc_Click;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mathuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHDThuoc;
    }
}