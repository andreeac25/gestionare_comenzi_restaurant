using Microsoft.Data.Sqlite;
using Restaurant.Models;


namespace RestaurantApp.Services
{
    // Service responsabil de gestionarea categoriilor din baza de date
    public class CategorieService
    {
        // Abstracție pentru conexiunea la baza de date
        private DatabaseService db = new DatabaseService();

        // Returnează toate categoriile existente din tabelul Categorii
        public List<Categorie> GetCategorii()
        {
            var list = new List<Categorie>();

            // Folosim conexiunea oferită de DatabaseService
            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Categorii";

                var reader = cmd.ExecuteReader();
                // Transformăm fiecare rând din DB într-un obiect Categorie
                while (reader.Read())
                {
                    list.Add(new Categorie
                    {
                        Id = reader.GetInt32(0),
                        Nume = reader.GetString(1)
                    });
                }
            }
            // Returnăm lista finală către UI
            return list;
        }
    }
}