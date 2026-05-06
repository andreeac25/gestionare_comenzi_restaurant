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
    public partial class AdaugaCategorieForm : Form
    {
        // Instanță a serviciului care gestionează meniul și categoriile
        MenuService service = new MenuService();
        public AdaugaCategorieForm()
        {
            // Inițializează componentele formularului
            InitializeComponent();
        }

        // Eveniment declanșat la apăsarea butonului "Adaugă"
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            // Verifică dacă textbox-ul nu este gol sau doar spații
            if (!string.IsNullOrWhiteSpace(txtNumeCategorie.Text))
            {
                // Adaugă categoria folosind serviciul MenuService
                service.AddCategorie(txtNumeCategorie.Text);
                // Setează rezultatul formularului ca fiind OK (pentru a fi folosit de formularul părinte)
                this.DialogResult = DialogResult.OK;
                // Închide formularul după adăugare
                this.Close();
            }
        }
    }
}
