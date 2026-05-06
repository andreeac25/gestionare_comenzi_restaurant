using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Restaurant.Models;
using RestaurantApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Restaurant.Forms
{
    public partial class ComandaForm : Form
    {

        private int masaId;
        // Servicii pentru categorii și produse 
        CategorieService categorieService = new CategorieService();
        ProdusService produsService = new ProdusService();
        // Lista curentă de produse din bon (comanda activă)
        List<BonItem> bon = new List<BonItem>();
        // Lista produselor deja trimise
        List<BonItem> bonTrimis = new List<BonItem>();

        public ComandaForm()
        {
            InitializeComponent();
        }

        private void ComandaForm_Load(object sender, EventArgs e)
        {
            // La încărcarea formularului, încărcăm categoriile
            LoadCategorii();
        }

        // Constructor folosit când știm masa + dacă e ocupată
        public ComandaForm(int masaId, bool ocupata)
        {
            InitializeComponent();
            this.masaId = masaId;
            lblMasa.Text = "Masa " + masaId;
        }

        // Constructor folosit când există deja un bon existent (editare comandă)
        public ComandaForm(int masaId, List<BonItem> bonExistent)
        {
            InitializeComponent();
            this.masaId = masaId;
            bon = bonExistent; 
            lblMasa.Text = "Masa " + masaId;
            RefreshBon();
        }

        // Returnează bonul curent
        public List<BonItem> GetBon()
        {
            return bon;
        }

        // Încarcă toate categoriile din baza de date și le afișează ca butoane
        private void LoadCategorii()
        {
            panelCategorii.Controls.Clear();

            var categorii = categorieService.GetCategorii();

            foreach (var cat in categorii)
            {
                Button btn = new Button();

                btn.Text = cat.Nume;
                btn.Width = 120;
                btn.Height = 60;
                btn.Margin = new Padding(5);
                btn.BackColor = Color.FromArgb(0xF4, 0xEB, 0xDD);
                // salvăm ID-ul categoriei în Tag pentru a-l folosi la click
                btn.Tag = cat.Id;
                // eveniment click categorie
                btn.Click += Categorie_Click;
                panelCategorii.Controls.Add(btn);
            }
        }

        // La click pe categorie -> încărcăm produsele din acea categorie
        private void Categorie_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int categorieId = (int)btn.Tag;
            LoadProduse(categorieId);
        }

        // Încarcă produsele dintr-o categorie și le afișează ca butoane
        private void LoadProduse(int categorieId)
        {
            panelProduse.Controls.Clear();
            var produse = produsService.GetProduseByCategorie(categorieId);
            foreach (var prod in produse)
            {
                Button btn = new Button();
                btn.Text = $"{prod.Nume}\n{prod.Pret} RON";
                btn.Width = 130;
                btn.Height = 80;

                // stil 
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;

                // salvăm obiectul produs în Tag pentru acces rapid la click
                btn.Tag = prod;
                btn.Click += Produs_Click;
                panelProduse.Controls.Add(btn);
            }
        }

        // Adaugă produs în bon sau crește cantitatea dacă există deja
        private void Produs_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Produs prod = (Produs)btn.Tag;

            // verificăm dacă produsul există deja în bon
            var existing = bon.FirstOrDefault(x => x.ProdusId == prod.Id);

            if (existing != null)
            {
                existing.Cantitate++;
            }
            else
            {
                bon.Add(new BonItem
                {
                    ProdusId = prod.Id,
                    Nume = prod.Nume,
                    Cantitate = 1,
                    Pret = prod.Pret,
                    Trimis = false
                });
            }
            RefreshBon();
        }

        // Reîncarcă lista vizuală a bonului în UI
        private void RefreshBon()
        {
            panelBon.Controls.Clear();

            foreach (var item in bon)
            {
                Panel p = new Panel();
                p.Width = panelBon.Width - 10;
                p.Height = 25;

                Label lbl = new Label();
                lbl.Text =
                    $"{item.Nume}" +
                    $" - {item.Cantitate}\n";

                lbl.Dock = DockStyle.Fill;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                p.Controls.Add(lbl);

                // Ștergere produs din bon cu confirmare
                p.Click += (s, e) =>
                {
                    var result = MessageBox.Show(
                        $"Sigur stergi produsul {item.Nume}?",
                        "Confirmare",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bon.Remove(item);
                        RefreshBon();
                    }
                };

                lbl.Click += (s, e) =>
                {
                    var result = MessageBox.Show(
                        $"Sigur stergi produsul {item.Nume}?",
                        "Confirmare",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bon.Remove(item);
                        RefreshBon();
                    }
                };

                panelBon.Controls.Add(p);
            }
            // actualizare total bon
            lblTotal.Text = "Total: " + bon.Sum(x => x.Total).ToString("0.00") + " RON";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        // Generează nota de plată PDF
        private void btnNota_Click(object sender, EventArgs e)
        {
            if (bon.Count == 0)
            {
                MessageBox.Show("Bonul este gol!");
                return;
            }

            GenereazaNotaPDF();
        }

        // Fereastră de alegere metodă plată (Cash / Card)
        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Plata";
            f.Size = new Size(350, 250);
            f.BackColor = Color.FromArgb(47, 58, 68);
            Label lbl = new Label();
            lbl.Text = "Alege metoda de plata";
            lbl.Location = new Point(90, 50);
            lbl.AutoSize = true;
            lbl.ForeColor = Color.White;
            f.Controls.Add(lbl);

            Button btnCash = new Button();
            btnCash.Text = "Cash";
            btnCash.BackColor = Color.FromArgb(244, 235, 221);
            btnCash.Location = new Point(40, 90);
            btnCash.Size = new Size(100, 40);

            Button btnCard = new Button();
            btnCard.Text = "Card";
            btnCard.BackColor = Color.FromArgb(244, 235, 221);
            btnCard.Location = new Point(190, 90);
            btnCard.Size = new Size(100, 40);

            f.Controls.Add(btnCash);
            f.Controls.Add(btnCard);

            btnCash.Click += (s, ev) =>
            {
                SaveIncasare("Cash");
                f.Close();
            };

            btnCard.Click += (s, ev) =>
            {
                SaveIncasare("Card");
                f.Close();
            };

            f.ShowDialog();
        }

        // Salvează încasarea (plata finală)
        private void SaveIncasare(string metoda)
        {
            decimal total = (decimal)bon.Sum(x => x.Pret * x.Cantitate);

            Incasare inc = new Incasare
            {
                MasaId = masaId,
                MetodaPlata = metoda,
                Total = total,
                Data = DateTime.Now
            };

            MainForm.Incasari.Add(inc); // dacă o faci static
                                        // sau trimiți înapoi la MainForm

            bon.Clear();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Trimite comanda 
        private void btnTrimite_Click(object sender, EventArgs e)
        {
            var produseNoi = bon.Where(x => x.Trimis == false).ToList();

            if (produseNoi.Count == 0)
            {
                MessageBox.Show("Nu exista produse noi!");
                return;
            }

            string mesaj = "Trimis:\n";

            foreach (var p in produseNoi)
            {
                mesaj += $"{p.Nume} x{p.Cantitate}\n";
                p.Trimis = true; //  marcăm ca trimis
            }

            MessageBox.Show(mesaj);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Generează PDF pentru nota de plată
        private void GenereazaNotaPDF()
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Nota de plata";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fontTitlu = new XFont("Arial", 18);
            XFont fontText = new XFont("Arial", 12);
            int y = 40;

            // Titlu
            gfx.DrawString("NOTA DE PLATA", fontTitlu, XBrushes.Black,
                new XRect(0, y, page.Width, 30),
                XStringFormats.TopCenter);
            y += 50;
            // Masa
            gfx.DrawString($"Masa: {masaId}", fontText, XBrushes.Black, 40, y);
            y += 30;
            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 20;
            // Produse
            foreach (var item in bon)
            {
                gfx.DrawString(
                    $"{item.Nume} x{item.Cantitate} - {item.Pret * item.Cantitate} RON",
                    fontText,
                    XBrushes.Black,
                    40,
                    y);
                y += 20;
            }
            y += 20;
            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 30;
            decimal total = (decimal)bon.Sum(x => x.Pret * x.Cantitate);
            gfx.DrawString($"TOTAL: {total} RON", fontTitlu, XBrushes.Black, 40, y);
            // salvare pe desktop în foldere structurate
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPrincipal = Path.Combine(desktop, "Aplicatie Restaurant");
            string folderNote = Path.Combine(folderPrincipal, "Note Plata Aplicatie");
            // creează dacă nu există
            if (!Directory.Exists(folderPrincipal))
            {
                Directory.CreateDirectory(folderPrincipal);
            }
            if (!Directory.Exists(folderNote))
            {
                Directory.CreateDirectory(folderNote);
            }
            string fileName = $"Nota_Masa_{masaId}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string path = Path.Combine(folderNote, fileName);
            document.Save(path);
            // deschide automat folderul cu fișierul generat
            System.Diagnostics.Process.Start("explorer.exe", path);
        }
    }
}
