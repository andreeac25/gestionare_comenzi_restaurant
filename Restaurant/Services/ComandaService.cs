using Microsoft.Data.Sqlite;

namespace RestaurantApp.Services
{
    // Service responsabil de gestionarea comenzilor din restaurant
    // Include operații: adăugare produs, ștergere logică, trimitere comandă și încasare
    public class ComandaService
    {
        // Abstracție pentru accesul la baza de date
        private DatabaseService db = new DatabaseService();

        // Adaugă un produs la o masă (o nouă linie în tabelul Comenzi)
        public void AdaugaProdus(int masaId, int produsId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                // Inserare comandă nouă (produs asociat unei mese)
                cmd.CommandText = @"
                    INSERT INTO Comenzi (MasaId, ProdusId, Cantitate, EsteTrimis, EsteSters)
                    VALUES (@masa, @produs, 1, 0, 0)
                ";

                cmd.Parameters.AddWithValue("@masa", masaId);
                cmd.Parameters.AddWithValue("@produs", produsId);

                cmd.ExecuteNonQuery();
            }
        }

        // Ștergere logică a unui produs din comandă (nu se șterge fizic din DB)
        public void StergeProdus(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Comenzi SET EsteSters = 1 WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Marchează toate produsele unei mese ca "trimise la bucătărie"
        public void TrimiteComanda(int masaId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Comenzi SET EsteTrimis = 1 WHERE MasaId = @masa AND EsteTrimis = 0";
                cmd.Parameters.AddWithValue("@masa", masaId);

                cmd.ExecuteNonQuery();
            }
        }


        // Încasează masa: șterge toate comenzile asociate mesei
        // Practic resetarea mesei după plată
        public void Incaseaza(int masaId)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                var cmd = conn.CreateCommand();
                // Ștergere fizică din DB după plată (resetare completă a mesei)
                cmd.CommandText = "DELETE FROM Comenzi WHERE MasaId = @masa";
                cmd.Parameters.AddWithValue("@masa", masaId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}