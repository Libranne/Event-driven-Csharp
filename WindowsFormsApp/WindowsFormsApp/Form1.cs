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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void lb_fname_Click(object sender, EventArgs e)
        {

        }

        private void bt_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + tb_name.Text);
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon dong Form lai hay khong?", "Form Closing",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
