using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class ClassMain
    {
        public string str = @"Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
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

            return true; }

        public DataTable getTable(string Sach)
        {
            SqlDataAdapter ad = new SqlDataAdapter("Select*from tblSach", cnn);
            DataTable dt = new DataTable("Sach");
            ad.Fill(dt);
            return dt;
        }
        public DataTable Table(string NXB)
        {
           // string sql = "select*from" + tblNhaXuatBan;
            SqlDataAdapter ad = new SqlDataAdapter("Select*from tblNhaXuatBan", cnn);
            DataTable tb = new DataTable("NXB");
            ad.Fill(tb);
            return tb;
        }
    }
        }
    
