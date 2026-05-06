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
    public partial class OspatariForm : Form
    {
        // Serviciu de autentificare / gestionare utilizatori (ospătari)
        AuthService auth = new AuthService();        
        
        public OspatariForm()
        {
            InitializeComponent();
        }

        // Încarcă lista de ospătari din serviciu și o leagă la ListBox
        private void LoadOspatari()
        {
            lstOspatari.DataSource = null;
            lstOspatari.DataSource = auth.GetOspatari();
            lstOspatari.DisplayMember = "Username";
            lstOspatari.ValueMember = "Id";
        }


        // La încărcarea formularului se populează lista de ospătari
        private void OspatariForm_Load(object sender, EventArgs e)
        {
            LoadOspatari();
        }

        // Șterge un ospătar selectat din listă, cu confirmare utilizator
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = lstOspatari.SelectedItem as User;
            if (user == null) return;

            // Dialog de confirmare pentru a evita ștergeri accidentale
            var result = MessageBox.Show(
                $"Stergi ospatarul {user.Username}?",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                auth.DeleteOspatar(user.Username);
                LoadOspatari();
            }
        }

        // Adaugă un nou ospătar printr-un formular creat dinamic
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Adauga Ospatar";
            f.Size = new Size(300, 200);
            f.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3A44");
            f.StartPosition = FormStartPosition.CenterParent;

            TextBox txtUser = new TextBox { PlaceholderText = "Username", Top = 20, Left = 20, Width = 200 };
            TextBox txtPass = new TextBox { PlaceholderText = "Parola", Top = 60, Left = 20, Width = 200 };

            Button ok = new Button
            {
                Text = "Adauga",
                Top = 110,
                Left = 20,
                Width = 100,
                Height = 30,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#F4EBDD")
            };

            ok.Click += (s, ev) =>
            {
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Completeaza toate campurile!");
                    return;
                }

                auth.AddOspatar(txtUser.Text, txtPass.Text);
                LoadOspatari();
                f.Close();
            };

            f.Controls.Add(txtUser);
            f.Controls.Add(txtPass);
            f.Controls.Add(ok);

            f.ShowDialog();
        }

        // Editează un ospătar selectat
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var user = lstOspatari.SelectedItem as User;
            if (user == null) return;

            Form f = new Form();
            f.Text = "Editare Ospatar";
            f.Size = new Size(300, 200);
            f.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3A44");
            f.StartPosition = FormStartPosition.CenterParent;

            TextBox txtUser = new TextBox
            {
                Text = user.Username,
                Top = 20,
                Left = 20,
                Width = 200
            };

            TextBox txtPass = new TextBox
            {
                Text = user.Password,
                Top = 60,
                Left = 20,
                Width = 200
            };

            Button ok = new Button
            {
                Text = "Salveaza",
                Top = 110,
                Left = 20,
                Width = 100,
                Height = 30,
                BackColor = System.Drawing.ColorTranslator.FromHtml("#F4EBDD")
            };

            ok.Click += (s, ev) =>
            {
                var user = lstOspatari.SelectedItem as User;
                if (user == null) return;

                auth.UpdateOspatar(user.Id, txtUser.Text, txtPass.Text);

                LoadOspatari(); // refresh list
                f.Close();
            };

            f.Controls.Add(txtUser);
            f.Controls.Add(txtPass);
            f.Controls.Add(ok);

            f.ShowDialog();
        }
    }
}
