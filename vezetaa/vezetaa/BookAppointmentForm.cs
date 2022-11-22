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
    public partial class BookAppointmentForm : UserControl
    {
        
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        string  doc_username = null;
        public BookAppointmentForm()
        {
            InitializeComponent();
        }
        private void BookAppointmentForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select speciality_name from SPECIALITY";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_specialities.Items.Add(dr[0].ToString());
            }
            cmb_specialities.SelectedIndex = 0;
            dr.Close();
        }



        private void btn_showDoctors_Click(object sender, EventArgs e)
        {

            if (Doctors.Items.Count > 0)
            {
                foreach (ListViewItem item in Doctors.Items)
                {
                    Doctors.Items.Remove(item);
                }
            }
            if (list_Appointements.Items.Count > 0)
            {
                foreach (ListViewItem item in list_Appointements.Items)
                {
                    list_Appointements.Items.Remove(item);
                }
            }
            //////////////////////////////////////////////////////
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select USERNAME,HOSPITAL_NAME , HOSPITAL_LOC,PHONE_NUM FROM DOCTOR WHERE SPECIALITY = :speciality";
            cmd.Parameters.Add("speciality", cmb_specialities.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                var listViewItem = new ListViewItem(row);
                Doctors.Items.Add(listViewItem);
            }
            dr.Close();
        }



        private void btn_appointement_Click(object sender, EventArgs e)
        {
            if (list_Appointements.Items.Count > 0)
            {
                foreach (ListViewItem item in list_Appointements.Items)
                {
                    list_Appointements.Items.Remove(item);
                }
            }
            if (Doctors.SelectedItems.Count > 0)
            {
                doc_username = Doctors.SelectedItems[0].SubItems[0].Text;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GetDocAppointement";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("doc_name", doc_username);
                cmd.Parameters.Add("doc_appointement", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string date_time = dr[0].ToString();
                    char spearator = ' ';
                    string[] item = date_time.Split(spearator);
                    var listViewItem = new ListViewItem(item);
                    list_Appointements.Items.Add(listViewItem);
                }
                dr.Close();
                if (list_Appointements.Items.Count == 0)
                {
                    MessageBox.Show("This doctor doesn't have avaliable appointements");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from Doctor's list");
            }
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            if (list_Appointements.SelectedItems.Count > 0)
            {
                string date = list_Appointements.SelectedItems[0].SubItems[0].Text;
                string time = list_Appointements.SelectedItems[0].SubItems[1].Text;
                string day_time = date + " " + time;

                //insert booked appointement into booked_appointement table
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"INSERT INTO booked_appointment
                                    VALUES (:doc_username,:day_time,:patient_username)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("doc_username", doc_username);
                cmd.Parameters.Add("day_time", day_time);
                cmd.Parameters.Add("patient_username",Home.un);
                int insert = cmd.ExecuteNonQuery();
                if (insert != -1)
                {
                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conn;

                    cmd1.CommandText = @"update doc_appointments set is_booked = 1
                                         where doc_appointments.doc_un=:doc_username and doc_appointments.day_t=:day_time";
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.Add("doc_username", doc_username);
                    cmd1.Parameters.Add("day_time", day_time);

                    int update = cmd1.ExecuteNonQuery();
                    if (update != -1)
                    {
                        MessageBox.Show("success\n booked appointement in  " + day_time + " with doctor " + doc_username);
                    }
                    if (list_Appointements.Items.Count > 0)
                    {
                        foreach (ListViewItem item in list_Appointements.Items)
                        {
                            list_Appointements.Items.Remove(item);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select an item from Appointements's list");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patient_username_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
