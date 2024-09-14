using MySql.Data.MySqlClient;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    class CustomerData
    {
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
        }

        public void Delete(Customer customer)
        {
            // create new class for appt in database folder 'appointment data' - add methods,
            // delete method and call on any appointments with customerId, before I can delete the customer itself.
            string deleteCustomer = "DELETE FROM Customer Where customerId = @customerId";

            {

                using (MySqlCommand command = new MySqlCommand(deleteCustomer, DB_Connection.conn))
                {
                    command.Parameters.AddWithValue("@customerId", customer.ID);
                    command.ExecuteNonQuery();
                }
            }
            AddressData addressData = new AddressData();
            addressData.Delete(customer.Address);
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

