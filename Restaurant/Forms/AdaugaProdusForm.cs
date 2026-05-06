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
    public partial class AdaugaProdusForm : Form
    {
        MenuService service = new MenuService();// Serviciu care gestionează meniul (produse, categorii etc.)
        public int CategorieId; // ID-ul categoriei în care va fi adăugat produsul (setat din alt formular)

        public AdaugaProdusForm()
        {
            InitializeComponent();
        }
        // Eveniment declanșat la apăsarea butonului de "Adaugă produs"
        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            // Validare simplă: dacă numele produsului este gol, ieșim din metodă
            if (string.IsNullOrWhiteSpace(txtNume.Text)) return;
            // In cazul in care se introduce altecav in afara de numere
            if (!double.TryParse(txtPret.Text, out double pret))
            {
                MessageBox.Show("Preț invalid!");
                return;
            }
            // Adaugă produsul în sistem prin MenuService
            service.AddProdus(
                txtNume.Text,
                double.Parse(txtPret.Text),
                CategorieId);
            this.DialogResult = DialogResult.OK;// Marchează formularul ca "OK" pentru formularul părinte
            this.Close();
        }
    }
}
