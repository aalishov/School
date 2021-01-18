
namespace P04_VehicleWinFormApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carFuelLabel = new System.Windows.Forms.Label();
            this.carConsumptionLabel = new System.Windows.Forms.Label();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.carFuelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.truckConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.truckFuelTextBox = new System.Windows.Forms.TextBox();
            this.truckModelTextBox = new System.Windows.Forms.TextBox();
            this.truckBrandTextBox = new System.Windows.Forms.TextBox();
            this.truckConsumptionLabel = new System.Windows.Forms.Label();
            this.truckFuelLabel = new System.Windows.Forms.Label();
            this.truckModelLabel = new System.Windows.Forms.Label();
            this.truckBrandLabel = new System.Windows.Forms.Label();
            this.createVehicle = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.driveRadioButton = new System.Windows.Forms.RadioButton();
            this.refuelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.carRadioButton = new System.Windows.Forms.RadioButton();
            this.truckRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carConsumptionTextBox);
            this.groupBox1.Controls.Add(this.carFuelTextBox);
            this.groupBox1.Controls.Add(this.carModelTextBox);
            this.groupBox1.Controls.Add(this.carBrandTextBox);
            this.groupBox1.Controls.Add(this.carConsumptionLabel);
            this.groupBox1.Controls.Add(this.carFuelLabel);
            this.groupBox1.Controls.Add(this.carModelLabel);
            this.groupBox1.Controls.Add(this.carBrandLabel);
            this.groupBox1.Location = new System.Drawing.Point(51, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(390, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car info";
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Location = new System.Drawing.Point(18, 56);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(75, 25);
            this.carBrandLabel.TabIndex = 0;
            this.carBrandLabel.Text = "Brand: ";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(16, 100);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(77, 25);
            this.carModelLabel.TabIndex = 1;
            this.carModelLabel.Text = "Model: ";
            // 
            // carFuelLabel
            // 
            this.carFuelLabel.AutoSize = true;
            this.carFuelLabel.Location = new System.Drawing.Point(18, 139);
            this.carFuelLabel.Name = "carFuelLabel";
            this.carFuelLabel.Size = new System.Drawing.Size(61, 25);
            this.carFuelLabel.TabIndex = 2;
            this.carFuelLabel.Text = "Fuel: ";
            // 
            // carConsumptionLabel
            // 
            this.carConsumptionLabel.AutoSize = true;
            this.carConsumptionLabel.Location = new System.Drawing.Point(18, 178);
            this.carConsumptionLabel.Name = "carConsumptionLabel";
            this.carConsumptionLabel.Size = new System.Drawing.Size(139, 25);
            this.carConsumptionLabel.TabIndex = 3;
            this.carConsumptionLabel.Text = "Consumption: ";
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(163, 56);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(191, 30);
            this.carBrandTextBox.TabIndex = 4;
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(163, 97);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.Size = new System.Drawing.Size(191, 30);
            this.carModelTextBox.TabIndex = 5;
            // 
            // carConsumptionTextBox
            // 
            this.carConsumptionTextBox.Location = new System.Drawing.Point(163, 175);
            this.carConsumptionTextBox.Name = "carConsumptionTextBox";
            this.carConsumptionTextBox.Size = new System.Drawing.Size(191, 30);
            this.carConsumptionTextBox.TabIndex = 7;
            // 
            // carFuelTextBox
            // 
            this.carFuelTextBox.Location = new System.Drawing.Point(163, 134);
            this.carFuelTextBox.Name = "carFuelTextBox";
            this.carFuelTextBox.Size = new System.Drawing.Size(191, 30);
            this.carFuelTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.truckConsumptionTextBox);
            this.groupBox2.Controls.Add(this.truckFuelTextBox);
            this.groupBox2.Controls.Add(this.truckModelTextBox);
            this.groupBox2.Controls.Add(this.truckBrandTextBox);
            this.groupBox2.Controls.Add(this.truckConsumptionLabel);
            this.groupBox2.Controls.Add(this.truckFuelLabel);
            this.groupBox2.Controls.Add(this.truckModelLabel);
            this.groupBox2.Controls.Add(this.truckBrandLabel);
            this.groupBox2.Location = new System.Drawing.Point(476, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(390, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Truck info";
            // 
            // truckConsumptionTextBox
            // 
            this.truckConsumptionTextBox.Location = new System.Drawing.Point(163, 175);
            this.truckConsumptionTextBox.Name = "truckConsumptionTextBox";
            this.truckConsumptionTextBox.Size = new System.Drawing.Size(191, 30);
            this.truckConsumptionTextBox.TabIndex = 7;
            // 
            // truckFuelTextBox
            // 
            this.truckFuelTextBox.Location = new System.Drawing.Point(163, 134);
            this.truckFuelTextBox.Name = "truckFuelTextBox";
            this.truckFuelTextBox.Size = new System.Drawing.Size(191, 30);
            this.truckFuelTextBox.TabIndex = 6;
            // 
            // truckModelTextBox
            // 
            this.truckModelTextBox.Location = new System.Drawing.Point(163, 97);
            this.truckModelTextBox.Name = "truckModelTextBox";
            this.truckModelTextBox.Size = new System.Drawing.Size(191, 30);
            this.truckModelTextBox.TabIndex = 5;
            // 
            // truckBrandTextBox
            // 
            this.truckBrandTextBox.Location = new System.Drawing.Point(163, 56);
            this.truckBrandTextBox.Name = "truckBrandTextBox";
            this.truckBrandTextBox.Size = new System.Drawing.Size(191, 30);
            this.truckBrandTextBox.TabIndex = 4;
            // 
            // truckConsumptionLabel
            // 
            this.truckConsumptionLabel.AutoSize = true;
            this.truckConsumptionLabel.Location = new System.Drawing.Point(18, 178);
            this.truckConsumptionLabel.Name = "truckConsumptionLabel";
            this.truckConsumptionLabel.Size = new System.Drawing.Size(139, 25);
            this.truckConsumptionLabel.TabIndex = 3;
            this.truckConsumptionLabel.Text = "Consumption: ";
            // 
            // truckFuelLabel
            // 
            this.truckFuelLabel.AutoSize = true;
            this.truckFuelLabel.Location = new System.Drawing.Point(18, 139);
            this.truckFuelLabel.Name = "truckFuelLabel";
            this.truckFuelLabel.Size = new System.Drawing.Size(61, 25);
            this.truckFuelLabel.TabIndex = 2;
            this.truckFuelLabel.Text = "Fuel: ";
            // 
            // truckModelLabel
            // 
            this.truckModelLabel.AutoSize = true;
            this.truckModelLabel.Location = new System.Drawing.Point(16, 100);
            this.truckModelLabel.Name = "truckModelLabel";
            this.truckModelLabel.Size = new System.Drawing.Size(77, 25);
            this.truckModelLabel.TabIndex = 1;
            this.truckModelLabel.Text = "Model: ";
            // 
            // truckBrandLabel
            // 
            this.truckBrandLabel.AutoSize = true;
            this.truckBrandLabel.Location = new System.Drawing.Point(18, 56);
            this.truckBrandLabel.Name = "truckBrandLabel";
            this.truckBrandLabel.Size = new System.Drawing.Size(75, 25);
            this.truckBrandLabel.TabIndex = 0;
            this.truckBrandLabel.Text = "Brand: ";
            // 
            // createVehicle
            // 
            this.createVehicle.Location = new System.Drawing.Point(873, 31);
            this.createVehicle.Name = "createVehicle";
            this.createVehicle.Size = new System.Drawing.Size(155, 220);
            this.createVehicle.TabIndex = 9;
            this.createVehicle.Text = "Create";
            this.createVehicle.UseVisualStyleBackColor = true;
            this.createVehicle.Click += new System.EventHandler(this.createVehicle_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(740, 298);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(288, 97);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.refuelRadioButton);
            this.groupBox3.Controls.Add(this.driveRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(298, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 130);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // driveRadioButton
            // 
            this.driveRadioButton.AutoSize = true;
            this.driveRadioButton.Location = new System.Drawing.Point(21, 41);
            this.driveRadioButton.Name = "driveRadioButton";
            this.driveRadioButton.Size = new System.Drawing.Size(78, 29);
            this.driveRadioButton.TabIndex = 0;
            this.driveRadioButton.TabStop = true;
            this.driveRadioButton.Text = "Drive";
            this.driveRadioButton.UseVisualStyleBackColor = true;
            // 
            // refuelRadioButton
            // 
            this.refuelRadioButton.AutoSize = true;
            this.refuelRadioButton.Location = new System.Drawing.Point(21, 85);
            this.refuelRadioButton.Name = "refuelRadioButton";
            this.refuelRadioButton.Size = new System.Drawing.Size(88, 29);
            this.refuelRadioButton.TabIndex = 1;
            this.refuelRadioButton.TabStop = true;
            this.refuelRadioButton.Text = "Refuel";
            this.refuelRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.truckRadioButton);
            this.groupBox4.Controls.Add(this.carRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(51, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 130);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vehicle";
            // 
            // carRadioButton
            // 
            this.carRadioButton.AutoSize = true;
            this.carRadioButton.Location = new System.Drawing.Point(23, 41);
            this.carRadioButton.Name = "carRadioButton";
            this.carRadioButton.Size = new System.Drawing.Size(65, 29);
            this.carRadioButton.TabIndex = 0;
            this.carRadioButton.TabStop = true;
            this.carRadioButton.Text = "Car";
            this.carRadioButton.UseVisualStyleBackColor = true;
            // 
            // truckRadioButton
            // 
            this.truckRadioButton.AutoSize = true;
            this.truckRadioButton.Location = new System.Drawing.Point(23, 85);
            this.truckRadioButton.Name = "truckRadioButton";
            this.truckRadioButton.Size = new System.Drawing.Size(83, 29);
            this.truckRadioButton.TabIndex = 1;
            this.truckRadioButton.TabStop = true;
            this.truckRadioButton.Text = "Truck";
            this.truckRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Value";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(584, 365);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 30);
            this.valueTextBox.TabIndex = 14;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(579, 423);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(19, 25);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 478);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.createVehicle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox carConsumptionTextBox;
        private System.Windows.Forms.TextBox carFuelTextBox;
        private System.Windows.Forms.TextBox carModelTextBox;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.Label carConsumptionLabel;
        private System.Windows.Forms.Label carFuelLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox truckConsumptionTextBox;
        private System.Windows.Forms.TextBox truckFuelTextBox;
        private System.Windows.Forms.TextBox truckModelTextBox;
        private System.Windows.Forms.TextBox truckBrandTextBox;
        private System.Windows.Forms.Label truckConsumptionLabel;
        private System.Windows.Forms.Label truckFuelLabel;
        private System.Windows.Forms.Label truckModelLabel;
        private System.Windows.Forms.Label truckBrandLabel;
        private System.Windows.Forms.Button createVehicle;
        private System.Windows.Forms.Button executeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton refuelRadioButton;
        private System.Windows.Forms.RadioButton driveRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton truckRadioButton;
        private System.Windows.Forms.RadioButton carRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

