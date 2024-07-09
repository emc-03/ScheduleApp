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
        public UpdateCustomerForm(Customer customer)
        {
            customerToUpdate = customer;
            InitializeComponent();
                       
        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            returnToParentForm();
        }

        private void returnToParentForm()
        {
            this.Close();
            CustomerInformationForm customerDataForm = new CustomerInformationForm();
            customerDataForm.Show();
        }

        private void UpfnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCButton_Click(object sender, EventArgs e)
        {

            CustomerData customerData = new CustomerData();
            customerToUpdate.FirstName = this.UpfnameInput.Text;
            customerToUpdate.LastName = this.UplnameInput.Text;
            customerToUpdate.Address.Address1 = this.UpaddressInput.Text;
            customerToUpdate.Address.Address2 = this.Upaddress2Input.Text;
            customerToUpdate.Address.PhoneNumber = this.UpPhoneInput.Text;
            customerToUpdate.Address.PostalCode = this.postalCodeInput.Text;
            customerToUpdate.Address.City.Name = this.UpcityInput.Text;
            customerToUpdate.Address.City.Country.Name = this.UpcountryInput.Text;

            customerData.Update(customerToUpdate);
            MessageBox.Show("Customer successfully updated.");
            returnToParentForm();
       
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
