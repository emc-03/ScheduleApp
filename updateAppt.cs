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
    public partial class updateAppt : Form
    {
        public updateAppt()
        {
            InitializeComponent();
        }

        private void UpcustIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void upCustomerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void UplnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void uplnLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpfnameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void upfnLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void apptTypeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                /* 
     {

     using (DataTable dataTable = new DataTable("Appointment"))
     using (MySqlDataReader reader = command.ExecuteReader())
         {
             // Read the results
             while (reader.Read())
             {
                 // Assuming dateTimePicker1 is the first column (index 0)
                 DateTime dateTimeValue = reader.GetDateTime(0);
                 Console.WriteLine("DateTime value: " + dateTimeValue);
             }
         }
     }

 }
 */
            }
            catch (Exception except)
            {
                Console.WriteLine("An error occurred: " + except.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void upCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //calendarForm calendar = new calendarForm();
            //calendar.Show();
        }

        private void updateAppt_Load(object sender, EventArgs e)
        {

        }
    }
}
