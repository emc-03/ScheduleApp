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
    public partial class CountryReportMain : Form
    {
       
        private Dictionary<int, string> _customerIdDictionary = new Dictionary<int, string>();
        int customerId;


        public CountryReportMain()
        {
            InitializeComponent();
            populateDatatoCountryReportGrid();
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

                // Use a lambda to add countries to the dropdown, it improves readability of the foreach loop 
                countryList.ForEach(country => customerDropDown.Items.Add(country));

                customerDropDown.DisplayMember = "Name";

                if (customerDropDown.Items.Count > 0)
                {
                    customerDropDown.SelectedIndex = 0; // Select the first country by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading countries: {ex.Message}");
            }
        }




        private void addListToCustomerReport(Customer customer)
        {
            if (customer != null)
            {
                dataCountryReport.Rows.Add
                    (customer.FirstName + " " + customer.LastName);
            }

        }

        private void countryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = customerDropDown.SelectedItem as Country;
            if (selectedCountry == null)
            {
                return;
            }
            CustomerData customerData = new CustomerData();
            List<Customer> customer2 = customerData.FindAll(customerId);

            dataCountryReport.Rows.Clear();
            foreach (Customer customer in customer2)
            {
                if (customer.Address.City.Country.ID == selectedCountry.ID)
                {
                    addListToCustomerReport(customer);
                }
            }
        }

        public void populateDatatoCountryReportGrid()
        {

            dataCountryReport.Columns.Clear();
            dataCountryReport.Columns.Add("customerName", "Name");

        }
        private void exitReport_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridCreateByReport_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void CountryReportMain_Load(object sender, EventArgs e) { }

    }

}
