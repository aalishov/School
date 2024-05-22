namespace P01_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);

            int intervalCounter = 0;
            int evenCounter = 0;

            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                int num = int.Parse(richTextBox1.Lines[i]);
                if (num >= p && num <= q)
                {
                    intervalCounter++;
                }
                if (num % 2 == 0)
                {
                    evenCounter++;
                }
            }
            label3.Text = $"Numbers between [{p}; {q}] - {intervalCounter}";
            label4.Text = $"Even number - {evenCounter}";
        }
    }
}
