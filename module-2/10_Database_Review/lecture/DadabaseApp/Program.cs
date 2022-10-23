using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data.SqlClient;

namespace DadabaseApp
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string connectionString = LoadConnectionString();

                // Create the Data Access Object
                JokesDAO jokes = new JokesDAO(connectionString);

              

                // Create and run the user interface
                UserInterface ui = new UserInterface(jokes);
                ui.ShowMainMenu();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        // You don't need to worry about any of this code, but it loads data from the appsettings.json file
        // Also, Static methods are still bad, 'mmmkay? 
        private static string LoadConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("DadJokes");

            return connectionString;
        }
    }
}
