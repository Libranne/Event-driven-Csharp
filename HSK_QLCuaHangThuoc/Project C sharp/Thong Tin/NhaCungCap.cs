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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewNhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvNhaCungCap.DataSource = tb;
                    }
                }
            }
        }

        void gridLoad()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM viewNhaCungCap", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvNhaCungCap.DataSource = tb;
                    }
                }
            }
        }

        public bool checkThongTin()
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui long nhap ma nha cung cap!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return false;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Vui long nhap ten nha cung cap!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui long nhap dia chi nha cung cap!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui long nhap so dien thoai nha cung cap!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private bool CheckKhoaChinh()
        {
            bool kt = false; String maNCC = txtMaNCC.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
            con.Open();
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblNhaCungCap where sMaNCC='" + maNCC + "'", con);
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
        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvNhaCungCap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();

            
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Ban chac chan muon xoa?", "Thong bao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dg == DialogResult.OK)
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "pr_Xoa_NhaCungCap";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@maNCC", txtMaNCC.Text);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        MessageBox.Show("Đã xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridLoad();
                    }
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "pr_Sua_NhaCungCap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNCC", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("@tenNCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@dienThoai", txtSDT.Text);

                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();

                    gridLoad();
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (CheckKhoaChinh())
            {
                MessageBox.Show("Đã tồn tại mã nhà cung cấp,vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = "pr_THEM_nhaCungCap";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maNCC", txtMaNCC.Text);
                            cmd.Parameters.AddWithValue("@tenNCC", txtTenNCC.Text);
                            cmd.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@dienThoai", txtSDT.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("Đã thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "Tên NCC", "*" + txtTimKiem.Text + "*");

            (dgvNhaCungCap.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
