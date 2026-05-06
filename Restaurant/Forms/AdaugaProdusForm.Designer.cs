namespace Restaurant.Forms
{
    partial class AdaugaProdusForm
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
            txtNume = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPret = new TextBox();
            btnSalveaza = new Button();
            SuspendLayout();
            // 
            // txtNume
            // 
            txtNume.Location = new Point(101, 32);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(211, 27);
            txtNume.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 235, 221);
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 1;
            label1.Text = "Nume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 235, 221);
            label2.Location = new Point(21, 84);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 2;
            label2.Text = "Pret:";
            // 
            // txtPret
            // 
            txtPret.Location = new Point(101, 88);
            txtPret.Name = "txtPret";
            txtPret.Size = new Size(125, 27);
            txtPret.TabIndex = 3;
            // 
            // btnSalveaza
            // 
            btnSalveaza.BackColor = Color.FromArgb(214, 198, 168);
            btnSalveaza.FlatStyle = FlatStyle.Flat;
            btnSalveaza.Location = new Point(260, 163);
            btnSalveaza.Name = "btnSalveaza";
            btnSalveaza.Size = new Size(94, 29);
            btnSalveaza.TabIndex = 4;
            btnSalveaza.Text = "Salveaza";
            btnSalveaza.UseVisualStyleBackColor = false;
            btnSalveaza.Click += btnAdaugaProdus_Click;
            // 
            // AdaugaProdusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(379, 216);
            Controls.Add(btnSalveaza);
            Controls.Add(txtPret);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNume);
            Name = "AdaugaProdusForm";
            Text = "AdaugaProdusForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNume;
        private Label label1;
        private Label label2;
        private TextBox txtPret;
        private Button btnSalveaza;
    }
}