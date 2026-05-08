namespace Restaurant.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 235, 221);
            label1.Location = new Point(227, 187);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Utilizator:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 235, 221);
            label2.Location = new Point(227, 228);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 1;
            label2.Text = "Parola:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(342, 191);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(214, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(342, 232);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(214, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(200, 155, 90);
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(31, 38, 44);
            btnLogin.Location = new Point(315, 282);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 155, 90);
            label3.Location = new Point(292, 104);
            label3.Name = "label3";
            label3.Size = new Size(196, 50);
            label3.TabIndex = 5;
            label3.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label label3;
    }
}
