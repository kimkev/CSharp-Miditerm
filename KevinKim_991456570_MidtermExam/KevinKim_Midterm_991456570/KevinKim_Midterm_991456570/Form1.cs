using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace KevinKim_Midterm_991456570
{
    public partial class Form1 : Form
    {
        // Connection to the database
        string connectionString = null;
        SqlConnection cnn;
        SqlCommand command;
        int x=0;

        public Form1()
        {
            InitializeComponent();
        }

        // Establish connection to database on load
        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=DESKTOP-4P2PB1M\\SQLEXPRESS;" +
                              "Initial Catalog = OrderDB;" +
                              "Integrated Security = SSPI; " +
                              "Persist Security Info = false";

            cnn = new SqlConnection(connectionString);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                // Query to insert into Customer
                command = new SqlCommand("Insert into dbo.Customer values(@name, @address," +
                                         "@phonenum)", cnn);


                command.Parameters.AddWithValue("@name", this.txtName.Text);
                command.Parameters.AddWithValue("@address", this.txtAddress.Text);
                command.Parameters.AddWithValue("@phonenum", this.txtPhoneNumber.Text);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Customer record added");


                // Query to insert into Order
                SqlCommand command2 = new SqlCommand("Insert into dbo.[Order] values(@toppings, @cardtype, " +
                                                    "@cardno, @status, @custid)", cnn);


                // List to check which toppings are checked
                List<string> toppings = new List<string>();
                if (this.chkCheese.Checked)
                {
                    toppings.Add("Cheese");
                }
                if (this.chkPepperoni.Checked)
                {
                    toppings.Add("Pepperoni");
                }
                if (this.chkMushrooms.Checked)
                {
                    toppings.Add("Mushrooms");
                }
                string toppingChoice = String.Join(", ", toppings.ToArray());

                command2.Parameters.AddWithValue("@toppings", toppingChoice.ToString());
                command2.Parameters.AddWithValue("@cardtype", this.cmbCard.SelectedItem.ToString());
                command2.Parameters.AddWithValue("@cardno", this.txtCardNo.Text);
                command2.Parameters.AddWithValue("@status", this.txtStatus.Text);
                // cannot determine the current auto incremented customer id. used a substitute for now
                x++;
                command2.Parameters.AddWithValue("@custid", x);

                int r2 = command2.ExecuteNonQuery();

                MessageBox.Show(r2 + " Order record added");


                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                if (txtStatus.Text == "Cancelled")
                {
                    // delete query
                    command = new SqlCommand("delete from dbo.[order] where orderid = @orderid", cnn);

                    command.Parameters.AddWithValue("@orderid", this.txtOrderId.Text);

                    int r = command.ExecuteNonQuery();

                    MessageBox.Show(r + " Order deleted");
                }

                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                // update query
                command = new SqlCommand("update dbo.customer set Address = @address", cnn);

                command.Parameters.AddWithValue("@address", this.txtAddress.Text);

                int r = command.ExecuteNonQuery();

                MessageBox.Show(r + " Customer address updated");

                cnn.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (this.txtStatus.Text.Contains("In Process"))
            {
                this.txtStatus.Text = "Cancelled";
            }
            else if (this.txtStatus.Text.Contains("Cancelled"))
            {
                this.txtStatus.Text = "In Process";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {

                // empty out the output box first
                this.txtOutput.Clear();

                cnn.Open();
                command = new SqlCommand("select * from dbo.customer, dbo.[order] " +
                                         "where dbo.customer.custid = dbo.[order].custid " +
                                         "AND dbo.[order].orderid = @orderid", cnn);

                command.Parameters.AddWithValue("@orderid", this.txtOrderId.Text);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    this.txtOutput.AppendText(
                        "Customer Name: " + reader["CustName"].ToString() + Environment.NewLine +
                        "Address: " + reader["Address"].ToString() + Environment.NewLine +
                        "Telephone: " + reader["PhoneNo"].ToString() + Environment.NewLine +
                        "Toppings: " + reader["Toppings"].ToString().Substring(0, 10) + Environment.NewLine +
                        "Credit Card Type: " + reader["CardType"].ToString() + Environment.NewLine +
                        "Credit Card No: " + reader["CardNo"].ToString() + Environment.NewLine + 
                        "Status: " + reader["Status"].ToString() + Environment.NewLine + Environment.NewLine);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {

                // empty out the output box first
                this.txtOutput.Clear();

                cnn.Open();
                command = new SqlCommand("select * from dbo.customer, dbo.[order] " +
                                         "where dbo.customer.custid = dbo.[order].custid " +
                                         "AND dbo.customer.custid = @custid", cnn);

                command.Parameters.AddWithValue("@id", this.txtOrderId.Text);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    this.txtOutput.AppendText(
                        "Customer Name: " + reader["CustName"].ToString() + Environment.NewLine +
                        "Address: " + reader["Address"].ToString() + Environment.NewLine +
                        "Telephone: " + reader["PhoneNo"].ToString() + Environment.NewLine +
                        "Toppings: " + reader["Toppings"].ToString().Substring(0, 10) + Environment.NewLine +
                        "Credit Card Type: " + reader["CardType"].ToString() + Environment.NewLine +
                        "Credit Card No: " + reader["CardNo"].ToString() + Environment.NewLine +
                        "Status: " + reader["Status"].ToString() + Environment.NewLine + Environment.NewLine);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error in SQL! " + ex.Message);
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
    }
}
