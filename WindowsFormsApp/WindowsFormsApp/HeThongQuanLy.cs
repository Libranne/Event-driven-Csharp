using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class HeThongQuanLy : Form
    {
        public HeThongQuanLy()
        {
            InitializeComponent();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.MdiParent = this;
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("ban co chac muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
             Close();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void caculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator C = new Calculator();
            C.MdiParent = this;
            C.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information I = new Information();
            I.MdiParent = this;
            I.Show();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach Q = new QuanLySach();
            Q.MdiParent = this;
            Q.Show();
        }

        private void tinhTienSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Tinhtiensach T = new Tinhtiensach();
            T.MdiParent = this;
            T.Show();
        }
    }
}
