using MySql.Data.MySqlClient;
using ScheduleApp.models;
using ScheduleApp.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class CustomerData
    {


        private List<Customer> _customerList = new List<Customer>();
       

        public Customer Add(Customer customer)
        {
            

            AddressData addressData = new AddressData();
            addressData.Add(customer.Address);

            string newQueryCustomer = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                " VALUES (@customerName, @addressId, 1, @createDate, @createdBy, @lastUpdateBy)";
            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(newQueryCustomer, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customer.FirstName + " " + customer.LastName);
                    command.Parameters.AddWithValue("@addressId", customer.Address.ID);
                    command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@createdBy", "createdBy");
                    command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                    command.ExecuteNonQuery();

                    customer.ID = (int)command.LastInsertedId;
                }

                connection.Close();

            }
            _customerList.Add(customer);
            return customer;
        }

        public Customer Get(int customerID)
        {
            Customer customer = new Customer();
            AddressData addressData = new AddressData();

            string getCustomerQuery = "SELECT * FROM customer WHERE customerId = @customerId";

            {

                using (MySqlCommand command = new MySqlCommand(getCustomerQuery, DB_Connection.conn))
                {
                    command.Parameters.AddWithValue("@customerId", customer.ID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer.ID = (int)reader["CustomerId"];
                            string[] name = reader["customerName"].ToString().Split(' ');
                            customer.FirstName = name[0];
                            customer.LastName = name[1];
                            customer.IsActive = (bool)reader["active"];


                            int addressId = (int)reader["addressId"];
                            customer.Address = addressData.Get(addressId);
                        }
                    }
                }
            }
            return customer;
        }

        public void Update(Customer customer)
        {
            AddressData addressData = new AddressData();
            addressData.Update(customer.Address);

            string updateQueryCustomer = "UPDATE customer SET customerName = @customerName, active = @active,  lastUpdateBy = @lastUpdateBy" +
                " WHERE customerId = @customerId";


            {

                using (MySqlCommand command = new MySqlCommand(updateQueryCustomer, DB_Connection.conn))
                {
                    command.Parameters.AddWithValue("@customerName", customer.FirstName + " " + customer.LastName);
                    command.Parameters.AddWithValue("@customerId", customer.ID);
                    command.Parameters.AddWithValue("@active", customer.IsActive);
                    command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                    command.ExecuteNonQuery();
                }
            }
            _customerList.Remove(customer);
            _customerList.Add(customer);
        }

        public void Delete(Customer customer)
        {
            // Delete any appointments associated with the customer
            AppointmentData appointmentData = new AppointmentData();
            appointmentData.DeleteAppointmentsByCustomer(customer.ID); // Deletes all appointments with this customer ID

            // Delete customer from the database
            string deleteCustomerQuery = "DELETE FROM Customer WHERE customerId = @customerId";

            using (MySqlCommand command = new MySqlCommand(deleteCustomerQuery, DB_Connection.conn))
            {
                // Add the customer ID
                command.Parameters.AddWithValue("@customerId", customer.ID);

                // Execute the delete command
                try
                {
                    DB_Connection.conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("An error occurred: " + ex.Message);
                    throw;
                }
                finally
                {

                    if (DB_Connection.conn.State == System.Data.ConnectionState.Open)
                    {
                        DB_Connection.conn.Close();
                    }
                }
            }

            //  Delete the customer's address (assuming a separate Address table)
            AddressData addressData = new AddressData();
            addressData.Delete(customer.Address);
            _customerList.Remove(customer);

        }


        public List<Customer> FindAll(int userId)
        {
            List<Customer> customerFindAllList = new List<Customer>();
            string getCustomer = "SELECT * FROM customer"; // Not filtering by userId
            AddressData addressData = new AddressData();
            AppointmentData appointmentData = new AppointmentData();

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(getCustomer, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.ID = (int)reader["customerId"];
                            string[] name = reader["customerName"].ToString().Split(' ');
                            if (name.Length < 2)
                            {
                                MessageBox.Show("Must have first and last name.");
                            }
                            else
                            {
                                customer.FirstName = name[0];
                                customer.LastName = name[1];
                            }

                            customer.IsActive = (bool)reader["active"];
                            customer.Address = addressData.Get((int)reader["addressId"]);
                            customer.AppointmentList = appointmentData.FindAllApptList(userId, customer.ID); // Use customer ID

                            customerFindAllList.Add(customer);
                        }
                    }
                }
                connection.Close();
            }

            return customerFindAllList;
        }



    }

}

