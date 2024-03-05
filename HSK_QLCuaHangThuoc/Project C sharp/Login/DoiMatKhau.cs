using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_sharp
{
    public partial class DoiMatKhau : Form
    {
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        public DoiMatKhau(string user, string pass)
        {
            InitializeComponent();
            txtuser_check.Text = user;
            txtpass_check.Text = pass;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        bool bThayMK(string constr, string pass_cu, string pass_moi, string user)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string thaymk = "Update TK_MK set MatKhau = " + "'" + pass_moi + "'" + "Where MatKhau = " + "'" + pass_cu + "'" + "AND TaiKhoan = " + "'" + user + "'";
                using (SqlCommand cmd = new SqlCommand(thaymk, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        bool bCheckMK_Cu(string constr, string pass, string pass_cu, string user)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string thaymk = "Update TK_MK set MatKhau = " + "'" + pass + "'" + "Where MatKhau = " + "'" + pass_cu + "'" + "AND TaiKhoan = " + "'" + user + "'";
                using (SqlCommand cmd = new SqlCommand(thaymk, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        void ThayMK_TK()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string pass_cu, pass_moi, pass_moi_xacnhan, user, pass;
                pass_cu = txtPass_Cu.Text;
                pass_moi = txtPass_Moi.Text;
                pass_moi_xacnhan = txtPass_Moi_XacNhan.Text;
                user = txtuser_check.Text;
                pass = txtpass_check.Text;
                bool i = bCheckMK_Cu(constr, pass, pass_cu, user);
                if (i)
                {
                    if (pass_moi.Equals(pass_moi_xacnhan))
                    {
                        bool j = bThayMK(constr, pass_cu, pass_moi, user);
                        if (j)
                        {
                            MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass_Cu.Focus();
                }
            }
        }

        private void btnThayDoi_MatKhau_Click(object sender, EventArgs e)
        {

            
            ThayMK_TK();
        }

        private void btnHuyThayDoi_MatKhau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi đây?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbHienMK_ThayDoiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK_ThayDoiMK.Checked)
            {
                txtPass_Cu.UseSystemPasswordChar = false;
                txtPass_Moi.UseSystemPasswordChar = false;
                txtPass_Moi_XacNhan.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass_Cu.UseSystemPasswordChar = true;
                txtPass_Moi.UseSystemPasswordChar = true;
                txtPass_Moi_XacNhan.UseSystemPasswordChar = true;
            }
        }
    }
}
