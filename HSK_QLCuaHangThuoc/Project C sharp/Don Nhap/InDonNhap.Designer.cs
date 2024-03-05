
namespace Project_C_sharp
{
    partial class InDonNhap
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
            this.crystalDonNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalDonNhap
            // 
            this.crystalDonNhap.ActiveViewIndex = -1;
            this.crystalDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalDonNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalDonNhap.Location = new System.Drawing.Point(25, 12);
            this.crystalDonNhap.Name = "crystalDonNhap";
            this.crystalDonNhap.Size = new System.Drawing.Size(1380, 453);
            this.crystalDonNhap.TabIndex = 0;
            this.crystalDonNhap.Load += new System.EventHandler(this.crystalDonNhap_Load_1);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(105, 491);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(100, 22);
            this.txtTrangThai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trang Thai";
            // 
            // InDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.crystalDonNhap);
            this.Name = "InDonNhap";
            this.Text = "InDonNhap";
            this.Load += new System.EventHandler(this.InDonNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalDonNhap;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label1;
    }
}