using DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhanSu.ListForm
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void filldata()
        {
            DataTable data = NhanVienDAO.Instance.GetAllNhanVien();
            DataTable datapb = PhongBanDAO.Instance.GetAllPhongBan();
            DataTable datacv = ChucVuDAO.Instance.GetAllChucVu();
            dgNhanVien.DataSource = data;
            cbPhongBan.DataSource = datapb;
            cbPhongBan.DisplayMember = "TenPB";
            cbChucVu.DataSource = datacv;
            cbChucVu.DisplayMember = "TenCV";


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtMaNhanVien.Text;
            string TenNV = txtTenNhanVien.Text;
            string MaPB = PhongBanDAO.Instance.GetMaPhongBan(cbPhongBan.Text).Rows[0][0].ToString();
            int HeSoLuong = Int32.Parse(txtHeSoLuong.Text);
            string GioiTinh = cbGioiTinh.Text;
            string NgaySinh = dateNgaySinh.Text;
            string SoCM = txtSoCM.Text;
            string DienThoai = txtSDT.Text;
            string TrinhDoHV = txtTrinhDo.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string ngayvaolam = dateNgayVaoLam.Text;
            string maCV = ChucVuDAO.Instance.getMaChucVu(cbChucVu.Text).Rows[0][0].ToString();
            if (NhanVienDAO.Instance.AddNhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email,ngayvaolam, maCV))
            {
                MessageBox.Show("thêm nhân viên thành công");
                filldata();
            }
            else
            {
                MessageBox.Show("thêm nhân viên không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID;
            string manv;
            foreach (DataGridViewRow row in dgNhanVien.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                txtMaNhanVien.Text = ID;
            }
            manv = txtMaNhanVien.Text;
            if (NhanVienDAO.Instance.DelNhanVien(manv))
            {
                MessageBox.Show("Xoá thành công");
                filldata();
            }
            else
            {
                MessageBox.Show("Xoá Thất bại");
            }
        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID;
            foreach (DataGridViewRow row in dgNhanVien.SelectedRows)
            {
                ID = row.Cells[0].Value.ToString();
                DataTable select = NhanVienDAO.Instance.GetNhanVien(ID);
                txtMaNhanVien.Text = select.Rows[0][0].ToString();
                txtTenNhanVien.Text = select.Rows[0][1].ToString();
                cbPhongBan.Text = select.Rows[0][2].ToString();
                cbChucVu.Text = select.Rows[0][3].ToString();
                cbGioiTinh.Text = select.Rows[0][4].ToString();
                txtDiaChi.Text  = select.Rows[0][5].ToString();
                txtSoCM.Text = select.Rows[0][6].ToString();
                txtSDT.Text = select.Rows[0][7].ToString();
                txtTrinhDo.Text = select.Rows[0][8].ToString();
                txtEmail.Text = select.Rows[0][9].ToString();
                txtHeSoLuong.Text = select.Rows[0][10].ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtMaNhanVien.Text;
            string TenNV = txtTenNhanVien.Text;
            string MaPB = PhongBanDAO.Instance.GetMaPhongBan(cbPhongBan.Text).Rows[0][0].ToString();
            int HeSoLuong = Int32.Parse(txtHeSoLuong.Text);
            string GioiTinh = cbGioiTinh.Text;
            string NgaySinh = dateNgaySinh.Text;
            string SoCM = txtSoCM.Text;
            string DienThoai = txtSDT.Text;
            string TrinhDoHV = txtTrinhDo.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string ngayvaolam = dateNgayVaoLam.Text;
            string maCV = ChucVuDAO.Instance.getMaChucVu(cbChucVu.Text).Rows[0][0].ToString();
            if (NhanVienDAO.Instance.UpNhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, maCV))
            {
                MessageBox.Show("cập nhật nhân viên thành công");
                filldata();
            }
            else
            {
                MessageBox.Show("cập nhật nhân viên không thành công");
            }
        }

        private void NhanVien_Load_1(object sender, EventArgs e)
        {
            filldata();
        }
    }
}
