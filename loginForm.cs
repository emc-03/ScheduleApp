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
            UserData userData = new UserData();
            FileStream output = new FileStream(streamName, FileMode.Append, FileAccess.Write);
            getFileStream = new StreamWriter(output);

            string loginName = userInput.Text;
            string password = passwordInput.Text;
            User user = userData.Get(loginName, password);


            if (user == null)
            {

                MessageBox.Show(loginError);
                return;

            }
            else
            {


                // Update the user's login timestamp
                try
                {
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Login_History.txt"), true))
                    {
                        outputFile.WriteLine("User : " + user.Name + " lastLogin : " + DateTime.UtcNow);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating login history file: " + ex.Message);
                }

                DateTime currentTime = DateTime.UtcNow;
                DateTime alertTime = currentTime.AddMinutes(15);
                                               
              
                // MessageBox.Show("Successful Login");
                this.Hide();
                CustomerInformationForm customerData = new CustomerInformationForm(user.ID);
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

        private void loginPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
