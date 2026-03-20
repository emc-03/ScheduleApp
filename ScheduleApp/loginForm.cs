using ScheduleApp.Database;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class loginForm : Form
    {

        private string loginError = "Login failed. Please check your username and password.";
        
        public loginForm()
        {
            InitializeComponent();

            //CultureInfo.CurrentCulture = new CultureInfo("es"); // for testing purposes only 

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

        private void Login(string loginName, string enteredPassword)
        {
            try
            {

                UserData userData = new UserData();


                // Retrieve user by login and password
                User user = userData.Get(loginName, enteredPassword);

                if (user == null || enteredPassword != user.Password)
                {
                    MessageBox.Show(loginError);
                    return;
                }

                try
                {

                    File.AppendAllText
                        (
                        "Login_History.txt", "User: " + (user.Name ?? "Unknown") + " " +
                        "| Last Login: " + DateTime.UtcNow + Environment.NewLine
                        );

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

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Perform login
            // Get the user input
            string loginName = userInput.Text.Trim();
            string enteredpassword = passwordInput.Text.Trim();

            Login(loginName, enteredpassword);
        }
private void loginLabel_Click(object sender, EventArgs e) { }

private void userInput_TextChanged(object sender, EventArgs e) { }

private void passwordInput_TextChanged(object sender, EventArgs e) { }

private void loginPanelMain_Paint(object sender, PaintEventArgs e) { }

private void menuBarPanel_Paint(object sender, PaintEventArgs e) { }
       
    }
}
