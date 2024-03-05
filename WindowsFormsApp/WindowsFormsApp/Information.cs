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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* if (textBox1.Text == "")
                ErrorProvider.SetError(textBox1, "ban phai nhap ho ten!");
            else ErrorProvider.SetError(textBox1, "");*/
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkBox1.Checked == true)
            {
                str = checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text + "\n";
            }


            if (str.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có sở thích nào bạn chọn!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            if (radioButton1.Checked == true)
            {
                str = radioButton1.Text + "\n";
            }
            if (radioButton2.Checked == true)
            {
                str = radioButton2.Text + "\n";
            }
            if (radioButton3.Checked == true)
            {
                str = radioButton3.Text + "\n";
            }
            if (radioButton4.Checked == true)
            {
                str = radioButton4.Text + "\n";
            }
            

            if (str.Length > 0)
            {
                MessageBox.Show("Màu bạn thích là: \n" + str);
            }
            else
            {
                MessageBox.Show("Không có màu nào bạn chọn!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
                ErrorProvider.Equals(textBox1, "ban phai nhap ho ten");
            else
                ErrorProvider.Equals(textBox1,"");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
                ErrorProvider.Equals(textBox2, "ban phai nhap tuoi");
            else
            {
                try
                {
                    int temp = int.Parse(textBox2.Text);
                    if (temp < 18)
                        ErrorProvider.Equals(textBox2, "tuoi phai lon hon 18!");
                    else
                        ErrorProvider.Equals(textBox2, "");
                }
                catch
                {
                    ErrorProvider.Equals(textBox2, "tuoi phai la so!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ten cua ban la: " + textBox1.Text,"thong bao");
        }
    }
}
