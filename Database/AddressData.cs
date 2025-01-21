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
            TrimFeilds(address);
            CityData cityData = new CityData();
            cityData.Add(address.City);

            string newQueryAddress = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                   " VALUES (@address, @address2,  @cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdateBy)";
            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(newQueryAddress, connection))
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

                    // Retrieve the last inserted ID 
                    address.ID = (int)command.LastInsertedId;
                }
                connection.Close();
            }
        }

        public void Update(Address address)
        {
            TrimFeilds(address);
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

            string deleteAddress = "DELETE FROM Address Where addressId = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteAddress, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", address.ID);
                DB_Connection.conn.Open();
                command.ExecuteNonQuery();
                DB_Connection.conn.Close();

            }
            CityData cityData = new CityData();
            cityData.Delete(address.City);
        }

        public Address Get(int addressId)
        {
            Address address = new Address();
            CityData cityData = new CityData();

            string getAddressQuery = "SELECT * FROM address WHERE addressId = @addressId";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(getAddressQuery, connection))
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
                            address.PhoneNumber = reader["phone"].ToString();
                            address.City = cityData.Get((int)reader["cityId"]);

                        }
                        TrimFeilds(address);
                    }

                }

                connection.Close();
            }
            return address;
        }

        //trim feilds methods
        public void TrimFeilds(Address address)
        {
            foreach (var property in GetType().GetProperties())
            {
                
                if (property.PropertyType == typeof(string) && property.CanRead && property.CanWrite)
                {
                    string currentValue = (string)property.GetValue(this);

                    if (currentValue != null)
                    {
                        property.SetValue(this, currentValue.Trim());
                    }
                }
            }
        }
    }
}


