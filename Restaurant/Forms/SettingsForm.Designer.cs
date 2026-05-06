namespace Restaurant.Forms
{
    partial class SettingsForm
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
            btnEditateMeniu = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 155, 90);
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // btnEditateMeniu
            // 
            btnEditateMeniu.BackColor = Color.FromArgb(244, 235, 221);
            btnEditateMeniu.FlatStyle = FlatStyle.Flat;
            btnEditateMeniu.ForeColor = Color.FromArgb(31, 38, 44);
            btnEditateMeniu.Location = new Point(12, 74);
            btnEditateMeniu.Name = "btnEditateMeniu";
            btnEditateMeniu.Size = new Size(255, 29);
            btnEditateMeniu.TabIndex = 2;
            btnEditateMeniu.Text = "Editeaza Meniu";
            btnEditateMeniu.UseVisualStyleBackColor = false;
            btnEditateMeniu.Click += btnEditateMeniu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 235, 221);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(31, 38, 44);
            button1.Location = new Point(12, 127);
            button1.Name = "button1";
            button1.Size = new Size(255, 29);
            button1.TabIndex = 3;
            button1.Text = "Gestioneaza Ospatari";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGestiuneOsp_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 38, 44);
            ClientSize = new Size(279, 196);
            Controls.Add(button1);
            Controls.Add(btnEditateMeniu);
            Controls.Add(label1);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEditateMeniu;
        private Button button1;
    }
}