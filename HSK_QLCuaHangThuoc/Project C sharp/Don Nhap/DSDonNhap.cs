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
    public partial class DSDonNhap : Form
    {
        ClassMain dch = new ClassMain();
        public DSDonNhap()
        {
            InitializeComponent();
           

        }

        private void load()
        {
            // IN TOAN BO DON NHAP

             if (dch.ketnoi() == false)
                 return;
             string sql = "pr_baocaodn";
             SqlCommand cmd = new SqlCommand(sql, dch.cnn);
             cmd.CommandType = CommandType.StoredProcedure;
             using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
             {
                 DataTable tb = new System.Data.DataTable();
                 ad.Fill(tb);

                ReportDonNhap rpt = new ReportDonNhap();
                rpt.SetDataSource(tb);
                 crystalDonNhap.ReportSource = rpt;
                 crystalDonNhap.Refresh();
             }
        }

        private void trangthai()
        {
            if (dch.ketnoi() == false)
                return;
            string sql = "pr_dnthanhtoan";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@trangthai", txtTrangThai.Text);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable dt = new System.Data.DataTable();
                ad.Fill(dt);
                ReportDonNhap rpt = new ReportDonNhap();
                rpt.SetDataSource(dt);
                crystalDonNhap.ReportSource = rpt;
                crystalDonNhap.Refresh();
            }
        }

        private void nhanvien()
        {
            if (dch.ketnoi() == false)
                return;
            string sql = "pr_timkiemdnncc";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennv", txtNhanVien.Text);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                ReportDonNhap rpt = new ReportDonNhap();
                rpt.SetDataSource(tb);
                crystalDonNhap.ReportSource = rpt;
                crystalDonNhap.Refresh();
            }
        }
        private void SoDN()
        {
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
                ReportDonNhap rpt = new ReportDonNhap();
                rpt.SetDataSource(tb);
                crystalDonNhap.ReportSource = rpt;
                crystalDonNhap.Refresh();
            }
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

        private void thongketheothang()
        {
            if (dch.ketnoi() == false)
                return;
            string sql = "pr_thangnam";
            SqlCommand cmd = new SqlCommand(sql, dch.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngay", dtThangnam.Value);
            using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
            {
                DataTable tb = new System.Data.DataTable();
                ad.Fill(tb);
                ReportDonNhap rpt = new ReportDonNhap();
                rpt.SetDataSource(tb);
                crystalDonNhap.ReportSource = rpt;
                crystalDonNhap.Refresh();
            }
        }
        private void AnDieukhien()
        {
            txtNhanVien.Visible = false;
            dtThangnam.Visible = false;
            txtSoDN.Visible = false;
            txtTrangThai.Visible = false;

        }





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



     

     

      

        private void DSDonNhap_Load(object sender, EventArgs e)
        {
            load();
            AnDieukhien();
        }

        private void rdbTrangthai_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtTrangThai.Visible = true;
            txtTrangThai.Top = rdbSoDN.Top;
        }

        private void rdbSoDN_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtSoDN.Visible = true;
            txtSoDN.Top = rdbSoDN.Top;
        }

        private void rdbNgayLap_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            dtThangnam.Visible = true;
            dtThangnam.Top = rdbNgayLap.Top;
        }

        private void rdbNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            AnDieukhien();
            txtNhanVien.Visible = true;
            txtNhanVien.Top = rdbNhanVien.Top;
        }

        private void btnInDN_Click(object sender, EventArgs e)
        {
            if (rdbNhanVien.Checked)
            {
                nhanvien();
            }
            if (rdbSoDN.Checked)
            {
                SoDN();
            }
            if (rdbNgayLap.Checked)
            {
                thongketheothang();
            }
            if (rdbTrangthai.Checked)
            {
                trangthai();
            }
        }

        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {
           
           /* if(txtNhanVien.Text.Length>=4)
            {
                btnInDN.Visible = true;
            }*/
        }
    }
}

