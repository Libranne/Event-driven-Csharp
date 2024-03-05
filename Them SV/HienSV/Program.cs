using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HienSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSINHVIEN", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}",rd["masv"],
                                rd["shoten"],rd["sgioitinh"],rd["dngaysinh"]);
                        rd.Close();
                    }
                    cnn.Close();
                    Console.Read();
                }
            }
        }
    }
}
