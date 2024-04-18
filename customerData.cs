using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class CustomerInformationForm : Form
    {
        private Customer _selectedCustomer;
        private readonly CustomerData _customerData = new CustomerData();
        public CustomerInformationForm()
        {
            InitializeComponent();
            loadData();

        }
        // dataGridView
        public void loadData()
        {
           List<Customer> customerList = _customerData.FindAll();
           //dataGridCustomer.DataSource = BINDINGLIST? ;
            
            // TODO Binding list to make sure that when a row is selected that the full customer is available 
        }

        private void custButtonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm loginForm = new loginForm();
            loginForm.Show();

        }

        private void newCustomer_Click(object sender, EventArgs e)
        {


            Customer customer = new Customer();

            Random rnd = new Random();
            int customerID = rnd.Next(1000);
            custIdInput.Text = customerID.ToString();
            if (string.IsNullOrWhiteSpace(fnameInput.Text))
            {
                MessageBox.Show("Fill in missing fields.");
                fnameInput.Clear();
                fnameInput.Focus();
                return;
            }
            else
            {
                customer.FirstName = fnameInput.Text;
            }


            if (string.IsNullOrEmpty(lnameInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                lnameInput.Clear();
                lnameInput.Focus();
                return;
            }
            else
            {
                customer.LastName = lnameInput.Text;
            }

            if (string.IsNullOrEmpty(phoneInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                phoneInput.Clear();
                phoneInput.Focus();
                return;
            }
            else
            {
                customer.Address.PhoneNumber = phoneInput.Text;
            }
            if (string.IsNullOrEmpty(addressInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                addressInput.Clear();
                addressInput.Focus();
                return;
            }
            else
            {
                customer.Address.Address1 = addressInput.Text;
            }
            //addressInput2
            if (string.IsNullOrEmpty(addressInput2.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                addressInput2.Clear();
                addressInput2.Focus();
                return;
            }
            else
            {
                customer.Address.Address2 = addressInput2.Text;
            }

            if (string.IsNullOrEmpty(cityInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                cityInput.Clear();
                cityInput.Focus();
                return;
            }
            else
            {
                customer.Address.City.Name = cityInput.Text;
            }
            #region postal code 

            if (string.IsNullOrEmpty(postalCodeInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                postalCodeInput.Clear();
                postalCodeInput.Focus();
                return;
            }
            else
            {
                customer.Address.PostalCode = postalCodeInput.Text;
            }
            #endregion postal code

            if (string.IsNullOrEmpty(countryInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                countryInput.Clear();
                countryInput.Focus();
                return;
            }
            else
            {
                customer.Address.City.Country.Name = countryInput.Text;
            }
            try
            {

               
                _customerData.Add(customer);

                int index = dataGridCustomer.Rows.Add();
                //TODO find col names in GUI for line 173 
                // repeat for all properties on customer
                dataGridCustomer.Rows[index].Cells["customerId"].Value = customer.ID;
                dataGridCustomer.Rows[index].Cells["customerName"].Value = customer.FirstName;
                dataGridCustomer.Rows[index].Cells["customerName"].Value = customer.LastName;
                dataGridCustomer.Rows[index].Cells["addressId"].Value = customer.Address;
                dataGridCustomer.Rows[index].Cells["active"].Value = customer.IsActive;
                dataGridCustomer.Rows[index].Tag = customer;


                Console.WriteLine("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("Value does not meet parameters");
            }
            finally
            {
                if (DB_Connection.conn.State == ConnectionState.Open)
                {
                    DB_Connection.conn.Close();
                }
            }
        }



        private void deleteCustButton_Click(object sender, EventArgs e)
        {
           
            selectRow();
            if(_selectedCustomer != null) { 
            _customerData.Delete(_selectedCustomer);
            MessageBox.Show("Customer information has been deleted.");
            }
        }


        private void selectRow()

        {

            Int32 rowCount = dataGridCustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            // if more then 1 row was selected they can't update more than one customer at a time. 
            if (rowCount > 0)
            {

                _selectedCustomer = dataGridCustomer.SelectedRows[0].Tag as Customer;

            }

            loadData();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void apptLookup_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendarForm calendar = new calendarForm();
            calendar.Show();
        }


        private void customerSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custSearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.custSearchBox.Text = "";
        }

        private void fnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // TO DO needs to select the row and fill update form
            // ensure the correct row is being selected from the database correctly 
            selectRow();
       
            if (_selectedCustomer != null) {
            UpdateCustomerForm updateCustomer = new UpdateCustomerForm(_selectedCustomer);
                updateCustomer.Show();
            }
            // else if the selectedCustomer is null then create a messagebox 
          


        }

        private void custIdInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

