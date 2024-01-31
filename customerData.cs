using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class customerData : Form
    {
        private int selectedCustomer = -1;

        public customerData()
        {
            InitializeComponent();
            loadData();

        }
        // dataGridView
        public void loadData()
        {
            string getCustomer = "SELECT * FROM customer";

            MySqlCommand command = new MySqlCommand(getCustomer, DB_Connection.conn);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            dataGridCustomer.DataSource = dataTable;

        }

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


            Customer customer = new Customer();
            customer.Address = new Address();
            customer.Address.City = new City();
            customer.Address.City.Country = new Country();

            Random rnd = new Random();
            int customerID = rnd.Next(1000);
            custIdInput.Text = customerID.ToString();
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

            if (string.IsNullOrEmpty(phoneInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                phoneInput.Clear();
                phoneInput.Focus();
                return;
            }
            else
            {
                customer.Address.PhoneNumber = phoneInput.Text;
            }
            if (string.IsNullOrEmpty(addressInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                addressInput.Clear();
                addressInput.Focus();
                return;
            }
            else
            {
                customer.Address.Address1 = addressInput.Text;
            }
            //addressInput2
            if (string.IsNullOrEmpty(addressInput2.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                addressInput2.Clear();
                addressInput2.Focus();
                return;
            }
            else
            {
                customer.Address.Address2 = addressInput2.Text;
            }

            if (string.IsNullOrEmpty(cityInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                cityInput.Clear();
                cityInput.Focus();
                return;
            }
            else
            {
                customer.Address.City.Name = cityInput.Text;
            }
            #region postal code 

            if (string.IsNullOrEmpty(postalCodeInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
                postalCodeInput.Clear();
                postalCodeInput.Focus();
                return;
            }
            else
            {
                customer.Address.PostalCode = postalCodeInput.Text;
            }
            #endregion postal code

            if (string.IsNullOrEmpty(countryInput.Text))

            {
                MessageBox.Show("Fill in missing fields.");
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

                CustomerData customerData = new CustomerData();
                customerData.Add(customer);

                int index = dataGridCustomer.Rows.Add();
                //TODO find col names in GUI for line 173 
                // repeat for all properties on customer
                dataGridCustomer.Rows[index].Cells["columnNameHere"].Value = customer.ID;



                Console.WriteLine("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("Value does not meet parameters");
            }
            finally
            {
                if (DB_Connection.conn.State == ConnectionState.Open)
                {
                    DB_Connection.conn.Close();
                }
            }
        }



        private void deleteCustButton_Click(object sender, EventArgs e)
        {
            selectRow();

            string connString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connString);

            mySqlConnection.Open();

            string deleteCustomer = "DELETE FROM Customer Where customerID = @ID";
            MySqlCommand command = new MySqlCommand(deleteCustomer, mySqlConnection);

            MessageBox.Show("Customer information has been deleted.");
        }


        private void selectRow()
        {
            Int32 selectedRowCount =
                dataGridCustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder stringB = new System.Text.StringBuilder();
                for (int i = 0; i < selectedRowCount; i++)
                {
                    stringB.Append("Row: ");
                    stringB.Append(dataGridCustomer.SelectedRows[i].Index.ToString());

                }
                stringB.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(stringB.ToString(), "Selected Row");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void apptLookup_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendarForm calendar = new calendarForm();
            calendar.Show();
        }


        private void customerSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custSearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.custSearchBox.Text = "";
        }

        private void fnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateAppt updateAppointment = new updateAppt();
            updateCustomer updateCustmr = new updateCustomer();
            // TO DO needs to select the row and fill update form
            selectRow();
            updateCustmr.Show();


        }

        private void custIdInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

