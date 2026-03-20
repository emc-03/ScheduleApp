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
            loadData(user.ID);

            DateTime quarterTime = DateTime.Now.AddMinutes(15);


            bool foundAppointment = false;

            foreach (Customer customer in _customerList)
            {
                if (foundAppointment)
                {
                    break;
                }
                foreach (Appointment appointment in customer.AppointmentList)
                {

                    if (appointment.Start <= quarterTime && appointment.Start >= DateTime.Now)
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

            // Add columns only if they do not already exist
            if (dataGridCustomer.Columns.Count == 0)
            {
                dataGridCustomer.Columns.Add("customerName", "Name");
                dataGridCustomer.Columns.Add("customerPhone", "Phone");
                dataGridCustomer.Columns.Add("customerAddress1", "Primary Address");
                dataGridCustomer.Columns.Add("customerAddress2", "Secondary Address");
                dataGridCustomer.Columns.Add("customerCity", "City");
                dataGridCustomer.Columns.Add("customerCountry", "Country");
                dataGridCustomer.Columns.Add("customerID", "ID");
                dataGridCustomer.Columns["customerID"].Visible = false;
            }

            // Clear existing rows before adding new ones
            dataGridCustomer.Rows.Clear();

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
            customer.FirstName = fnameInput.Text.Trim();
            customer.LastName = lnameInput.Text.Trim();
            customer.Address.PhoneNumber = phoneInput.Text.Trim();
            customer.Address.Address1 = addressInput.Text.Trim();
            customer.Address.Address2 = addressInput2.Text.Trim();
            customer.Address.City.Name = cityInput.Text.Trim();
            customer.Address.PostalCode = postalCodeInput.Text.Trim();
            customer.Address.City.Country.Name = countryInput.Text.Trim();

            try
            {
                _customerValidation = new CustomerValidator();
                _customerValidation.ValidateCustomer(customer);

                // Reassigning the customer so it has an ID from the database
                customer = _customerData.Add(customer);

                _customerList.Add(customer);
                loadData(_user.ID);

                this.fnameInput.Clear();
                this.lnameInput.Clear();
                this.phoneInput.Clear();
                this.addressInput.Clear();
                this.addressInput2.Clear();
                this.cityInput.Clear();
                this.postalCodeInput.Clear();
                this.countryInput.Clear();

                MessageBox.Show("Customer information has been created.");

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
        private void CustomerInformationForm_Load(object sender, EventArgs e) { }

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

        private void postalCodeInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

