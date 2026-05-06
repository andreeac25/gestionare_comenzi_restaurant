namespace Restaurant.Forms
{
    partial class ComandaForm
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
            panelCategorii = new FlowLayoutPanel();
            panelProduse = new FlowLayoutPanel();
            panelBon = new FlowLayoutPanel();
            lblTotal = new Label();
            btnTrimite = new Button();
            btnNota = new Button();
            btnIncaseaza = new Button();
            lblMasa = new Label();
            SuspendLayout();
            // 
            // panelCategorii
            // 
            panelCategorii.AutoScroll = true;
            panelCategorii.Location = new Point(2, 3);
            panelCategorii.Name = "panelCategorii";
            panelCategorii.Size = new Size(162, 465);
            panelCategorii.TabIndex = 0;
            // 
            // panelProduse
            // 
            panelProduse.AutoScroll = true;
            panelProduse.Location = new Point(170, 3);
            panelProduse.Name = "panelProduse";
            panelProduse.Size = new Size(415, 465);
            panelProduse.TabIndex = 1;
            // 
            // panelBon
            // 
            panelBon.AutoScroll = true;
            panelBon.BackColor = Color.FromArgb(244, 235, 221);
            panelBon.Location = new Point(591, 37);
            panelBon.Name = "panelBon";
            panelBon.Size = new Size(274, 346);
            panelBon.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(591, 386);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 28);
            lblTotal.TabIndex = 0;
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnTrimite
            // 
            btnTrimite.BackColor = Color.FromArgb(119, 221, 119);
            btnTrimite.FlatAppearance.BorderColor = Color.Black;
            btnTrimite.FlatAppearance.BorderSize = 0;
            btnTrimite.FlatStyle = FlatStyle.Flat;
            btnTrimite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrimite.ForeColor = Color.Black;
            btnTrimite.Location = new Point(591, 431);
            btnTrimite.Name = "btnTrimite";
            btnTrimite.Size = new Size(90, 29);
            btnTrimite.TabIndex = 0;
            btnTrimite.Text = "Trimite";
            btnTrimite.UseVisualStyleBackColor = false;
            btnTrimite.Click += btnTrimite_Click;
            // 
            // btnNota
            // 
            btnNota.BackColor = Color.FromArgb(178, 186, 187);
            btnNota.FlatStyle = FlatStyle.Flat;
            btnNota.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNota.ForeColor = Color.Black;
            btnNota.Location = new Point(689, 431);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(80, 29);
            btnNota.TabIndex = 3;
            btnNota.Text = "Nota";
            btnNota.UseVisualStyleBackColor = false;
            btnNota.Click += btnNota_Click;
            // 
            // btnIncaseaza
            // 
            btnIncaseaza.BackColor = Color.FromArgb(255, 105, 97);
            btnIncaseaza.FlatStyle = FlatStyle.Flat;
            btnIncaseaza.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncaseaza.ForeColor = Color.Black;
            btnIncaseaza.Location = new Point(775, 431);
            btnIncaseaza.Name = "btnIncaseaza";
            btnIncaseaza.Size = new Size(90, 29);
            btnIncaseaza.TabIndex = 4;
            btnIncaseaza.Text = "Incaseaza";
            btnIncaseaza.UseVisualStyleBackColor = false;
            btnIncaseaza.Click += button2_Click;
            // 
            // lblMasa
            // 
            lblMasa.AutoSize = true;
            lblMasa.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasa.ForeColor = SystemColors.ButtonHighlight;
            lblMasa.Location = new Point(591, 9);
            lblMasa.Name = "lblMasa";
            lblMasa.Size = new Size(57, 25);
            lblMasa.TabIndex = 5;
            lblMasa.Text = "Masa";
            // 
            // ComandaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(871, 472);
            Controls.Add(lblMasa);
            Controls.Add(btnIncaseaza);
            Controls.Add(btnNota);
            Controls.Add(btnTrimite);
            Controls.Add(lblTotal);
            Controls.Add(panelBon);
            Controls.Add(panelProduse);
            Controls.Add(panelCategorii);
            Name = "ComandaForm";
            Text = "ComandaForm";
            Load += ComandaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelCategorii;
        private FlowLayoutPanel panelProduse;
        private FlowLayoutPanel panelBon;
        private Label lblTotal;
        private Button btnTrimite;
        private Button btnNota;
        private Button btnIncaseaza;
        private Label lblMasa;
    }
}