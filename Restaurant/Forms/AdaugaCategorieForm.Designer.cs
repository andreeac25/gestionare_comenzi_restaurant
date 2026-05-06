namespace Restaurant.Forms
{
    partial class AdaugaCategorieForm
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
            txtNumeCategorie = new TextBox();
            btnAdauga = new Button();
            SuspendLayout();
            // 
            // txtNumeCategorie
            // 
            txtNumeCategorie.Location = new Point(43, 43);
            txtNumeCategorie.Name = "txtNumeCategorie";
            txtNumeCategorie.Size = new Size(158, 27);
            txtNumeCategorie.TabIndex = 0;
            // 
            // btnAdauga
            // 
            btnAdauga.BackColor = Color.FromArgb(214, 198, 168);
            btnAdauga.FlatStyle = FlatStyle.Flat;
            btnAdauga.ForeColor = Color.Black;
            btnAdauga.Location = new Point(68, 106);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(94, 29);
            btnAdauga.TabIndex = 1;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = false;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // AdaugaCategorieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(241, 169);
            Controls.Add(btnAdauga);
            Controls.Add(txtNumeCategorie);
            Name = "AdaugaCategorieForm";
            Text = "AdaugaCategorieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeCategorie;
        private Button btnAdauga;
    }
}