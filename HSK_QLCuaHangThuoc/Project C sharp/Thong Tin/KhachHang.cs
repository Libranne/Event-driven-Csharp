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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        private void KhachHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewKhachHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvKhachHang.DataSource = tb;
                    }
                }
            }
        }

        void gridLoad()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewKhachHang", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvKhachHang.DataSource = tb;
                    }
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCheck.Text = dgvKhachHang.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            txtGioiTinh.Text = dgvKhachHang.CurrentRow.Cells["Giới tính"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtSoDT.Text = dgvKhachHang.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            mtbNgaySinh.Text = dgvKhachHang.CurrentRow.Cells["Ngày sinh"].Value.ToString();
        }

        private bool CheckKhoaChinh()
        {
            bool kt = false; String maKH = txtMaKH.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
            con.Open();
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblKhachHang where sMaKH='" + maKH + "'", con);
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
                MessageBox.Show("Đã tồn tại mã khách hàng,vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_THEM_KhachHang";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maKH", txtMaKH.Text);
                            cmd.Parameters.AddWithValue("@tenKH", txtTenKH.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@dienThoai", txtSoDT.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(mtbNgaySinh.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtMaKH.Text == "" || txtMaKH.Text != txtCheck.Text)
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_THEM_KhachHang";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maKH", txtMaKH.Text);
                            cmd.Parameters.AddWithValue("@tenKH", txtTenKH.Text);
                            cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@dienThoai", txtSoDT.Text);
                            cmd.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(mtbNgaySinh.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gridLoad();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtMaKH.Text != txtCheck.Text)
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_Xoa_KhachHang";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maKH", txtMaKH.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gridLoad();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "pr_TimKiem_KhachHang";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tenKH", txtTenKH.Text);

                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();

                        //MessageBox.Show("Đã xóa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridLoad();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
