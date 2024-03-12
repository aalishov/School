namespace P06_FormApp
{
    public partial class Form1 : Form
    {
        MyFormReader reader;
        MyFormWriter writer;
        Engine engine;
        public Form1()
        {
            InitializeComponent();
            reader = new MyFormReader(textBox1);
            writer = new MyFormWriter();
            writer.SetObject(label1);
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine = new Engine(reader, writer); ;
        }
    }
}
