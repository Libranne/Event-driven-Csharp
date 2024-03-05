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

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        private string cnn;

        public Form3()
        {
            InitializeComponent();
        }

       
       

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ClassMain c = new ClassMain();
            c.ketnoi();
            DataTable dt = c.getTable("Sach");
            dgvSach.DataSource = dt;
            cbbSach.DataSource = dt;
              cbbSach.DisplayMember = dt.Columns[1].ColumnName;
            //  cbbSach.ValueMember = "sTieude";

            DataTable tb = c.Table("tblNhaXuatBan");
             cbbNXB.DataSource = tb;
           // cbbNXB.DisplayMember = tb.Columns[0].ColumnName;
                 cbbNXB.ValueMember = tb.Columns[1].ColumnName;

        }

        private void cbbSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
