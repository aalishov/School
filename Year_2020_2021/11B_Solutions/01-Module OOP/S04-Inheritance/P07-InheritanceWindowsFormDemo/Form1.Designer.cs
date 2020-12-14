
namespace P07_InheritanceWindowsFormDemo
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
            this.buttonAddChild = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelSchoolName = new System.Windows.Forms.Label();
            this.labelChildList = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.listBoxChildrens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAddChild
            // 
            this.buttonAddChild.Location = new System.Drawing.Point(93, 269);
            this.buttonAddChild.Name = "buttonAddChild";
            this.buttonAddChild.Size = new System.Drawing.Size(163, 82);
            this.buttonAddChild.TabIndex = 0;
            this.buttonAddChild.Text = "Добави";
            this.buttonAddChild.UseVisualStyleBackColor = true;
            this.buttonAddChild.Click += new System.EventHandler(this.buttonAddChild_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 102);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(71, 32);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(35, 152);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(111, 32);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Години";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 99);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 39);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(158, 149);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(166, 39);
            this.textBoxAge.TabIndex = 4;
            // 
            // labelSchoolName
            // 
            this.labelSchoolName.AutoSize = true;
            this.labelSchoolName.Location = new System.Drawing.Point(226, 23);
            this.labelSchoolName.Name = "labelSchoolName";
            this.labelSchoolName.Size = new System.Drawing.Size(263, 32);
            this.labelSchoolName.TabIndex = 5;
            this.labelSchoolName.Text = "СУ \"Васил Левски\"";
            // 
            // labelChildList
            // 
            this.labelChildList.AutoSize = true;
            this.labelChildList.Location = new System.Drawing.Point(391, 69);
            this.labelChildList.Name = "labelChildList";
            this.labelChildList.Size = new System.Drawing.Size(279, 32);
            this.labelChildList.TabIndex = 6;
            this.labelChildList.Text = "Добавени ученици: ";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(35, 203);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(80, 32);
            this.labelClass.TabIndex = 7;
            this.labelClass.Text = "Клас";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(156, 203);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(168, 39);
            this.textBoxClass.TabIndex = 8;
            // 
            // listBoxChildrens
            // 
            this.listBoxChildrens.FormattingEnabled = true;
            this.listBoxChildrens.ItemHeight = 32;
            this.listBoxChildrens.Location = new System.Drawing.Point(397, 116);
            this.listBoxChildrens.Name = "";
            this.listBoxChildrens.Size = new System.Drawing.Size(291, 260);
            this.listBoxChildrens.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 418);
            this.Controls.Add(this.listBoxChildrens);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelChildList);
            this.Controls.Add(this.labelSchoolName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddChild);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddChild;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelSchoolName;
        private System.Windows.Forms.Label labelChildList;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.ListBox listBoxChildrens;
    }
}

