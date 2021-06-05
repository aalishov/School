
namespace Pharmacy.Web
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
            this.addMedicine = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.addPharmacyButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addMedicine
            // 
            this.addMedicine.Location = new System.Drawing.Point(890, 12);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(183, 84);
            this.addMedicine.TabIndex = 0;
            this.addMedicine.Text = "Add medicine";
            this.addMedicine.UseVisualStyleBackColor = true;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(21, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 438);
            this.listBox1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(361, 472);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(241, 58);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // addPharmacyButton
            // 
            this.addPharmacyButton.Location = new System.Drawing.Point(889, 126);
            this.addPharmacyButton.Name = "addPharmacyButton";
            this.addPharmacyButton.Size = new System.Drawing.Size(184, 85);
            this.addPharmacyButton.TabIndex = 3;
            this.addPharmacyButton.Text = "Add pharmacy";
            this.addPharmacyButton.UseVisualStyleBackColor = true;
            this.addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(495, 9);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(334, 438);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 542);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.addPharmacyButton);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addMedicine);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMedicine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button addPharmacyButton;
        private System.Windows.Forms.ListBox listBox2;
    }
}

