using MyApp.Services;
using MyApp.ViewModels;
using System.Windows.Forms;

namespace MyApp.Form
{
    public partial class Form1
    {
        CarsService service = new CarsService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<IndexCarViewModel> list = service.GetCarsByBrand(textBox1.Text);
            richTextBox1.AppendText($"{textBox1.Text} cars: ");
            foreach (var c in list)
            {
                richTextBox1.AppendText($"\n\t{c.Model}");
            }
        }
    }
}