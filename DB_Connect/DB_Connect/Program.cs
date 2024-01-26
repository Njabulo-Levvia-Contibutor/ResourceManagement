using System;
using System.Data;
using System.Data.SqlClient;
namespace DB_Connect
{
    class Program
    {
        // connection string
        static string connString = "Server=levvia-resource-manager.database.windows.net;Database=levvia-resource-manager-sql2;User Id=levvia-resource-manager-sql@levvia-resource-manager;Password=&mx3x9eVwa&Uns;";

        static void Main()

        {

            

            using (SqlConnection connection = new SqlConnection(connString))

            {

                // Open connection

                connection.Open();

                Console.WriteLine("Connected successfully.");

                string query = "select * from sys.tables";

                using (SqlCommand cmd = new SqlCommand(query, connection))

                {

                    using (SqlDataReader reader = cmd.ExecuteReader())

                    {

                        while (reader.Read())

                        {

                            

                            Console.WriteLine(reader.GetString(0));
                            cmd.ExecuteNonQuery();
                            //close connection
                            connection.Close();
                        }

                    }

                }


            }

        }

        private static void CreateTable(object sender, EventArgs e)
        {

            string sqlStatment = string.Format("CREATE TABLE {0}([Id] [int] IDENTITY(1,1) NOT NULL, [Name] [varchar](50) NULL)", "Person");
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlStatment, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

    }
}