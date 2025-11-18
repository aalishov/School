namespace P03_SumNumsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b= int.Parse(textBox2.Text);
            int c = a + b;
            label3.Text = c.ToString();
        }
    }
}
