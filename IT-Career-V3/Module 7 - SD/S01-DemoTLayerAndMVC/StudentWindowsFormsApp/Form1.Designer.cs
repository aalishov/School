
namespace StudentWindowsFormsApp
{
    partial class Form1
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
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentAgeTextBox = new System.Windows.Forms.TextBox();
            this.studetnSchoolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createStudentButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(194, 24);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(193, 34);
            this.studentIdTextBox.TabIndex = 0;
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(194, 64);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(193, 34);
            this.studentFirstNameTextBox.TabIndex = 1;
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.Location = new System.Drawing.Point(194, 104);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(193, 34);
            this.studentLastNameTextBox.TabIndex = 2;
            // 
            // studentAgeTextBox
            // 
            this.studentAgeTextBox.Location = new System.Drawing.Point(194, 144);
            this.studentAgeTextBox.Name = "studentAgeTextBox";
            this.studentAgeTextBox.Size = new System.Drawing.Size(193, 34);
            this.studentAgeTextBox.TabIndex = 3;
            // 
            // studetnSchoolTextBox
            // 
            this.studetnSchoolTextBox.Location = new System.Drawing.Point(194, 184);
            this.studetnSchoolTextBox.Name = "studetnSchoolTextBox";
            this.studetnSchoolTextBox.Size = new System.Drawing.Size(193, 34);
            this.studetnSchoolTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "School";
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(115, 240);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(204, 54);
            this.createStudentButton.TabIndex = 10;
            this.createStudentButton.Text = "Create";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // inputIdTextBox
            // 
            this.inputIdTextBox.Location = new System.Drawing.Point(568, 32);
            this.inputIdTextBox.Name = "inputIdTextBox";
            this.inputIdTextBox.Size = new System.Drawing.Size(193, 34);
            this.inputIdTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Seacrh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(627, 184);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(21, 29);
            this.resultLabel.TabIndex = 14;
            this.resultLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 358);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputIdTextBox);
            this.Controls.Add(this.createStudentButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studetnSchoolTextBox);
            this.Controls.Add(this.studentAgeTextBox);
            this.Controls.Add(this.studentLastNameTextBox);
            this.Controls.Add(this.studentFirstNameTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentFirstNameTextBox;
        private System.Windows.Forms.TextBox studentLastNameTextBox;
        private System.Windows.Forms.TextBox studentAgeTextBox;
        private System.Windows.Forms.TextBox studetnSchoolTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputIdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
    }
}

