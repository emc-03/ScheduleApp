using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScheduleApp
{
    public partial class updateCustomer : Form
    {
        public updateCustomer()
        {
            InitializeComponent();

            Customer customerUpdate = new Customer();
        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            customerData customerDataForm = new customerData();
            customerDataForm.Show();
        }

        private void UpfnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCButton_Click(object sender, EventArgs e)
        {
            
            //Customer getCustomerID = new Customer();
            //MySqlCommand mySqlCommand = new MySqlCommand (getCustomerID);
            //mySqlCommand.Connection = DB_Connection.conn;

            //Customer updateCustomerID(int CustomerID)
            //{
            //    Customer customer = null;
            //    using (MySqlConnection connection = new MySqlConnection(connection))
            //    {
            //        connection.Open();
            //        string fetchCustomerID = "SELECT * FROM customer WHERE customerId = @CustomerID;
            //        using (MySqlCommand fetchCommand = new MySqlCommand(fetchCustomerID, DB_Connection.conn)) ;
            //    }

            //}

            //TODO needs to pull from the database and populate the feilds


            //string currentFirstName = "currentFirstName";
            //string currentLastName = "currentLastName";

            //int currentCustomerID = -1;

            //string fetchCustomerID = "SELECT customerID FROM customer WHERE firstName = @firstName and lastName = @lastName";
            //using (MySqlCommand fetchCommand = new MySqlCommand(fetchCustomerID, DB_Connection.conn))
            //{
            //    fetchCommand.Parameters.AddWithValue("@firstName", currentFirstName);
            //    fetchCommand.Parameters.AddWithValue("@lastName", currentLastName);
           

            //try
            //{
            //    DB_Connection.conn.Open();
            //    object queryResult = fetchCommand.ExecuteScalar();

            //    if (DialogResult != null)
            //    {
            //        currentCustomerID = Convert.ToInt32(queryResult);
            //            Console.WriteLine($"Customer ID: {currentCustomerID.CustomerID}");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Customer not found. Please check the customer ID. ");
            //        return; // exit if customer not found. 
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Error, cannot find customer ID: " + error.Message);
            //    return;  // exit if error found;
            //}
            //finally
            //{
            //    DB_Connection.conn.Close();
            //}

            //}

            



            // populate updated information into the database 
            string updateFirstName = "NewFirstName";
            string updateLastName = "NewLastName";
            string updatePhone = "NewPhone";
            string updateAddress = "NewAddress";
            string updateAddress2 = "NewAddress2";
            string updatePostalCode = "NewPostalCode";
            string updateCity = "NewCity";
            string updateCountry = "NewCountry";

            int customerID = -1;

            string updateQuery = "UPDATE customer SET firstName = @firstName, lastName = @lastName, phone = @phone, " +
                                 "address = @address, address2 = @address2, city = @city, postalCode = @postalCode, " +
                                 "country = @country, lastUpdateByUpdate = @lastUpdateBy " +
                                 "WHERE customerID = @customerId";

            using (MySqlCommand command = new MySqlCommand(updateQuery, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@firstName", updateFirstName);
                command.Parameters.AddWithValue("@lastName", updateLastName);
                command.Parameters.AddWithValue("@phone", updatePhone);
                command.Parameters.AddWithValue("@address", updateAddress);
                command.Parameters.AddWithValue("@address2", updateAddress2);
                command.Parameters.AddWithValue("@postalCode", updatePostalCode);
                command.Parameters.AddWithValue("@city", updateCity);
                command.Parameters.AddWithValue("@country", updateCountry);
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedByAddress");
                command.Parameters.AddWithValue("@customerId", customerID);

                try
                {
                    DB_Connection.conn.Open();

                    // Execute the UPDATE query
                    int rowsSelected = command.ExecuteNonQuery();


                    if (rowsSelected > 0)
                    {
                        MessageBox.Show("Customer data updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows selected. Customer may not exist, provide alternate ID.");
                    }
                }
                catch (Exception except)
                {
                    MessageBox.Show("Error: " + except.Message);
                }
                finally
                {
                    DB_Connection.conn.Close();
                }
            }
        }
    }
}
