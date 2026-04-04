namespace P02_CarsCatalogFormApp
{
    partial class MainForm
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
            btnManufacturers = new Button();
            SuspendLayout();
            // 
            // btnManufacturers
            // 
            btnManufacturers.Location = new Point(647, 363);
            btnManufacturers.Name = "btnManufacturers";
            btnManufacturers.Size = new Size(127, 66);
            btnManufacturers.TabIndex = 0;
            btnManufacturers.Text = "Manufacturers";
            btnManufacturers.UseVisualStyleBackColor = true;
            btnManufacturers.Click += this.btnManufacturers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManufacturers);
            Name = "MainForm";
            Text = "Cars catalog";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManufacturers;
    }
}
