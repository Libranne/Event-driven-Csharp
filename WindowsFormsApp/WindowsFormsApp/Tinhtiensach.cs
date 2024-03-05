using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Tinhtiensach : Form
    {
        public Tinhtiensach()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            int result = (Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtDongia.Text)) + Convert.ToInt32(txtVAT.Text);
            txtTongtien.Text = result.ToString();

        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ban da mua sach: "+cbbTensach.Text+ " cua NXB: "+cbbNXB.Text+  " Voi so tien phai thanh toan la: "+ txtTongtien.Text, "Hoa Don");
        }

       

        private void Tinhtiensach_Load(object sender, EventArgs e)
        {
           
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
          
        }

       private void txtDongia_Validating(object sender, CancelEventArgs e)
        {
            if (txtDongia.Text == "")
               errorProvider1.SetError(txtDongia, "ban phai nhap ");
            else
            {
                try
                {
                    int temp = Convert.ToInt32(txtDongia.Text);
                    if (temp <=0)
                       errorProvider1.SetError(txtDongia, "sai gia tri!");
                    else
                        errorProvider1.SetError(txtDongia, "");
                }
                catch
                {
                    errorProvider1.SetError(txtDongia, " phai la so!");
                }
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

            int result1 = Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtDongia.Text) * 10 / 100;
            txtVAT.Text = result1.ToString();
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoluong_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoluong.Text == "")
                errorProvider2.SetError(txtSoluong, "ban phai nhap ");
            // do textchanged o so luong nen khi nhap chu cai vao no se bao loi ngay=>> khong xu ly duoc(dung button ok)
           /* else
            {
                try
                {
                    int temp = Convert.ToInt32(txtSoluong.Text);
                    if (temp <= 0)
                        errorProvider1.SetError(txtSoluong, "sai gia tri!");
                    else
                        errorProvider1.SetError(txtSoluong, "");
                }
                catch
                {
                    errorProvider1.SetError(txtSoluong, " phai la so!");
                }
            }*/
        }

        private void cbbTensach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
