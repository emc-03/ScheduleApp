using MySql.Data.MySqlClient;
using ScheduleApp.Database;
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

        private Customer customerToUpdate = new Customer();
        public event Action<Customer> UpdatedCustomer;
        private CustomerValidator _validator = new CustomerValidator();
        public UpdateCustomerForm(Customer customer)

      
        {
            customerToUpdate = customer;
            InitializeComponent();
            PopulateCustomerData();

        }
        private void PopulateCustomerData()
        {
            // Populate the controls with customer data
            UpcountryInput.Text = customerToUpdate.Address.City.Country.Name;
            UpcityInput.Text = customerToUpdate.Address.City.Name;
            UpaddressInput.Text = customerToUpdate.Address.Address1;
            Upaddress2Input.Text = customerToUpdate.Address.Address2;
            UpPhoneInput.Text = customerToUpdate.Address.PhoneNumber;
            UpfnameInput.Text = customerToUpdate.FirstName;
            UplnameInput.Text = customerToUpdate.LastName;
            postalCodeInput.Text = customerToUpdate.Address.PostalCode;
        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void UpfnameInput_TextChanged(object sender, EventArgs e)
        {

        }
       

        
        private void updateCButton_Click(object sender, EventArgs e)
        {
            string firstName = UpfnameInput.Text;
            string lastName = UplnameInput.Text;
            string address1 = UpaddressInput.Text;
            string address2 = Upaddress2Input.Text;
            string postalCode = postalCodeInput.Text;
            string phoneNumber = UpPhoneInput.Text;
            string city = UpcityInput.Text;
            string country = UpcountryInput.Text;

            try
            {
                // Update customer object with UI values
                customerToUpdate.FirstName = firstName;
                customerToUpdate.LastName = lastName;
                customerToUpdate.Address.Address1 = address1;
                customerToUpdate.Address.Address2 = address2;
                customerToUpdate.Address.PhoneNumber = phoneNumber;
                customerToUpdate.Address.PostalCode = postalCode;
                customerToUpdate.Address.City.Name = city;
                customerToUpdate.Address.City.Country.Name = country;

                // Reset all inputs before highlighting errors
                ResetInput(UpfnameInput);
                ResetInput(UplnameInput);
                ResetInput(UpaddressInput);
                ResetInput(Upaddress2Input);
                ResetInput(postalCodeInput);
                ResetInput(UpPhoneInput);
                ResetInput(UpcityInput);
                ResetInput(UpcountryInput);


                // Validate customer data 
                _validator.ValidateCustomer(firstName, lastName, address1, address2, postalCode, phoneNumber, city, country);

                // If validation passes, update the customer and close the form
                CustomerData customerData = new CustomerData();
                customerData.Update(customerToUpdate);

                MessageBox.Show("Customer successfully updated.");
                UpdatedCustomer(customerToUpdate);
                this.Close();
            }
            catch (Exception ex)
            {
               
                // Check each field if validation failed and reset/focus accordingly
                if (!_validator.IsValidFirstName(firstName))
                {
                    MessageBox.Show("Invalid first name.");
                    HighlightError(UpfnameInput);
                    UpfnameInput.Focus();
                }
                else if (!_validator.IsValidLastName(lastName))
                {
                    MessageBox.Show("Invalid last name.");
                    HighlightError(UplnameInput);
                    UplnameInput.Focus();
                }
                else if (!_validator.IsValidAddress(address1))
                {
                    MessageBox.Show("Invalid address.");
                    HighlightError(UpaddressInput);
                    UpaddressInput.Focus();
                }
                else if (!_validator.IsValidAddress(address2)) // Optional
                {
                    MessageBox.Show("Invalid secondary address.");
                    HighlightError(Upaddress2Input);
                    Upaddress2Input.Focus();
                }
                else if (!_validator.IsValidPostalCode(postalCode))
                {
                    MessageBox.Show("Invalid postal code.");
                    HighlightError(postalCodeInput);
                    postalCodeInput.Focus();
                }
                else if (!_validator.IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Invalid phone number.");
                    HighlightError(UpPhoneInput);
                    UpPhoneInput.Focus();
                }
                else if (!_validator.IsValidCity(city))
                {
                    MessageBox.Show("Invalid city.");
                    HighlightError(UpcityInput);
                    UpcityInput.Focus();
                }
                else if (!_validator.IsValidCountry(country))
                {
                    MessageBox.Show("Invalid country.");
                    HighlightError(UpcountryInput);
                    UpcountryInput.Focus();
                }
            }
        }


        private void UpcustIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpPhoneInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void postalCodeInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
