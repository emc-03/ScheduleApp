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
        private void spanishLanguage() {
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

     

            string searchRow = "SELECT * From user WHERE userName = @userName and password = @password";
            DataTable dataTable = new DataTable();
            MySqlCommand mySqlCommand = new MySqlCommand(searchRow);
            //string connString = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            //MySqlConnection mySqlConnection = new MySqlConnection(connString);
            mySqlCommand.Connection = DB_Connection.conn;

            mySqlCommand.Parameters.AddWithValue("@userName", loginName);
            mySqlCommand.Parameters.AddWithValue("@password", password);

            int adapter = new MySqlDataAdapter(mySqlCommand).Fill(dataTable);

            if(dataTable.Rows.Count <= 0)
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
               // MessageBox.Show("Successful Login");
                this.Hide();
                customerData customerData = new customerData();
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
