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
    public partial class UpdateCustomerForm : Form
    {
        private Customer customerToUpdate = new Customer();
        public event Action<Customer> UpdatedCustomer;

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

            
            customerToUpdate.FirstName = this.UpfnameInput.Text;
            customerToUpdate.LastName = this.UplnameInput.Text;
            customerToUpdate.Address.Address1 = this.UpaddressInput.Text;
            customerToUpdate.Address.Address2 = this.Upaddress2Input.Text;
            customerToUpdate.Address.PhoneNumber = this.UpPhoneInput.Text;
            customerToUpdate.Address.PostalCode = this.postalCodeInput.Text;
            customerToUpdate.Address.City.Name = this.UpcityInput.Text;
            customerToUpdate.Address.City.Country.Name = this.UpcountryInput.Text;

            try
            {
              
                CustomerData customerData = new CustomerData();
                customerData.Update(customerToUpdate);

                MessageBox.Show("Customer successfully updated.");
                //fire off event
                UpdatedCustomer(customerToUpdate);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Customer successfully updated.");

            this.Close();

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
    }
}
