using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Restaurant.Forms
{
    public partial class IstoricForm : Form
    {
        public IstoricForm()
        {
            InitializeComponent();
        }

        private void IstoricForm_Load(object sender, EventArgs e)
        {
            LoadNote();
            LoadRapoarte();
        }

        //Metoda pentru încărcarea notelor de plată din baza de date și afișarea acestora în DataGridView
        private void LoadNote()
        {
            string connStr = "Data Source=Data/restaurant.db";

            using var conn = new SqliteConnection(connStr);

            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            SELECT
                Id,
                MasaId,
                Ospatar,
                Total,
                MetodaPlata,
                Data
            FROM NotePlata
            ORDER BY Id DESC";

            DataTable dt = new DataTable();

            using var reader = cmd.ExecuteReader();

            dt.Load(reader);

            dgvNote.DataSource = dt;
        }

        // Metoda pentru încărcarea rapoartelor zilnice din baza de date și afișarea acestora în DataGridView
        private void LoadRapoarte()
        {
            string connStr = "Data Source=Data/restaurant.db";

            using var conn = new SqliteConnection(connStr);

            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = @"
            SELECT
                Id,
                DataRaport,
                TotalCash,
                TotalCard,
                TotalGeneral,
                NrMese,
                GeneratDe
            FROM RapoarteZilnice
            ORDER BY Id DESC";

            DataTable dt = new DataTable();

            using var reader = cmd.ExecuteReader();

            dt.Load(reader);

            dgvRapoarte.DataSource = dt;
        }
    }
}
