namespace P10_ConverterFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double initalAmount = double.Parse(textBoxInitialAmount.Text);
            string initialMetric = comboBoxInitialMetric.SelectedItem?.ToString();
            string typeConvert = cobmoBoxTargetMetric.SelectedItem?.ToString();
            double result = 0;
            if (initialMetric == "mm" && typeConvert == "m")
            {
                result = initalAmount / 1000;
            }
            else if (initialMetric == "m" && typeConvert == "mm")
            {
                result = initalAmount * 1000;
            }
            else if (initialMetric == "cm" && typeConvert == "m")
            {
                result = initalAmount / 100;
            }
            else if (initialMetric == "m" && typeConvert == "cm")
            {
                result = initalAmount * 100;
            }
            else if (initialMetric == "cm" && typeConvert == "mm")
            {
                result = initalAmount * 10;
            }
            else if (initialMetric == "mm" && typeConvert == "cm")
            {
                result = initalAmount / 10;
            }
            labelResult.Text = result.ToString("F3");
        }
    }
}
