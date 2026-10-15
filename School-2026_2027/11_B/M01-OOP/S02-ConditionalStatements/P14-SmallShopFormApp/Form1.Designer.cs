namespace P14_SmallShopFormApp
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
            productLabel = new Label();
            cityLabel = new Label();
            quantityLabel = new Label();
            priceLabel = new Label();
            comboBoxProduct = new ComboBox();
            comboBoxCity = new ComboBox();
            textBoxQuantity = new TextBox();
            labelPrice = new Label();
            calcPriceButton = new Button();
            SuspendLayout();
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(31, 44);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(60, 20);
            productLabel.TabIndex = 0;
            productLabel.Text = "Product";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(31, 98);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(34, 20);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "City";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(31, 162);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(65, 20);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(31, 231);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price:";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Items.AddRange(new object[] { "coffee", "water", "juice", "sweets", "peanuts" });
            comboBoxProduct.Location = new Point(136, 44);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(151, 28);
            comboBoxProduct.TabIndex = 4;
            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Sofia", "Plovdiv", "Varna" });
            comboBoxCity.Location = new Point(136, 98);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(151, 28);
            comboBoxCity.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(136, 155);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(125, 27);
            textBoxQuantity.TabIndex = 6;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(136, 231);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 20);
            labelPrice.TabIndex = 7;
            labelPrice.Click += labelPrice_Click;
            // 
            // calcPriceButton
            // 
            calcPriceButton.BackColor = Color.IndianRed;
            calcPriceButton.Location = new Point(31, 307);
            calcPriceButton.Name = "calcPriceButton";
            calcPriceButton.Size = new Size(256, 56);
            calcPriceButton.TabIndex = 8;
            calcPriceButton.Text = "Calculate Price";
            calcPriceButton.UseVisualStyleBackColor = false;
            calcPriceButton.Click += calcPriceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(385, 450);
            Controls.Add(calcPriceButton);
            Controls.Add(labelPrice);
            Controls.Add(textBoxQuantity);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxProduct);
            Controls.Add(priceLabel);
            Controls.Add(quantityLabel);
            Controls.Add(cityLabel);
            Controls.Add(productLabel);
            Name = "Form1";
            Text = "Products Price";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productLabel;
        private Label cityLabel;
        private Label quantityLabel;
        private Label priceLabel;
        private ComboBox comboBoxProduct;
        private ComboBox comboBoxCity;
        private TextBox textBoxQuantity;
        private Label labelPrice;
        private Button calcPriceButton;
    }
}
