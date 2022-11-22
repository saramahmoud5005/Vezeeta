using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezetaa
{ 
    public partial class Form1 : Form
    {
       // public static Boolean is_enabled = false;
       public Form1()
        {  
            InitializeComponent();
     
        }
       /* public Form1(Boolean u) {
            InitializeComponent();
            

            Form1.is_enabled = u;
            enable_button();
            

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            home1.Hide();
            buyProductForm1.Hide();
            deleteAppointementForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            bookAppointmentForm1.Show();
            bookAppointmentForm1.BringToFront();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            deleteAppointementForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            buyProductForm1.Show();
            buyProductForm1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            deleteAppointementForm1.Show();
            deleteAppointementForm1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            deleteAppointementForm1.Hide();
            displayPurchasesReport1.Hide();

            displayAppointmentsReport1.Show();
            displayAppointmentsReport1.BringToFront();
       
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            deleteAppointementForm1.Hide();
            displayAppointmentsReport1.Hide();

            displayPurchasesReport1.Show();
            displayPurchasesReport1.BringToFront();

           


        }
        /*public  void enable_button() {
            button1.Enabled =is_enabled;
            button2.Enabled = is_enabled;
            button3.Enabled = is_enabled;
            button4.Enabled = is_enabled;
            button5.Enabled = is_enabled;
        }*/
       

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
