using MySql.Data.MySqlClient;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    class CountryData

    {
        public void Add(Country country)
        {

            string newQueryCountry = "INSERT INTO country (country, createDate, createdBy, lastUpdateBy)" +
                   " VALUES (@country, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlCommand command = new MySqlCommand(newQueryCountry, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@country", country.Name);
                command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                command.Parameters.AddWithValue("@createdBy", "createdByCountry");
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedByCountry");

                // Execute the command to insert into the 'country' table
                command.ExecuteNonQuery();

                // Retrieve the last inserted ID (if using auto-increment)
                country.ID = (int)command.LastInsertedId;

            }

        }
        public void Update(Country country)
        {

            string updateQueryCountry = "UPDATE country SET country = @country, lastUpdateBy = @lastUpdateBy" +
                " WHERE countryId = @countryId";

            using (MySqlCommand command = new MySqlCommand(updateQueryCountry, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@countryId", country.ID);
                command.Parameters.AddWithValue("@country", country.Name);
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                // Execute the command to update the country
                command.ExecuteNonQuery();

            }
        }
        public void Delete(Country country)
        {
            string deleteCountry = "DELETE FROM Country Where countryId = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteCountry, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", country.ID);
                command.ExecuteNonQuery();
            }
        }
        public Country Get(int countryId)
        {
            Country country = new Country();
           

            string getCountryQuery = "SELECT TOP(1) FROM country WHERE countryId = @countryId";


            using (MySqlCommand command = new MySqlCommand(getCountryQuery, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@countryId", countryId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        country.ID = countryId;
                        country.Name = reader["country"].ToString();
                       
                    }
                }

            }
            return country;
        }

    }


}
