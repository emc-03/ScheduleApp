using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
