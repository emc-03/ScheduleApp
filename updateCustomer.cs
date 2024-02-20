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
        private Customer customerToUpdate;
        public updateCustomer(Customer customer)
        {
            InitializeComponent();
            customerToUpdate = customer;
           
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

            CustomerData customerData = new CustomerData();
            customerToUpdate.ID = int.Parse(this.UpcustIdInput.Text);
            // TODO populate all feilds from customer.
            customerData.Update(customerToUpdate);
            // messagebox or exit 
           

        }                           

        private void UpcustIdInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
