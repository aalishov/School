
namespace P01_ShapesArea
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.labelFirstInput = new System.Windows.Forms.Label();
            this.labelSecondInput = new System.Windows.Forms.Label();
            this.tbFirstInput = new System.Windows.Forms.TextBox();
            this.tbSecondInput = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbSquare);
            this.groupBox1.Controls.Add(this.rbTriangle);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(19, 119);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(112, 29);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(19, 84);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(89, 29);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(19, 49);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(97, 29);
            this.rbTriangle.TabIndex = 0;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // labelFirstInput
            // 
            this.labelFirstInput.AutoSize = true;
            this.labelFirstInput.Location = new System.Drawing.Point(216, 49);
            this.labelFirstInput.Name = "labelFirstInput";
            this.labelFirstInput.Size = new System.Drawing.Size(35, 25);
            this.labelFirstInput.TabIndex = 1;
            this.labelFirstInput.Text = "a=";
            // 
            // labelSecondInput
            // 
            this.labelSecondInput.AutoSize = true;
            this.labelSecondInput.Location = new System.Drawing.Point(205, 84);
            this.labelSecondInput.Name = "labelSecondInput";
            this.labelSecondInput.Size = new System.Drawing.Size(46, 25);
            this.labelSecondInput.TabIndex = 2;
            this.labelSecondInput.Text = "ha=";
            // 
            // tbFirstInput
            // 
            this.tbFirstInput.Location = new System.Drawing.Point(248, 46);
            this.tbFirstInput.Name = "tbFirstInput";
            this.tbFirstInput.Size = new System.Drawing.Size(134, 33);
            this.tbFirstInput.TabIndex = 3;
            // 
            // tbSecondInput
            // 
            this.tbSecondInput.Location = new System.Drawing.Point(248, 85);
            this.tbSecondInput.Name = "tbSecondInput";
            this.tbSecondInput.Size = new System.Drawing.Size(134, 33);
            this.tbSecondInput.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(210, 135);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(171, 60);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(94, 215);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(20, 25);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 249);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.tbSecondInput);
            this.Controls.Add(this.tbFirstInput);
            this.Controls.Add(this.labelSecondInput);
            this.Controls.Add(this.labelFirstInput);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(438, 288);
            this.MinimumSize = new System.Drawing.Size(438, 288);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.Label labelFirstInput;
        private System.Windows.Forms.Label labelSecondInput;
        private System.Windows.Forms.TextBox tbFirstInput;
        private System.Windows.Forms.TextBox tbSecondInput;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
    }
}

