namespace P00_DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            MessageBox.Show("Message...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message...");
        }
    }
}