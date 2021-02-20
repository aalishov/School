
namespace RealEstates.WinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateProperty = new System.Windows.Forms.Button();
            this.buttonCatalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real Estates";
            // 
            // buttonCreateProperty
            // 
            this.buttonCreateProperty.Location = new System.Drawing.Point(48, 103);
            this.buttonCreateProperty.Name = "buttonCreateProperty";
            this.buttonCreateProperty.Size = new System.Drawing.Size(129, 70);
            this.buttonCreateProperty.TabIndex = 1;
            this.buttonCreateProperty.Text = "Добави";
            this.buttonCreateProperty.UseVisualStyleBackColor = true;
            this.buttonCreateProperty.Click += new System.EventHandler(this.buttonCreateProperty_Click);
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.Location = new System.Drawing.Point(202, 103);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(126, 70);
            this.buttonCatalog.TabIndex = 2;
            this.buttonCatalog.Text = "Каталог";
            this.buttonCatalog.UseVisualStyleBackColor = true;
            this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCatalog);
            this.Controls.Add(this.buttonCreateProperty);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Real Estates";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateProperty;
        private System.Windows.Forms.Button buttonCatalog;
    }
}

