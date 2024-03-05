using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThemSV
{
    class Program
    {
        public static bool themSV(string constr,int masv,string hoten,DateTime ngaysinh,string gioitinh)
        {
            string sqlInsert = "insert into tblSINHVIEN(MaSV,sHoTen,dNgaysinh,sGioitinh)" +
                "values(" + masv + ",N'" + hoten + "','" + ngaysinh + "','" + gioitinh + "')";
            Console.WriteLine(sqlInsert);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert,cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
            

        }

       // public static bool xoaSV()
            // them sua xoa tim : ten ngay sinh nam sinh
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
                    bool i = Program.themSV(constr, masv, hoten, ngaysinh, gt);
                    if (i) Console.WriteLine("Them Thanh Cong");
                    else Console.WriteLine("Them khong thanh cong");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
