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
    }
}
