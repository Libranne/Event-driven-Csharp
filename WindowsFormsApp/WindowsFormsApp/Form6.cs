using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";


            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DStheoten";
                    cmd.Parameters.AddWithValue("@tennxb", txtTenNXB.Text);

;                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                       CrystalReport4 rpt = new CrystalReport4();
                        rpt.SetDataSource(tb);
                        crystalReportViewer1.ReportSource = rpt;
                        crystalReportViewer1.Refresh();

                    }
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
