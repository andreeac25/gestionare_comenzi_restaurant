using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            if (!dgvNote.Columns.Contains("Deschide"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Deschide";
                btn.HeaderText = "";
                btn.Text = "Deschide nota";
                btn.UseColumnTextForButtonValue = true;

                dgvNote.Columns.Add(btn);
            }

            dgvNote.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;

                if (dgvNote.Columns[e.ColumnIndex].Name == "Deschide")
                {
                    string path = dgvNote.Rows[e.RowIndex]
                        .Cells["PdfPath"].Value.ToString();

                    OpenPdf(path);
                }
            };
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
            if (!dgvRapoarte.Columns.Contains("Deschide"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Deschide";
                btn.HeaderText = "";
                btn.Text = "Deschide PDF";
                btn.UseColumnTextForButtonValue = true;

                dgvRapoarte.Columns.Add(btn);
            }

            dgvRapoarte.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0) return;

                if (dgvRapoarte.Columns[e.ColumnIndex].Name == "Deschide")
                {
                    string path = dgvRapoarte.Rows[e.RowIndex]
                        .Cells["PdfPath"].Value.ToString();

                    OpenPdf(path);
                }
            };
        }


        // Metoda pentru deschiderea fișierului PDF atunci când se face clic pe butonul "Deschide nota" sau "Deschide PDF"
        private void OpenPdf(string path)
        {
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Fisierul nu exista!");
            }
        }
    }
}
