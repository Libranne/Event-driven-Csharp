using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLySach
{
    class Program
    {
        static void HientblSach()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSach", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", rd["sMasach"],
                                rd["sTieude"], rd["fDongia"], rd["iSoluong"], rd["sMaNXB"]);
                        rd.Close();
                    }
                    cnn.Close();
                    Console.ReadLine();
                }
            }
        }

        static void HientblNXB()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNhaXuatBan", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", rd["sMaNXB"],
                                rd["sTenNXB"], rd["sDiachi"], rd["sSDT"]);
                        rd.Close();
                    }
                    cnn.Close();
                    Console.ReadLine();
                }
            }
        }

        static void ThemSach()
        {
            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string masach; string tieude; float dongia; int soluong; string manxb;
                    Console.WriteLine("Nhap ma sach:");
                    masach = Console.ReadLine();
                    Console.WriteLine("Nhap tieu de:");
                    tieude = Console.ReadLine();
                    Console.WriteLine("Nhap don gia:");
                    dongia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so luong:");
                    soluong = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap ma nha xuat ban:");
                    manxb = Console.ReadLine();



                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_ThemSach";
                        cmd.Parameters.AddWithValue("@masach", masach);
                        cmd.Parameters.AddWithValue("@tieude", tieude);
                        cmd.Parameters.AddWithValue("@dongia", dongia);
                        cmd.Parameters.AddWithValue("@soluong", soluong);
                        cmd.Parameters.AddWithValue("@manxb", manxb);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("them thanh cong");
                            HientblSach();
                        }
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
        static bool Checkma(string constr, string masach)
        {
            string sqlcheck = "update tblSach where sMasach=" + masach;

            Console.WriteLine(sqlcheck);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlcheck, cnn))
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
                constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string tieude; float dongia; int soluong; string manxb;
                    Console.WriteLine("Nhap ma sach:");
                    masach = Console.ReadLine();

                    Checkma(constr, masach);
                    Console.WriteLine("Nhap tieu de:");
                    tieude = Console.ReadLine();
                    Console.WriteLine("Nhap don gia:");
                    dongia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap so luong:");
                    soluong = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap ma nha xuat ban:");
                    manxb = Console.ReadLine();



                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_ThemSach";
                        cmd.Parameters.AddWithValue("@masach", masach);
                        cmd.Parameters.AddWithValue("@tieude", tieude);
                        cmd.Parameters.AddWithValue("@dongia", dongia);
                        cmd.Parameters.AddWithValue("@soluong", soluong);
                        cmd.Parameters.AddWithValue("@manxb", manxb);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("them thanh cong");
                            HientblSach();
                        }
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

        static void ThemNXB()
        {
            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string manxb; string tennxb; string diachi; string sdt;
                    Console.WriteLine("Nhap ma NXB:");
                    manxb = Console.ReadLine();
                    Console.WriteLine("Nhap ten NXB:");
                    tennxb = Console.ReadLine();
                    Console.WriteLine("Nhap Dia chi:");
                    diachi = Console.ReadLine();
                    Console.WriteLine("Nhap SDT:");
                    sdt = Console.ReadLine();



                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_ThemNXB";
                        cmd.Parameters.AddWithValue("@manxb", manxb);
                        cmd.Parameters.AddWithValue("@tennxb", tennxb);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@sdt", sdt);

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
        static void XoaSach()
        {
            try
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    string masach;
                    Console.WriteLine("Nhap ma Sach can xoa:");
                    masach = Console.ReadLine();


                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pr_XoaSach";
                        cmd.Parameters.AddWithValue("@masach", masach);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("xoa thanh cong");
                            Console.WriteLine("Danh sach sau khi xoa:");
                            HientblSach();
                        }
                        else Console.WriteLine("Ma sach chua ton tai");


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static void TimSachPr()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string tensach;
                int i = 0;
                Console.Write("nhap Ten Sach can tim: ");
                tensach = Console.ReadLine();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_Timsach";
                    cmd.Parameters.AddWithValue("@tieude", tensach);
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            i++;
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", rd["sMasach"], rd["sTieude"], rd["fDongia"], rd["iSoluong"], rd["sMaNXB"]);
                        }
                        if (i == 0)
                        {
                            Console.WriteLine("khong tim thay sach");
                        }
                        rd.Close();
                        cnn.Close();
                    }
                }
            }
            Console.ReadLine();
        }

        static void TimSach()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string tensach;
                Console.Write("nhap gioi tinh sinh vien can tim: ");
                tensach = Console.ReadLine();
                using (SqlCommand cmd = new SqlCommand("Select*from tblSach Where sTieude=" + "'" + tensach + "'", cnn))
                {
                    cnn.Open();
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", data["sMasach"], data["sTieude"], data["fDongia"], data["iSoluong"], data["sMaNXB"]);
                        }
                        data.Close();
                        cnn.Close();
                    }
                }
            }
            Console.ReadLine();
        }
        static void UpdateNameSach()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string tensach, masach;
                Console.WriteLine("Nhap ma sach can chinh sua:");
                masach = Console.ReadLine();
                Console.WriteLine("Nhap ten sach sua:");
                tensach = Console.ReadLine();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "pr_UpdateNameSach";
                    cmd.Parameters.AddWithValue("@masach", masach);
                    cmd.Parameters.AddWithValue("@tensach", tensach);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) Console.WriteLine("Chinh sua thanh cong");
                    else Console.WriteLine("Chinh sua khong thanh cong");

                }

            }
            Console.ReadLine();
        }

        static void HienSachtable()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from tblSach", cnn))
                {


                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable tb = new DataTable("tblSach"))
                        {
                            ad.Fill(tb);
                            if (tb.Rows.Count == 0)
                                Console.WriteLine("Khong co ban ghi nao!");
                            else
                                foreach (DataRow r in tb.Rows)
                                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", r["sMasach"], r["sTieude"], r["fDongia"], r["iSoluong"], r["sMaNXB"]);
                            Console.ReadLine();
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        static void CheckPrimaryKey()
        {
            Console.WriteLine("Moi nhap ma sach can kiem tra:");
            string masach = Console.ReadLine();
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(constr);
            string sql = "select sMasach from tblSach Where sMasach=" + masach;
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            if (tbl.Rows.Count > 0)
                Console.WriteLine("Ma sach da co!");
            else Console.WriteLine("Ma sach {0} chua co.", masach);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int choose;

            do
            {
                string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLSV;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    Console.WriteLine("-----------Chuong Trinh Quan Ly Sach------------");

                    Console.WriteLine("1.Hien du lieu bang Sach");
                    Console.WriteLine("2.hien du lieu bang Nha Xuat Ban");
                    Console.WriteLine("3.Them du lieu vao bang Sach");
                    Console.WriteLine("4.Xoa du lieu theo ma Sach");
                    Console.WriteLine("5.Tim Sach theo ten");
                    Console.WriteLine("6.Kiem tra ma sach da ton tai hay chua");
                    Console.WriteLine("7.Them du lieu vao bang NXB");
                    Console.WriteLine("8.Chinh sua ten sach theo ma sach");
                    Console.WriteLine("----------------------------");

                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:/* HientblSach()*/ HienSachtable(); break;
                        case 2: HientblNXB(); break;
                        case 3: ThemSach(); break;
                        case 4: XoaSach(); HientblSach(); break;
                        case 5: TimSachPr(); break;
                        case 6: CheckPrimaryKey(); break;
                        case 7: ThemNXB(); HientblNXB(); break;
                        case 8: UpdateNameSach(); break;
                        // case 9: DSSVnu(); break;
                        default: Console.WriteLine("Thanks!"); break;
                    }
                }

            } while (choose != 0);

        }
    }
}
