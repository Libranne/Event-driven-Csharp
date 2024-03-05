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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

    
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            Dang_Nhap();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        string constr = "Data Source=LAPTOP-KPVI1J9T;Initial Catalog=QLKD_CuaHangThuoc;Integrated Security=True";
        bool checkUser_DangNhap(string constr, string user)
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
        bool checkPass_DangNhap(string constr, string pass, string user)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string check_pass = "Update TK_MK set MatKhau = " + "'" + pass + "'" + "Where MatKhau = " + "'" + pass + "'" + "AND TaiKhoan = " + "'" + user + "'";
                using (SqlCommand cmd = new SqlCommand(check_pass, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0;
                }
            }
        }

       
        void Dang_Nhap()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string user, pass;
                user = txtUser.Text;
                pass = txtPass.Text;
                bool i = checkUser_DangNhap(constr, user);
                if (i)
                {
                    bool j = checkPass_DangNhap(constr, pass, user);
                    if (j)
                    {
                        /*if (cb_luumk.Checked)
                        {
                            bool l = Luu_TK(constr, txtUser.Text, txtPass.Text);
                        }*/
                       Menu qlt = new Menu(user, pass);
                        qlt.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác! Vui lòng thử lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác! Vui lòng thử lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Visible = false;
            txtPass.Clear();
        }

        private void cb_hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienmk.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

     

        private void txtUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                errorUser.SetError(txtUser, "Nhập tài khoản!");
            }
            else
            {
                errorUser.SetError(txtUser, "");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                errorUser.SetError(txtPass, "Nhập mật khẩu!");
            }
            else
            {
                errorUser.SetError(txtPass, "");
            }
        }
    }
}
