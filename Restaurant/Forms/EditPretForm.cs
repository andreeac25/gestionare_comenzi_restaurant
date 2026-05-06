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
    public partial class EditPretForm : Form
    {
        MenuService service = new MenuService(); // Serviciu pentru operații pe meniu 
        public Produs ProdusSelectat; // Produsul primit din formularul părinte (produs selectat)

        public EditPretForm()
        {
            InitializeComponent();
        }

        // La încărcarea formularului → afișăm datele produsului
        private void EditPretForm_Load(object sender, EventArgs e)
        {
            lblProdus.Text = ProdusSelectat.Nume;
            lblPretVechi.Text = $"Pret vechi: {ProdusSelectat.Pret} RON";

            txtPret.Text = ProdusSelectat.Pret.ToString();
        }

        // Buton salvare nou preț
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            // validare: verificăm dacă input-ul este un număr valid
            if (double.TryParse(txtPret.Text, out double pretNou))
            {
                // actualizăm prețul în baza de date
                service.UpdatePret(ProdusSelectat.Id, pretNou);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
