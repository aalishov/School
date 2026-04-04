namespace P10_Ranking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            textBox1.Text = listBox1.Items[count - 1].ToString();
            textBox2.Text = listBox1.Items[count - 2].ToString();
            textBox3.Text = listBox1.Items[count - 3].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
        }
    }
}

