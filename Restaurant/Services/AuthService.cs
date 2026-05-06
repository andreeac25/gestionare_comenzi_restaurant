using Microsoft.Data.Sqlite;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    // Clasa responsabilă de autentificare și operații CRUD pentru utilizatorii din sistem
    public class AuthService
    {
        // String de conexiune către baza de date SQLite locală
        private string connStr = "Data Source=Data/restaurant.db";

        // Metodă de login: verifică dacă există un user cu username + password în DB
        public User Login(string username, string password)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();

            // Query parametrizat -> protecție împotriva SQL Injection
            cmd.CommandText = @"
        SELECT Username, Password, Role
        FROM Users
        WHERE Username = $u AND Password = $p";

            cmd.Parameters.AddWithValue("$u", username);
            cmd.Parameters.AddWithValue("$p", password);

            using var reader = cmd.ExecuteReader();

            // Dacă găsim un rezultat, construim obiectul User
            if (reader.Read())
            {
                return new User
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1),
                    Role = reader.GetString(2)
                };
            }

            return null;
        }

        // Returnează toți utilizatorii cu rol de ospătar
        public List<User> GetOspatari()
        {
            List<User> list = new List<User>();

            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            // Filtrare direct în SQL după rol
            cmd.CommandText = "SELECT Id, Username, Password, Role FROM Users WHERE Role = 'Ospatar'";

            using var reader = cmd.ExecuteReader();

            // Parcurgem rezultatele și le transformăm în obiecte User
            while (reader.Read())
            {
                list.Add(new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Role = reader.GetString(3)
                });
            }

            return list;
        }

        // Adaugă un nou ospătar în baza de date 
        public void AddOspatar(string user, string pass)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            // INSERT parametrizat pentru siguranță
            cmd.CommandText = @"
        INSERT INTO Users (Username, Password, Role)
        VALUES ($u, $p, 'Ospatar')";

            cmd.Parameters.AddWithValue("$u", user);
            cmd.Parameters.AddWithValue("$p", pass);

            cmd.ExecuteNonQuery();
        }

        // Șterge un ospătar după username
        public void DeleteOspatar(string username)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Users WHERE Username = $u";

            cmd.Parameters.AddWithValue("$u", username);

            cmd.ExecuteNonQuery();
        }

        // Actualizează datele unui ospătar după ID
        public void UpdateOspatar(int id, string newUsername, string newPassword)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            // UPDATE pe baza ID-ului pentru a evita modificări greșite
            cmd.CommandText = @"
        UPDATE Users
        SET Username = $user,
            Password = $pass
        WHERE Id = $id";

            cmd.Parameters.AddWithValue("$user", newUsername);
            cmd.Parameters.AddWithValue("$pass", newPassword);
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }
    }
}

