
namespace BrokerCompany.WinFormsApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioShutdown = new System.Windows.Forms.RadioButton();
            this.radioCompanyInfo = new System.Windows.Forms.RadioButton();
            this.radioRentBuilding = new System.Windows.Forms.RadioButton();
            this.radioRegisterBroker = new System.Windows.Forms.RadioButton();
            this.radioRegisterBuilding = new System.Windows.Forms.RadioButton();
            this.radioCreateCompany = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioShutdown);
            this.panel1.Controls.Add(this.radioCompanyInfo);
            this.panel1.Controls.Add(this.radioRentBuilding);
            this.panel1.Controls.Add(this.radioRegisterBroker);
            this.panel1.Controls.Add(this.radioRegisterBuilding);
            this.panel1.Controls.Add(this.radioCreateCompany);
            this.panel1.Location = new System.Drawing.Point(29, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 101);
            this.panel1.TabIndex = 0;
            // 
            // radioShutdown
            // 
            this.radioShutdown.AutoSize = true;
            this.radioShutdown.Location = new System.Drawing.Point(463, 55);
            this.radioShutdown.Name = "radioShutdown";
            this.radioShutdown.Size = new System.Drawing.Size(138, 35);
            this.radioShutdown.TabIndex = 5;
            this.radioShutdown.TabStop = true;
            this.radioShutdown.Text = "Shutdown";
            this.radioShutdown.UseVisualStyleBackColor = true;
            // 
            // radioCompanyInfo
            // 
            this.radioCompanyInfo.AutoSize = true;
            this.radioCompanyInfo.Location = new System.Drawing.Point(463, 14);
            this.radioCompanyInfo.Name = "radioCompanyInfo";
            this.radioCompanyInfo.Size = new System.Drawing.Size(177, 35);
            this.radioCompanyInfo.TabIndex = 4;
            this.radioCompanyInfo.TabStop = true;
            this.radioCompanyInfo.Text = "Company info";
            this.radioCompanyInfo.UseVisualStyleBackColor = true;
            // 
            // radioRentBuilding
            // 
            this.radioRentBuilding.AutoSize = true;
            this.radioRentBuilding.Location = new System.Drawing.Point(242, 55);
            this.radioRentBuilding.Name = "radioRentBuilding";
            this.radioRentBuilding.Size = new System.Drawing.Size(173, 35);
            this.radioRentBuilding.TabIndex = 3;
            this.radioRentBuilding.TabStop = true;
            this.radioRentBuilding.Text = "Rent building";
            this.radioRentBuilding.UseVisualStyleBackColor = true;
            // 
            // radioRegisterBroker
            // 
            this.radioRegisterBroker.AutoSize = true;
            this.radioRegisterBroker.Location = new System.Drawing.Point(242, 14);
            this.radioRegisterBroker.Name = "radioRegisterBroker";
            this.radioRegisterBroker.Size = new System.Drawing.Size(190, 35);
            this.radioRegisterBroker.TabIndex = 2;
            this.radioRegisterBroker.TabStop = true;
            this.radioRegisterBroker.Text = "Register broker";
            this.radioRegisterBroker.UseVisualStyleBackColor = true;
            // 
            // radioRegisterBuilding
            // 
            this.radioRegisterBuilding.AutoSize = true;
            this.radioRegisterBuilding.Location = new System.Drawing.Point(26, 55);
            this.radioRegisterBuilding.Name = "radioRegisterBuilding";
            this.radioRegisterBuilding.Size = new System.Drawing.Size(210, 35);
            this.radioRegisterBuilding.TabIndex = 1;
            this.radioRegisterBuilding.TabStop = true;
            this.radioRegisterBuilding.Text = "Register building";
            this.radioRegisterBuilding.UseVisualStyleBackColor = true;
            // 
            // radioCreateCompany
            // 
            this.radioCreateCompany.AutoSize = true;
            this.radioCreateCompany.Location = new System.Drawing.Point(26, 14);
            this.radioCreateCompany.Name = "radioCreateCompany";
            this.radioCreateCompany.Size = new System.Drawing.Size(201, 35);
            this.radioCreateCompany.TabIndex = 0;
            this.radioCreateCompany.TabStop = true;
            this.radioCreateCompany.Text = "Create company";
            this.radioCreateCompany.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioShutdown;
        private System.Windows.Forms.RadioButton radioCompanyInfo;
        private System.Windows.Forms.RadioButton radioRentBuilding;
        private System.Windows.Forms.RadioButton radioRegisterBroker;
        private System.Windows.Forms.RadioButton radioRegisterBuilding;
        private System.Windows.Forms.RadioButton radioCreateCompany;
        private System.Windows.Forms.Button button1;
    }
}

