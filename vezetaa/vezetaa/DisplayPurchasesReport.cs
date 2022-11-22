using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace vezetaa
{
    public partial class DisplayPurchasesReport : UserControl
    {
        purchase cr2;
        public DisplayPurchasesReport()
        {
            InitializeComponent();
        }

        private void DisplayPurchasesReport_Load(object sender, EventArgs e)
        {
         
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            cr2 = new purchase();
            
            cr2.SetParameterValue(0, Home.un);
            
            crystalReportViewer1.ReportSource = cr2;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
