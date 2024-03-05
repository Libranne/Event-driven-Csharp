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
    public partial class Thuoc : Form
    {
        public Thuoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckKhoaChinh())
            {
                MessageBox.Show("Đã tồn tại mã thuốc,vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_THEM_matHangThuoc";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maThuoc", txtMaThuoc.Text);
                            cmd.Parameters.AddWithValue("@tenThuoc", txtTenThuoc.Text);
                            cmd.Parameters.AddWithValue("@tenNCC", cbbTenNCC.Text);
                            cmd.Parameters.AddWithValue("@donGia", Convert.ToInt32(txtDonGia.Text));
                           // cmd.Parameters.AddWithValue("@soLuong", Convert.ToInt32(txtSoLuong.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã thêm mặt hàng thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtMaThuoc.Text == "" || txtMaThuoc.Text != txtCheck.Text)
                MessageBox.Show("Mặt hàng thuốc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_Sua_matHangThuoc";
                            cmd.CommandType = CommandType.StoredProcedure;
                            //txtCheck.Text = dgvMatHangThuoc.CurrentRow.Cells["sMaThuoc"].Value.ToString();
                            cmd.Parameters.AddWithValue("@maThuoc", txtCheck.Text);
                            cmd.Parameters.AddWithValue("@maThuocMoi", txtMaThuoc.Text);
                            cmd.Parameters.AddWithValue("@tenThuoc", txtTenThuoc.Text);
                            cmd.Parameters.AddWithValue("@tenNCC", cbbTenNCC.Text);
                            cmd.Parameters.AddWithValue("@donGia", Convert.ToInt32(txtDonGia.Text));
                            cmd.Parameters.AddWithValue("@soLuong", Convert.ToInt32(txtSoLuong.Text));

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã sửa mặt hàng thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtMaThuoc.Text == "" || txtMaThuoc.Text != txtCheck.Text)
                MessageBox.Show("Mặt hàng thuốc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_Xoa_matHangThuoc";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maThuoc", txtMaThuoc.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã xóa mặt hàng thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }
        private bool CheckKhoaChinh()
        {
            bool kt = false; String maThuoc = txtMaThuoc.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
            con.Open();
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblThuoc where sMaThuoc='" + maThuoc + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra); if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;
            }
            da_kiemtra.Dispose();
            return kt;
        }
        private void dgvMatHangThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCheck.Text = dgvMatHangThuoc.CurrentRow.Cells["Mã Thuốc"].Value.ToString();
            txtMaThuoc.Text = dgvMatHangThuoc.CurrentRow.Cells["Mã Thuốc"].Value.ToString();
            txtTenThuoc.Text = dgvMatHangThuoc.CurrentRow.Cells["Tên thuốc"].Value.ToString();
            cbbTenNCC.Text = dgvMatHangThuoc.CurrentRow.Cells["Tên nhà cung cấp"].Value.ToString();
            txtDonGia.Text = dgvMatHangThuoc.CurrentRow.Cells["Đơn giá"].Value.ToString();
            txtSoLuong.Text = dgvMatHangThuoc.CurrentRow.Cells["Số lượng"].Value.ToString();
        }
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        private void Thuoc_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewMatHangThuoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvMatHangThuoc.DataSource = tb;

                    }
                }
            }
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblNhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);

                        cbbTenNCC.DataSource = tb;
                        cbbTenNCC.ValueMember = "sTenNCC";
                    }
                }
            }
        }
        void gridLoad()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewMatHangThuoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvMatHangThuoc.DataSource = tb;

                    }
                }
            }
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblNhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);

                        cbbTenNCC.DataSource = tb;
                        cbbTenNCC.ValueMember = "sTenNCC";
                    }
                }
            }
        }
    }
}
