using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
    public partial class MainForm : Form
    {
        private Button btn;
        private string i;
        public static List<Incasare> Incasari = new List<Incasare>();
        Dictionary<int, List<BonItem>> meseBonuri = new Dictionary<int, List<BonItem>>(); //fiecare masă are propriul bon
        private User currentUser;
        private bool esteLogout = false;


        // constructor alternativ
        public MainForm()
        {
            InitializeComponent();
        }

        // constructor folosit când există utilizator logat
        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // asignare manuală ID-uri pentru mese
            btnMasa1.Tag = 1;
            btnMasa2.Tag = 2;
            btnMasa3.Tag = 3;
            btnMasa4.Tag = 4;
            btnMasa5.Tag = 5;
            btnMasa6.Tag = 6;
            btnMasa7.Tag = 7;
            btnMasa8.Tag = 8;
            btnMasa9.Tag = 9;
            btnMasa10.Tag = 10;

            // verificare sesiune user
            if (AppSession.CurrentUser == null)
            {
                MessageBox.Show("Nu există utilizator logat!");
                this.Close();
                return;
            }

            // afișare user în UI
            lblUser.Text = $"Logat: {AppSession.CurrentUser.Username}";

            // restricție de acces pentru Admin
            if (AppSession.CurrentUser.Role != "Admin")
            {
                btnSettings.Visible = false;
            }
        }

        // click pe masă -> deschide comanda asociată mesei
        private void Masa_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int masaId = (int)btn.Tag;

            // dacă masa NU există -> creează listă goală
            if (!meseBonuri.ContainsKey(masaId))
            {
                meseBonuri[masaId] = new List<BonItem>();
            }

            // trimitem lista către ComandaForm
            ComandaForm form = new ComandaForm(masaId, meseBonuri[masaId]);

            var result = form.ShowDialog();

            // salvăm înapoi modificările
            meseBonuri[masaId] = form.GetBon();

            // culoare masă
            if (meseBonuri[masaId].Count > 0)
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF6B6B");
            else
                btn.BackColor = Color.FromArgb(244, 235, 221);
        }

        // deschide setările (doar pentru admin)
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.ShowDialog();
        }

        // generează raport final al zilei (static -> global)
        public static void GenereazaRaportFinal()
        {
            var azi = DateTime.Today;

            // filtrare încasări din ziua curentă
            var incasariAzi = Incasari
                .Where(x => x.Data.Date == azi)
                .ToList();

            if (incasariAzi.Count == 0)
            {
                MessageBox.Show("Nu exista incasari azi!");
                return;
            }

            int nrMese = incasariAzi.Count;

            decimal total = incasariAzi.Sum(x => x.Total);

            decimal totalCash = incasariAzi
                .Where(x => x.MetodaPlata == "Cash")
                .Sum(x => x.Total);

            decimal totalCard = incasariAzi
                .Where(x => x.MetodaPlata == "Card")
                .Sum(x => x.Total);

            GenereazaPDFRaport(nrMese, total, totalCash, totalCard);
        }

        // generează PDF-ul raportului zilnic
        public static void GenereazaPDFRaport(int nrMese, decimal total, decimal cash, decimal card)
        {
            // salvare
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPrincipal = Path.Combine(desktop, "Aplicatie Restaurant");
            string folderRapoarte = Path.Combine(folderPrincipal, "Rapoarte");
            // nume fișier
            string fileName = $"Raport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            // cale completă
            string path = Path.Combine(folderRapoarte, fileName);

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Raport final";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont fontTitlu = new XFont("Arial", 18);
            XFont fontText = new XFont("Arial", 12);

            int y = 50;

            gfx.DrawString("RAPORT FINAL ZI", fontTitlu, XBrushes.Black, 40, y);
            y += 40;

            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 30;

            // userul logat
            string numeOspatar = AppSession.CurrentUser?.Username ?? "Necunoscut";

            gfx.DrawString($"Ospatar: {numeOspatar}", fontText, XBrushes.Black, 40, y);
            y += 30;


            gfx.DrawString($"Data: {DateTime.Now:dd.MM.yyyy}", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString($"Numar mese: {nrMese}", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 30;


            gfx.DrawString($"Cash: {cash} RON", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString($"Card: {card} RON", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString("----------------------------------------", fontText, XBrushes.Black, 40, y);
            y += 30;

            gfx.DrawString($"Total incasari: {total} RON", fontText, XBrushes.Black, 40, y);
            y += 30;

            // creează dacă nu există
            if (!Directory.Exists(folderPrincipal))
            {
                Directory.CreateDirectory(folderPrincipal);
            }

            if (!Directory.Exists(folderRapoarte))
            {
                Directory.CreateDirectory(folderRapoarte);
            }

            // salvare
            document.Save(path);

            //deschizi raportul dupa generare
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            });
        }

        // buton raport -> generează și închide aplicația
        private void btnRaport_Click(object sender, EventArgs e)
        {
            MainForm.GenereazaRaportFinal();
            
        }

        // control comportament la închidere form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // dacă nu e logout → închide aplicația complet
            if (!esteLogout)
            {
                Application.Exit();
            }
        }

        //buton pentru logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            esteLogout = true;

            AppSession.CurrentUser = null;

            this.Close(); 
        }
    }
}