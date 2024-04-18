using MySql.Data.MySqlClient;
using ScheduleApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    class CityData
    {
        public void Add(City city)
        {
            CountryData countryData = new CountryData();
            countryData.Add(city.Country);

            string newQueryCity = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdateBy)" +
                        " VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlCommand command = new MySqlCommand(newQueryCity, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@city", city.Name);
                command.Parameters.AddWithValue("@countryId", city.Country.ID);
                command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                command.Parameters.AddWithValue("@createdBy", "createdByCity");
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedByCity");

                // Execute the command to insert into the 'city' table
                command.ExecuteNonQuery();

                // Retrieve the last inserted ID (if using auto-increment)
                city.ID = (int)command.LastInsertedId;
            }
        }
        public void Update(City city)
        {
            CountryData countryData = new CountryData();
            countryData.Update(city.Country);

            string updateQueryCity = "UPDATE city SET city = @city, lastUpdateBy = @lastUpdateBy" +
                " WHERE cityId = @cityId";

            using (MySqlCommand command = new MySqlCommand(updateQueryCity, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@cityId", city.ID);
                command.Parameters.AddWithValue("@city", city.Name);
                command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedBy");

                // Execute the command to update the city
                command.ExecuteNonQuery();

            }
        }
        public void Delete(City city)
        {
            CountryData countryData = new CountryData();
            countryData.Delete(city.Country);
            string deleteCity = "DELETE FROM City Where cityId = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteCity, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", city.ID);
                command.ExecuteNonQuery();
            }
        }
    }
}
