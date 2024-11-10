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
            try
            {
                UserData userData = new UserData();
                string loginName = userInput.Text;
                string password = passwordInput.Text;

                // Retrieve user by login and password
                User user = userData.Get(loginName, password);
                if (user == null)
                {
                    MessageBox.Show("Login failed. Please check your username and password.");
                    return;
                }

                // Update login history
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string logFilePath = Path.Combine(docPath, "Login_History.txt");

                try
                {
                    using (StreamWriter outputFile = new StreamWriter(logFilePath, true))
                    {
                        outputFile.WriteLine("User: " + (user.Name ?? "Unknown") + " | Last Login: " + DateTime.UtcNow);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access to the login history file is denied.");
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("File error: " + ioEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating login history file: " + ex.Message);
                }

                // Successful login - navigate to customer information
                DateTime currentTime = DateTime.UtcNow;
                DateTime alertTime = currentTime.AddMinutes(15);

                this.Hide();
                CustomerInformationForm customerData = new CustomerInformationForm(user);
                customerData.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }



        //private void loginButton_Click(object sender, EventArgs e)
        //{
        //    UserData userData = new UserData();
        //    string loginName = userInput.Text;
        //    string password = passwordInput.Text;

        //    // Retrieve user by login and password
        //    User user = userData.Get(loginName, password);
        //    if (user == null)
        //    {
        //        MessageBox.Show("Login failed. Please check your username and password.");
        //        return;
        //    }

        //    // Update login history
        //    try
        //    {
        //        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //        string logFilePath = Path.Combine(docPath, "Login_History.txt");

        //        using (StreamWriter outputFile = new StreamWriter(logFilePath, true))
        //        {
        //            outputFile.WriteLine("User: " + user.Name + " | Last Login: " + DateTime.UtcNow);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error updating login history file: " + ex.Message);
        //    }

        //    // Successful login - navigate to customer information
        //    DateTime currentTime = DateTime.UtcNow;
        //    DateTime alertTime = currentTime.AddMinutes(15);

        //    this.Hide();
        //    CustomerInformationForm customerData = new CustomerInformationForm(user);
        //    customerData.Show();
        //}




        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
