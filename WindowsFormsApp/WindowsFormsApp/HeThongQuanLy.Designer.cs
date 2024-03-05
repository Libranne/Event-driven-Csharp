
namespace WindowsFormsApp
{
    partial class HeThongQuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTienSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.heThongToolStripMenuItem.Text = "He Thong";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.dangNhapToolStripMenuItem.Text = "Log in";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.dangNhapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.caculatorToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.quanLySachToolStripMenuItem,
            this.tinhTienSachToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quanLyToolStripMenuItem.Text = "Quan Ly";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.form1ToolStripMenuItem.Text = "Form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // caculatorToolStripMenuItem
            // 
            this.caculatorToolStripMenuItem.Name = "caculatorToolStripMenuItem";
            this.caculatorToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.caculatorToolStripMenuItem.Text = "Calculator";
            this.caculatorToolStripMenuItem.Click += new System.EventHandler(this.caculatorToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // quanLySachToolStripMenuItem
            // 
            this.quanLySachToolStripMenuItem.Name = "quanLySachToolStripMenuItem";
            this.quanLySachToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.quanLySachToolStripMenuItem.Text = "QuanLySach";
            this.quanLySachToolStripMenuItem.Click += new System.EventHandler(this.quanLySachToolStripMenuItem_Click);
            // 
            // tinhTienSachToolStripMenuItem
            // 
            this.tinhTienSachToolStripMenuItem.Name = "tinhTienSachToolStripMenuItem";
            this.tinhTienSachToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.tinhTienSachToolStripMenuItem.Text = "TinhTienSach";
            this.tinhTienSachToolStripMenuItem.Click += new System.EventHandler(this.tinhTienSachToolStripMenuItem_Click);
            // 
            // HeThongQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 586);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeThongQuanLy";
            this.Text = "He Thong Quan Ly";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhTienSachToolStripMenuItem;
    }
}