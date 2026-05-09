namespace Restaurant.Forms
{
    partial class EditareMeniuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCategorii = new ListBox();
            lstProduse = new ListBox();
            btnAdaugaCategorie = new Button();
            btnAdaugaProdus = new Button();
            btnStergeProdus = new Button();
            btnModificaPret = new Button();
            btnStergereCat = new Button();
            SuspendLayout();
            // 
            // lstCategorii
            // 
            lstCategorii.BackColor = Color.FromArgb(244, 235, 221);
            lstCategorii.FormattingEnabled = true;
            lstCategorii.Location = new Point(12, 12);
            lstCategorii.Name = "lstCategorii";
            lstCategorii.Size = new Size(171, 344);
            lstCategorii.TabIndex = 0;
            lstCategorii.Click += lstCategorii_SelectedIndexChanged;

            // 
            // lstProduse
            // 
            lstProduse.FormattingEnabled = true;
            lstProduse.Location = new Point(189, 12);
            lstProduse.Name = "lstProduse";
            lstProduse.Size = new Size(276, 384);
            lstProduse.TabIndex = 1;
            lstProduse.SelectedIndexChanged += lstProduse_SelectedIndexChanged;
            // 
            // btnAdaugaCategorie
            // 
            btnAdaugaCategorie.BackColor = Color.White;
            btnAdaugaCategorie.FlatStyle = FlatStyle.Flat;
            btnAdaugaCategorie.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdaugaCategorie.ForeColor = Color.Black;
            btnAdaugaCategorie.Location = new Point(12, 367);
            btnAdaugaCategorie.Name = "btnAdaugaCategorie";
            btnAdaugaCategorie.Size = new Size(171, 29);
            btnAdaugaCategorie.TabIndex = 2;
            btnAdaugaCategorie.Text = "Adauga Categorie";
            btnAdaugaCategorie.UseVisualStyleBackColor = false;
            btnAdaugaCategorie.Click += btnAdaugaCategorie_Click;
            // 
            // btnAdaugaProdus
            // 
            btnAdaugaProdus.BackColor = Color.FromArgb(214, 198, 168);
            btnAdaugaProdus.FlatStyle = FlatStyle.Flat;
            btnAdaugaProdus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdaugaProdus.Location = new Point(189, 406);
            btnAdaugaProdus.Name = "btnAdaugaProdus";
            btnAdaugaProdus.Size = new Size(75, 29);
            btnAdaugaProdus.TabIndex = 3;
            btnAdaugaProdus.Text = "Adauga";
            btnAdaugaProdus.UseVisualStyleBackColor = false;
            btnAdaugaProdus.Click += btnAdaugaProdus_Click;
            // 
            // btnStergeProdus
            // 
            btnStergeProdus.BackColor = Color.FromArgb(214, 198, 168);
            btnStergeProdus.FlatStyle = FlatStyle.Flat;
            btnStergeProdus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStergeProdus.Location = new Point(270, 406);
            btnStergeProdus.Name = "btnStergeProdus";
            btnStergeProdus.Size = new Size(71, 29);
            btnStergeProdus.TabIndex = 4;
            btnStergeProdus.Text = "Sterge";
            btnStergeProdus.UseVisualStyleBackColor = false;
            btnStergeProdus.Click += btnStergeProdus_Click;
            // 
            // btnModificaPret
            // 
            btnModificaPret.BackColor = Color.FromArgb(214, 198, 168);
            btnModificaPret.FlatStyle = FlatStyle.Flat;
            btnModificaPret.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificaPret.Location = new Point(347, 407);
            btnModificaPret.Name = "btnModificaPret";
            btnModificaPret.Size = new Size(118, 29);
            btnModificaPret.TabIndex = 5;
            btnModificaPret.Text = "Modifica pret";
            btnModificaPret.UseVisualStyleBackColor = false;
            btnModificaPret.Click += btnModificaPret_Click;
            // 
            // btnStergereCat
            // 
            btnStergereCat.BackColor = Color.White;
            btnStergereCat.FlatStyle = FlatStyle.Flat;
            btnStergereCat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStergereCat.ForeColor = Color.Black;
            btnStergereCat.Location = new Point(12, 402);
            btnStergereCat.Name = "btnStergereCat";
            btnStergereCat.Size = new Size(171, 29);
            btnStergereCat.TabIndex = 6;
            btnStergereCat.Text = "Sterge Categorie";
            btnStergereCat.UseVisualStyleBackColor = false;
            btnStergereCat.Click += btnStergereCat_Click;
            // 
            // EditareMeniuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(478, 450);
            Controls.Add(btnStergereCat);
            Controls.Add(btnModificaPret);
            Controls.Add(btnStergeProdus);
            Controls.Add(btnAdaugaProdus);
            Controls.Add(btnAdaugaCategorie);
            Controls.Add(lstProduse);
            Controls.Add(lstCategorii);
            Name = "EditareMeniuForm";
            Text = "EditareMeniuForm";
            Load += EditareMeniuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstCategorii;
        private ListBox lstProduse;
        private Button btnAdaugaCategorie;
        private Button btnAdaugaProdus;
        private Button btnStergeProdus;
        private Button btnModificaPret;
        private Button btnStergereCat;
    }
}