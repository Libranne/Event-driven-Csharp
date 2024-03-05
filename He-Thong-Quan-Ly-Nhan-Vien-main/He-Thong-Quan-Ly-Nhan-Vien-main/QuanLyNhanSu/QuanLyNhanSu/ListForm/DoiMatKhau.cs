using System;
using System.Windows.Forms;
using DAO;

namespace QuanLyNhanSu.ListForm
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TK = txtTaiKhoan2.Text;
            string MKM = txtMKM.Text;
            if (AccountDAO.Instance.UpdateUser(TK, MKM))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công");
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTaiKhoan2.Text = AccountDAO.Instance.AccountInfor().TenDangNhap;
        }
    }
}
