using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Project_C_sharp
{
    class ClassMain
    {
        public string str = @"Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        public SqlConnection cnn = new SqlConnection();

        public bool ketnoi()
        {
            try
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.ConnectionString = str;
                cnn.Open();
            }
            catch
            {
                MessageBox.Show(" loi ket noi co so du lieu", "thong bao");
                return false;
            }

            return true;
        }

    

        public DataTable TableDN(string DonNhap)
        {
             SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM vvDS_DonNhap", cnn);
         DataTable dt = new DataTable("DonNhap");
         ad.Fill(dt);
         return dt;
        }
        public DataTable TableTT(string ThongTin)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM tblThongTin", cnn);
            DataTable gc = new DataTable("ThongTin");
            ad.Fill(gc);
            return gc;
        }


        public DataTable TableNV(string NhanVien)
        {
            // string sql = "select*from" + tblNhaXuatBan;
            SqlDataAdapter ad = new SqlDataAdapter("Select*from tblNhanVien", cnn);
            DataTable tb = new DataTable("NhanVien");
            ad.Fill(tb);
            return tb;
        }
        public DataTable TableNCC(string NCC)
        {
          
            SqlDataAdapter ad = new SqlDataAdapter("Select*from tblNhaCungCap", cnn);
            DataTable ba = new DataTable("NCC");
            ad.Fill(ba);
            return ba;
        }
        public DataTable TableCTDonNhap(string CTDonNhap)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM vvDS_CTDonNhap", cnn);
            DataTable ct = new DataTable("CTDonNhap");
            ad.Fill(ct);
            return ct;
        }
        public DataTable TableThuoc(string thuoc)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM tblThuoc", cnn);
            DataTable t = new DataTable("thuoc");
            ad.Fill(t);
            return t;
        }
      

        public void Timkiemdl(string thutuc, string thamso, string giatri, DataGridView dgr)
        {
            try
            {
                if (ketnoi() == false)
                    return;
                SqlCommand cmd = new SqlCommand(thutuc, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(thamso, giatri);
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable tk = new DataTable();
                    ad.Fill(tk);
                    dgr.DataSource = tk;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm dữ liệu", "Thông báo");
            }
        }

        public DataTable TableHD(string HD)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM v_HoaDon", cnn);
            DataTable dt = new DataTable("HD");
            ad.Fill(dt);
            return dt;
        }

        public DataTable TableKH(string KH)
        {

            SqlDataAdapter ad = new SqlDataAdapter("Select*from tblKhachHang", cnn);
            DataTable ba = new DataTable("KH");
            ad.Fill(ba);
            return ba;
        }
        public DataTable TableHDT(string HDT)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM V_HDThuoc", cnn);
            DataTable ct = new DataTable("HDT");
            ad.Fill(ct);
            return ct;
        }
        


     
        
    }
    }

