﻿
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCreateBuilding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create company";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCreateBuilding
            // 
            this.buttonCreateBuilding.Location = new System.Drawing.Point(199, 18);
            this.buttonCreateBuilding.Name = "buttonCreateBuilding";
            this.buttonCreateBuilding.Size = new System.Drawing.Size(143, 86);
            this.buttonCreateBuilding.TabIndex = 2;
            this.buttonCreateBuilding.Text = "Create building";
            this.buttonCreateBuilding.UseVisualStyleBackColor = true;
            this.buttonCreateBuilding.Click += new System.EventHandler(this.buttonCreateBuilding_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateBuilding);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCreateBuilding;
    }
}

