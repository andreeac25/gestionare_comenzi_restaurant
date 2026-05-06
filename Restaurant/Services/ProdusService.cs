using Restaurant.Models;
namespace RestaurantApp.Services
{
    // Service responsabil de operații legate de produse
    public class ProdusService
    {
        // Abstracție pentru conexiunea la baza de date
        private DatabaseService db = new DatabaseService();

        // Returnează toate produsele dintr-o categorie specifică
        public List<Produs> GetProduseByCategorie(int categorieId)
        {
            var list = new List<Produs>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Produse WHERE CategorieId = @cat";
                cmd.Parameters.AddWithValue("@cat", categorieId);
                

                var reader = cmd.ExecuteReader();

                // Transformăm fiecare rând din baza de date în obiect Produs
                while (reader.Read())
                {
                    list.Add(new Produs
                    {
                        Id = reader.GetInt32(0),
                        Nume = reader.GetString(1),
                        Pret = reader.GetDouble(2),
                        CategorieId = reader.GetInt32(3)
                    });
                }
            }
            // Returnăm lista finală către UI
            return list;
        }
    }
}