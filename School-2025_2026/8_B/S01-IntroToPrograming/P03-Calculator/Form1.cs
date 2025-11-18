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
            button3.Text = "C";
            label1.Text = string.Empty; //label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int sum = a + b;
            label1.Text=sum.ToString();
        }
    }
}
