namespace P04_Toto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 58);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "Първо число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 112);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Второ число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 172);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 2;
            label3.Text = "Трето число";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 58);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 3;
            label4.Text = "Четвърто число";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 112);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 4;
            label5.Text = "Пето число";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 172);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 5;
            label6.Text = "Шесто число";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(58, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(58, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(58, 34);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(516, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(58, 34);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(516, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(58, 34);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(516, 172);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(58, 34);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(199, 249);
            button1.Name = "button1";
            button1.Size = new Size(299, 105);
            button1.TabIndex = 12;
            button1.Text = "Генерирай числата";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 403);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Тото 6 от 49";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}
