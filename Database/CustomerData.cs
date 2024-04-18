using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database

{
    class CustomerData
    {
        public void Add(Customer customer)
        {

            AddressData addressData = new AddressData();
            addressData.Add(customer.Address);

            // Execute the command for inserting into the 'customer' table
            string newQueryCustomer = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                " VALUES (@customerName, @addressId, 1, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlCommand command = new MySqlCommand(newQueryCustomer, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@customerName", customer.FirstName + "|" + customer.LastName);
                command.Parameters.AddWithValue("@addressId", customer.Address.ID);
                command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                command.Parameters.AddWithValue("@createdBy", "createdBy");
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                // Execute the command to insert into the 'customer' table
                command.ExecuteNonQuery();

                customer.ID = (int)command.LastInsertedId;
            }

        }
        public void Update(Customer customer)
        {
            AddressData addressData = new AddressData();
            addressData.Update(customer.Address);

            string updateQueryCustomer = "UPDATE customer SET customerName = @customerName, active = @active,  lastUpdateBy = @lastUpdateBy" +
                " WHERE customerId = @customerId";

            using (MySqlCommand command = new MySqlCommand(updateQueryCustomer, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@customerName", customer.FirstName + "|" + customer.LastName);
                command.Parameters.AddWithValue("@customerId", customer.ID);
                command.Parameters.AddWithValue("@active", customer.IsActive);
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                // Execute the command to update the customer
                command.ExecuteNonQuery();

            }
        }
        public void Delete(Customer customer)
        {
            AddressData addressData = new AddressData();
            addressData.Delete(customer.Address);
            string deleteCustomer = "DELETE FROM Customer Where customerID = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteCustomer, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", customer.ID);
                command.ExecuteNonQuery();
            }
        }
        public List<Customer> FindAll()
        {

            List<Customer> customerList = new List<Customer>();
            string getCustomer = "SELECT * FROM customer";
            AddressData addressData = new AddressData();
            
            using (MySqlCommand command = new MySqlCommand(getCustomer, DB_Connection.conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    // this reads 1 row at a time 
                    {
                        Customer customer = new Customer();
                        customer.ID = (int)reader["CustomerId"];
                        string[] name = reader["customerName"].ToString().Split('|');
                        customer.FirstName = name[0];
                        customer.LastName = name[1];
                        // add the rest of the customer table properties from the database 
                        // need to retrieve address, city and country info for each customer. - call a get method and pass the customer
                        customer.Address.ID = (int)reader["addressId"];
                        addressData.Get(customer.Address.ID);
                        customerList.Add(customer);
                    }
                }
            }
            
            return customerList;
        }
    }
}

