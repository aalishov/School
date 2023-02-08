using P01_AnimalsCatalog.Data;
using P01_AnimalsCatalog.Data.Models;

namespace P01_AnimalsCatalog
{
    public partial class Form1 : Form
    {
        Animal current = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            string url = textBox3.Text;

            Animal animal = new Animal()
            {
                Name = name,
                Age = age,
                ImageUrl = url
            };

            using (AppDbContext context = new AppDbContext())
            {
                context.Animals.Add(animal);
                context.SaveChanges();
            }

            MessageBox.Show("Animal added!");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    Animal newAnimal = context.Animals.FirstOrDefault(x => x.Id < current.Id);
                    if (newAnimal != null)
                    {
                        current = newAnimal;
                        label4.Text = $"{current.Name} - {current.Age}";
                        pictureBox1.Load(current.ImageUrl);
                    }
                    else
                    {
                        MessageBox.Show("No more animals!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    Animal newAnimal = context.Animals.FirstOrDefault(x => x.Id > current.Id);
                    if (newAnimal != null)
                    {
                        current = newAnimal;
                        label4.Text = $"{current.Name} - {current.Age}";
                        pictureBox1.Load(current.ImageUrl);
                    }
                    else
                    {
                        MessageBox.Show("No more animals!");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                current = context.Animals.FirstOrDefault();
                if (current != null)
                {
                    label4.Text= $"{current.Name} - {current.Age}";
                    pictureBox1.Load(current.ImageUrl);
                }
                else
                {
                    label4.Text = "Empty database!";
                }
            }
        }
    }
}