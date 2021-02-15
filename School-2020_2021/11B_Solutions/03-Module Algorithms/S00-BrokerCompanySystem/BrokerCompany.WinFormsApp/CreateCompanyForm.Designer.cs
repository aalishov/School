
namespace BrokerCompany.WinFormsApp
{
    partial class CreateCompanyForm
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
            this.textBoxComoanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComoanyName
            // 
            this.textBoxComoanyName.Location = new System.Drawing.Point(243, 22);
            this.textBoxComoanyName.Name = "textBoxComoanyName";
            this.textBoxComoanyName.Size = new System.Drawing.Size(220, 38);
            this.textBoxComoanyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company name";
            // 
            // buttonCreateCompany
            // 
            this.buttonCreateCompany.Location = new System.Drawing.Point(500, 16);
            this.buttonCreateCompany.Name = "buttonCreateCompany";
            this.buttonCreateCompany.Size = new System.Drawing.Size(155, 48);
            this.buttonCreateCompany.TabIndex = 2;
            this.buttonCreateCompany.Text = "Create";
            this.buttonCreateCompany.UseVisualStyleBackColor = true;
            this.buttonCreateCompany.Click += new System.EventHandler(this.buttonCreateCompany_Click);
            // 
            // CreateCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 128);
            this.Controls.Add(this.buttonCreateCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComoanyName);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CreateCompanyForm";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.CreateCompanyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxComoanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateCompany;
    }
}