using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            filldata();
        }
        public void filldata()
        {
            DataTable data = ChucVuDAO.Instance.GetAllChucVu();
            dgChucVu.DataSource = data;
        }

        private void dgChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maCV;
            string tenCV;
            foreach (DataGridViewRow row in dgChucVu.SelectedRows)
            {
                maCV = row.Cells[0].Value.ToString();
                tenCV = row.Cells[1].Value.ToString();
                txtMaCV.Text = maCV;
                txtTenCV.Text = tenCV;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text;
            string tenCV = txtTenCV.Text;
            if (ChucVuDAO.Instance.AddChucVu(maCV, tenCV))
            {
                MessageBox.Show("Thêm chức vụ thành công");
                filldata();
            }
            else 
            {
                MessageBox.Show("Thêm chức vụ không thành công");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV.Text;
            if (ChucVuDAO.Instance.DelChucVu(maCV))
            {
                MessageBox.Show("Xoá chức vụ thành công");
                filldata();
                txtMaCV.Text = "";
                txtTenCV.Text = "";
            }
            else
            {
                MessageBox.Show("Xoá chức vụ không thành công");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCVNew = txtMaCV.Text;
            string tenCV = txtTenCV.Text;
            string maCVOld = "";
            foreach (DataGridViewRow row in dgChucVu.SelectedRows)
            {
                maCVOld = row.Cells[0].Value.ToString();
            }
            if (ChucVuDAO.Instance.UpChucVu(maCVOld, maCVNew, tenCV))
            {

                MessageBox.Show("Cập nhật thành công");
                filldata();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }
    }
}
