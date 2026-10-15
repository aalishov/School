namespace P14_SmallShopFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcPriceButton_Click(object sender, EventArgs e)
        {
            string product = comboBoxProduct.SelectedItem.ToString();
            string city = comboBoxCity.SelectedItem.ToString();
            double quantity = double.Parse(textBoxQuantity.Text);

            double price = 0.0;
            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.50;
                        break;
                    case "water":
                        price = 0.80;
                        break;
                    case "juice":
                        price = 1.20;
                        break;
                    case "sweets":
                        price = 1.45;
                        break;
                    case "peanuts":
                        price = 1.60;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.40;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "juice":
                        price = 1.15;
                        break;
                    case "sweets":
                        price = 1.30;
                        break;
                    case "peanuts":
                        price = 1.50;
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.45;
                        break;
                    case "water":
                        price = 0.70;
                        break;
                    case "juice":
                        price = 1.10;
                        break;
                    case "sweets":
                        price = 1.35;
                        break;
                    case "peanuts":
                        price = 1.55;
                        break;
                }
            }
            // Display the calculated price in the label
            labelPrice.Text = $"{(price * quantity).ToString("F2")}lv";

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
