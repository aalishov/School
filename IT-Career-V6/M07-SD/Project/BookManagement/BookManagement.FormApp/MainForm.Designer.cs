namespace BookManagement.FormApp
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
            btnGanres = new Button();
            btnBooks = new Button();
            SuspendLayout();
            // 
            // btnGanres
            // 
            btnGanres.Location = new Point(54, 33);
            btnGanres.Name = "btnGanres";
            btnGanres.Size = new Size(167, 127);
            btnGanres.TabIndex = 0;
            btnGanres.Text = "Ganres";
            btnGanres.UseVisualStyleBackColor = true;
            btnGanres.Click += btnGanres_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(241, 33);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(190, 127);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBooks);
            Controls.Add(btnGanres);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGanres;
        private Button btnBooks;
    }
}