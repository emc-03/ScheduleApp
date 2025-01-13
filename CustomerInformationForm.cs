using ScheduleApp.Database;
using ScheduleApp.models;
using ScheduleApp.Validator;
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
        private CustomerValidator _customerValidation;
        private readonly User _user = new User();

        public CustomerInformationForm(User user)
        {
            _user = user;
            InitializeComponent();
            //loadData(user.ID);
            loadData(user.ID);

            DateTime quarterTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow.AddMinutes(15), TimeZoneInfo.Local);


            bool foundAppointment = false;

            foreach (Customer customer in _customerList)
            {
                if (foundAppointment)
                {
                    break;
                }
                foreach (Appointment appointment in customer.AppointmentList)
                {

                    if (appointment.Start <= quarterTime && appointment.Start >= TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.Local))
                    {
                        MessageBox.Show("You have an appointment within the next 15 minutes.");
                        foundAppointment = true;
                        break;
                    }
                }
            }

        }

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
            dataGridCustomer.Rows.Add
                (customer.FirstName + " " + customer.LastName, customer.Address.PhoneNumber,
                customer.Address.Address1, customer.Address.Address2, customer.Address.City.Name,
                customer.Address.City.Country.Name, customer.ID);
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

            //FirstName
            if (string.IsNullOrEmpty(fnameInput.Text))
            {
                MessageBox.Show("First Name is required");
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
                MessageBox.Show("Last Name is required.");
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
                MessageBox.Show("Phone number is required.");
                phoneInput.Clear();
                phoneInput.Focus();
                return;
            }
            else
            {
                customer.Address.PhoneNumber = phoneInput.Text;
            }

            // Address Line 1 Validation
            if (string.IsNullOrEmpty(addressInput.Text))
            {
                MessageBox.Show("Address is required");
                addressInput.Clear();
                addressInput.Focus();
                return;
            }
            else
            {
                customer.Address.Address1 = addressInput.Text;
            }

            // Address Line 2 Validation
            if (string.IsNullOrEmpty(addressInput2.Text))
            {
                MessageBox.Show("Address is required");
                addressInput2.Clear();
                addressInput2.Focus();
                return;
            }
            else
            {
                customer.Address.Address2 = addressInput2.Text;
            }

            // City Validation
            if (string.IsNullOrEmpty(cityInput.Text))
            {
                MessageBox.Show("City is required");
                cityInput.Clear();
                cityInput.Focus();
                return;
            }

            else
            {
                customer.Address.City.Name = cityInput.Text;
            }

            // Postal Code Validation
            if (string.IsNullOrEmpty(postalCodeInput.Text))
            {
                MessageBox.Show("Postal Code is required");
                postalCodeInput.Clear();
                postalCodeInput.Focus();
                return;
            }
            else
            {
                //  assign it to the customer object
                customer.Address.PostalCode = postalCodeInput.Text;
            }

            // Country Validation
            if (string.IsNullOrEmpty(countryInput.Text))
            {
                MessageBox.Show("Country is required");
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
                _customerValidation = new CustomerValidator();
                _customerValidation.ValidateCustomer(customer);

                // Reassigning the customer so it has an ID from the database
                customer = _customerData.Add(customer);

                _customerList.Add(customer);
                loadData(_user.ID);

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
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            selectRow();
            if (_selectedCustomer != null)
            {
                _customerData.Delete(_selectedCustomer);
                _customerList.Remove(_selectedCustomer);
                loadData(_user.ID);
                _selectedCustomer = null;

                MessageBox.Show("Customer information has been deleted.");
            }
        }

        private void selectRow()

        {
            Int32 rowCount = dataGridCustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //only updates 1 row at a time 
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


        private void apptLookup_Click(object sender, EventArgs e)//object sender, EventArgs e)
        {

            selectRow();
            if (_selectedCustomer != null)
            {
                calendarForm calendar = new calendarForm(_selectedCustomer, _user);
                calendar.Show();
            }

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
            else if (_selectedCustomer == null)
            {
                MessageBox.Show("No customer found.");
            }
            else
            {

                MessageBox.Show("No row selected.");
            }


        }
        private void reportForm_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }

        private void fnameInput_TextChanged(object sender, EventArgs e) { }

        private void custButtonPanel1_Paint(object sender, PaintEventArgs e) { }

        private void custIdInput_TextChanged(object sender, EventArgs e) { }

        private void addressInput2_TextChanged(object sender, EventArgs e) { }

        private void lnameInput_TextChanged(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void custSearchBox_TextChanged(object sender, EventArgs e) { }

        private void addressInput_TextChanged(object sender, EventArgs e) { }

        private void phoneInput_TextChanged(object sender, EventArgs e) { }

    }
}

