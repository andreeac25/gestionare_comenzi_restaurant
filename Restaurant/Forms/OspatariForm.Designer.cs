namespace Restaurant.Forms
{
    partial class OspatariForm
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
            lstOspatari = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lstOspatari
            // 
            lstOspatari.BackColor = Color.FromArgb(244, 235, 221);
            lstOspatari.FormattingEnabled = true;
            lstOspatari.Location = new Point(23, 12);
            lstOspatari.Name = "lstOspatari";
            lstOspatari.Size = new Size(271, 304);
            lstOspatari.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(214, 198, 168);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(314, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adauga";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(214, 198, 168);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(314, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sterge";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(214, 198, 168);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(314, 117);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Editeaza";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // OspatariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(424, 332);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstOspatari);
            Name = "OspatariForm";
            Text = "OspatariForm";
            Load += OspatariForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOspatari;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
    }
}