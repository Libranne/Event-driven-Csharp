using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThemSVpr
{
    class Program
    {


        static void Main(string[] args)
        {

            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    int masv; string hoten; DateTime ngaysinh; string gt;
                    Console.WriteLine("Nhap ma SV:");
                    masv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap ho ten SV:");
                    hoten = Console.ReadLine();
                    Console.WriteLine("Nhap ngay sinh:");
                    ngaysinh = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Nhap gioi tinh SV:");
                    gt = Console.ReadLine();

                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_ThemSV";
                        cmd.Parameters.AddWithValue("@masv", masv);
                        cmd.Parameters.AddWithValue("@tensv", hoten);
                        cmd.Parameters.AddWithValue("@ns", ngaysinh);
                        cmd.Parameters.AddWithValue("@gt", gt);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) Console.WriteLine("them thanh cong");
                        else Console.WriteLine("them khong thanh cong");

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
