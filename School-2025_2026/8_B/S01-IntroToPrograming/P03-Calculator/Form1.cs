namespace P03_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "+";
            button2.Text = "-";
            button4.Text = "*";
            button5.Text = "/";
            button3.Text = "C";
            label1.Text = string.Empty; //label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int result = a + b;
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int result = a - b;
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int result = a * b;
            label1.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int result = a / b;
            int reminder = a % b;
            label1.Text = $"{result} -> {reminder}";
        }
    }
}
