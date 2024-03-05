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
    public partial class CTHoaDon : Form
    {

        ClassMain hdt = new ClassMain();
        public CTHoaDon(string sohd)
        {
            InitializeComponent();
            cbb_sohd.Text = sohd;
            string sql = "pr_timkiemsohdt";
            hdt.Timkiemdl(sql, "@sohd", sohd, dgvHDThuoc);
        }

        private void CTHoaDon_Load(object sender, EventArgs e)
        {
            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.TableHD("HD");
            cbb_sohd.DataSource = dt;
            cbb_sohd.DisplayMember = dt.Columns[0].ColumnName;

            DataTable ct = c.TableThuoc("thuoc");
            cbb_mathuoc.DataSource = ct;
            cbb_mathuoc.DisplayMember = ct.Columns[1].ColumnName;
        }
        void gridload(string sohd)
        {
            cbb_sohd.Text = sohd;
            string sql = "pr_timkiemsohdt";
            hdt.Timkiemdl(sql, "@sohd", sohd, dgvHDThuoc);
        }

        public void reset()
        {
            cbb_mathuoc.Text = null;
            txt_soluong.Text = null;

        }

        private void btn_loadclick_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dgvHDThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_sohd.Text = dgvHDThuoc.CurrentRow.Cells[0].Value.ToString();
            cbb_mathuoc.Text = dgvHDThuoc.CurrentRow.Cells[1].Value.ToString();
            txt_soluong.Text = dgvHDThuoc.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThemHDThuoc_Click_Click(object sender, EventArgs e)
        {
            if (cbb_sohd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_sohd.Focus();
            }
            else
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "pr_ThemHDT";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(cbb_sohd.Text));
                    cmd.Parameters.AddWithValue("@tenthuoc", cbb_mathuoc.Text);
                    cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txt_soluong.Text));

                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    MessageBox.Show("Đã thêm mới Hóa Đơn Thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gridload(cbb_sohd.Text);
            }


        }

        private void btnXoaHDThuoc_Click_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pr_XoaHDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(cbb_sohd.Text));
                cmd.Parameters.AddWithValue("@tenthuoc", cbb_mathuoc.Text);

                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Xóa Hóa Đơn Thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridload(cbb_sohd.Text);
        }

        private void btnSuaHDThuoc_Click_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["QLKD_CuaHangThuoc"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "pr_SuaHDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", Convert.ToInt32(cbb_sohd.Text));
                cmd.Parameters.AddWithValue("@tenthuoc", cbb_mathuoc.Text);
                cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txt_soluong.Text));
                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Đã sửa Hóa Đơn Thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gridload(cbb_sohd.Text);
        }

    }
    }
