using Microsoft.Data.Sqlite;


namespace RestaurantApp.Services
{
    // Clasa responsabilă de inițializarea bazei de date la pornirea aplicației
    // Creează tabelele dacă nu există și inserează date default (seed data)
    public class DbInitializer
    {
        // Calea către fișierul SQLite
        private string dbPath = "Data/restaurant.db";

        // Metoda principală de inițializare a bazei de date
        public void Initialize()
        {
            Directory.CreateDirectory("Data");
            

            using (var conn = new SqliteConnection($"Data Source={dbPath}"))
            {
                conn.Open();

                var cmd = conn.CreateCommand();

                // Creare tabele
                cmd.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Categorii (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nume TEXT UNIQUE
                );

                CREATE TABLE IF NOT EXISTS Produse (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nume TEXT,
                    Pret REAL,
                    CategorieId INTEGER,
                    UNIQUE(Nume, CategorieId)
                );
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );
                ";
                cmd.ExecuteNonQuery();

                // Inserare date
                SeedData(conn);
            }
        }

        // Metodă responsabilă de popularea bazei de date cu date default
        private void SeedData(SqliteConnection conn)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users";
            var userCount = Convert.ToInt32(cmd.ExecuteScalar());

            //Utilizatori
            if (userCount == 0)
            {
                cmd.CommandText =
                @"
            INSERT INTO Users (Username, Password, Role) VALUES
            ('admin', '2004', 'Admin'),
            ('numeOspatar1', '1234', 'Ospatar'),
            ('numeOspatar2', '5678', 'Ospatar');
            ";
                cmd.ExecuteNonQuery();
            }

            // verificăm dacă există deja date
            cmd.CommandText = "SELECT COUNT(*) FROM Categorii";
            long catCount = (long)cmd.ExecuteScalar();
            long catProd = (long)cmd.ExecuteScalar();



            // CATEGORII
            if (catCount == 0)
            {
                cmd.CommandText =
                @"
                INSERT INTO Categorii (Nume) VALUES
                ('Pui'),
                ('Vita'),
                ('Porc'),
                ('Peste'),
                ('Garnituri'),
                ('Paste'),
                ('Pizza'),
                ('Ciorbe/Supe'),
                ('Desert'),
                ('Apa/Suc'),
                ('Cocktail'),
                ('Cafea');
                ";
                cmd.ExecuteNonQuery();
            }

