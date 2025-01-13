using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using ScheduleApp.Validator;
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
    public partial class UpdateCustomerForm : Form
    {

        private Customer _customerToUpdate = new Customer();
        public event Action<Customer> UpdatedCustomer;
        private CustomerValidator _validator = new CustomerValidator();
        public UpdateCustomerForm(Customer customer)

        {
            _customerToUpdate = customer;
            InitializeComponent();
            PopulateCustomerData();

        }
        private void PopulateCustomerData()
        {
            // Populate the controls with customer data
            UpcountryInput.Text = _customerToUpdate.Address.City.Country.Name;
            UpcityInput.Text = _customerToUpdate.Address.City.Name;
            UpaddressInput.Text = _customerToUpdate.Address.Address1;
            Upaddress2Input.Text = _customerToUpdate.Address.Address2;
            UpPhoneInput.Text = _customerToUpdate.Address.PhoneNumber;
            UpfnameInput.Text = _customerToUpdate.FirstName;
            UplnameInput.Text = _customerToUpdate.LastName;
            postalCodeInput.Text = _customerToUpdate.Address.PostalCode;
        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateCButton_Click(object sender, EventArgs e)
        {
            // Define customerToUpdate object here and map inputs
            Customer customerToUpdate = new Customer
            {
                ID = _customerToUpdate.ID,
                FirstName = UpfnameInput.Text,
                LastName = UplnameInput.Text,
                Address = new Address
                {
                    Address1 = UpaddressInput.Text,
                    Address2 = Upaddress2Input.Text,
                    PostalCode = postalCodeInput.Text,
                    PhoneNumber = UpPhoneInput.Text,
                    City = new City
                    {
                        Name = UpcityInput.Text,
                        Country = new Country { Name = UpcountryInput.Text }
                    }
                }
            };

            try
            {
                // Validate customer data 
                _validator.ValidateCustomer(customerToUpdate);

                // If validation passes, update the customer and close the form
                CustomerData customerData = new CustomerData();
                customerData.Update(customerToUpdate);

                MessageBox.Show("Customer successfully updated.");
                UpdatedCustomer(customerToUpdate);
                this.Close();
            }
            catch (Exception)
            {
                // Catch validation exception and handle error highlighting
                if (!_validator.IsValidFirstName(customerToUpdate.FirstName))
                {
                    MessageBox.Show("Invalid first name.");
                    HighlightError(UpfnameInput);
                    UpfnameInput.Focus();
                }
                else if (!_validator.IsValidLastName(customerToUpdate.LastName))
                {
                    MessageBox.Show("Invalid last name.");
                    HighlightError(UplnameInput);
                    UplnameInput.Focus();
                }
                else if (!_validator.IsValidAddress(customerToUpdate.Address.Address1))
                {
                    MessageBox.Show("Invalid address.");
                    HighlightError(UpaddressInput);
                    UpaddressInput.Focus();
                }
                else if (!_validator.IsValidAddress(customerToUpdate.Address.Address2))
                {
                    MessageBox.Show("Invalid secondary address.");
                    HighlightError(Upaddress2Input);
                    Upaddress2Input.Focus();
                }
                else if (!_validator.IsValidPostalCode(customerToUpdate.Address.PostalCode))
                {
                    MessageBox.Show("Invalid postal code.");
                    HighlightError(postalCodeInput);
                    postalCodeInput.Focus();
                }
                else if (!_validator.IsValidPhoneNumber(customerToUpdate.Address.PhoneNumber))
                {
                    MessageBox.Show("Invalid phone number.");
                    HighlightError(UpPhoneInput);
                    UpPhoneInput.Focus();
                }
                else if (!_validator.IsValidCity(customerToUpdate.Address.City.Name))
                {
                    MessageBox.Show("Invalid city.");
                    HighlightError(UpcityInput);
                    UpcityInput.Focus();
                }
                else if (!_validator.IsValidCountry(customerToUpdate.Address.City.Country.Name))
                {
                    MessageBox.Show("Invalid country.");
                    HighlightError(UpcountryInput);
                    UpcountryInput.Focus();
                }
            }
        }
        private void UpfnameInput_TextChanged(object sender, EventArgs e) { }
        private void UpcustIdInput_TextChanged(object sender, EventArgs e) { }
        private void UpPhoneInput_TextChanged(object sender, EventArgs e) { }
        private void UpdateCustomerForm_Load(object sender, EventArgs e) { }
        private void postalCodeInput_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

    }
}
