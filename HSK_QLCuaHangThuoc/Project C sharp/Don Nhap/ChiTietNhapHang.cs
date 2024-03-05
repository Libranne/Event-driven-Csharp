using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_sharp
{
    public partial class ChiTietNhapHang : Form
    {
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        ClassMain dch = new ClassMain();

        public ChiTietNhapHang(string sodn)
        {
            InitializeComponent();
            cbbDonNhap.Text = sodn;
            string sql = "pr_timkiemsoctdn";
            dch.Timkiemdl(sql, "@sodn", sodn, dgvCTDonNhap);


        }
        bool b_Tongtien(string constr)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string tong = "Update tblDN_Thuoc set fTongtien = iSoLuongNhap * fGiaNhap";
                using (SqlCommand cmd = new SqlCommand(tong, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        bool UpdateSL_Thuoc(string constr, int sl, string tenthuoc)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string update = "Update tblThuoc set fSoluong = fSoLuong +" + sl + "Where sTenThuoc =" + "'" + tenthuoc + "'";
                using (SqlCommand cmd = new SqlCommand(update, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        void Update_thuoc()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string tenthuoc;
                int sl;
                tenthuoc = cbbTenthuoc.Text;
                sl = Convert.ToInt32(txtSoluong.Text);
                bool i = UpdateSL_Thuoc(constr, sl, tenthuoc);
            }
        }

        void TongTien()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                bool i = b_Tongtien(constr);
            }
        }

        private void ChiTietNhapHang_Load(object sender, EventArgs e)
        {


            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.TableDN("DonNhap");
           /* cbbDonNhap.DataSource = dt;
            cbbDonNhap.DisplayMember = dt.Columns[0].ColumnName;*/

            DataTable ct = c.TableThuoc("thuoc");
            cbbTenthuoc.DataSource = ct;
          cbbTenthuoc.DisplayMember = ct.Columns[1].ColumnName;

        }

     

        void Load_Grid(string sodn)
        {

            cbbDonNhap.Text = sodn;
            string sql = "pr_timkiemsoctdn";
            dch.Timkiemdl(sql, "@sodn", sodn, dgvCTDonNhap);
        }
        public void Reset()
        {

            // cbbDonNhap.Text = null;
            cbbTenthuoc.Text = null;
            txtSoluong.Text = "";
            txtGia.Text = "";
        }
     
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Reset();
            
        }

        private void Them()
        {
            if (cbbDonNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập so don nhap", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbDonNhap.Focus();

            }
            else
            {
                if (CheckT_TrungDN())
                {
                    Them_TrungDN();
                }

                /* else if(mtbNgayNhap.Text == string.Empty)
                 {
                     MessageBox.Show("Vui lòng nhập ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     mtbNgayNhap.Focus();
                 }*/
                else

                {
                    try
                    {

                        SqlConnection cnn = new SqlConnection();
                        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "Pr_ThemCTDN";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(cbbDonNhap.Text));
                        cmd.Parameters.AddWithValue("@tenthuoc", cbbTenthuoc.Text);
                        cmd.Parameters.AddWithValue("@soluongnhap", Convert.ToInt32(txtSoluong.Text));
                        cmd.Parameters.AddWithValue("@gianhap", Convert.ToInt32(txtGia.Text));

                        cmd.Connection = cnn;
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        MessageBox.Show("Đã thêm mới Đơn Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        // MessageBox.Show("vui long xem lai du lieu", "Thong Bao" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                    Load_Grid(cbbDonNhap.Text);
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them();
            TongTien();
            Load_Grid(cbbDonNhap.Text);
        }
        void Update_DonNhap()
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pr_SuaCTDN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(cbbDonNhap.Text));
                cmd.Parameters.AddWithValue("@tenthuoc", cbbTenthuoc.Text);
                cmd.Parameters.AddWithValue("@soluongnhap", Convert.ToInt32(txtSoluong.Text));
                cmd.Parameters.AddWithValue("@gianhap", Convert.ToInt32(txtGia.Text));

                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Đã cập nhật Đơn Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load_Grid(cbbDonNhap.Text);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Update_DonNhap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pr_XoaCTDN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(cbbDonNhap.Text));
                cmd.Parameters.AddWithValue("@tenthuoc", cbbTenthuoc.Text);
                /*cmd.Parameters.AddWithValue("@mancc", cbbMaNCC.Text);
                 cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(mtbNgayNhap.Text));*/

                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Đã xóa Đơn Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Grid(cbbDonNhap.Text);
            TongTien();
         
        }

        private void dgvCTDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbDonNhap.Text = dgvCTDonNhap.CurrentRow.Cells[0].Value.ToString();
            cbbTenthuoc.Text = dgvCTDonNhap.CurrentRow.Cells[1].Value.ToString();
            txtSoluong.Text = dgvCTDonNhap.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dgvCTDonNhap.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnInDon_Click(object sender, EventArgs e)
        {
            InCTDN ctdn = new InCTDN(cbbDonNhap.Text);
            ctdn.Show();
        }
        private bool CheckT_TrungDN()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                bool kt = false;
                int madn = Convert.ToInt32(cbbDonNhap.Text);
                string tenthuoc = cbbTenthuoc.Text;
                float gianhap = Convert.ToSingle(txtGia.Text);
                cnn.Open();
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from V_CTDonNhap Where iSoDN =" + madn + "AND sTenThuoc =" + "N'" + tenthuoc + "'" + "AND fGiaNhap =" + "'" + gianhap + "'", cnn);
                DataTable dt_kiemtra = new DataTable();
                da_kiemtra.Fill(dt_kiemtra); if (dt_kiemtra.Rows.Count > 0)
                {
                    kt = true;
                }
                da_kiemtra.Dispose();
                return kt;
            }

        }
        void Them_TrungDN()
        {
            try
            {

                SqlConnection cnn = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pr_LoadCTDN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(cbbDonNhap.Text));
                cmd.Parameters.AddWithValue("@tenthuoc", cbbTenthuoc.Text);
                cmd.Parameters.AddWithValue("@sl", Convert.ToInt32(txtSoluong.Text));
                cmd.Parameters.AddWithValue("@gianhap", Convert.ToInt32(txtGia.Text));

                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                Update_thuoc();
                MessageBox.Show("Đã thêm mới Đơn Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    }
