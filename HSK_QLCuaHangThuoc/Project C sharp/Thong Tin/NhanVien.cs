using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_C_sharp
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        private void NhanVien_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM view_NhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvNhanVien.DataSource = tb;
                    }
                }
            }
        }

        void gridLoad()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM view_NhanVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvNhanVien.DataSource = tb;
                    }
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCheck.Text = dgvNhanVien.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["Giới tính"].Value.ToString();
            mtbNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtSoDT.Text = dgvNhanVien.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            mtbNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells["Ngày vào làm"].Value.ToString();
            txtLuong.Text = dgvNhanVien.CurrentRow.Cells["Lương"].Value.ToString();
        }

        private bool CheckKhoaChinh()
        {
            bool kt = false; String maNV = txtMaNV.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
            con.Open();
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblNhanVien where sMaNV='" + maNV + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra); if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;
            }
            da_kiemtra.Dispose();
            return kt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckKhoaChinh())
            {
                MessageBox.Show("Đã tồn tại mã nhân viên,vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_THEM_NhanVien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@tenNV", txtTenNV.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(mtbNgaySinh.Text));
                            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@dienThoai", txtSoDT.Text);
                            cmd.Parameters.AddWithValue("@ngayvaolam", Convert.ToDateTime(mtbNgayVaoLam.Text));
                            cmd.Parameters.AddWithValue("@luong", Convert.ToInt32(txtLuong.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            gridLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtMaNV.Text != txtCheck.Text)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_Sua_NhanVien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@tenNV", txtTenNV.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(mtbNgaySinh.Text));
                            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@dienThoai", txtSoDT.Text);
                            cmd.Parameters.AddWithValue("@ngayvaolam", Convert.ToDateTime(mtbNgayVaoLam.Text));
                            cmd.Parameters.AddWithValue("@luong", Convert.ToInt32(txtLuong.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            gridLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtMaNV.Text != txtCheck.Text)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_Xoa_NhanVien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNV", txtMaNV.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            gridLoad();
        }
        ClassMain dch = new ClassMain();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pr_timnvtrongkhoang";
                cmd.CommandType = CommandType.StoredProcedure;
              
         
                 cmd.Parameters.AddWithValue("@ngay1", Convert.ToDateTime(mtbNgay1.Text));
                cmd.Parameters.AddWithValue("@ngay2", Convert.ToDateTime(mtbNgay2.Text)); 

               cmd.Connection = cnn;
                cnn.Open();

               
                cmd.CommandType = CommandType.StoredProcedure;
               
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable nv = new DataTable();
                    ad.Fill(nv);
                    dgvNhanVien.DataSource = nv;

                }


                cmd.ExecuteNonQuery();
                cnn.Close();
               

                /*MessageBox.Show("Đã xóa Đơn Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}

