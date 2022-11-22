using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace vezetaa
{ 
    
    public partial class Home : UserControl
    {
        public static string un;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
       public string p_name;
        bool flag = false;
        Form1 f;
        public Home()
        {
            InitializeComponent();
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
           

           
            

        }

        private void patient_username_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_name = patient_username.Text.ToString();
            
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select phone_num from Patient where username=: p_name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("p_name", p_name);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string num0 = dr[0].ToString();
                if (num0.Length > 0)
                {
                    flag = true;
                }
            }
            dr.Close();
            if (!flag)
            {
                MessageBox.Show("Invalid User Name!");
                patient_username.Clear();
            }
            else
            {
                
               
              //  f = new Form1();
              
                MessageBox.Show(" login success");
                un = patient_username.Text.ToString();

            }
         //  DeleteAppointementForm f = new DeleteAppointementForm(un);
         
        }
    }
}
