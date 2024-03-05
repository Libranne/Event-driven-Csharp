using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace QuanLyNhanSu.ListForm
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            filldata();
            panel1.Hide();
            panel2.Hide();
            btnDoiMatKhau.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void filldata()
        {
            DataTable data1 = AccountDAO.Instance.GetNonAllUser();
            DataTable data2 = AccountDAO.Instance.GetAllUser();
            dg1.DataSource = data1;
            dg2.DataSource = data2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID;
            string manv;
            foreach (DataGridViewRow row in dg2.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                txtMaNv.Text = ID;
            }
            manv = txtMaNv.Text;
            if (AccountDAO.Instance.DelUser(manv))
            {
                MessageBox.Show("Xoá thành công");
                filldata();
            }
            else
            {
                MessageBox.Show("Xoá Thất bại");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matkhau = txtMatKhau.Text;
            string taikhoan = txtTaiKhoan.Text;
            string quyenhan = cbQuyenHan.Text;
            string manv = txtMaNv.Text;
            if (AccountDAO.Instance.AddUser(manv, taikhoan, matkhau, quyenhan))
            {
                MessageBox.Show("thêm thành công");
                filldata();
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID;
            panel2.Hide();
            panel1.Show();
            foreach (DataGridViewRow row in dg1.SelectedRows)
            {
               ID = row.Cells[0].Value.ToString();
               txtMaNv.Text = ID;
            }
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            string TK;
            btnDoiMatKhau.Enabled = true;
            btnXoa.Enabled = true;
            panel1.Hide();
            foreach (DataGridViewRow row in dg2.SelectedRows)
            {
                TK = row.Cells[2].Value.ToString();
                txtTaiKhoan2.Text = TK;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panel2.Show();
            txtTaiKhoan2.ReadOnly = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string TK = txtTaiKhoan2.Text;
            string MKM = txtMKM.Text;
            if(AccountDAO.Instance.UpdateUser(TK,MKM))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                panel2.Hide();
                filldata();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công");
            }
        }
    }
}
