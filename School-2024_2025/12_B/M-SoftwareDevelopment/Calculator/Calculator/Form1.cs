namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1=double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = num1 * num2;
            label1.Text = result.ToString();
        }
    }
}
