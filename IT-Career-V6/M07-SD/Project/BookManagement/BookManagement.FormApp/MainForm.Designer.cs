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
            components = new System.ComponentModel.Container();
            btnGanres = new Button();
            btnBooks = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnSearch = new Button();
            txtSearch = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnGanres
            // 
            btnGanres.Location = new Point(43, 33);
            btnGanres.Name = "btnGanres";
            btnGanres.Size = new Size(167, 127);
            btnGanres.TabIndex = 0;
            btnGanres.Text = "Ganres";
            btnGanres.UseVisualStyleBackColor = true;
            btnGanres.Click += btnGanres_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(216, 33);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(190, 127);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(454, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(369, 364);
            listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(77, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 213);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(40, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 50);
            panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(104, 14);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Author";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 14);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Title";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(36, 139);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(240, 55);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 450);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(btnBooks);
            Controls.Add(btnGanres);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGanres;
        private Button btnBooks;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ErrorProvider errorProvider1;
    }
}