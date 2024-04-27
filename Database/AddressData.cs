using MySql.Data.MySqlClient;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    class AddressData
    {
        public void Add(Address address)
        {


            CityData cityData = new CityData();
            cityData.Add(address.City);

            string newQueryAddress = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                   " VALUES (@address, @address2,  @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlCommand command = new MySqlCommand(newQueryAddress, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@address", address.Address1);
                command.Parameters.AddWithValue("@address2", address.Address2);
                command.Parameters.AddWithValue("@cityId", address.City.ID);
                command.Parameters.AddWithValue("@postalCode", address.PostalCode);
                command.Parameters.AddWithValue("@phone", address.PhoneNumber);
                command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                command.Parameters.AddWithValue("@createdBy", "createdByAddress");
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedByAddress");

                // Execute the command to insert into the 'address' table
                command.ExecuteNonQuery();

                // Retrieve the last inserted ID (if using auto-increment)
                address.ID = (int)command.LastInsertedId;
            }

        }

        public void Update(Address address)
        {
            CityData cityData = new CityData();
            cityData.Update(address.City);

            string updateQueryAddress = "UPDATE address SET address = @address, address2 = @address2,  postalCode = @postalCode, phone = @phone,  lastUpdateBy = @lastUpdateBy" +
                " WHERE addressId = @addressId";

            using (MySqlCommand command = new MySqlCommand(updateQueryAddress, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@addressId", address.ID);
                command.Parameters.AddWithValue("@address", address.Address1);
                command.Parameters.AddWithValue("@address2", address.Address2);
                command.Parameters.AddWithValue("@postalCode", address.PostalCode);
                command.Parameters.AddWithValue("@phone", address.PhoneNumber);
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");
                // Execute the command to update the address
                command.ExecuteNonQuery();

            }
        }

        public void Delete(Address address)
        {
            CityData cityData = new CityData();
            cityData.Delete(address.City);
            string deleteAddress = "DELETE FROM Address Where addressId = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteAddress, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", address.ID);
                command.ExecuteNonQuery();
            }
        }

        public Address Get(int addressId)
        {
            Address address = new Address();
            CityData cityData = new CityData();

            string getAddressQuery = "SELECT TOP(1) FROM address WHERE addressId = @addressId";

            // TODO Create a using statment to open a new connection - same thing in city and country class
            // replace end of line 85 with new connection parameter
            using (MySqlCommand command = new MySqlCommand(getAddressQuery, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@addressId", addressId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        address.ID = addressId;

                        address.Address1 = reader["address"].ToString();
                        address.Address2 = reader["address2"].ToString();
                        address.PostalCode = reader["postalCode"].ToString();
                        address.PhoneNumber = reader["phoneNumber"].ToString();
                        address.City = cityData.Get((int)reader["cityId"]);

                    }
                }
               
            }
            return address;
        }
    }
}


