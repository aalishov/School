namespace KR_1901181004
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioCombo = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioDel = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведете данни:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(25, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 27);
            this.txtInput.TabIndex = 1;
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Location = new System.Drawing.Point(25, 105);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(139, 24);
            this.radioList.TabIndex = 2;
            this.radioList.TabStop = true;
            this.radioList.Text = "Списъчна кутия";
            this.radioList.UseVisualStyleBackColor = true;
            // 
            // radioCombo
            // 
            this.radioCombo.AutoSize = true;
            this.radioCombo.Location = new System.Drawing.Point(25, 154);
            this.radioCombo.Name = "radioCombo";
            this.radioCombo.Size = new System.Drawing.Size(170, 24);
            this.radioCombo.TabIndex = 3;
            this.radioCombo.TabStop = true;
            this.radioCombo.Text = "Комбинирана кутия";
            this.radioCombo.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(25, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 204);
            this.listBox1.TabIndex = 4;
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEdit);
            this.groupBox1.Controls.Add(this.radioDel);
            this.groupBox1.Controls.Add(this.radioAdd);
            this.groupBox1.Location = new System.Drawing.Point(246, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.Location = new System.Drawing.Point(37, 125);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(17, 16);
            this.radioEdit.TabIndex = 5;
            this.radioEdit.TabStop = true;
            this.radioEdit.UseVisualStyleBackColor = true;
            this.radioEdit.CheckedChanged += new System.EventHandler(this.radioEdit_CheckedChanged);
            // 
            // radioDel
            // 
            this.radioDel.AutoSize = true;
            this.radioDel.Location = new System.Drawing.Point(37, 75);
            this.radioDel.Name = "radioDel";
            this.radioDel.Size = new System.Drawing.Size(17, 16);
            this.radioDel.TabIndex = 4;
            this.radioDel.TabStop = true;
            this.radioDel.UseVisualStyleBackColor = true;
            this.radioDel.CheckedChanged += new System.EventHandler(this.radioDel_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(37, 32);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(17, 16);
            this.radioAdd.TabIndex = 3;
            this.radioAdd.TabStop = true;
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавяне";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(331, 92);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 41);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Изтриване";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(331, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 41);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Редактиране";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(25, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Търсене";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(190, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 44);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(190, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 44);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Търсене";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(171, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Комбинирана кутия";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Списъчна кутия";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 102);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 597);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioCombo);
            this.Controls.Add(this.radioList);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioCombo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioDel;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
    }
}
