using Microsoft.Data.Sqlite;

namespace RestaurantApp.Services
{
    public class DatabaseService
    {
        private string connectionString = "Data Source=Data/restaurant.db";

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}