
namespace P08_TravelWinFormApp
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
            this.textBoxBudget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonWinter = new System.Windows.Forms.RadioButton();
            this.radioButtonSummer = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBudget
            // 
            this.textBoxBudget.Location = new System.Drawing.Point(153, 12);
            this.textBoxBudget.Name = "textBoxBudget";
            this.textBoxBudget.Size = new System.Drawing.Size(165, 38);
            this.textBoxBudget.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Budget";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonWinter);
            this.groupBox1.Controls.Add(this.radioButtonSummer);
            this.groupBox1.Location = new System.Drawing.Point(20, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Season";
            // 
            // radioButtonWinter
            // 
            this.radioButtonWinter.AutoSize = true;
            this.radioButtonWinter.Location = new System.Drawing.Point(132, 37);
            this.radioButtonWinter.Name = "radioButtonWinter";
            this.radioButtonWinter.Size = new System.Drawing.Size(103, 35);
            this.radioButtonWinter.TabIndex = 1;
            this.radioButtonWinter.TabStop = true;
            this.radioButtonWinter.Text = "Winter";
            this.radioButtonWinter.UseVisualStyleBackColor = true;
            // 
            // radioButtonSummer
            // 
            this.radioButtonSummer.AutoSize = true;
            this.radioButtonSummer.Location = new System.Drawing.Point(6, 37);
            this.radioButtonSummer.Name = "radioButtonSummer";
            this.radioButtonSummer.Size = new System.Drawing.Size(120, 35);
            this.radioButtonSummer.TabIndex = 0;
            this.radioButtonSummer.TabStop = true;
            this.radioButtonSummer.Text = "Summer";
            this.radioButtonSummer.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 176);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(23, 31);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 146);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBudget);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonWinter;
        private System.Windows.Forms.RadioButton radioButtonSummer;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
    }
}

