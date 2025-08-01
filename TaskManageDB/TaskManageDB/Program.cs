using System;
using System.Data.SqlClient;

namespace TaskManagerDB
{
    class Program
    {
        static void Main()
        {
            string connectionString =  "Data Source=LEVAXX11\\MSSQLSERVER2022;Initial Catalog=TaskManagerDB;User ID=levax; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to the database was successful.");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }   
        }
    }
}