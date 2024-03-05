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
    public partial class HoaDon : Form
    {
        ClassMain dch = new ClassMain();
        public HoaDon()
        {
            InitializeComponent();
        }
        private void LayDSHD()
        {
            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.TableHD("HD");
            dgvHoaDon.DataSource = dt;

            DataTable tb = c.TableNV("tblNhanVien");
            cbb_maNV.DataSource = tb;
            cbb_maNV.DisplayMember = tb.Columns[1].ColumnName;

            DataTable ba = c.TableKH("tblKhachHang");
            cbb_maKH.DataSource = ba;
            cbb_maKH.ValueMember = "sTenKH";
        }


        private void HoaDon_Load(object sender, EventArgs e)
        {
            LayDSHD();
        }

        void gridLoad()
        {
            string str = @"Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("select * from v_HoaDon", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("HD");
                        ad.Fill(tb);
                        dgvHoaDon.DataSource = tb;
                    }
                }
            }

        }
        private bool kiemtrakhoachinh()
        {
            bool kt = false;
            int mahd = Convert.ToInt32(txtsoHD.Text);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString);
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from tblHoaDon where iSoHD='" + mahd + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra); if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;
            }
            da_kiemtra.Dispose();
            return kt;
        }

        private void them()
        {
            if (txtsoHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoHD.Focus();
            }
            else

                if (kiemtrakhoachinh())
            {
                MessageBox.Show("Đã tồn tại số hóa đơn, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "pr_ThemHD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(txtsoHD.Text));
                    cmd.Parameters.AddWithValue("@tennv", cbb_maNV.Text);
                    cmd.Parameters.AddWithValue("@tenkh", cbb_maKH.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", Convert.ToDateTime(mtbNgayLap.Text));

                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Đã thêm mới hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gridLoad();
            }
        }

        private void btnThem_Click_Click(object sender, EventArgs e)
        {
            them();
        }

        public void Reset()
        {
            txtsoHD.Text = "";
            cbb_maNV.Text = null;
            cbb_maKH.Text = null;
            mtbNgayLap.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            gridLoad();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsoHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            cbb_maNV.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            cbb_maKH.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            mtbNgayLap.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnXoa_Click_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pr_XoaHD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(txtsoHD.Text));
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

            gridLoad();
        }

        private void btnSua_Click_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pr_SuaHD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(txtsoHD.Text));
                cmd.Parameters.AddWithValue("@tennv", cbb_maNV.Text);
                cmd.Parameters.AddWithValue("@tenkh", cbb_maKH.Text);
                cmd.Parameters.AddWithValue("@ngaylap", Convert.ToDateTime(mtbNgayLap.Text));

                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Đã cập nhật hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridLoad();
        }

        private void mtbNgayLap_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                DateTime ngaylap = Convert.ToDateTime(mtbNgayLap.Text);
                mtbNgayLap.Text = ngaylap.ToString("dd/MM/yyyy");
                if (ngaylap > dt)
                {
                    errorProvider1.SetError(mtbNgayLap, "Ngày lập không được lớn hơn ngày hiện tại");
                    mtbNgayLap.Focus();
                }
            }
            catch
            {
                errorProvider1.SetError(mtbNgayLap, "Hãy nhập đúng ngày tháng");
                mtbNgayLap.Focus();
            }
        }

        private void txtsoHD_Validating(object sender, CancelEventArgs e)
        {
            if (txtsoHD.Text == "")
            {
                txtsoHD.Focus();
                errorProvider2.SetError(txtsoHD, "ban phai nhap ");
            }
            else
            {
                try
                {
                    int temp = Convert.ToInt32(txtsoHD.Text);
                    if (temp <= 0)
                    {
                        txtsoHD.Focus();
                        errorProvider2.SetError(txtsoHD, "sai gia tri!");
                    }

                    /* else
                         errorProvider1.SetError(txtDonNhap, "");*/
                }
                catch
                {
                    txtsoHD.Focus();
                    errorProvider2.SetError(txtsoHD, " phai la so!");
                }
            }
        }

        private void btn_chitietHD_Click(object sender, EventArgs e)
        {
            if (txtsoHD.Text == "")
            {
                MessageBox.Show(String.Format(" Hãy nhập số hóa đơn"),
                                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoHD.Focus();

            }
            else
            {
                CTHoaDon CT = new CTHoaDon(txtsoHD.Text);
                CT.Show();

            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            InHoaDon ID = new InHoaDon(txtsoHD.Text);
            ID.Show();
        }

        private void btnTim_Click_Click(object sender, EventArgs e)
        {

           
        }
    }

}
