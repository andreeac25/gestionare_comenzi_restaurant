namespace Restaurant.Forms
{
    partial class IstoricForm
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
            dgvNote = new DataGridView();
            dgvRapoarte = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRapoarte).BeginInit();
            SuspendLayout();
            // 
            // dgvNote
            // 
            dgvNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNote.Location = new Point(29, 104);
            dgvNote.Name = "dgvNote";
            dgvNote.RowHeadersWidth = 51;
            dgvNote.Size = new Size(803, 305);
            dgvNote.TabIndex = 0;
            // 
            // dgvRapoarte
            // 
            dgvRapoarte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapoarte.Location = new Point(29, 446);
            dgvRapoarte.Name = "dgvRapoarte";
            dgvRapoarte.RowHeadersWidth = 51;
            dgvRapoarte.Size = new Size(931, 333);
            dgvRapoarte.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 155, 90);
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 2;
            label1.Text = "Istoric";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 235, 221);
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 3;
            label2.Text = "Note de plata";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(244, 235, 221);
            label3.Location = new Point(29, 412);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 4;
            label3.Text = "Rapoarte";
            // 
            // IstoricForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 58, 68);
            ClientSize = new Size(990, 791);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRapoarte);
            Controls.Add(dgvNote);
            Name = "IstoricForm";
            Text = "IstoricForm";
            Load += IstoricForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRapoarte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNote;
        private DataGridView dgvRapoarte;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}