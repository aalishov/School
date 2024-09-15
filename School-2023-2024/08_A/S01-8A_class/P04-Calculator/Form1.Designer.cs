namespace P04_Calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 87);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(405, 99);
            button1.Name = "button1";
            button1.Size = new Size(191, 116);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 311);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 348);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "---------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
