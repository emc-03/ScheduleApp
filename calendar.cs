using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class calendarForm : Form

    {
        private SqlConnection gridConnection;
        private SqlDataAdapter adapter;
        private DataSet data;


        public calendarForm()
        {
            InitializeComponent();
            loadDataGrid();
        }

        public void loadDataGrid()
        {
            string getAppt = "SELECT * FROM appointment";

            MySqlCommand command = new MySqlCommand(getAppt, DB_Connection.conn);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            appointmentDataGrid.DataSource = dataTable;

        }
        private void customerDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInformationForm custData = new CustomerInformationForm();
            custData.Show();

        }

        private void deleteApptButton_Click(object sender, EventArgs e)
        {

        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerInformationForm customer = new CustomerInformationForm();
            customer.Show();
        }

      // TODO copy the login form sql from the login form and create a query from the database to find the 
            // appointments for the userID and the customerID; display them to the calendar
            


            // PREVIOUS CODE DESIGN -- FIX NEW DESIGN AND DELETE LATER 
            //int customerData = Convert.ToInt32(UpcustIdInput.Text);
            //string searchRow = "SELECT * From user WHERE userId = @customerData and userId = @userData";
            //DataTable weekTable = new DataTable();
            //MySqlCommand mySqlCommand = new MySqlCommand(searchRow);
            //mySqlCommand.Connection = DB_Connection.conn;

            //mySqlCommand.Parameters.AddWithValue("@customerData", customerData);
            //mySqlCommand.Parameters.AddWithValue("@userData", User.userId);


            //int adapter = new MySqlDataAdapter(mySqlCommand).Fill(weekTable);
     

       

            
            // PREVIOUS CODE DESIGN _ UPDATE NEW DESIGN AND DELETE LATER
            //string searchRow = "SELECT * From user WHERE userId = @customerData and userId = @userData";
            //DataTable monthTable = new DataTable();
            //MySqlCommand mySqlCommand = new MySqlCommand(searchRow);
            //mySqlCommand.Connection = DB_Connection.conn;

            //mySqlCommand.Parameters.AddWithValue("@customerData", customerData);
            //mySqlCommand.Parameters.AddWithValue("@userData", User.userId);

            //int adapter = new MySqlDataAdapter(mySqlCommand).Fill(monthTable);

        

               private void apptTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void createApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApptType create = new ApptType();
            create.Show();
        }

        private void updateApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateAppt update = new updateAppt();
            update.Show();

        }

        private void appointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

       

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchApptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "?";
                //string searchAppt = TextBox.?; TODO What do I reference ? 

                //using (MySqlConnection connection = new MySqlConnection(connectionString));
                // search the query 

            }
            catch
            {
                MessageBox.Show("Appointment could not be found!");
            }

            // when monthRadioButton selected 
            /*   string monthConnection = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString; // table for test use - TODO  where to find the connection string?; 

             create sql object 
            gridConnection = new SqlConnection(monthConnection);
             create dataAdapter object
            adapter = new SqlDataAdapter("SELECT * FROM client_schedule", monthConnection);
             create a Dataset Object 
            data = new DataSet();
            adapter.Fill(data, "client_schedule");
            monthDataGrid.DataSource = data.Tables["client_schedule"];
            */

        }
}
}