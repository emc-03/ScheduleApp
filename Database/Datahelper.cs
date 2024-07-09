using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApp.Database
{
    //class Datahelper()
    //{
    ////    private static newCustomerId;
    ////    public static string connectionStr;
    ////assign to database connection string?
    ////    public static int createID(string table)
    ////{
    ////    using (MySqlConnection connection = new MySqlConnection(DB_Connection.ConnectionString))
    ////    {
    ////        connection.Open();
    ////        using (MySqlCommand command = new MySqlCommand(newCustomerId, connection))
    ////            MySqlCommand cmd = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", c);
    ////        MySqlDataReader rdr = cmd.ExecuteReader();
    ////        List<int> idList = new List<int>();
    ////        while (rdr.Read())
    ////        {
    ////            idList.Add(Convert.ToInt32(rdr[0]));
    ////        }
    ////        rdr.Close();
    ////        connection.Close();
    ////        return newCustomerId(idList);
    ////    }

    //}
}
