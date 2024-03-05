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
    public partial class DangKy : Form
    {
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        public DangKy()
        {
            InitializeComponent();
        }
        bool themTK_Moi(string constr, string user, string pass)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string themTK = "Insert into TK_MK values(" + "'" + user + "'" + "," + "'" + pass + "'" + ")";
                using (SqlCommand cmd = new SqlCommand(themTK, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        bool checkTK_User(string constr, string user)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string check_user = "Update TK_MK set TaiKhoan = " + "'" + user + "'" + "Where TaiKhoan = " + "'" + user + "'";
                using (SqlCommand cmd = new SqlCommand(check_user, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

        void check_TT()
        {
            if (txtUser_DangKy.Text == "" || txtPass_DangKy.Text == "" || txtPass_NhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void Dang_Ky()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string user, pass, pass_nhaplai;
                user = txtUser_DangKy.Text;
                pass = txtPass_DangKy.Text;
                pass_nhaplai = txtPass_NhapLai.Text;
                bool i = checkTK_User(constr, user);
                if (i)
                {
                    MessageBox.Show("Đã tồn tại tài khoản trên. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser_DangKy.Focus();
                }
                else
                {
                    if (pass.Equals(pass_nhaplai))
                    {
                        bool j = themTK_Moi(constr, user, pass);
                        if (j)
                        {
                            MessageBox.Show("Thêm tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass_DangKy.Clear();
                        txtPass_DangKy.Focus();
                        txtPass_NhapLai.Clear();
                    }
                }
            }

        }
        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Moi_Click(object sender, EventArgs e)
        {
            if (txtUser_DangKy.Text == "" || txtPass_DangKy.Text == "" || txtPass_NhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Dang_Ky();
                Login dn = new Login();
                dn.Show();
                this.Close();
            }
        }

        private void btnHuy_DangKy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi đây?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Login dn = new Login();
                dn.Show();

            }
        }

        private void cbHienMK_DangKy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK_DangKy.Checked)
            {
                txtPass_DangKy.UseSystemPasswordChar = false;
                txtPass_NhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass_DangKy.UseSystemPasswordChar = true;
                txtPass_NhapLai.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_DangKy_Validating(object sender, CancelEventArgs e)
        {
            if (txtUser_DangKy.Text == "")
            {
                errorProvider1.SetError(txtUser_DangKy, "Khong duoc bo trong");
                txtUser_DangKy.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUser_DangKy, "");
            }

        }

        private void txtPass_DangKy_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass_DangKy.Text == "")
            {
                errorProvider1.SetError(txtPass_DangKy, "Khong duoc bo trong");
                txtPass_DangKy.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPass_DangKy, "");
            }
        }

        private void txtPass_NhapLai_Validating(object sender, CancelEventArgs e)
        {
            if (txtPass_NhapLai.Text == "")
            {
                errorProvider1.SetError(txtPass_NhapLai, "Khong duoc bo trong");
                txtPass_NhapLai.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPass_NhapLai, "");
            }
        }
    }
}
