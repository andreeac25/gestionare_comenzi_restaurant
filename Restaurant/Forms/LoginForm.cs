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
    public partial class LoginForm : Form
    {
        // Instanță a serviciului de autentificare
        AuthService auth = new AuthService();
        public LoginForm()
        {
            // Inițializează componentele formularului (controale UI)
            InitializeComponent();
        }

        // Eveniment declanșat la apăsarea butonului de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Apelează metoda de login din AuthService folosind datele introduse
            var user = auth.Login(txtUser.Text, txtPass.Text);

            // Dacă utilizatorul nu este găsit sau parola este greșită
            if (user == null)
            {
                MessageBox.Show("Login invalid!");
                return;
            }
            // Salvează utilizatorul curent într-o sesiune globală
            AppSession.CurrentUser = user;

            // Ascunde formularul de login
            this.Hide();

            // Creează și deschide formularul principal (modal)
            MainForm main = new MainForm();
            main.ShowDialog();
            ClearFields();

            // Afișează din nou formularul de login
            this.Show();

        }

        // Metodă pentru resetarea câmpurilor de input
        private void ClearFields()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
