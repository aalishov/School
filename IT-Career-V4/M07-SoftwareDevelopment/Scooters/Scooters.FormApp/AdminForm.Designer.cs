
namespace Scooters.FormApp
{
    partial class AdminForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.radioButtonUsers = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonScooters = new System.Windows.Forms.RadioButton();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(931, 604);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(277, 616);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(152, 65);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(456, 616);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(160, 64);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // radioButtonUsers
            // 
            this.radioButtonUsers.AutoSize = true;
            this.radioButtonUsers.Location = new System.Drawing.Point(22, 3);
            this.radioButtonUsers.Name = "radioButtonUsers";
            this.radioButtonUsers.Size = new System.Drawing.Size(106, 42);
            this.radioButtonUsers.TabIndex = 3;
            this.radioButtonUsers.TabStop = true;
            this.radioButtonUsers.Text = "Users";
            this.radioButtonUsers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonScooters);
            this.panel1.Controls.Add(this.radioButtonUsers);
            this.panel1.Location = new System.Drawing.Point(30, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 102);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonScooters
            // 
            this.radioButtonScooters.AutoSize = true;
            this.radioButtonScooters.Location = new System.Drawing.Point(22, 51);
            this.radioButtonScooters.Name = "radioButtonScooters";
            this.radioButtonScooters.Size = new System.Drawing.Size(144, 42);
            this.radioButtonScooters.TabIndex = 4;
            this.radioButtonScooters.TabStop = true;
            this.radioButtonScooters.Text = "Scooters";
            this.radioButtonScooters.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(277, 687);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(310, 42);
            this.checkBoxDelete.TabIndex = 5;
            this.checkBoxDelete.Text = "Activate delete option";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(648, 610);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(205, 54);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(73, 49);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "button1";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 43);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 736);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminForm";
            this.Text = "Scooter Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton radioButtonUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonScooters;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}