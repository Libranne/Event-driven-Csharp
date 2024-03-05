using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_sharp
{
    public partial class InCTDN : Form
    {
        ClassMain dch = new ClassMain();
        public InCTDN(string sodn)
        {
            InitializeComponent();
            txtSoDN.Text = sodn;

            if (dch.ketnoi() == false)
                return;
            string sql = "pr_baocaoctdn";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sodn", txtSoDN.Text);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                /* Don_Nhap.CrystalReportDonNhap rp = new Don_Nhap.CrystalReportDonNhap();*/
                ReportDonNhap rp = new ReportDonNhap();
                rp.SetDataSource(tb);
                crytalCTDN.ReportSource = rp;
                crytalCTDN.Refresh();
            }
        }

        private void InCTDN_Load(object sender, EventArgs e)
        {

        }

        private void crytalCTDN_Load(object sender, EventArgs e)
        {

        }
    }
}
