namespace P04_Toto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetRandomNumber().ToString();
            textBox2.Text = GetRandomNumber().ToString();
            textBox3.Text = GetRandomNumber().ToString();
            textBox4.Text = GetRandomNumber().ToString();
            textBox5.Text = GetRandomNumber().ToString();
            textBox6.Text = GetRandomNumber().ToString();
        }
        public int GetRandomNumber()
        {
            return new Random().Next() % 49 + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
