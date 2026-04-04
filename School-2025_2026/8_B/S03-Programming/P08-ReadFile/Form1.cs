namespace P08_ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "data.txt";

            StreamReader reader = new StreamReader(path);

            string result = reader.ReadToEnd();

            richTextBox1.Text = result;
        }
    }
}
