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
using ScheduleApp.models;

namespace ScheduleApp
{
    public partial class loginForm : Form
    {

        private string loginError = "Login failed. Please check your username and password.";

        public loginForm()
        {
            InitializeComponent();


            if (CultureInfo.CurrentCulture.Name == "es")
            {
                spanishLanguage();
            }

        }

        // default in english
        private void spanishLanguage()
        {
            loginLabel.Text = "Pantalla de inicio de sesión";
            userLabel.Text = "Nombre de usuario";
            passwordLabel.Text = "Contraseña";
            loginButton.Text = "Iniciar sesión";
            loginError = "Inicio de sesión fallado. Verifique el nombre de usuario y la contraseña.";
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
                    MessageBox.Show(loginError);
                    return;
                }

                try
                {

                    File.AppendAllText("Login_History.txt", "User: " + (user.Name ?? "Unknown") + " | Last Login: " + DateTime.UtcNow + Environment.NewLine);

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
        private void loginLabel_Click(object sender, EventArgs e) { }
      
        private void userInput_TextChanged(object sender, EventArgs e) { }

        private void passwordInput_TextChanged(object sender, EventArgs e) { }
   
        private void loginPanelMain_Paint(object sender, PaintEventArgs e) { }

        private void menuBarPanel_Paint(object sender, PaintEventArgs e) { }
       
    }
}
