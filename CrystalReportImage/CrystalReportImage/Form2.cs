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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GetCrystalReport();
        }

        public void GetCrystalReport()
        {
            ReportDocument crReportDocument = new ReportDocument();
            crReportDocument = new CrystalReport();
            //crReportDocument.SetDataSource(ds);
            crReportDocument.SetParameterValue("Image", SharedClass.ImageUrl);
            crystalReportViewer1.ReportSource = crReportDocument;


        }

    }
}
