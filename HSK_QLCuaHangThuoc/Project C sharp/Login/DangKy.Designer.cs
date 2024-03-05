
namespace Project_C_sharp
{
    partial class DangKy
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbHienMK_DangKy = new System.Windows.Forms.CheckBox();
            this.btnDangKy_Moi = new System.Windows.Forms.Button();
            this.txtPass_NhapLai = new System.Windows.Forms.TextBox();
            this.txtPass_DangKy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy_DangKy = new System.Windows.Forms.Button();
            this.txtUser_DangKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "ĐĂNG KÝ TÀI KHOẢN MỚI";
            // 
            // cbHienMK_DangKy
            // 
            this.cbHienMK_DangKy.AutoSize = true;
            this.cbHienMK_DangKy.Location = new System.Drawing.Point(476, 268);
            this.cbHienMK_DangKy.Name = "cbHienMK_DangKy";
            this.cbHienMK_DangKy.Size = new System.Drawing.Size(140, 21);
            this.cbHienMK_DangKy.TabIndex = 18;
            this.cbHienMK_DangKy.Text = "Hiển thị mật khẩu";
            this.cbHienMK_DangKy.UseVisualStyleBackColor = true;
            this.cbHienMK_DangKy.CheckedChanged += new System.EventHandler(this.cbHienMK_DangKy_CheckedChanged);
            // 
            // btnDangKy_Moi
            // 
            this.btnDangKy_Moi.Location = new System.Drawing.Point(376, 324);
            this.btnDangKy_Moi.Name = "btnDangKy_Moi";
            this.btnDangKy_Moi.Size = new System.Drawing.Size(77, 30);
            this.btnDangKy_Moi.TabIndex = 15;
            this.btnDangKy_Moi.Text = "Đăng ký";
            this.btnDangKy_Moi.UseVisualStyleBackColor = true;
            this.btnDangKy_Moi.Click += new System.EventHandler(this.btnDangKy_Moi_Click);
            // 
            // txtPass_NhapLai
            // 
            this.txtPass_NhapLai.Location = new System.Drawing.Point(332, 265);
            this.txtPass_NhapLai.Name = "txtPass_NhapLai";
            this.txtPass_NhapLai.Size = new System.Drawing.Size(102, 22);
            this.txtPass_NhapLai.TabIndex = 13;
            this.txtPass_NhapLai.UseSystemPasswordChar = true;
            this.txtPass_NhapLai.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_NhapLai_Validating);
            // 
            // txtPass_DangKy
            // 
            this.txtPass_DangKy.Location = new System.Drawing.Point(332, 211);
            this.txtPass_DangKy.Name = "txtPass_DangKy";
            this.txtPass_DangKy.Size = new System.Drawing.Size(102, 22);
            this.txtPass_DangKy.TabIndex = 12;
            this.txtPass_DangKy.UseSystemPasswordChar = true;
            this.txtPass_DangKy.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_DangKy_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // btnHuy_DangKy
            // 
            this.btnHuy_DangKy.Location = new System.Drawing.Point(255, 324);
            this.btnHuy_DangKy.Name = "btnHuy_DangKy";
            this.btnHuy_DangKy.Size = new System.Drawing.Size(77, 30);
            this.btnHuy_DangKy.TabIndex = 17;
            this.btnHuy_DangKy.Text = "Hủy";
            this.btnHuy_DangKy.UseVisualStyleBackColor = true;
            this.btnHuy_DangKy.Click += new System.EventHandler(this.btnHuy_DangKy_Click);
            // 
            // txtUser_DangKy
            // 
            this.txtUser_DangKy.Location = new System.Drawing.Point(332, 170);
            this.txtUser_DangKy.Name = "txtUser_DangKy";
            this.txtUser_DangKy.Size = new System.Drawing.Size(102, 22);
            this.txtUser_DangKy.TabIndex = 11;
            this.txtUser_DangKy.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_DangKy_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập tài khoản";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHienMK_DangKy);
            this.Controls.Add(this.btnDangKy_Moi);
            this.Controls.Add(this.txtPass_NhapLai);
            this.Controls.Add(this.txtPass_DangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy_DangKy);
            this.Controls.Add(this.txtUser_DangKy);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbHienMK_DangKy;
        private System.Windows.Forms.Button btnDangKy_Moi;
        private System.Windows.Forms.TextBox txtPass_NhapLai;
        private System.Windows.Forms.TextBox txtPass_DangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy_DangKy;
        private System.Windows.Forms.TextBox txtUser_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}