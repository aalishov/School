namespace DR2_1901181004
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioSearch = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBoxList2 = new System.Windows.Forms.CheckBox();
            this.checkBoxList1 = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(57, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(461, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(299, 164);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(574, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Затваряне";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.Location = new System.Drawing.Point(130, 207);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(118, 24);
            this.radioEdit.TabIndex = 3;
            this.radioEdit.TabStop = true;
            this.radioEdit.Text = "Редактиране";
            this.radioEdit.UseVisualStyleBackColor = true;
            this.radioEdit.CheckedChanged += new System.EventHandler(this.radioEdit_CheckedChanged);
            // 
            // radioSearch
            // 
            this.radioSearch.AutoSize = true;
            this.radioSearch.Location = new System.Drawing.Point(296, 207);
            this.radioSearch.Name = "radioSearch";
            this.radioSearch.Size = new System.Drawing.Size(88, 24);
            this.radioSearch.TabIndex = 4;
            this.radioSearch.TabStop = true;
            this.radioSearch.Text = "Търсене";
            this.radioSearch.UseVisualStyleBackColor = true;
            this.radioSearch.CheckedChanged += new System.EventHandler(this.radioSearch_CheckedChanged);
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(436, 207);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(105, 24);
            this.radioDelete.TabIndex = 5;
            this.radioDelete.TabStop = true;
            this.radioDelete.Text = "Изтриване";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtEdit);
            this.groupBox1.Location = new System.Drawing.Point(57, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактиране на избрания запис";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(38, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 37);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(24, 49);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(193, 27);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnNewSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.checkBoxList2);
            this.groupBox2.Controls.Add(this.checkBoxList1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(384, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Търсене на запис";
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Location = new System.Drawing.Point(241, 100);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(118, 58);
            this.btnNewSearch.TabIndex = 5;
            this.btnNewSearch.Text = "Ново търсене";
            this.btnNewSearch.UseVisualStyleBackColor = true;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Търсене";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBoxList2
            // 
            this.checkBoxList2.AutoSize = true;
            this.checkBoxList2.Location = new System.Drawing.Point(6, 134);
            this.checkBoxList2.Name = "checkBoxList2";
            this.checkBoxList2.Size = new System.Drawing.Size(183, 24);
            this.checkBoxList2.TabIndex = 3;
            this.checkBoxList2.Text = "Втора списъчна кутия";
            this.checkBoxList2.UseVisualStyleBackColor = true;
            // 
            // checkBoxList1
            // 
            this.checkBoxList1.AutoSize = true;
            this.checkBoxList1.Location = new System.Drawing.Point(6, 100);
            this.checkBoxList1.Name = "checkBoxList1";
            this.checkBoxList1.Size = new System.Drawing.Size(187, 24);
            this.checkBoxList1.TabIndex = 2;
            this.checkBoxList1.Text = "Първа списъчна кутия";
            this.checkBoxList1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioDelete);
            this.Controls.Add(this.radioSearch);
            this.Controls.Add(this.radioEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioSearch;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBoxList2;
        private System.Windows.Forms.CheckBox checkBoxList1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}