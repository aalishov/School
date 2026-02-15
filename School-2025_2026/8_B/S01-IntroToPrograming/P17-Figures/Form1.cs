namespace P17_Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = double.Parse(textBox1.Text);
                double P = 4 * a;
                double S = a * a;
                label4.Text = $"P = {P:F2}";
                label5.Text = $"S = {S:f2}";
            }
            else if (radioButton2.Checked)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double P = 2 * a + 2 * b;
                double S = a * b;
                label4.Text = $"P = {P:F2}";
                label5.Text = $"S = {S:f2}";
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                if (a < b + c && b < a + c && c < a + b)
                {
                    double P = a + b + c;
                    double p = P / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    label4.Text = $"P = {P:F2}";
                    label5.Text = $"S = {S:f2}";
                }
                else
                {
                    label4.Text = $"Триъгълник със страни {a}, {b}, {c} не съществува!";
                }
            }
        }
    }
}
