namespace P16_Klas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girls8A = int.Parse(textBox1.Text);
            int girls8B = int.Parse(textBox2.Text);
            int girls8V = int.Parse(textBox3.Text);
            int boys8A = int.Parse(textBox4.Text);
            int boys8B = int.Parse(textBox5.Text);
            int boys8V = int.Parse(textBox6.Text);

            int sum = 0;

            if (radioButton1.Checked)
            {
                if (checkBox1.Checked) { sum += girls8A; }
                if (checkBox2.Checked) { sum += girls8B; }
                if (checkBox3.Checked) { sum += girls8V; }
            }
            else if (radioButton2.Checked)
            {
                if (checkBox1.Checked) { sum += boys8A; }
                if (checkBox2.Checked) { sum += boys8B; }
                if (checkBox3.Checked) { sum += boys8V; }
            }
            else
            {
                if (checkBox1.Checked) { sum += girls8A + boys8A; }
                if (checkBox2.Checked) { sum += girls8B + boys8B; }
                if (checkBox3.Checked) { sum += girls8V + boys8V; }
            }

            label4.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "0";
        }
    }
}