            // PRODUSE
            if (catProd == 0)
            {
                cmd.CommandText =
                @"
            INSERT INTO Produse (Nume, Pret, CategorieId) VALUES
            ('Piept de pui la gratar', 25, 1),
            ('Snitel de pui', 28, 1),
            ('Aripioare crispy', 22, 1),
            ('Pulpe de pui', 24, 1),
            ('Ficatei de pui', 20, 1),
            ('Tigaie picanta pui', 27, 1),
            ('Pui sweet & sour', 30, 1),
            ('Burger pui', 26, 1),
            ('Quesadilla pui', 29, 1),
            ('Pui la cuptor', 25, 1),

            ('Burger vita premium', 35, 2),
            ('Friptura vita', 55, 2),
            ('Antricot vita', 60, 2),
            ('Ribeye steak', 75, 2),
            ('T-bone steak', 80, 2),
            ('Vita la gratar', 50, 2),
            ('Tigaie vita legume', 40, 2),
            ('Cheeseburger vita', 38, 2),
            ('Steak pepper', 65, 2),
            ('Carpaccio vita', 45, 2),

            ('Ceafa porc', 30, 3),
            ('Cotlet porc', 32, 3),
            ('Coaste porc BBQ', 35, 3),
            ('Snitel porc', 28, 3),
            ('Mici 4 buc', 22, 3),
            ('Carnati porc', 25, 3),
            ('Pulpa porc la cuptor', 33, 3),
            ('Tigaie picanta porc', 29, 3),
            ('Ciolan afumat', 40, 3),
            ('Burger porc', 27, 3),

            ('Somon la gratar', 45, 4),
            ('Pastrav prajit', 35, 4),
            ('Dorada la cuptor', 50, 4),
            ('File de cod', 40, 4),
            ('Calamar pane', 38, 4),
            ('Creveti la tigaie', 55, 4),
            ('Hamsii prajite', 25, 4),
            ('Platou peste', 70, 4),
            ('Saramura crap', 42, 4),
            ('File somon cu legume', 48, 4),

            ('Cartofi prajiti', 12, 5),
            ('Cartofi wedges', 14, 5),
            ('Orez simplu', 10, 5),
            ('Orez cu legume', 12, 5),
            ('Piure de cartofi', 13, 5),
            ('Legume la gratar', 15, 5),
            ('Salata varza', 8, 5),
            ('Salata muraturi', 9, 5),
            ('Ciuperci sote', 14, 5),
            ('Mamaliga', 10, 5),

            ('Spaghetti Carbonara', 30, 6),
            ('Penne Arrabiata', 28, 6),
            ('Tagliatelle Bolognese', 32, 6),
            ('Paste Quattro Formaggi', 35, 6),
            ('Fettuccine Alfredo', 33, 6),
            ('Paste cu pui', 30, 6),
            ('Paste cu fructe de mare', 40, 6),
            ('Lasagna', 34, 6),
            ('Penne cu pesto', 29, 6),
            ('Spaghetti Napoli', 27, 6),

            ('Pizza Margherita', 28, 7),
            ('Pizza Diavola', 32, 7),
            ('Pizza Quattro Stagioni', 35, 7),
            ('Pizza Capriciosa', 34, 7),
            ('Pizza Tonno', 33, 7),
            ('Pizza Prosciutto', 31, 7),
            ('Pizza Vegetariana', 30, 7),
            ('Pizza BBQ', 36, 7),
            ('Pizza Salami', 32, 7),
            ('Pizza Quattro Formaggi', 38, 7),
           
            ('Ciorba de burta', 20, 8),
            ('Ciorba de pui', 18, 8),
            ('Ciorba de vacuta', 19, 8),
            ('Ciorba de legume', 16, 8),
            ('Ciorba radauteana', 21, 8),
            ('Supa de pui', 15, 8),
            ('Supa crema ciuperci', 17, 8),
            ('Supa crema legume', 16, 8),
            ('Ciorba de fasole', 18, 8),
            ('Ciorba de peste', 22, 8),

            ('Tiramisu', 22, 9),
            ('Papanasi', 25, 9),
            ('Clatite ciocolata', 18, 9),
            ('Clatite gem', 16, 9),
            ('Cheesecake', 24, 9),
            ('Profiterol', 20, 9),
            ('Inghetata', 15, 9),
            ('Brownie', 19, 9),
            ('Tarta mere', 18, 9),
            ('Ecler', 17, 9),

            ('Apa plata', 8, 10),
            ('Apa minerala', 8, 10),
            ('Coca Cola', 10, 10),
            ('Fanta', 10, 10),
            ('Sprite', 10, 10),
            ('Fresh portocale', 15, 10),
            ('Limonada', 12, 10),
            ('Ice Tea', 10, 10),
            ('Pepsi', 10, 10),
            ('Apa tonica', 9, 10),

            ('Mojito', 25, 11),
            ('Pina Colada', 28, 11),
            ('Sex on the Beach', 26, 11),
            ('Blue Lagoon', 27, 11),
            ('Margarita', 30, 11),
            ('Caipirinha', 25, 11),
            ('Long Island', 35, 11),
            ('Aperol Spritz', 28, 11),
            ('Gin Tonic', 22, 11),
            ('Cosmopolitan', 29, 11),

            ('Espresso', 8, 12),
            ('Cappuccino', 10, 12),
            ('Latte', 12, 12),
            ('Americano', 9, 12),
            ('Macchiato', 10, 12),
            ('Flat White', 12, 12),
            ('Ristretto', 8, 12),
            ('Irish Coffee', 18, 12),
            ('Caffee Latte', 11, 12),
            ('Doppio', 9, 12);
            ";
                cmd.ExecuteNonQuery();
            }
        }
    }
}