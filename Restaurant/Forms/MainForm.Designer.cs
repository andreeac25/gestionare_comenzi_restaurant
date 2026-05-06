namespace Restaurant.Forms
{
    partial class MainForm
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
            btnSettings = new Button();
            panelMese = new Panel();
            btnMasa1 = new Button();
            btnMasa2 = new Button();
            btnMasa10 = new Button();
            btnMasa3 = new Button();
            btnMasa9 = new Button();
            btnMasa4 = new Button();
            btnMasa8 = new Button();
            btnMasa5 = new Button();
            btnMasa7 = new Button();
            btnMasa6 = new Button();
            lblUser = new Label();
            btnRaport = new Button();
            btnLogout = new Button();
            panelMese.SuspendLayout();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.AccessibleRole = AccessibleRole.None;
            btnSettings.BackColor = Color.FromArgb(214, 198, 168);
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(31, 38, 44);
            btnSettings.Location = new Point(694, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(94, 29);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "Setari";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelMese
            // 
            panelMese.Controls.Add(btnMasa1);
            panelMese.Controls.Add(btnMasa2);
            panelMese.Controls.Add(btnMasa10);
            panelMese.Controls.Add(btnMasa3);
            panelMese.Controls.Add(btnMasa9);
            panelMese.Controls.Add(btnMasa4);
            panelMese.Controls.Add(btnMasa8);
            panelMese.Controls.Add(btnMasa5);
            panelMese.Controls.Add(btnMasa7);
            panelMese.Controls.Add(btnMasa6);
            panelMese.Location = new Point(21, 60);
            panelMese.Name = "panelMese";
            panelMese.Size = new Size(758, 343);
            panelMese.TabIndex = 11;
            // 
            // btnMasa1
            // 
            btnMasa1.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa1.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa1.Location = new Point(69, 15);
            btnMasa1.Name = "btnMasa1";
            btnMasa1.Size = new Size(80, 60);
            btnMasa1.TabIndex = 0;
            btnMasa1.Tag = "id";
            btnMasa1.Text = "1";
            btnMasa1.UseVisualStyleBackColor = false;
            btnMasa1.Click += Masa_Click;
            // 
            // btnMasa2
            // 
            btnMasa2.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa2.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa2.Location = new Point(208, 71);
            btnMasa2.Name = "btnMasa2";
            btnMasa2.Size = new Size(80, 60);
            btnMasa2.TabIndex = 1;
            btnMasa2.Tag = "id";
            btnMasa2.Text = "2";
            btnMasa2.UseVisualStyleBackColor = false;
            btnMasa2.Click += Masa_Click;
            // 
            // btnMasa10
            // 
            btnMasa10.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa10.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa10.Location = new Point(609, 199);
            btnMasa10.Name = "btnMasa10";
            btnMasa10.Size = new Size(80, 60);
            btnMasa10.TabIndex = 9;
            btnMasa10.Tag = "id";
            btnMasa10.Text = "10";
            btnMasa10.UseVisualStyleBackColor = false;
            btnMasa10.Click += Masa_Click;
            // 
            // btnMasa3
            // 
            btnMasa3.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa3.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa3.Location = new Point(348, 15);
            btnMasa3.Name = "btnMasa3";
            btnMasa3.Size = new Size(80, 60);
            btnMasa3.TabIndex = 2;
            btnMasa3.Tag = "id";
            btnMasa3.Text = "3";
            btnMasa3.UseVisualStyleBackColor = false;
            btnMasa3.Click += Masa_Click;
            // 
            // btnMasa9
            // 
            btnMasa9.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa9.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa9.Location = new Point(483, 248);
            btnMasa9.Name = "btnMasa9";
            btnMasa9.Size = new Size(80, 60);
            btnMasa9.TabIndex = 8;
            btnMasa9.Tag = "id";
            btnMasa9.Text = "9";
            btnMasa9.UseVisualStyleBackColor = false;
            btnMasa9.Click += Masa_Click;
            // 
            // btnMasa4
            // 
            btnMasa4.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa4.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa4.Location = new Point(483, 71);
            btnMasa4.Name = "btnMasa4";
            btnMasa4.Size = new Size(80, 60);
            btnMasa4.TabIndex = 4;
            btnMasa4.Tag = "id";
            btnMasa4.Text = "4";
            btnMasa4.UseVisualStyleBackColor = false;
            btnMasa4.Click += Masa_Click;
            // 
            // btnMasa8
            // 
            btnMasa8.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa8.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa8.Location = new Point(348, 199);
            btnMasa8.Name = "btnMasa8";
            btnMasa8.Size = new Size(80, 60);
            btnMasa8.TabIndex = 7;
            btnMasa8.Tag = "id";
            btnMasa8.Text = "8";
            btnMasa8.UseVisualStyleBackColor = false;
            btnMasa8.Click += Masa_Click;
            // 
            // btnMasa5
            // 
            btnMasa5.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa5.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa5.Location = new Point(609, 15);
            btnMasa5.Name = "btnMasa5";
            btnMasa5.Size = new Size(80, 60);
            btnMasa5.TabIndex = 4;
            btnMasa5.Tag = "id";
            btnMasa5.Text = "5";
            btnMasa5.UseVisualStyleBackColor = false;
            btnMasa5.Click += Masa_Click;
            // 
            // btnMasa7
            // 
            btnMasa7.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa7.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa7.Location = new Point(208, 248);
            btnMasa7.Name = "btnMasa7";
            btnMasa7.Size = new Size(80, 60);
            btnMasa7.TabIndex = 6;
            btnMasa7.Tag = "id";
            btnMasa7.Text = "7";
            btnMasa7.UseVisualStyleBackColor = false;
            btnMasa7.Click += Masa_Click;
            // 
            // btnMasa6
            // 
            btnMasa6.BackColor = Color.FromArgb(244, 235, 221);
            btnMasa6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasa6.ForeColor = Color.FromArgb(107, 74, 46);
            btnMasa6.Location = new Point(69, 199);
            btnMasa6.Name = "btnMasa6";
            btnMasa6.Size = new Size(80, 60);
            btnMasa6.TabIndex = 5;
            btnMasa6.Tag = "id";
            btnMasa6.Text = "6";
            btnMasa6.UseVisualStyleBackColor = false;
            btnMasa6.Click += Masa_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(244, 235, 221);
            lblUser.Location = new Point(21, 12);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 31);
            lblUser.TabIndex = 12;
            lblUser.Text = "label1";
            // 
            // btnRaport
            // 
            btnRaport.BackColor = Color.FromArgb(214, 198, 168);
            btnRaport.FlatStyle = FlatStyle.Popup;
            btnRaport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaport.Location = new Point(630, 409);
            btnRaport.Margin = new Padding(0);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(149, 29);
            btnRaport.TabIndex = 13;
            btnRaport.Text = "Trimite Raport";
            btnRaport.UseVisualStyleBackColor = false;
            btnRaport.Click += btnRaport_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.FlatAppearance.BorderColor = Color.Red;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(21, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Delogare";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnRaport);
            Controls.Add(lblUser);
            Controls.Add(panelMese);
            Controls.Add(btnSettings);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMese.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSettings;
        private Panel panelMese;
        private Button btnMasa1;
        private Button btnMasa2;
        private Button btnMasa10;
        private Button btnMasa3;
        private Button btnMasa9;
        private Button btnMasa4;
        private Button btnMasa8;
        private Button btnMasa5;
        private Button btnMasa7;
        private Button btnMasa6;
        private Label lblUser;
        private Button btnRaport;
        private Button btnLogout;
    }
}