namespace P02_ShowHide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Hide";
            button2.Text = "Show";
            button3.Text = "Change text";
            label1.Text = "Hello world!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            MessageBox.Show("Text changed!");
        }
    }
}
