using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLSV
{
    class Program
    {
        public static void ConnectSQL()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";

        }

        private static bool themSV(string constr, int masv, string hoten, DateTime ngaysinh, string gioitinh)
        {
            string sqlInsert = "insert into tblSINHVIEN(MaSV,sHoTen,dNgaysinh,sGioitinh)" +
                "values(" + masv + ",N'" + hoten + "','" + ngaysinh + "','" + gioitinh + "')";
            Console.WriteLine(sqlInsert);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            };

            try
            {
                ConnectSQL();

                using (SqlConnection cnn = new SqlConnection(constr))
                {

                    Console.WriteLine("Nhap ma SV:");
                    masv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap ho ten SV:");
                    hoten = Console.ReadLine();
                    Console.WriteLine("Nhap ngay sinh:");
                    ngaysinh = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Nhap gioi tinh SV:");
                    gioitinh = Console.ReadLine();
                    bool i = Program.themSV(constr, masv, hoten, ngaysinh, gioitinh);
                    if (i) Console.WriteLine("Them Thanh Cong");
                    else Console.WriteLine("Them khong thanh cong");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


        static void ThemSVpr()
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
            Console.ReadLine();
        }
        static void XoaSV()
        {
            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    int masv;
                    Console.WriteLine("Nhap ma SV can xoa:");
                    masv = Convert.ToInt32(Console.ReadLine());


                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_XoaSV";
                        cmd.Parameters.AddWithValue("@masv", masv);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) Console.WriteLine("xoa thanh cong");
                        else Console.WriteLine("Xoa khong thanh cong");

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }

        static void CapNhatSV()
        {
            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    int masv; string tensv;
                    Console.WriteLine("Nhap ma SV can Update:");
                    masv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap ten sinh vien cap nhat:");
                    tensv = Console.ReadLine();


                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_UpdateSV";
                        cmd.Parameters.AddWithValue("@masv", masv);
                        cmd.Parameters.AddWithValue("@tensv", tensv);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) Console.WriteLine("update thanh cong");
                        else Console.WriteLine("Update khong thanh cong");

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void TimSV()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string gt;
                Console.Write("nhap gioi tinh sinh vien can tim: ");
                gt = Console.ReadLine();
                using (SqlCommand cmd = new SqlCommand("Select*from tblSINHVIEN Where sGioitinh=" + "'" + gt + "'", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", data["MaSV"], data["sHoTen"], data["dNgaysinh"], data["sGioitinh"]);
                        }
                        data.Close();
                        cnn.Close();
                    }
                }
            }
            Console.ReadLine();
        }

        static void HienSV()
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
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", rd["masv"],
                                rd["shoten"], rd["sgioitinh"], rd["dngaysinh"]);
                        rd.Close();
                    }
                    cnn.Close();

                }
            }
            Console.ReadLine();
        }

        static void CheckPrimaryKey()
        {
            Console.WriteLine("Moi nhap ma sinh vien can kiem tra:");
            int masv = Convert.ToInt32(Console.ReadLine());
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(constr);
            string sql = "select MaSV from tblSINHVIEN Where MaSV=" + masv;
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tblphong = new DataTable();
            mydata.Fill(tblphong);
            if (tblphong.Rows.Count > 0)
                Console.WriteLine("Ma sinh vien da co!");
            else Console.WriteLine("Ma sinh vien {0} chua co.", masv);
            Console.ReadLine();
        }

        // su dung dataAdapter and dataTable nhan va hien du lieu bang sinh vien
        static void NhanvaHienSV()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select*from tblSINHVIEN", cnn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable("tblSINHVIEN"))
                        {
                            ad.Fill(tb);
                            if (tb.Rows.Count == 0)
                                Console.WriteLine("Khong co ban ghi nao!");
                            else
                                foreach (DataRow r in tb.Rows)
                                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", r["masv"], r["shoten"], r["dngaysinh"], r["sgioitinh"]);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
        //ham hien danh sach sinh vien chi lay sinh vien NU,sap xep thep ngay sinh
        static void DSSVnu()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
            string sql = "SELECT*FROM tblSINHVIEN";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(sql, cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "SV");
                    DataTable dt = ds.Tables["SV"];
                    DataView dv = new DataView(dt, "sGioitinh='nu'", "dNgaysinh", DataViewRowState.CurrentRows);
                    foreach (DataRowView drv in dv)
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", drv["masv"], drv["sHoten"], drv["dNgaysinh"], drv["sGioitinh"]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    cnn.Close();
                    Console.ReadLine();
                }
            }
        }


        static void Main(string[] args)
        {
            int Choose;
            do
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    Console.WriteLine("-------Chuong trinh quan li sinh vien-----");

                    Console.WriteLine("1.Hien danh sach sinh vien");

                    Console.WriteLine("2.Them sinh vien style Text");

                    Console.WriteLine("3.Them sinh vien style storeProcedure");

                    Console.WriteLine("4.Xoa sinh vien theo stt");

                    Console.WriteLine("5.Tim  sinh vien theo Gioi tinh");

                    Console.WriteLine("6. cap nhat ten sinh vien theo ma ");

                    Console.WriteLine("7.Kiem tra sinh vien da co hay chua");

                    Console.WriteLine("8.Nhan va Hien danh sach sinh vien theo dataAdapter and DataTable");

                    Console.WriteLine("9.Hien danh sach sinh vien Nu theo DataView");

                    Console.WriteLine("0.Thoat chuong trinh!");
                    Console.WriteLine("---------------------------------------------------------------");



                    Choose = int.Parse(Console.ReadLine());

                    switch (Choose)
                    {
                        case 1: HienSV(); break;
                        //case 2:themSV(); break;
                        case 3: ThemSVpr(); break;
                        case 4: XoaSV(); break;
                        case 5: TimSV(); break;
                        case 6: CapNhatSV(); break;
                        case 7: CheckPrimaryKey(); break;
                        case 8: NhanvaHienSV(); break;
                        case 9: DSSVnu(); break;
                        default: Console.WriteLine("Thanks!"); break;
                    }
                    break;

                }
            } while (Choose != 0);

        }


    }
}



