namespace P02_PizzaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbSizeSmall = new System.Windows.Forms.RadioButton();
            this.comboBPizza = new System.Windows.Forms.ComboBox();
            this.bOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSizeFamily = new System.Windows.Forms.RadioButton();
            this.rbSizeBig = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPOnline = new System.Windows.Forms.RadioButton();
            this.rbPCash = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEChili = new System.Windows.Forms.CheckBox();
            this.cbESoyS = new System.Windows.Forms.CheckBox();
            this.cbEGarlicS = new System.Windows.Forms.CheckBox();
            this.cbEMustard = new System.Windows.Forms.CheckBox();
            this.cbEMayo = new System.Windows.Forms.CheckBox();
            this.cbEKetchup = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSizeSmall
            // 
            this.rbSizeSmall.AutoSize = true;
            this.rbSizeSmall.Location = new System.Drawing.Point(6, 37);
            this.rbSizeSmall.Name = "rbSizeSmall";
            this.rbSizeSmall.Size = new System.Drawing.Size(89, 35);
            this.rbSizeSmall.TabIndex = 3;
            this.rbSizeSmall.TabStop = true;
            this.rbSizeSmall.Text = "small";
            this.rbSizeSmall.UseVisualStyleBackColor = true;
            // 
            // comboBPizza
            // 
            this.comboBPizza.FormattingEnabled = true;
            this.comboBPizza.Location = new System.Drawing.Point(38, 29);
            this.comboBPizza.Margin = new System.Windows.Forms.Padding(5);
            this.comboBPizza.Name = "comboBPizza";
            this.comboBPizza.Size = new System.Drawing.Size(451, 39);
            this.comboBPizza.TabIndex = 0;
            this.comboBPizza.SelectedIndexChanged += new System.EventHandler(this.comboBPizza_SelectedIndexChanged);
            // 
            // bOrder
            // 
            this.bOrder.Location = new System.Drawing.Point(76, 454);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(351, 44);
            this.bOrder.TabIndex = 1;
            this.bOrder.Text = "Order";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(526, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSizeFamily);
            this.groupBox1.Controls.Add(this.rbSizeBig);
            this.groupBox1.Controls.Add(this.rbSizeSmall);
            this.groupBox1.Location = new System.Drawing.Point(38, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rbSizeFamily
            // 
            this.rbSizeFamily.AutoSize = true;
            this.rbSizeFamily.Location = new System.Drawing.Point(6, 119);
            this.rbSizeFamily.Name = "rbSizeFamily";
            this.rbSizeFamily.Size = new System.Drawing.Size(97, 35);
            this.rbSizeFamily.TabIndex = 5;
            this.rbSizeFamily.TabStop = true;
            this.rbSizeFamily.Text = "family";
            this.rbSizeFamily.UseVisualStyleBackColor = true;
            // 
            // rbSizeBig
            // 
            this.rbSizeBig.AutoSize = true;
            this.rbSizeBig.Location = new System.Drawing.Point(6, 78);
            this.rbSizeBig.Name = "rbSizeBig";
            this.rbSizeBig.Size = new System.Drawing.Size(69, 35);
            this.rbSizeBig.TabIndex = 4;
            this.rbSizeBig.TabStop = true;
            this.rbSizeBig.Text = "big";
            this.rbSizeBig.UseVisualStyleBackColor = true;
            this.rbSizeBig.CheckedChanged += new System.EventHandler(this.rbSizeBig_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPOnline);
            this.groupBox2.Controls.Add(this.rbPCash);
            this.groupBox2.Location = new System.Drawing.Point(38, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 145);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // rbPOnline
            // 
            this.rbPOnline.AutoSize = true;
            this.rbPOnline.Location = new System.Drawing.Point(6, 78);
            this.rbPOnline.Name = "rbPOnline";
            this.rbPOnline.Size = new System.Drawing.Size(98, 35);
            this.rbPOnline.TabIndex = 5;
            this.rbPOnline.TabStop = true;
            this.rbPOnline.Text = "online";
            this.rbPOnline.UseVisualStyleBackColor = true;
            // 
            // rbPCash
            // 
            this.rbPCash.AutoSize = true;
            this.rbPCash.Location = new System.Drawing.Point(6, 37);
            this.rbPCash.Name = "rbPCash";
            this.rbPCash.Size = new System.Drawing.Size(106, 35);
            this.rbPCash.TabIndex = 4;
            this.rbPCash.TabStop = true;
            this.rbPCash.Text = "in cash";
            this.rbPCash.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEChili);
            this.groupBox3.Controls.Add(this.cbESoyS);
            this.groupBox3.Controls.Add(this.cbEGarlicS);
            this.groupBox3.Controls.Add(this.cbEMustard);
            this.groupBox3.Controls.Add(this.cbEMayo);
            this.groupBox3.Controls.Add(this.cbEKetchup);
            this.groupBox3.Location = new System.Drawing.Point(246, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 348);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // cbEChili
            // 
            this.cbEChili.AutoSize = true;
            this.cbEChili.Location = new System.Drawing.Point(6, 240);
            this.cbEChili.Name = "cbEChili";
            this.cbEChili.Size = new System.Drawing.Size(78, 35);
            this.cbEChili.TabIndex = 5;
            this.cbEChili.Text = "chili";
            this.cbEChili.UseVisualStyleBackColor = true;
            // 
            // cbESoyS
            // 
            this.cbESoyS.AutoSize = true;
            this.cbESoyS.Location = new System.Drawing.Point(6, 201);
            this.cbESoyS.Name = "cbESoyS";
            this.cbESoyS.Size = new System.Drawing.Size(134, 35);
            this.cbESoyS.TabIndex = 4;
            this.cbESoyS.Text = "soy sauce";
            this.cbESoyS.UseVisualStyleBackColor = true;
            // 
            // cbEGarlicS
            // 
            this.cbEGarlicS.AutoSize = true;
            this.cbEGarlicS.Location = new System.Drawing.Point(6, 160);
            this.cbEGarlicS.Name = "cbEGarlicS";
            this.cbEGarlicS.Size = new System.Drawing.Size(157, 35);
            this.cbEGarlicS.TabIndex = 3;
            this.cbEGarlicS.Text = "garlic sauce";
            this.cbEGarlicS.UseVisualStyleBackColor = true;
            // 
            // cbEMustard
            // 
            this.cbEMustard.AutoSize = true;
            this.cbEMustard.Location = new System.Drawing.Point(6, 119);
            this.cbEMustard.Name = "cbEMustard";
            this.cbEMustard.Size = new System.Drawing.Size(121, 35);
            this.cbEMustard.TabIndex = 2;
            this.cbEMustard.Text = "mustard";
            this.cbEMustard.UseVisualStyleBackColor = true;
            // 
            // cbEMayo
            // 
            this.cbEMayo.AutoSize = true;
            this.cbEMayo.Location = new System.Drawing.Point(6, 78);
            this.cbEMayo.Name = "cbEMayo";
            this.cbEMayo.Size = new System.Drawing.Size(158, 35);
            this.cbEMayo.TabIndex = 1;
            this.cbEMayo.Text = "mayonnaise";
            this.cbEMayo.UseVisualStyleBackColor = true;
            // 
            // cbEKetchup
            // 
            this.cbEKetchup.AutoSize = true;
            this.cbEKetchup.Location = new System.Drawing.Point(6, 37);
            this.cbEKetchup.Name = "cbEKetchup";
            this.cbEKetchup.Size = new System.Drawing.Size(118, 35);
            this.cbEKetchup.TabIndex = 0;
            this.cbEKetchup.Text = "ketchup";
            this.cbEKetchup.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(843, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 53);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.comboBPizza);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSizeSmall;
        private System.Windows.Forms.ComboBox comboBPizza;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSizeFamily;
        private System.Windows.Forms.RadioButton rbSizeBig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPOnline;
        private System.Windows.Forms.RadioButton rbPCash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbEChili;
        private System.Windows.Forms.CheckBox cbESoyS;
        private System.Windows.Forms.CheckBox cbEGarlicS;
        private System.Windows.Forms.CheckBox cbEMustard;
        private System.Windows.Forms.CheckBox cbEMayo;
        private System.Windows.Forms.CheckBox cbEKetchup;
        private System.Windows.Forms.Button button1;
    }
}
