using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C_sharp
{
    public partial class Menu : Form
    {
        public Menu(string user,string pass)
        {
           
            InitializeComponent();
            txtuser1.Text = user;
            txtpass1.Text = pass;
            if (txtuser1.Text != "admin")
            {
                nhậpHàngToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                nhàCungCấpToolStripMenuItem.Visible = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

      


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Visible = false;
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHang N = new NhapHang();
            N.MdiParent = this;
            N.Show();

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuoc T = new Thuoc();
            T.MdiParent = this;
            T.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien N = new NhanVien();
            N.MdiParent = this;
            N.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            KH.MdiParent = this;
            KH.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon HD = new HoaDon();
            HD.MdiParent = this;
            HD.Show();
        }

        private void đơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSDonNhap dsdn = new DSDonNhap();
            dsdn.MdiParent = this;
            dsdn.Show();
        }

        private void đơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemDonNhap tkdn = new TimKiemDonNhap();
            tkdn.MdiParent = this;
            tkdn.Show();
        }

        private void txtpass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(txtuser1.Text, txtpass1.Text);
            dmk.MdiParent = this;
            dmk.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
