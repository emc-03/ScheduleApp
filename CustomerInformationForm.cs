using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ScheduleApp
{
    public partial class CustomerInformationForm : Form
    {

        private Customer _selectedCustomer;
        private readonly CustomerData _customerData = new CustomerData();
        //TODO Start here change to list 
        private List<Customer> _customerList = new List<Customer>();
        private readonly User _user = new User();


        public CustomerInformationForm(User user)
        {
            _user = user;
            InitializeComponent();
            loadData(user.ID);
            // could be made into a lambda - inner foreach becomes a if statement - .Any method
            DateTime quarterTime = DateTime.UtcNow.AddMinutes(15);

            bool foundAppointment = false;
            foreach (Customer customer in _customerList)
            {
                if (foundAppointment)
                {
                    break;
                }
                foreach (Appointment appointment in customer.AppointmentList)
                {
                    if (appointment.Start <= quarterTime && appointment.Start >= DateTime.UtcNow)
                    {
                        // add a currenttime var and add additional if statemtent 
                        MessageBox.Show("You have an appointment within the next 15 minutes.");
                        foundAppointment = true;
                        break;
                    }
                }
            }

        }
        // dataGridView
        public void loadData(int userId)
        {
            _customerList = _customerData.FindAll(userId);
            dataGridCustomer.Columns.Add("customerName", "Name");
            dataGridCustomer.Columns.Add("customerPhone", "Phone");
            dataGridCustomer.Columns.Add("customerAddress1", "Primary Address");
            dataGridCustomer.Columns.Add("customerAddress2", "Secondary Address");
            dataGridCustomer.Columns.Add("customerCity", "City");
            dataGridCustomer.Columns.Add("customerCountry", "Country");
            dataGridCustomer.Columns.Add("customerID", "ID");
            dataGridCustomer.Columns["customerID"].Visible = false;
            foreach (Customer customer in _customerList)
            {
                addCustomertoDataGrid(customer);
                
            }

        }

        private void addCustomertoDataGrid(Customer customer)
        {
            dataGridCustomer.Rows.Add(customer.FirstName + " " + customer.LastName, customer.Address.PhoneNumber,
                customer.Address.Address1, customer.Address.Address2, customer.Address.City.Name, customer.Address.City.Country.Name, customer.ID);
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

                //reassigning the customer so it has an ID from the database
                customer = _customerData.Add(customer);

                addCustomertoDataGrid(customer);
                Console.WriteLine("Data inserted successfully.");
                this.fnameInput.Clear();
                this.lnameInput.Clear();
                

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
            if (_selectedCustomer != null)
            {
                _customerData.Delete(_selectedCustomer);
                int rowIndex = dataGridCustomer.SelectedRows[0].Index;
                dataGridCustomer.Rows.RemoveAt(rowIndex);

                MessageBox.Show("Customer information has been deleted.");
            }
        }


        private void selectRow()

        {
            //int rowCount = dataGridCustomer.SelectedRows.Count;
            Int32 rowCount = dataGridCustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            // if more then 1 row was selected they can't update more than one customer at a time. 
            if (rowCount > 0)
            {
                var rawSelectedCustomerID = dataGridCustomer.SelectedRows[0].Cells["customerID"].Value;
                if (rawSelectedCustomerID == null || !int.TryParse(rawSelectedCustomerID.ToString(), out int selectedCustomerID))
                {
                    return;
                }
                // Check if the customer with the selected ID exists in the list
                if (_customerList.Any(customer => customer.ID == selectedCustomerID))
                {
                    _selectedCustomer = _customerList.First(customer => customer.ID == selectedCustomerID);
                }
                else
                {
                    MessageBox.Show("Could not find Customer in memory.");
                }

            }
            else
            {
                MessageBox.Show("No row selected.");
            }


        

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void apptLookup_Click(object sender, EventArgs e)//object sender, EventArgs e)
        {

            selectRow();
            if (_selectedCustomer != null)
            {
                calendarForm calendar = new calendarForm(_selectedCustomer, _user);
                calendar.Show();
            }

        }


        private void customerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (DataTable dataTable = new DataTable("Customer"))
                    using (SqlCommand cmd = new SqlCommand("", connection))
                    {
                        cmd.Parameters.AddWithValue("customerId", customerSearch.Text);
                        cmd.Parameters.AddWithValue("contactname", string.Format("%{0}%", customerSearch.Text));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                        dataGridCustomer.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
         
            selectRow();

            if (_selectedCustomer != null)
            {
                UpdateCustomerForm updateCustomer = new UpdateCustomerForm(_selectedCustomer);
                updateCustomer.Show();
            }
            // else if the selectedCustomer is null then create a messagebox 



        }

        private void custIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void custSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerInformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

