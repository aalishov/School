namespace P08_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Въведи страни на правоъгълник";
            button1.Text = "Изчисли";
            label2.Text = "Периметърът е: ";
            label3.Text = "Лицето е: "; ;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO:
        }
    }
}
