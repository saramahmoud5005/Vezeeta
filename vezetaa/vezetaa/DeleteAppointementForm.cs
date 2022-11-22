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
    
    public partial class DeleteAppointementForm : UserControl
    {
    
        
        OracleDataAdapter adapter, adapter2;
        OracleCommandBuilder builder, builder2;
        DataSet ds1;
        DataSet ds2;
        string  p_username;
        DateTime current_date = DateTime.Now;
        public DeleteAppointementForm( )
        {
           
            InitializeComponent();
        }
        public DeleteAppointementForm(string s)
        {
          this.p_username = s;
            InitializeComponent();
            
            
        }

        private void DeleteAppointementForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                int indx = item.Index;
              
               
                dataGridView1.Rows.RemoveAt(indx);
                ds2.Tables[0].Rows[indx][2] = 0;
                
            }
        }

        private void btn_showDoctors_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            builder2 = new OracleCommandBuilder(adapter2);
           // ds1.Tables[0].PrimaryKey = ds1.Tables[0].Columns[0];
            adapter.Update(ds1.Tables[0]);
            //adapter.Dispose


               try
            {
                Console.WriteLine("\nAdding key info into DataTable");
                ds2.Tables[0].PrimaryKey = new DataColumn[] { ds2.Tables[0].Columns["doc_un"] };

                // Update database
                Console.WriteLine("Calling DataAdapter.Update");
                adapter2.Update(ds2.Tables[0]);
                ds2.Tables[0].AcceptChanges();

                Console.WriteLine("Edit row successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error editing rows: {0}", ex.Message);
            }
            

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            p_username = Home.un;
            
            string connectionOracle = "Data Source=orcl; User Id=scott;Password=tiger;";
            string loadData = "select  DOC_USERNAME,DAY_TIME,patient_username from BOOKED_APPOINTMENT where patient_username= '" + p_username + "' ";
       
            string loadData2 = "select  DOC_UN,DAY_T,IS_BOOKED  from DOC_APPOINTMENTS ds,BOOKED_APPOINTMENT ba where ds.doc_un=ba.doc_username and ds.day_t=ba.day_time and ba.patient_username='" + p_username + "'";
            adapter = new OracleDataAdapter(loadData, connectionOracle);
            adapter2 = new OracleDataAdapter(loadData2, connectionOracle);

            ds1 = new DataSet();
            ds2 = new DataSet();
            adapter.Fill(ds1);
            adapter2.Fill(ds2);
           
           
            //MessageBox.Show(ds1.Tables[0].Rows[0][0].ToString());
            dataGridView1.DataSource = ds1.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
