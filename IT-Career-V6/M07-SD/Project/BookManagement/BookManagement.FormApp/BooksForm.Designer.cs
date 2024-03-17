namespace BookManagement.FormApp
{
    partial class BooksForm
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
            bookBindingSource = new BindingSource(components);
            booksServiceBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ganresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ImageUrl = new DataGridViewTextBoxColumn();
            btnPrevious = new Button();
            btnNext = new Button();
            button1 = new Button();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbAuthor = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtPrice = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            btnAction = new Button();
            label5 = new Label();
            label6 = new Label();
            lblCount = new Label();
            lblPages = new Label();
            pictureBox1 = new PictureBox();
            cmbOrderBy = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbOrder = new ComboBox();
            btnGanres = new Button();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Data.Models.Book);
            // 
            // booksServiceBindingSource
            // 
            booksServiceBindingSource.DataSource = typeof(Services.BooksService);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, ganresDataGridViewTextBoxColumn, ImageUrl });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(702, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // ganresDataGridViewTextBoxColumn
            // 
            ganresDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ganresDataGridViewTextBoxColumn.DataPropertyName = "Ganres";
            ganresDataGridViewTextBoxColumn.HeaderText = "Ganres";
            ganresDataGridViewTextBoxColumn.MinimumWidth = 6;
            ganresDataGridViewTextBoxColumn.Name = "ganresDataGridViewTextBoxColumn";
            // 
            // ImageUrl
            // 
            ImageUrl.DataPropertyName = "ImageUrl";
            ImageUrl.HeaderText = "ImageUrl";
            ImageUrl.MinimumWidth = 6;
            ImageUrl.Name = "ImageUrl";
            ImageUrl.Visible = false;
            ImageUrl.Width = 125;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(702, 473);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(108, 90);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(816, 473);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(133, 90);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1176, 704);
            button1.Name = "button1";
            button1.Size = new Size(119, 55);
            button1.TabIndex = 3;
            button1.Text = "Seed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(434, 88);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(228, 34);
            txtTitle.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 94);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 5;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 6;
            label2.Text = "Author";
            // 
            // cmbAuthor
            // 
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(434, 137);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(228, 36);
            cmbAuthor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 196);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 8;
            label3.Text = "Year";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(434, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 34);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(434, 242);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 34);
            txtPrice.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 245);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDelete);
            panel1.Controls.Add(rbUpdate);
            panel1.Controls.Add(rbAdd);
            panel1.Location = new Point(351, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 41);
            panel1.TabIndex = 12;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(208, 3);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(89, 32);
            rbDelete.TabIndex = 2;
            rbDelete.TabStop = true;
            rbDelete.Text = "Delete";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbDelete_CheckedChanged;
            // 
            // rbUpdate
            // 
            rbUpdate.AutoSize = true;
            rbUpdate.Location = new Point(92, 3);
            rbUpdate.Name = "rbUpdate";
            rbUpdate.Size = new Size(98, 32);
            rbUpdate.TabIndex = 1;
            rbUpdate.TabStop = true;
            rbUpdate.Text = "Update";
            rbUpdate.UseVisualStyleBackColor = true;
            rbUpdate.CheckedChanged += rbUpdate_CheckedChanged;
            // 
            // rbAdd
            // 
            rbAdd.AutoSize = true;
            rbAdd.Location = new Point(16, 6);
            rbAdd.Name = "rbAdd";
            rbAdd.Size = new Size(70, 32);
            rbAdd.TabIndex = 0;
            rbAdd.TabStop = true;
            rbAdd.Text = "Add";
            rbAdd.UseVisualStyleBackColor = true;
            rbAdd.CheckedChanged += rbAdd_CheckedChanged;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(351, 358);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(187, 95);
            btnAction.TabIndex = 13;
            btnAction.Text = "Add";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1372, 479);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 14;
            label5.Text = "Books count:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1430, 517);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 15;
            label6.Text = "Pages:";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(1517, 479);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(65, 28);
            lblCount.TabIndex = 16;
            lblCount.Text = "label7";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(1517, 517);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(65, 28);
            lblPages.TabIndex = 17;
            lblPages.Text = "label7";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // cmbOrderBy
            // 
            cmbOrderBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrderBy.FormattingEnabled = true;
            cmbOrderBy.Location = new Point(1100, 479);
            cmbOrderBy.Name = "cmbOrderBy";
            cmbOrderBy.Size = new Size(223, 36);
            cmbOrderBy.TabIndex = 19;
            cmbOrderBy.SelectedIndexChanged += cmbOrderBy_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(992, 483);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 20;
            label7.Text = "Order by";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1019, 535);
            label8.Name = "label8";
            label8.Size = new Size(63, 28);
            label8.TabIndex = 21;
            label8.Text = "Order";
            // 
            // cmbOrder
            // 
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Items.AddRange(new object[] { "ASC", "DESC" });
            cmbOrder.Location = new Point(1100, 527);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Size = new Size(223, 36);
            cmbOrder.TabIndex = 22;
            cmbOrder.SelectedIndexChanged += cmbOrder_SelectedIndexChanged;
            // 
            // btnGanres
            // 
            btnGanres.Location = new Point(544, 361);
            btnGanres.Name = "btnGanres";
            btnGanres.Size = new Size(136, 92);
            btnGanres.TabIndex = 23;
            btnGanres.Text = "Ganres";
            btnGanres.UseVisualStyleBackColor = true;
            btnGanres.Click += btnGanres_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 771);
            Controls.Add(btnGanres);
            Controls.Add(cmbOrder);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbOrderBy);
            Controls.Add(pictureBox1);
            Controls.Add(lblPages);
            Controls.Add(lblCount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAction);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(cmbAuthor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(button1);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "BooksForm";
            Text = "BooksForm";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bookBindingSource;
        private BindingSource booksServiceBindingSource;
        private DataGridView dataGridView1;
        private Button btnPrevious;
        private Button btnNext;
        private Button button1;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private ComboBox cmbAuthor;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtPrice;
        private Label label4;
        private Panel panel1;
        private RadioButton rbDelete;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private Button btnAction;
        private Label label5;
        private Label label6;
        private Label lblCount;
        private Label lblPages;
        private PictureBox pictureBox1;
        private ComboBox cmbOrderBy;
        private Label label7;
        private Label label8;
        private ComboBox cmbOrder;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ganresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ImageUrl;
        private Button btnGanres;
    }
}