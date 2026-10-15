namespace P10_ConverterFormApp
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
            labelConvert = new Label();
            labelFrom = new Label();
            labelTo = new Label();
            labelResult = new Label();
            textBoxInitialAmount = new TextBox();
            comboBoxInitialMetric = new ComboBox();
            cobmoBoxTargetMetric = new ComboBox();
            buttonConvert = new Button();
            SuspendLayout();
            // 
            // labelConvert
            // 
            labelConvert.AutoSize = true;
            labelConvert.Location = new Point(54, 43);
            labelConvert.Name = "labelConvert";
            labelConvert.Size = new Size(81, 28);
            labelConvert.TabIndex = 0;
            labelConvert.Text = "Convert";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(291, 43);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(54, 28);
            labelFrom.TabIndex = 1;
            labelFrom.Text = "from";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(523, 43);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(31, 28);
            labelTo.TabIndex = 2;
            labelTo.Text = "to";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(54, 125);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(68, 28);
            labelResult.TabIndex = 3;
            labelResult.Text = "Result:";
            // 
            // textBoxInitialAmount
            // 
            textBoxInitialAmount.Location = new Point(153, 37);
            textBoxInitialAmount.Name = "textBoxInitialAmount";
            textBoxInitialAmount.Size = new Size(125, 34);
            textBoxInitialAmount.TabIndex = 4;
            // 
            // comboBoxInitialMetric
            // 
            comboBoxInitialMetric.FormattingEnabled = true;
            comboBoxInitialMetric.Items.AddRange(new object[] { "mm", "cm", "m" });
            comboBoxInitialMetric.Location = new Point(360, 35);
            comboBoxInitialMetric.Name = "comboBoxInitialMetric";
            comboBoxInitialMetric.Size = new Size(151, 36);
            comboBoxInitialMetric.TabIndex = 5;
            // 
            // cobmoBoxTargetMetric
            // 
            cobmoBoxTargetMetric.FormattingEnabled = true;
            cobmoBoxTargetMetric.Items.AddRange(new object[] { "mm", "cm", "m" });
            cobmoBoxTargetMetric.Location = new Point(564, 35);
            cobmoBoxTargetMetric.Name = "cobmoBoxTargetMetric";
            cobmoBoxTargetMetric.Size = new Size(151, 36);
            cobmoBoxTargetMetric.TabIndex = 6;
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(72, 178);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(634, 65);
            buttonConvert.TabIndex = 7;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 289);
            Controls.Add(buttonConvert);
            Controls.Add(cobmoBoxTargetMetric);
            Controls.Add(comboBoxInitialMetric);
            Controls.Add(textBoxInitialAmount);
            Controls.Add(labelResult);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Controls.Add(labelConvert);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelConvert;
        private Label labelFrom;
        private Label labelTo;
        private Label labelResult;
        private TextBox textBoxInitialAmount;
        private ComboBox comboBoxInitialMetric;
        private ComboBox cobmoBoxTargetMetric;
        private Button buttonConvert;
    }
}
