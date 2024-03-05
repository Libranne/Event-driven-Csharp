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
    public partial class NhapHang : Form
    {
        ClassMain dch = new ClassMain();
        public NhapHang()
        {
            InitializeComponent();
        }
       


        private void NhapHang_Load(object sender, EventArgs e)
        {
    
            LayDSDN();
            cbbTrangthai.Items.Add("Thanh Toán");
            cbbTrangthai.Items.Add("Chưa");
            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable gc = c.TableTT("ThongTin");

            dgvThongTin.DataSource = gc;


        }
        private void LayDSDN()
        {
            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.TableDN("DonNhap");
            
            dgvDonNhap.DataSource = dt;
           
           /* DataTable gc = c.TableTT("ThongTin");

            lvThongTin.DataSource = gc;*/


            DataTable tb = c.TableNV("tblNhanVien");
            cbbTenNV.DataSource = tb;
            cbbTenNV.DisplayMember = tb.Columns[1].ColumnName;

            DataTable ba = c.TableNCC("tblNhaCungCap");
            cbbTenNCC.DataSource = ba;
            cbbTenNCC.ValueMember = "sTenNCC";
            //cbbMaNCC.DisplayMember = ba.Columns[0].ColumnName;
        }
        private void load_TT()
        {
            ClassMain c = new ClassMain();
        c.ketnoi();
            DataTable gc = c.TableTT("ThongTin");

        dgvThongTin.DataSource = gc;
        }
        void Load_Grid()
        {
            /*ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.getTable("DonNhap");
            dgvDonNhap.DataSource = dt;*/
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
                         dgvDonNhap.DataSource = tb;
                     }
                 }
             }

        }

      
        private void btnChitietDN_Click(object sender, EventArgs e)
        {
             if (txtDonNhap.Text == "" )
             {
                 MessageBox.Show(String.Format(" Hãy nhập số đơn nhập "),
                                  "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtDonNhap.Focus();

             }
             else
             {
                 ChiTietNhapHang CT = new ChiTietNhapHang(txtDonNhap.Text);
                 CT.Show();

             }
          
        }
     /*   public bool KiemTraThongTin()
        {

            if (txtMasach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Ma sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Focus();
                return false;
            }
           
        }*/

        private bool kiemtrakhoachinh() {


                bool kt = false; int madn = Convert.ToInt32(txtDonNhap.Text);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
                con.Open();
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblDonNHap where iSoDN='" + madn + "'", con);
                DataTable dt_kiemtra = new DataTable();
                da_kiemtra.Fill(dt_kiemtra); if (dt_kiemtra.Rows.Count > 0)
                {
                    kt = true;
                }
                da_kiemtra.Dispose();
                return kt;

        }
    
            private void Them()
        {
            if (txtDonNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập so don nhap", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonNhap.Focus();
               
            }
           /* else if(mtbNgayNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbNgayNhap.Focus();
            }*/
            else
           if (kiemtrakhoachinh())
            {
                MessageBox.Show("Đã tồn tại số đơn nhập,vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Pr_ThemDN";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(txtDonNhap.Text));
                    cmd.Parameters.AddWithValue("@tennv", cbbTenNV.Text);
                    cmd.Parameters.AddWithValue("@tenncc", cbbTenNCC.Text);
                    cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(mtbNgayNhap.Text));
                    cmd.Parameters.AddWithValue("@trangthai", cbbTrangthai.Text);
                    cmd.Parameters.AddWithValue("@ghichu", rtbThongTin.Text);

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

                Load_Grid();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            Them();
    }
        public void Reset()
        {
            txtDonNhap.Text = "";
            cbbTenNV.Text = null;
            cbbTenNCC.Text = null;
            mtbNgayNhap.Text = "";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Reset();
            Load_Grid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pr_XoaDN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(txtDonNhap.Text));
               /* cmd.Parameters.AddWithValue("@manv", cbbMaNV.Text);
                cmd.Parameters.AddWithValue("@mancc", cbbMaNCC.Text);
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

            Load_Grid();
        }
  
       void Update_DonNhap()
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pr_SuaDN";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodn", Convert.ToInt32(txtDonNhap.Text));
                cmd.Parameters.AddWithValue("@tennv", cbbTenNV.Text);
                cmd.Parameters.AddWithValue("@tenncc", cbbTenNCC.Text);
                cmd.Parameters.AddWithValue("@ngaynhap", Convert.ToDateTime(mtbNgayNhap.Text));
                cmd.Parameters.AddWithValue("@trangthai", cbbTrangthai.Text);

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

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Update_DonNhap();
            Load_Grid();
        }

        private void txtDonNhap_Validating(object sender, CancelEventArgs e)
        {
            if (txtDonNhap.Text == "") {
                txtDonNhap.Focus();
                errorProvider.SetError(txtDonNhap, "ban phai nhap ");
            }    
            else
            {
                try
                {
                    int temp = Convert.ToInt32(txtDonNhap.Text);
                    if (temp <= 0)
                    {
                        txtDonNhap.Focus();
                        errorProvider.SetError(txtDonNhap, "sai gia tri!");
                    }
                        
                    /* else
                         errorProvider1.SetError(txtDonNhap, "");*/
                }
                catch
                {
                    txtDonNhap.Focus();
                    errorProvider.SetError(txtDonNhap, " phai la so!");  
                }
            } 
        }

        private void mtbNgayNhap_Validated(object sender, EventArgs e)
        {
           
        }

        private void NhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
        
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Đơn Nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

     

        private void dgvDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtDonNhap.Text = dgvDonNhap.CurrentRow.Cells[0].Value.ToString();
                cbbTenNV.Text = dgvDonNhap.CurrentRow.Cells[1].Value.ToString();
                cbbTenNCC.Text = dgvDonNhap.CurrentRow.Cells[2].Value.ToString();
                mtbNgayNhap.Text = dgvDonNhap.CurrentRow.Cells[3].Value.ToString();
                cbbTrangthai.Text = dgvDonNhap.CurrentRow.Cells[4].Value.ToString();
        }

        private void mtbNgayNhap_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                DateTime ngaynhap = Convert.ToDateTime(mtbNgayNhap.Text);
                mtbNgayNhap.Text = ngaynhap.ToString("dd/MM/yyyy");
                if (ngaynhap > dt)
                {
                    errorProvider1.SetError(mtbNgayNhap, "Ngày lập không được lớn hơn ngày hiện tại");
                    mtbNgayNhap.Focus();
                   
                }
             
            }
            catch
            {
                errorProvider1.SetError(mtbNgayNhap, "Hãy nhập đúng ngày tháng");
                mtbNgayNhap.Focus();
            }
        }

        private void btnInDon_Click(object sender, EventArgs e)
        {
            InDonNhap ID = new InDonNhap();
            ID.Show();
          /* InCTDN ctdn = new InCTDN(txtDonNhap.Text);
            ctdn.Show();*/

        }

       

        private void btnTim_Click(object sender, EventArgs e)
        {

           string sql = "pr_TimNV";
            string tennv = txtTimKiem.Text;
            dch.Timkiemdl(sql, "@tennv", tennv, dgvDonNhap);

        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbThongTin.Text +='\n'+dgvThongTin.CurrentRow.Cells[1].Value.ToString() ;
        }

        private void rtbThongTin_TextChanged(object sender, EventArgs e)
        {
            
            
                btnThem.Enabled = true;
            
        }
    }
}
