namespace BookManagement.FormApp
{
    partial class BookGanresForm
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
            lblTitle = new Label();
            lblAuthor = new Label();
            checkedListBox1 = new CheckedListBox();
            btnUpdateGanres = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(54, 41);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(54, 91);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(65, 28);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "label1";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(241, 41);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(352, 381);
            checkedListBox1.TabIndex = 2;
            // 
            // btnUpdateGanres
            // 
            btnUpdateGanres.Location = new Point(43, 180);
            btnUpdateGanres.Name = "btnUpdateGanres";
            btnUpdateGanres.Size = new Size(156, 64);
            btnUpdateGanres.TabIndex = 3;
            btnUpdateGanres.Text = "Update";
            btnUpdateGanres.UseVisualStyleBackColor = true;
            btnUpdateGanres.Click += btnUpdateGanres_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(46, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BookGanresForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 451);
            Controls.Add(btnExit);
            Controls.Add(btnUpdateGanres);
            Controls.Add(checkedListBox1);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BookGanresForm";
            Text = "BookGanresForm";
            Load += BookGanresForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private CheckedListBox checkedListBox1;
        private Button btnUpdateGanres;
        private Button btnExit;
    }
}