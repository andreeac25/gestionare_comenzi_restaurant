using Microsoft.Data.Sqlite;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Services
{
    // Service responsabil de gestionarea meniului:
    // categorii + produse (CRUD + afișare)
    public class MenuService
    {
        // Conexiune către baza de date SQLite
        private string connStr = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "restaurant.db")}";

        // Returnează toate categoriile din meniu
        public List<Categorie> GetCategorii()
        {
            List<Categorie> list = new List<Categorie>();

            using var conn = new SqliteConnection(connStr);

            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Nume FROM Categorii";

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Categorie
                {
                    Id = reader.GetInt32(0),
                    Nume = reader.GetString(1)
                });
            }

            return list;
        }

        // Returnează produsele pentru o categorie specifică
        public List<Produs> GetProduse(int categorieId)
        {
            List<Produs> list = new List<Produs>();

            using var conn = new SqliteConnection(connStr);
            conn.Open();

            using var transaction = conn.BeginTransaction();
            transaction.Commit();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Nume, Pret, CategorieId FROM Produse WHERE CategorieId = $id";
            cmd.Parameters.AddWithValue("$id", categorieId);

            using var reader = cmd.ExecuteReader();

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

            return list;
        }

        // Șterge o categorie + toate produsele asociate
        public void DeleteCategorie(int id)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();

            // 🔥 sterge produsele mai intai
            cmd.CommandText = "DELETE FROM Produse WHERE CategorieId = $id";
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();

            // 🔥 sterge categoria
            cmd.CommandText = "DELETE FROM Categorii WHERE Id = $id";
            cmd.ExecuteNonQuery();
        }

        // Adaugă o categorie nouă în baza de date
        public void AddCategorie(string nume)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Categorii (Nume) VALUES ($n)";
            cmd.Parameters.AddWithValue("$n", nume);

            cmd.ExecuteNonQuery();
        }

        // Șterge un produs după ID
        public void DeleteProdus(int id)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Produse WHERE Id = $id";
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }

        // Adaugă un produs nou în meniu
        public void AddProdus(string nume, double pret, int categorieId)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            @"INSERT INTO Produse (Nume, Pret, CategorieId)
      VALUES ($n, $p, $c)";

            cmd.Parameters.AddWithValue("$n", nume);
            cmd.Parameters.AddWithValue("$p", pret);
            cmd.Parameters.AddWithValue("$c", categorieId);

            cmd.ExecuteNonQuery();
        }

        // Actualizează prețul unui produs existent
        public void UpdatePret(int id, double pret)
        {
            using var conn = new SqliteConnection(connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Produse SET Pret = $p WHERE Id = $id";

            cmd.Parameters.AddWithValue("$p", pret);
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
