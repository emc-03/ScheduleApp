using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    class UpdateData
    {
        public void Update(Customer customer)
        {
            AddressData addressData = new AddressData();
            customerData customerUpdate = new customerData();
            
            //customerUpdate.(addressData);


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
