
namespace WindowsFormsApp
{
    partial class Form1
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
            this.lb_fname = new System.Windows.Forms.Label();
            this.bt_Show = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_fname.Location = new System.Drawing.Point(281, 136);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(71, 17);
            this.lb_fname.TabIndex = 0;
            this.lb_fname.Text = "Full Name";
            this.lb_fname.Click += new System.EventHandler(this.lb_fname_Click);
            // 
            // bt_Show
            // 
            this.bt_Show.ForeColor = System.Drawing.Color.Red;
            this.bt_Show.Location = new System.Drawing.Point(481, 200);
            this.bt_Show.Name = "bt_Show";
            this.bt_Show.Size = new System.Drawing.Size(86, 31);
            this.bt_Show.TabIndex = 1;
            this.bt_Show.Text = "Show";
            this.bt_Show.UseVisualStyleBackColor = true;
            this.bt_Show.Click += new System.EventHandler(this.bt_Show_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(386, 131);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(266, 22);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(653, 227);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 493);
            this.Controls.Add(this.button);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_Show);
            this.Controls.Add(this.lb_fname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Button bt_Show;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button button;
    }
}

