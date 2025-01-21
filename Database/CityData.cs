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
            TrimFeilds(city);
            CountryData countryData = new CountryData();
            countryData.Add(city.Country);

            string newQueryCity = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdateBy)" +
                        " VALUES (@city, @countryId, @createDate, @createdBy, @lastUpdateBy)";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(newQueryCity, connection))
                {
                    command.Parameters.AddWithValue("@city", city.Name);
                    command.Parameters.AddWithValue("@countryId", city.Country.ID);
                    command.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@createdBy", "createdByCity");
                    command.Parameters.AddWithValue("@lastUpdateBy", "lastUpdatedByCity");

                    // Execute the command to insert into the 'city' table
                    command.ExecuteNonQuery();

                    // Retrieve the last inserted ID 
                    city.ID = (int)command.LastInsertedId;
                }
                connection.Close();
            }
        }
        public void Update(City city)
        {
            TrimFeilds(city);
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

            string deleteCity = "DELETE FROM City Where cityId = @ID";
            using (MySqlCommand command = new MySqlCommand(deleteCity, DB_Connection.conn))
            {
                command.Parameters.AddWithValue("@ID", city.ID);
                DB_Connection.conn.Open();
                command.ExecuteNonQuery();
                DB_Connection.conn.Close();
            }
            CountryData countryData = new CountryData();
            countryData.Delete(city.Country);
        }
        public City Get(int cityId)
        {
            City city = new City();
            CountryData countryData = new CountryData();

            string getCityQuery = "SELECT * FROM city WHERE cityId = @cityId";

            using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(getCityQuery, connection))
                {
                    command.Parameters.AddWithValue("@cityId", cityId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            city.ID = cityId;
                            city.Name = reader["city"].ToString();
                            city.Country = countryData.Get((int)reader["countryId"]);

                        }
                        TrimFeilds(city);
                    }

                }
                connection.Close();
            }
            return city;

        }

        //trim feilds methods
        public void TrimFeilds(City city)
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
