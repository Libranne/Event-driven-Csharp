using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listNXB.Items.Add("NXB04");
            listNXB.Items.Add("NXB05");
            layDSTS();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textNXB.Text = listNXB.Items[listNXB.SelectedIndex].ToString();
            textNXB.Text = listNXB.Text;
        }
        private void layDSTS()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLySach"].ConnectionString;
           // MessageBox.Show(constr);
           using (SqlConnection cnn=new SqlConnection(constr))
            {
                using (SqlCommand cmd=new SqlCommand("Select*from tblSach",cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter (cmd))
                    {
                        DataTable tb = new DataTable("Sach");
                        ad.Fill(tb);
                        cbbSach.DataSource = tb;
                        cbbSach.DisplayMember = "sTieude";
                        cbbSach.ValueMember = "sMasach";
                    }
                }
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Ban da chon sach: {0} co ma sach la {1}", cbbSach.Text, cbbSach.SelectedValue),
                "Thong bao", MessageBoxButtons.OK);
        }

        private void cbbSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          /* int r1 = Convert.ToInt32(radioButton1.Text);
            if(r1==3)
            {
                button1.Visible = true;
            }*/
          if(radioButton1.Text.Equals(3))
            {
                button1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text.Length >3)
            {
                button1.Visible = true;
            }
        }
    }
}
