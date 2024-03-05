
namespace Project_C_sharp
{
    partial class InHoaDon
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
            this.btn_In = new System.Windows.Forms.Button();
            this.dtNgaylap = new System.Windows.Forms.DateTimePicker();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.rdbngaylap = new System.Windows.Forms.RadioButton();
            this.rdbSoHD = new System.Windows.Forms.RadioButton();
            this.rdpNV = new System.Windows.Forms.RadioButton();
            this.crystalReportViewerHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(1021, 667);
            this.btn_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(131, 32);
            this.btn_In.TabIndex = 23;
            this.btn_In.Text = "In";
            this.btn_In.UseVisualStyleBackColor = true;
            // 
            // dtNgaylap
            // 
            this.dtNgaylap.Location = new System.Drawing.Point(1048, 46);
            this.dtNgaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaylap.Name = "dtNgaylap";
            this.dtNgaylap.Size = new System.Drawing.Size(231, 22);
            this.dtNgaylap.TabIndex = 22;
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(673, 43);
            this.txtHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(157, 22);
            this.txtHD.TabIndex = 21;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(289, 45);
            this.txtNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(157, 22);
            this.txtNV.TabIndex = 20;
            // 
            // rdbngaylap
            // 
            this.rdbngaylap.AutoSize = true;
            this.rdbngaylap.Location = new System.Drawing.Point(934, 46);
            this.rdbngaylap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbngaylap.Name = "rdbngaylap";
            this.rdbngaylap.Size = new System.Drawing.Size(85, 21);
            this.rdbngaylap.TabIndex = 19;
            this.rdbngaylap.TabStop = true;
            this.rdbngaylap.Text = "Ngày lập";
            this.rdbngaylap.UseVisualStyleBackColor = true;
            // 
            // rdbSoHD
            // 
            this.rdbSoHD.AutoSize = true;
            this.rdbSoHD.Location = new System.Drawing.Point(565, 45);
            this.rdbSoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSoHD.Name = "rdbSoHD";
            this.rdbSoHD.Size = new System.Drawing.Size(102, 21);
            this.rdbSoHD.TabIndex = 18;
            this.rdbSoHD.TabStop = true;
            this.rdbSoHD.Text = "Số hóa đơn";
            this.rdbSoHD.UseVisualStyleBackColor = true;
            // 
            // rdpNV
            // 
            this.rdpNV.AutoSize = true;
            this.rdpNV.Location = new System.Drawing.Point(190, 46);
            this.rdpNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdpNV.Name = "rdpNV";
            this.rdpNV.Size = new System.Drawing.Size(93, 21);
            this.rdpNV.TabIndex = 17;
            this.rdpNV.TabStop = true;
            this.rdpNV.Text = "Nhân viên";
            this.rdpNV.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewerHD
            // 
            this.crystalReportViewerHD.ActiveViewIndex = -1;
            this.crystalReportViewerHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHD.Location = new System.Drawing.Point(157, 125);
            this.crystalReportViewerHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewerHD.Name = "crystalReportViewerHD";
            this.crystalReportViewerHD.Size = new System.Drawing.Size(1151, 513);
            this.crystalReportViewerHD.TabIndex = 16;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 743);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.dtNgaylap);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.rdbngaylap);
            this.Controls.Add(this.rdbSoHD);
            this.Controls.Add(this.rdpNV);
            this.Controls.Add(this.crystalReportViewerHD);
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.DateTimePicker dtNgaylap;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.RadioButton rdbngaylap;
        private System.Windows.Forms.RadioButton rdbSoHD;
        private System.Windows.Forms.RadioButton rdpNV;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHD;
    }
}