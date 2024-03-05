using Project_C_sharp.Don_Nhap;
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
    public partial class InDonNhap : Form
    {
        ClassMain dch = new ClassMain();
        public InDonNhap()
        {
            InitializeComponent();
          

           /* if (dch.ketnoi() == false)
                return;
            string sql = "pr_dnthanhtoan";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
          
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable dt = new System.Data.DataTable();
                ad.Fill(dt);
                
                ReportCTDN rpt = new ReportCTDN();
                rpt.SetDataSource(dt);
                
                crystalDonNhap.ReportSource = rpt;
                crystalDonNhap.Refresh();
            }*/

        }

        private void InDonNhap_Load(object sender, EventArgs e)
        {
            load();
        }


        private void load()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from vvDS_DonNhap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("DonNhap");
                        ad.Fill(tb);
                        ReportCTDN rpt = new ReportCTDN();
                        rpt.SetDataSource(tb);
                        crystalDonNhap.ReportSource = rpt;
                        crystalDonNhap.Refresh();
                    }
                }
            }

            // IN TOAN BO DON NHAP
           
        }

        private void crystalDonNhap_Load(object sender, EventArgs e)
        {
            load();
        }

        private void crystalDonNhap_Load_1(object sender, EventArgs e)
        {

        }





        /*  private void dongiatrongkhoang()
          {
              if (dch.KetnoiCSDL() == false)
                  return;
              string sql = "pr_timdongiatrongkhoang";
              SqlCommand cmd = new SqlCommand(sql, dch.cnn);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@giabatdau", txtgiabatdau.Text);
              cmd.Parameters.AddWithValue("@giaketthuc", txtgiaketthuc.Text);
              using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
              {
                  DataTable tb = new System.Data.DataTable();
                  ad.Fill(tb);
                  qlsach rpt = new qlsach();
                  rpt.SetDataSource(tb);
                  cryHD.ReportSource = rpt;
                  cryHD.Refresh();
              }
          }*/





        /*    private void rddongia_CheckedChanged(object sender, EventArgs e)
            {
                AnDieukhien();
                txtgiabatdau.Visible = true;
                txtgiaketthuc.Visible = true;
                lbden.Visible = true;
                txtgiabatdau.Top = rddongia.Top;
                txtgiaketthuc.Top = rddongia.Top;
                lbden.Top = rddongia.Top;
                txtkhachhang.Text = null;
            }*/


    }
}





    


