using ScheduleApp.Database;
using ScheduleApp.models;
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
    public partial class CustomerReportMain : Form
    {
       
        private Dictionary<int, string> _customerIdDictionary = new Dictionary<int, string>();
        int customerId;


        public CustomerReportMain()
        {
            InitializeComponent();
            populateDatatoCustomerReportGrid();
            LoadCountryToDropdown(customerId);
        }

        private void LoadCountryToDropdown(int customerId)
        {
            try
            {
                customerDropDown.Items.Clear();

                CountryData countryData = new CountryData();

                List<Country> countryList = countryData.FindAllCountry(customerId);

                if (countryList == null || !countryList.Any())
                {
                    MessageBox.Show("No Countries found.");
                    return;
                }

                foreach (Country country in countryList)
                {
                    customerDropDown.Items.Add(country); // adds user directly
                }
                customerDropDown.DisplayMember = "Name";

                if (customerDropDown.Items.Count > 0)
                {
                    customerDropDown.SelectedIndex = 0; // Select the first user by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }

        public void populateDatatoCustomerReportGrid()
        {

            dataCustomerReport.Columns.Clear();
            dataCustomerReport.Columns.Add("CustomerName", "Customer Name");

        }

        private void addListToCustomerReport(Customer customer)
        {
            if (customer != null)
            {
                dataCustomerReport.Rows.Add
                    (customer.FirstName + " " + customer.LastName);
            }

        }

        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void customerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = customerDropDown.SelectedItem as Country;
            if (selectedCountry == null)
            {
                return;
            }
            CustomerData customerData = new CustomerData();
            List<Customer> customer2 = customerData.FindAll(customerId);

            dataCustomerReport.Rows.Clear();
            foreach (var customer in customer2)
            {
                if (customer.Address.City.Country.ID == selectedCountry.ID)
                {
                    addListToCustomerReport(customer);
                }
            }
        }
        private void dataGridCreateByReport_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void CustomerReportMain_Load(object sender, EventArgs e) { }

    }

}
