namespace P03_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Въведи име:";
            label2.Text = "";
            button1.Text = "Поздрави";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = $"Здравей, {textBox1.Text}!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }
    }
}
