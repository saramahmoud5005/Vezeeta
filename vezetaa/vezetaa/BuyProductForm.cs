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
    public partial class BuyProductForm : UserControl
    {
     
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        int count =0;

        public BuyProductForm()
        {
            InitializeComponent();
        }

        private void BuyProductForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void decCount_Click(object sender, EventArgs e)
        {
            count--;
            countTxt.Text = count.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            countTxt.Text = count.ToString();
        }

        private void view_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select product_type, price from product where product_name =: pname";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("pname", productTxt.Text);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                viewTxt.Text = "Product Name: " + productTxt.Text;
                viewTxt.AppendText(Environment.NewLine);
                viewTxt.AppendText("Product Type: " + dr[0].ToString());
                viewTxt.AppendText(Environment.NewLine);
                viewTxt.AppendText("Price: " + dr[1].ToString());
            }
            else
            {
                viewTxt.Text = "Can't find what you need";
            }

            dr.Close();
        }

        

        private void buy_Click(object sender, EventArgs e)
        {
            if (productTxt.Text != string.Empty && Home.un != string.Empty && count != 0)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "GET_COUNT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("PName", productTxt.Text);
                cmd.Parameters.Add("PCount", OracleDbType.Int32, ParameterDirection.Output);

                cmd.ExecuteNonQuery();
                int numinDB = 0;
                try
                {
                    numinDB = Convert.ToInt32(cmd.Parameters["PCount"].Value.ToString());
                }
                catch
                {
                    viewTxt.Text = "Can' t find what you need?";
                }

                if (numinDB == 0)
                    MessageBox.Show("Sold Out");

                else if (count > numinDB)
                    MessageBox.Show("Only " + numinDB.ToString() + " left in stock");

                else

                {
                    //update product count
                    numinDB -= count;
                    OracleCommand cmmd = new OracleCommand();
                    cmmd.Connection = conn;
                    cmmd.CommandText = "update Product set product_count= :ccount where product_name = :nname";

                    cmmd.Parameters.Add("ccount", numinDB);
                    cmmd.Parameters.Add("nname", productTxt.Text);

                    cmmd.ExecuteNonQuery();

                    OracleCommand cmdd = new OracleCommand();
                    cmdd.Connection = conn;
                    cmdd.CommandText = "insert into sold_product (patient_username,product_name,day_time,product_count) values (:usernamee, :namee, :datee , :countt)";

                    cmdd.Parameters.Add("usernamee", Home.un);
                    cmdd.Parameters.Add("namee", productTxt.Text);
                    cmdd.Parameters.Add("datee", DateTime.Now.ToString());
                    cmdd.Parameters.Add("countt", count);

                    cmdd.ExecuteNonQuery();

                    MessageBox.Show("Your purchase was successful");
                }
            }
            else
                MessageBox.Show("Please, fill out username,product and count fields");

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void productTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void viewTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void countTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}
