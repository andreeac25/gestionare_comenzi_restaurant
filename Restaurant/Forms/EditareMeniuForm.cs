using Microsoft.Data.Sqlite;
using Restaurant.Models;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Forms
{
    public partial class EditareMeniuForm : Form
    {
        private Produs produsSelectat; // Variabilă care reține produsul selectat 
        // Serviciu care gestionează meniul (categorii + produse)
        MenuService service = new MenuService();
        public EditareMeniuForm()
        {
            InitializeComponent();
        }

        // La încărcarea formularului -> încărcăm lista de categorii
        private void EditareMeniuForm_Load(object sender, EventArgs e)
        {
            LoadCategorii();
        }

        // Încarcă toate categoriile din DB și le leagă la ListBox
        private void LoadCategorii()
        {
            lstCategorii.DataSource = service.GetCategorii();
            lstCategorii.DisplayMember = "Nume";
            lstCategorii.ValueMember = "Id";
        }

        // Când selectezi o categorie -> se încarcă produsele aferente
        private void lstCategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorii.SelectedItem == null) return;

            var cat = (Categorie)lstCategorii.SelectedItem;

            // încărcăm produsele din categoria selectată
            lstProduse.DataSource = service.GetProduse(cat.Id);
            lstProduse.DisplayMember = "DisplayText";
        }

        // Deschide formular pentru adăugare categorie
        private void btnAdaugaCategorie_Click(object sender, EventArgs e)
        {
            AdaugaCategorieForm f = new AdaugaCategorieForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCategorii();  // refresh după adăugare
            }
        }

        //Sterge categoria din lista
        private void btnStergereCat_Click(object sender, EventArgs e)
        {
            var cat = lstCategorii.SelectedItem as Categorie;

            if (cat == null)
            {
                MessageBox.Show("Selecteaza o categorie!");
                return;
            }

            var result = MessageBox.Show(
                $"Sigur vrei sa stergi categoria '{cat.Nume}'?",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                service.DeleteCategorie(cat.Id);

                LoadCategorii();   // refresh lista categorii
                lstProduse.DataSource = null; // golește produsele
            }
        }

        // Adaugă produs în categoria selectată
        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            var cat = lstCategorii.SelectedItem as Categorie;
            if (cat == null) return;

            AdaugaProdusForm f = new AdaugaProdusForm();
            f.CategorieId = cat.Id;

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadProduse(cat.Id); // refresh produse după adăugare
            }
        }

        // Ștergere produs selectat
        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            var prod = lstProduse.SelectedItem as Produs;
            if (prod == null) return;

            var result = MessageBox.Show(
                $"Stergi produsul {prod.Nume}?",
                "Confirmare",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                service.DeleteProdus(prod.Id);
                // refresh listă produse după ștergere
                var cat = lstCategorii.SelectedItem as Categorie;
                LoadProduse(cat.Id);
            }
        }

        // Reîncarcă produsele pentru o categorie
        private void LoadProduse(int categorieId)
        {
            lstProduse.DataSource = service.GetProduse(categorieId);
        }

        // Se actualizează când utilizatorul selectează alt produs
        private void lstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            produsSelectat = lstProduse.SelectedItem as Produs;
        }

        // Modificare preț produs
        private void btnModificaPret_Click(object sender, EventArgs e)
        {
            var prod = lstProduse.SelectedItem as Produs;
            if (prod == null) return;

            EditPretForm f = new EditPretForm();
            // trimitem produsul selectat către formular
            f.ProdusSelectat = prod;

            if (f.ShowDialog() == DialogResult.OK)
            {
                var cat = lstCategorii.SelectedItem as Categorie;
                // refresh după modificare preț
                LoadProduse(cat.Id);
            }
        }
    }
}
