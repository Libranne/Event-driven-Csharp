
namespace Project_C_sharp
{
    partial class DoiMatKhau
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
            this.txtuser_check = new System.Windows.Forms.TextBox();
            this.txtpass_check = new System.Windows.Forms.TextBox();
            this.btnThayDoi_MatKhau = new System.Windows.Forms.Button();
            this.txtPass_Moi_XacNhan = new System.Windows.Forms.TextBox();
            this.txtPass_Moi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass_Cu = new System.Windows.Forms.TextBox();
            this.cbHienMK_ThayDoiMK = new System.Windows.Forms.CheckBox();
            this.btnHuyThayDoi_MatKhau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtuser_check
            // 
            this.txtuser_check.Location = new System.Drawing.Point(570, 105);
            this.txtuser_check.Name = "txtuser_check";
            this.txtuser_check.Size = new System.Drawing.Size(100, 22);
            this.txtuser_check.TabIndex = 20;
            this.txtuser_check.Visible = false;
            // 
            // txtpass_check
            // 
            this.txtpass_check.Location = new System.Drawing.Point(570, 133);
            this.txtpass_check.Name = "txtpass_check";
            this.txtpass_check.Size = new System.Drawing.Size(100, 22);
            this.txtpass_check.TabIndex = 19;
            this.txtpass_check.Visible = false;
            // 
            // btnThayDoi_MatKhau
            // 
            this.btnThayDoi_MatKhau.Location = new System.Drawing.Point(306, 331);
            this.btnThayDoi_MatKhau.Name = "btnThayDoi_MatKhau";
            this.btnThayDoi_MatKhau.Size = new System.Drawing.Size(90, 29);
            this.btnThayDoi_MatKhau.TabIndex = 14;
            this.btnThayDoi_MatKhau.Text = "Thay đổi";
            this.btnThayDoi_MatKhau.UseVisualStyleBackColor = true;
            this.btnThayDoi_MatKhau.Click += new System.EventHandler(this.btnThayDoi_MatKhau_Click);
            // 
            // txtPass_Moi_XacNhan
            // 
            this.txtPass_Moi_XacNhan.Location = new System.Drawing.Point(281, 265);
            this.txtPass_Moi_XacNhan.Name = "txtPass_Moi_XacNhan";
            this.txtPass_Moi_XacNhan.Size = new System.Drawing.Size(100, 22);
            this.txtPass_Moi_XacNhan.TabIndex = 13;
            this.txtPass_Moi_XacNhan.UseSystemPasswordChar = true;
            // 
            // txtPass_Moi
            // 
            this.txtPass_Moi.Location = new System.Drawing.Point(281, 214);
            this.txtPass_Moi.Name = "txtPass_Moi";
            this.txtPass_Moi.Size = new System.Drawing.Size(100, 22);
            this.txtPass_Moi.TabIndex = 12;
            this.txtPass_Moi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thay Đổi Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtPass_Cu
            // 
            this.txtPass_Cu.Location = new System.Drawing.Point(281, 163);
            this.txtPass_Cu.Name = "txtPass_Cu";
            this.txtPass_Cu.Size = new System.Drawing.Size(100, 22);
            this.txtPass_Cu.TabIndex = 10;
            // 
            // cbHienMK_ThayDoiMK
            // 
            this.cbHienMK_ThayDoiMK.AutoSize = true;
            this.cbHienMK_ThayDoiMK.Location = new System.Drawing.Point(424, 267);
            this.cbHienMK_ThayDoiMK.Name = "cbHienMK_ThayDoiMK";
            this.cbHienMK_ThayDoiMK.Size = new System.Drawing.Size(140, 21);
            this.cbHienMK_ThayDoiMK.TabIndex = 18;
            this.cbHienMK_ThayDoiMK.Text = "Hiển thị mật khẩu";
            this.cbHienMK_ThayDoiMK.UseVisualStyleBackColor = true;
            this.cbHienMK_ThayDoiMK.CheckedChanged += new System.EventHandler(this.cbHienMK_ThayDoiMK_CheckedChanged);
            // 
            // btnHuyThayDoi_MatKhau
            // 
            this.btnHuyThayDoi_MatKhau.Location = new System.Drawing.Point(185, 331);
            this.btnHuyThayDoi_MatKhau.Name = "btnHuyThayDoi_MatKhau";
            this.btnHuyThayDoi_MatKhau.Size = new System.Drawing.Size(86, 29);
            this.btnHuyThayDoi_MatKhau.TabIndex = 16;
            this.btnHuyThayDoi_MatKhau.Text = "Hủy";
            this.btnHuyThayDoi_MatKhau.UseVisualStyleBackColor = true;
            this.btnHuyThayDoi_MatKhau.Click += new System.EventHandler(this.btnHuyThayDoi_MatKhau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtuser_check);
            this.Controls.Add(this.txtpass_check);
            this.Controls.Add(this.btnThayDoi_MatKhau);
            this.Controls.Add(this.txtPass_Moi_XacNhan);
            this.Controls.Add(this.txtPass_Moi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass_Cu);
            this.Controls.Add(this.cbHienMK_ThayDoiMK);
            this.Controls.Add(this.btnHuyThayDoi_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser_check;
        private System.Windows.Forms.TextBox txtpass_check;
        private System.Windows.Forms.Button btnThayDoi_MatKhau;
        private System.Windows.Forms.TextBox txtPass_Moi_XacNhan;
        private System.Windows.Forms.TextBox txtPass_Moi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass_Cu;
        private System.Windows.Forms.CheckBox cbHienMK_ThayDoiMK;
        private System.Windows.Forms.Button btnHuyThayDoi_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}