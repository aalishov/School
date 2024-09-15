namespace P03_FractionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = button1.Text;
            Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = button2.Text;
            Calculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = button3.Text;
            Calculate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = button4.Text;
            Calculate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            try
            {
                textBox1.Focus();
                textBox1.SelectAll();
                label10.Visible = false;
                label11.Text = "";
                label12.Text = "";
                int num1 = int.Parse(textBox1.Text);
                int denom1 = int.Parse(textBox2.Text);
                int num2 = int.Parse(textBox3.Text);
                int denom2 = int.Parse(textBox4.Text);
                int num3 = 0, denom3 = 0;
                if (label9.Text == "+")
                {
                    num3 = num1 * denom2 + num2 * denom1;
                    denom3 = denom1 * denom2;
                }
                if (label9.Text == "-")
                {
                    num3 = num1 * denom2 - num2 * denom1;
                    denom3 = denom1 * denom2;
                }
                if (label9.Text == "*")
                {
                    num3 = num1 * num2;
                    denom3 = denom1 * denom2;
                }
                if (label9.Text == ":")
                {
                    num3 = num1 * denom2;
                    denom3 = denom1 * num2;
                }
                int nod = Nod(num3, denom3);
                num3 /= nod;
                denom3 /= nod;
                if (denom3 == 0) throw new Exception();
                if (denom3 < 0) { num3 = -num3; denom3 = -denom3; }
                if (num3 < 0)
                {
                    label10.Visible = true;
                    num3 = -num3;
                }
                label11.Text = num3.ToString();
                label12.Text = denom3.ToString();
            }
            catch (Exception)
            { }
        }

        private int Nod(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != 0 && y != 0)
            {
                if (x > y) { x %= y; }
                else { y %= x; }
            }
            return x + y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
