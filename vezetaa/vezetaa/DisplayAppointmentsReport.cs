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
    public partial class DisplayAppointmentsReport : UserControl
    {
        bookapp cr1;
        public DisplayAppointmentsReport()
        {
            InitializeComponent();
        }

        private void DisplayAppointmentsReport_Load(object sender, EventArgs e)
        {
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Home hom = new Home();
            cr1 = new bookapp();
            
            cr1.SetParameterValue(0, Home.un);
           
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
