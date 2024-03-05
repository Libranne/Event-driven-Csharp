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

namespace WindowsFormsApp
{
    public partial class QuanLySach : Form
    {


        public QuanLySach()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtMasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            cbbSapxep.Items.Add("Ma sach");
            cbbSapxep.Items.Add("Ten sach");
            cbbSapxep.Items.Add("So luong");
            cbbSapxep.Items.Add("Don gia");
            cbbSapxep.Items.Add("NXB");
            layDSTS();
        }

        private void layDSTS()
        {
            string constr = ConfigurationManager.ConnectionStrings["QuanLySach"].ConnectionString;
            // MessageBox.Show(constr);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblSach", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Sach");
                        ad.Fill(tb);
                        dgvSach.DataSource = tb;
                        cbbSapxep.DisplayMember= "sTieude";
                        cbbSapxep.ValueMember= "sMasach";

                    }
                }
            }
        }

        public bool KiemTraThongTin()
        {

            if (txtMasach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Ma sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Focus();
                return false;
            }
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ten sach", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return false;
            }
            if (txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhap don gia", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return false;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhap so luong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return false;
            }
            
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanLySach"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Pr_ThemSach";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masach", txtMasach.Text);
                    cmd.Parameters.AddWithValue("@tieude", txtTenSach.Text);
                    cmd.Parameters.AddWithValue("@dongia", Convert.ToInt32(txtDongia.Text));
                    cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txtSoluong.Text));

                    cmd.Parameters.AddWithValue("@manxb", cbbNXB.Text);

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Đã thêm mới Sach thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Load_Grid();

        }

        void Load_Grid()
        {
            string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QuanLySach;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblSach", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Sach");
                        ad.Fill(tb);
                        dgvSach.DataSource = tb;
                    }
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn Xoa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanLySach"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "pr_XoaSach";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@masach", txtMasach.Text);
                    /* cmd.Parameters.AddWithValue("@tieude", txtTenSach.Text);
                     cmd.Parameters.AddWithValue("@dongia", Convert.ToInt32(txtDongia.Text));
                     cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txtSoluong.Text));

                     cmd.Parameters.AddWithValue("@manxb", txtNXB.Text);*/

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Đã xoa Sach thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Load_Grid();
            }

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dgvSach.CurrentRow.Cells["sMasach"].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells["sTieude"].Value.ToString();
            txtDongia.Text = dgvSach.CurrentRow.Cells["fDongia"].Value.ToString();
            txtSoluong.Text = dgvSach.CurrentRow.Cells["iSoluong"].Value.ToString();
            cbbNXB.Text = dgvSach.CurrentRow.Cells["sMaNXB"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["QuanLySach"].ConnectionString;
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "pr_SuaSach";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masach", txtMasach.Text);
                cmd.Parameters.AddWithValue("@tensach", txtTenSach.Text);
                 cmd.Parameters.AddWithValue("@dongia", Convert.ToInt32(txtDongia.Text));
                 cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txtSoluong.Text));

                 cmd.Parameters.AddWithValue("@nxb", cbbNXB.Text);

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã sua thong tin Sach thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Grid();
        }
    
        public void Reset()
        {
            txtMasach.Text = "";
            txtTenSach.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = ""; 
            cbbNXB.Text = "";
            cbbSapxep.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void QuanLySach_FormClosing(object sender, FormClosingEventArgs e)
        {
       
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtDongia_Validating(object sender, CancelEventArgs e)
        {
            // hơi thừa (đã có điều kiện trống ở trên )
            if (txtDongia.Text == "")
                errorProvider1.SetError(txtDongia, "ban phai nhap ");
            else
            {
                try
                {
                    int temp = Convert.ToInt32(txtDongia.Text);
                    if (temp <= 0)
                        errorProvider1.SetError(txtDongia, "sai gia tri!");
                    else
                        errorProvider1.SetError(txtDongia, "");
                }
                catch
                {
                    errorProvider1.SetError(txtDongia, " phai la so!");
                }
            }
        }

        private void txtSoluong_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoluong.Text == "")
                errorProvider2.SetError(txtSoluong, "ban phai nhap ");
            else
            {
                try
                {
                    int temp = Convert.ToInt32(txtSoluong.Text);
                    if (temp <= 0)
                        errorProvider2.SetError(txtSoluong, "sai gia tri!");
                    else
                        errorProvider2.SetError(txtSoluong, "");
                }
                catch
                {
                    errorProvider2.SetError(txtSoluong, " phai la so!");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên 
            string rowFilter = string.Format("{0} like '{1}'", "sTieude", "*" + txtTenSach.Text + "*");
         
            (dgvSach.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnTim_TextChanged(object sender, EventArgs e)
        {
           
        }
        

      
        private void cbbNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
           
        }

      

        private void cbbSapxep_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbbSapxep.SelectedIndex == 0)
            {
                this.dgvSach.Sort(this.dgvSach.Columns["sMasach"], ListSortDirection.Ascending);
            }
            else if(cbbSapxep.SelectedIndex == 1)
            {
                this.dgvSach.Sort(this.dgvSach.Columns["sTieude"], ListSortDirection.Ascending);
            }
            else if (cbbSapxep.SelectedIndex == 2)
            { 
                this.dgvSach.Sort(this.dgvSach.Columns["iSoluong"], ListSortDirection.Ascending); 
            }
            else if (cbbSapxep.SelectedIndex == 3)
            {
                this.dgvSach.Sort(this.dgvSach.Columns["fDongia"], ListSortDirection.Ascending);
            }
            else 
            {
                this.dgvSach.Sort(this.dgvSach.Columns["sMaNXB"], ListSortDirection.Ascending);
            }
        }
    }
    }

