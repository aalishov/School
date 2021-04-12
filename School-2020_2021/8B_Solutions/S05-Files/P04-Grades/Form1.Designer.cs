
namespace P04_Grades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFive = new System.Windows.Forms.Label();
            this.labelFour = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelSix = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Двойки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тройки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Четворки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Петици";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Шестици";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Успех: ";
            // 
            // labelFive
            // 
            this.labelFive.AutoSize = true;
            this.labelFive.Location = new System.Drawing.Point(182, 194);
            this.labelFive.Name = "labelFive";
            this.labelFive.Size = new System.Drawing.Size(23, 31);
            this.labelFive.TabIndex = 8;
            this.labelFive.Text = "-";
            // 
            // labelFour
            // 
            this.labelFour.AutoSize = true;
            this.labelFour.Location = new System.Drawing.Point(182, 153);
            this.labelFour.Name = "labelFour";
            this.labelFour.Size = new System.Drawing.Size(23, 31);
            this.labelFour.TabIndex = 7;
            this.labelFour.Text = "-";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Location = new System.Drawing.Point(182, 109);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(23, 31);
            this.labelThree.TabIndex = 6;
            this.labelThree.Text = "-";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(182, 66);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(23, 31);
            this.labelTwo.TabIndex = 5;
            this.labelTwo.Text = "-";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(182, 287);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(23, 31);
            this.labelAverage.TabIndex = 10;
            this.labelAverage.Text = "-";
            // 
            // labelSix
            // 
            this.labelSix.AutoSize = true;
            this.labelSix.Location = new System.Drawing.Point(182, 234);
            this.labelSix.Name = "labelSix";
            this.labelSix.Size = new System.Drawing.Size(23, 31);
            this.labelSix.TabIndex = 11;
            this.labelSix.Text = "-";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(193, 12);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(132, 40);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Изчисли";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(35, 12);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(128, 45);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Зареди";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 342);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelSix);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFive);
            this.Controls.Add(this.labelFour);
            this.Controls.Add(this.labelThree);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFive;
        private System.Windows.Forms.Label labelFour;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelSix;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonLoad;
    }
}

