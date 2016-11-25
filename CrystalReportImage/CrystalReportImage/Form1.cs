using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CrystalReportImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); GetCrystalReport();
        }

        public void GetCrystalReport()
        {
            ReportDocument crReportDocument = new ReportDocument();
            crReportDocument = new CrystalReport();
            //crReportDocument.SetDataSource(ds);
            crReportDocument.SetParameterValue("Image", txtImageUrl.Text.ToString());
            crystalReportViewer1.ReportSource = crReportDocument;

         
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            GetCrystalReport();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            SharedClass.ImageUrl = txtImageUrl.Text;
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
