using System;
using MySql.Data.MySqlClient;

namespace carRentalService.Model
{
    public class carRentalWeb
    {
       public string ConnectionString { get; set; }
        public carRentalWeb (string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
