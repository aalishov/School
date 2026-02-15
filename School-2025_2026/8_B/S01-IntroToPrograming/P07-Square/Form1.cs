namespace P07_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Въведи страна: ";
            label2.Text = "Периметърът е: ";
            label4.Text = "Лицето е: " ;
            label3.Text = string.Empty;
            label5.Text= string.Empty;
            button1.Text = "Изчисли";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int p = 4 * a;
            int s = a * a;
            label3.Text = p.ToString();
            label5.Text = s.ToString();
        }
    }
}
