namespace Restaurant.Forms
{
    partial class EditPretForm
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
            lblProdus = new Label();
            txtPret = new TextBox();
            label1 = new Label();
            lblPretVechi = new Label();
            btnSalveaza = new Button();
            SuspendLayout();
            // 
            // lblProdus
            // 
            lblProdus.AutoSize = true;
            lblProdus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdus.ForeColor = Color.FromArgb(244, 235, 221);
            lblProdus.Location = new Point(72, 23);
            lblProdus.Name = "lblProdus";
            lblProdus.Size = new Size(140, 28);
            lblProdus.TabIndex = 0;
            lblProdus.Text = "Nume Produs";
            // 
            // txtPret
            // 
            txtPret.Location = new Point(123, 112);
            txtPret.Name = "txtPret";
            txtPret.Size = new Size(100, 27);
            txtPret.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 235, 221);
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 2;
            label1.Text = "Pret Nou: ";
            // 
            // lblPretVechi
            // 
            lblPretVechi.AutoSize = true;
            lblPretVechi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPretVechi.ForeColor = Color.FromArgb(244, 235, 221);
            lblPretVechi.Location = new Point(12, 62);
            lblPretVechi.Name = "lblPretVechi";
            lblPretVechi.Size = new Size(49, 28);
            lblPretVechi.TabIndex = 4;
            lblPretVechi.Text = "pret";
            // 
            // btnSalveaza
            // 
            btnSalveaza.BackColor = Color.FromArgb(214, 198, 168);
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Location = new Point(88, 183);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(94, 29);
            btnSalveaza.TabIndex = 5;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnSalveaza_Click;
            // 
            // EditPretForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(272, 237);
            Controls.Add(btnSalveaza);
            Controls.Add(lblPretVechi);
            Controls.Add(label1);
            Controls.Add(txtPret);
            Controls.Add(lblProdus);
            Name = "EditPretForm";
            Text = "EditPretForm";
            Load += EditPretForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProdus;
        private TextBox txtPret;
        private Label label1;
        private Label lblPretVechi;
        private Button btnSalveaza;
    }
}