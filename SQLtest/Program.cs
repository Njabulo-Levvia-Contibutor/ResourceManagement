using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace sqltest
{
    class Program
    {
        static void Main()
        {

            // My Microsoft SQL connection string
            string connectionString = "Server=levvia-resource-manager.database.windows.net;Database=levvia-resource-manager-sql2;User Id=levvia-resource-manager-sql@levvia-resource-manager;Password=&mx3x9eVwa&Uns;";
            // Creating a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Opening connection
                connection.Open();
                Console.WriteLine("Connected successfully.");

                string query = "select * from sys.tables";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Processing data from the reader
                            Console.WriteLine(reader.GetString(0)); // Example of accessing column data
                        }
                    }
                }

            }
        }
    }
}