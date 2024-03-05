
namespace Project_C_sharp
{
    partial class InCTDN
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
            this.crytalCTDN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sodn = new System.Windows.Forms.Label();
            this.txtSoDN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crytalCTDN
            // 
            this.crytalCTDN.ActiveViewIndex = -1;
            this.crytalCTDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crytalCTDN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crytalCTDN.Location = new System.Drawing.Point(12, 27);
            this.crytalCTDN.Name = "crytalCTDN";
            this.crytalCTDN.Size = new System.Drawing.Size(1375, 581);
            this.crytalCTDN.TabIndex = 0;
            this.crytalCTDN.Load += new System.EventHandler(this.crytalCTDN_Load);
            // 
            // sodn
            // 
            this.sodn.AutoSize = true;
            this.sodn.Location = new System.Drawing.Point(37, 4);
            this.sodn.Name = "sodn";
            this.sodn.Size = new System.Drawing.Size(93, 17);
            this.sodn.TabIndex = 1;
            this.sodn.Text = "So Don Nhap";
            // 
            // txtSoDN
            // 
            this.txtSoDN.Location = new System.Drawing.Point(136, 1);
            this.txtSoDN.Name = "txtSoDN";
            this.txtSoDN.Size = new System.Drawing.Size(100, 22);
            this.txtSoDN.TabIndex = 2;
            // 
            // InCTDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 609);
            this.Controls.Add(this.txtSoDN);
            this.Controls.Add(this.sodn);
            this.Controls.Add(this.crytalCTDN);
            this.Name = "InCTDN";
            this.Text = "InCTDN";
            this.Load += new System.EventHandler(this.InCTDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crytalCTDN;
        private System.Windows.Forms.Label sodn;
        private System.Windows.Forms.TextBox txtSoDN;
    }
}