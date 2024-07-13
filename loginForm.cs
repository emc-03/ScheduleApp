using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApp.Database;
using System.Configuration;
using System.Globalization;

namespace ScheduleApp
{
    public partial class loginForm : Form
    {

        private StreamWriter getFileStream;
        string streamName = "log.txt";
        private string loginError = "Password and Username do not match.";
        // variables to increment login time by 15 minutes


        public loginForm()
        {
            InitializeComponent();

            // CultureInfo.CurrentCulture = new CultureInfo("es");   //for testing purposes only remove before submission 

            if (CultureInfo.CurrentCulture.Name == "es")
            {
                spanishLanguage();
            }

        }

        // default in english
        private void spanishLanguage()
        {
            loginLabel.Text = "Acceso";
            userLabel.Text = "Nombre de usuario";
            passwordLabel.Text = "Contraseña";
            loginButton.Text = "Acceso";
            loginError = "inicio de sesión fallido";

        }

        public void searchMysql()
        {
            //string searchRow = "SELECT * From user WHERE userName";
            //MysqlConnection.MysqlDataAdapter adapter = new MySql

        }


        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void logExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //getuserId 




            FileStream output = new FileStream(streamName, FileMode.Append, FileAccess.Write);
            getFileStream = new StreamWriter(output);

            string loginName = userInput.Text;
            string password = passwordInput.Text;

            string searchRow = "SELECT * From user WHERE username = '"+loginName+"' and password = '"+password+"'";
            DataTable dataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(searchRow);
            mySqlCommand.Connection = DB_Connection.conn;

            int adapter = new MySqlDataAdapter(mySqlCommand).Fill(dataTable);

            // Use LINQ to find the user with the matching username and password
            var user = dataTable.AsEnumerable().SingleOrDefault(row =>
                row.Field<string>("username") == loginName &&
                row.Field<string>("password") == password);



            if (dataTable.Rows.Count <= 0)
            {

                MessageBox.Show(loginError);
                return;

            }
            else
            {


                foreach (DataRow row in dataTable.Rows)
                {
                    //string userId = row["userId"].ToString();
                    User.userId = int.Parse(row["userId"].ToString());

                }
                // Update the user's login timestamp
                try
                {
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Login_History.txt"), true))
                    {
                        outputFile.WriteLine("User : " + loginName + " lastLogin : " + DateTime.UtcNow);
                    }
                    /*string updateTimestampQuery = "UPDATE user SET lastLogin = @lastLogin WHERE customerId = @Id";
                    MySqlCommand updateCommand = new MySqlCommand(updateTimestampQuery);
                    updateCommand.Connection = DB_Connection.conn;

                    DateTime currentLoginTime = DateTime.UtcNow;
                    updateCommand.Parameters.AddWithValue("@lastLogin", currentLoginTime);
                    updateCommand.Parameters.AddWithValue("@customerId", User.userId);

                    updateCommand.ExecuteNonQuery();
                    DB_Connection.conn.Close();*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating login timestamp: " + ex.Message);
                }

                DateTime currentTime = DateTime.UtcNow;
                DateTime alertTime = currentTime.AddMinutes(15);

                string checkAppointmentsQuery = "SELECT * FROM appointment WHERE userId = "+User.userId+" AND start between '"+currentTime+"' AND '"+alertTime+"'";

                DataTable appointmentsTable = new DataTable();
                MySqlCommand appointmentsCommand = new MySqlCommand(checkAppointmentsQuery);
                appointmentsCommand.Connection = DB_Connection.conn;

                appointmentsCommand.Parameters.AddWithValue("@customerId", User.userId);
                appointmentsCommand.Parameters.AddWithValue("@currentTime", currentTime);
                //appointmentsCommand.Parameters.AddWithValue("@alertTime", alertTime);

                adapter = new MySqlDataAdapter(appointmentsCommand).Fill(appointmentsTable);

                if (appointmentsTable.Rows.Count > 0)
                {
                    MessageBox.Show("You have an appointment within the next 15 minutes.");
                }

                // MessageBox.Show("Successful Login");
                this.Hide();
                CustomerInformationForm customerData = new CustomerInformationForm();
                customerData.Show();
                return;
            }

        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
