using Restaurant.Models;
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
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();

            // Verificare de securitate: accesul la acest formular este permis doar adminilor
            // Se verifică utilizatorul curent din sesiune (AppSession)
            if (AppSession.CurrentUser == null ||
        AppSession.CurrentUser.Role != "Admin")
            {
                MessageBox.Show("Acces interzis!");
                this.Close();
            }
        }

        // Deschide formularul pentru editarea meniului 
        private void btnEditateMeniu_Click(object sender, EventArgs e)
        {
            EditareMeniuForm f = new EditareMeniuForm();
            f.ShowDialog();
        }

        // Deschide formularul de gestionare a ospătarilor
        private void btnGestiuneOsp_Click(object sender, EventArgs e)
        {
            OspatariForm f = new OspatariForm();
            f.ShowDialog();
        }
    }
}
