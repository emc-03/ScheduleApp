using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class CustomerInformationForm : Form
    {

        private Customer _selectedCustomer;
        private readonly CustomerData _customerData = new CustomerData();
        private List<Customer> _customerList = new List<Customer>();
        private readonly User _user = new User();


        public CustomerInformationForm(User user)
        {
            _user = user;
            InitializeComponent();
            //loadData(user.ID);
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
                    Console.WriteLine("Start : " + appointment.Start + "quarterTime : " + quarterTime + " UTCNow : " + DateTime.UtcNow);
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


        //List<T>
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

        //END Commenting out to hopefully move to data source
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
            // Initialize customer
            Customer customer = new Customer
            {
                Address = new Address(),
                //Address = { City = new City(), City = { Country = new Country() } }
            };

            // First Name Validation
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

            // Last Name Validation
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

            // Phone Number Validation
            if (string.IsNullOrEmpty(phoneInput.Text))
            {
                MessageBox.Show("Fill in missing fields.");
                phoneInput.Clear();
                phoneInput.Focus();
                return;
            }
            else
            {
                string phonePattern = @"^[\d-]+$"; // Allows only digits and dashes
                if (!Regex.IsMatch(phoneInput.Text, phonePattern))
                {
                    MessageBox.Show("Invalid phone number! Only digits and dashes are allowed.");
                    phoneInput.Clear();
                    phoneInput.Focus();
                    return;
                }

                customer.Address.PhoneNumber = phoneInput.Text;
            }

            // Address Line 1 Validation
            if (string.IsNullOrEmpty(addressInput.Text))
            {
                MessageBox.Show("Fill in missing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressInput.Clear();
                addressInput.Focus();
                return;
            }
            else
            {
                //  validate a street address (letters, numbers, spaces, commas, periods, hyphens)
                string addressPattern = @"^[a-zA-Z0-9\s,.-]+$";

                if (!Regex.IsMatch(addressInput.Text, addressPattern))
                {
                    // If the address doesn't match the pattern
                    MessageBox.Show("Invalid street address! Please use only letters, numbers, spaces, commas, periods, and hyphens.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    addressInput.Clear();
                    addressInput.Focus();
                    return;
                }

                // assign it to the customer object
                customer.Address.Address1 = addressInput.Text;
            }
            // Address Line 2 Validation
            if (string.IsNullOrEmpty(addressInput2.Text))
            {
                MessageBox.Show("Fill in missing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressInput2.Clear();
                addressInput2.Focus();
                return;

            }

            else
            {
                // validate a street address (letters, numbers, spaces, commas, periods, hyphens)
                string addressPattern = @"^[a-zA-Z0-9\s,.-]+$";

                if (!Regex.IsMatch(addressInput2.Text, addressPattern))
                {
                    // If the address doesn't match the pattern, show an error message
                    MessageBox.Show("Invalid street address! Please use only letters, numbers, spaces, commas, periods, and hyphens.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    addressInput2.Clear();
                    addressInput2.Focus();
                    return;
                }


                customer.Address.Address2 = addressInput2.Text;
            }


            // City Validation
            if (string.IsNullOrEmpty(cityInput.Text))
            {
                MessageBox.Show("Fill in missing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cityInput.Clear();
                cityInput.Focus();
                return;
            }



            else
            {
                // validate that the city name contains only valid characters
                string cityPattern = @"^[a-zA-Z\s\-'.]+$"; // Allows letters, spaces, hyphens, apostrophes, and periods

                if (!Regex.IsMatch(cityInput.Text, cityPattern))
                {
                    // Show an error message if the city name is invalid
                    MessageBox.Show("Invalid city name! Please use only letters, spaces, hyphens, apostrophes, and periods.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cityInput.Clear();
                    cityInput.Focus();
                    return;
                }


                customer.Address.City.Name = cityInput.Text;
            }


            // Postal Code Validation
            if (string.IsNullOrEmpty(postalCodeInput.Text))
            {
                MessageBox.Show("Fill in missing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                postalCodeInput.Clear();
                postalCodeInput.Focus();
                return;
            }
            else
            {
                //  postal code contains only numbers
                string postalCodePattern = @"^\d+$";

                if (!Regex.IsMatch(postalCodeInput.Text, postalCodePattern))
                {
                    // Show an error message if the postal code is invalid
                    MessageBox.Show("Postal Code Invalid, please only use numbers!",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    postalCodeInput.Clear();
                    postalCodeInput.Focus();
                    return;
                }

                //  assign it to the customer object
                customer.Address.PostalCode = postalCodeInput.Text;
            }

            // Country Validation
            if (string.IsNullOrEmpty(countryInput.Text))
            {
                MessageBox.Show("Fill in missing fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                countryInput.Clear();
                countryInput.Focus();
                return;
            }
            else
            {
                // Allows letters, spaces, hyphens, apostrophes, and periods
                string countryPattern = @"^[a-zA-Z\s\-'.]+$";
                if (!Regex.IsMatch(countryInput.Text, countryPattern))
                {
                    //  country name is invalid
                    MessageBox.Show("Invalid country name! Please use only letters, spaces, hyphens, apostrophes, and periods.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    countryInput.Clear();
                    countryInput.Focus();
                    return;
                }


                // If the country name is valid, assign it to the customer object
                customer.Address.City.Country.Name = countryInput.Text;
            }


            try
            {
                // Reassigning the customer so it has an ID from the database
                customer = _customerData.Add(customer);

                // Add customer to DataGrid == removing as we are now using a data source
                //addCustomertoDataGrid(customer);

                Console.WriteLine("Data inserted successfully.");
                this.fnameInput.Clear();
                this.lnameInput.Clear();
                this.phoneInput.Clear();
                this.addressInput.Clear();
                this.addressInput2.Clear();
                this.cityInput.Clear();
                this.postalCodeInput.Clear();
                this.countryInput.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("Value does not meet parameters");
            }
            finally
            {
                //dataGridCustomer.DataSource = GetDataFromDatabase(); // Fetch updated data
                //dataGridCustomer.Refresh();
                _customerList.Add(customer);
                loadData(_user.ID);

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
                //int rowIndex = dataGridCustomer.SelectedRows[0].Index;
                //dataGridCustomer.Rows.RemoveAt(rowIndex);
                _customerList.Remove(_selectedCustomer);
                loadData(_user.ID);
                _selectedCustomer = null;

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
                var rawSelectedCustomerID = dataGridCustomer.SelectedRows[0].Cells["customerId"].Value;
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




        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void fnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdatedCustomerListener(Customer customer)
        {
            int updatedCustomerIndex = _customerList.FindIndex(c => c.ID == customer.ID);
            _customerList[updatedCustomerIndex] = customer;

            dataGridCustomer.Rows.Clear();
            foreach (Customer c in _customerList)
            {
                addCustomertoDataGrid(c);

            }


        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {


            selectRow();

            if (_selectedCustomer != null)
            {
                UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(_selectedCustomer);
                updateCustomerForm.UpdatedCustomer += UpdatedCustomerListener;

                updateCustomerForm.Show();
                _selectedCustomer = null;
            }
            else
            {

                MessageBox.Show("No row selected.");
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

        private void addressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

