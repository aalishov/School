namespace BookManagement.FormApp
{
    partial class GanresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GanresForm));
            listBox1 = new ListBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageInfo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            rdBtnDesc = new RadioButton();
            rdBtnAsc = new RadioButton();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            rbDelete = new RadioButton();
            rbUpdate = new RadioButton();
            rbAdd = new RadioButton();
            btnAction = new Button();
            groupBox1 = new GroupBox();
            lblCount = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(563, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(399, 452);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.Location = new Point(564, 644);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(95, 59);
            btnPrevious.TabIndex = 1;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.Location = new Point(683, 644);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(95, 59);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(805, 659);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(65, 28);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "label1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rdBtnDesc);
            panel1.Controls.Add(rdBtnAsc);
            panel1.Location = new Point(564, 574);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 56);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 2;
            label1.Text = "Sort: ";
            // 
            // rdBtnDesc
            // 
            rdBtnDesc.AutoSize = true;
            rdBtnDesc.Location = new Point(244, 13);
            rdBtnDesc.Name = "rdBtnDesc";
            rdBtnDesc.Size = new Size(74, 32);
            rdBtnDesc.TabIndex = 1;
            rdBtnDesc.TabStop = true;
            rdBtnDesc.Text = "Desc";
            rdBtnDesc.UseVisualStyleBackColor = true;
            rdBtnDesc.CheckedChanged += rdBtnDesc_CheckedChanged;
            // 
            // rdBtnAsc
            // 
            rdBtnAsc.AutoSize = true;
            rdBtnAsc.Location = new Point(143, 13);
            rdBtnAsc.Name = "rdBtnAsc";
            rdBtnAsc.Size = new Size(63, 32);
            rdBtnAsc.TabIndex = 0;
            rdBtnAsc.TabStop = true;
            rdBtnAsc.Text = "Asc";
            rdBtnAsc.UseVisualStyleBackColor = true;
            rdBtnAsc.CheckedChanged += rdBtnAsc_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "5", "10", "15", "20" });
            comboBox1.Location = new Point(893, 651);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 397);
            label2.Name = "label2";
            label2.Size = new Size(29, 28);
            label2.TabIndex = 6;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 456);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(197, 399);
            txtId.Name = "txtId";
            txtId.Size = new Size(247, 34);
            txtId.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 450);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 34);
            txtName.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbDelete);
            panel2.Controls.Add(rbUpdate);
            panel2.Controls.Add(rbAdd);
            panel2.Location = new Point(103, 518);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 72);
            panel2.TabIndex = 10;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Location = new Point(252, 18);
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
            rbUpdate.Location = new Point(126, 18);
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
            rbAdd.Location = new Point(28, 18);
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
            btnAction.Location = new Point(156, 619);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(277, 84);
            btnAction.TabIndex = 11;
            btnAction.Text = "button1";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCount);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(78, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 267);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Statistics";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(193, 57);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(65, 28);
            lblCount.TabIndex = 1;
            lblCount.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 57);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 0;
            label4.Text = "Ganres count: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(395, 9);
            label5.Name = "label5";
            label5.Size = new Size(264, 78);
            label5.TabIndex = 13;
            label5.Text = "GANRES";
            // 
            // GanresForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 753);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnPrevious);
            Controls.Add(btnAction);
            Controls.Add(panel2);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(lblPageInfo);
            Controls.Add(btnNext);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(1054, 800);
            MinimumSize = new Size(1054, 800);
            Name = "GanresForm";
            Text = "GanresForm";
            Load += GanresForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageInfo;
        private Panel panel1;
        private RadioButton rdBtnDesc;
        private RadioButton rdBtnAsc;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private Panel panel2;
        private RadioButton rbUpdate;
        private RadioButton rbAdd;
        private RadioButton rbDelete;
        private Button btnAction;
        private GroupBox groupBox1;
        private Label lblCount;
        private Label label4;
        private Label label5;
    }
}