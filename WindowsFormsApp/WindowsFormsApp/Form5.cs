using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WindowsFormsApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {   


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string path = string.Format{ }
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("D:\\Huong Su Kien\\WindowsFormsApp\\WindowsFormsApp\\CrystalReport3.rpt");

            ParameterFieldDefinition pfd = reportDocument.DataDefinition.ParameterFields["NguoiLap"];
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = textBox1.Text;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);

            crystalReportViewer1.ReportSource = reportDocument;
          //  reportDocument.RecordSelectionFormula = "{tblSach.iSoluong}>5";
            crystalReportViewer1.Refresh();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
