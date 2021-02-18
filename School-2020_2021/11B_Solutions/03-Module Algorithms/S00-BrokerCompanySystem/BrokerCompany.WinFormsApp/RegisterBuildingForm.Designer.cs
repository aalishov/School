
namespace BrokerCompany.WinFormsApp
{
    partial class RegisterBuildingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonResidence = new System.Windows.Forms.RadioButton();
            this.radioButtonBusiness = new System.Windows.Forms.RadioButton();
            this.radioButtonHotel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRent = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonResidence);
            this.groupBox1.Controls.Add(this.radioButtonBusiness);
            this.groupBox1.Controls.Add(this.radioButtonHotel);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building type";
            // 
            // radioButtonResidence
            // 
            this.radioButtonResidence.AutoSize = true;
            this.radioButtonResidence.Location = new System.Drawing.Point(371, 34);
            this.radioButtonResidence.Name = "radioButtonResidence";
            this.radioButtonResidence.Size = new System.Drawing.Size(138, 35);
            this.radioButtonResidence.TabIndex = 2;
            this.radioButtonResidence.TabStop = true;
            this.radioButtonResidence.Text = "Residence";
            this.radioButtonResidence.UseVisualStyleBackColor = true;
            // 
            // radioButtonBusiness
            // 
            this.radioButtonBusiness.AutoSize = true;
            this.radioButtonBusiness.Location = new System.Drawing.Point(197, 34);
            this.radioButtonBusiness.Name = "radioButtonBusiness";
            this.radioButtonBusiness.Size = new System.Drawing.Size(122, 35);
            this.radioButtonBusiness.TabIndex = 1;
            this.radioButtonBusiness.TabStop = true;
            this.radioButtonBusiness.Text = "Business";
            this.radioButtonBusiness.UseVisualStyleBackColor = true;
            // 
            // radioButtonHotel
            // 
            this.radioButtonHotel.AutoSize = true;
            this.radioButtonHotel.Location = new System.Drawing.Point(23, 34);
            this.radioButtonHotel.Name = "radioButtonHotel";
            this.radioButtonHotel.Size = new System.Drawing.Size(90, 35);
            this.radioButtonHotel.TabIndex = 0;
            this.radioButtonHotel.TabStop = true;
            this.radioButtonHotel.Text = "Hotel";
            this.radioButtonHotel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 38);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(137, 150);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(241, 38);
            this.textBoxCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stars";
            // 
            // textBoxStars
            // 
            this.textBoxStars.Location = new System.Drawing.Point(137, 194);
            this.textBoxStars.Name = "textBoxStars";
            this.textBoxStars.Size = new System.Drawing.Size(241, 38);
            this.textBoxStars.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rent";
            // 
            // textBoxRent
            // 
            this.textBoxRent.Location = new System.Drawing.Point(138, 243);
            this.textBoxRent.Name = "textBoxRent";
            this.textBoxRent.Size = new System.Drawing.Size(240, 38);
            this.textBoxRent.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 39);
            this.comboBox1.TabIndex = 10;
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.ItemHeight = 31;
            this.listBoxCompanies.Location = new System.Drawing.Point(397, 109);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(205, 159);
            this.listBoxCompanies.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // RegisterBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxCompanies);
            this.Controls.Add(this.textBoxRent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "RegisterBuildingForm";
            this.Text = "RegisterBuildingForm";
            this.Load += new System.EventHandler(this.RegisterBuildingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonResidence;
        private System.Windows.Forms.RadioButton radioButtonBusiness;
        private System.Windows.Forms.RadioButton radioButtonHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRent;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}