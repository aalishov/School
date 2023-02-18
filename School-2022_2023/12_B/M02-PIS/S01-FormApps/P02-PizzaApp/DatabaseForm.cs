using P02_PizzaApp.Data;
using P02_PizzaApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P02_PizzaApp
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = !(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text));
            if (isValid)
            {
                string name = textBox1.Text;
                string imageUrl = textBox2.Text;
                decimal price = decimal.Parse(textBox3.Text);
                Pizza pizza = new Pizza()
                {
                    Name = name,
                    ImageUrl = imageUrl,
                    Price = price,
                };
                using (AppDbContext context = new AppDbContext())
                {
                    Pizza p1 = context.Pizzas.FirstOrDefault(x=>x.Name==pizza.Name);
                    if (p1!=null)
                    {
                        MessageBox.Show("The same pizza is already added in the database!");
                    }
                    else
                    {
                        context.Pizzas.Add(pizza);
                        context.SaveChanges();
                        MessageBox.Show("Success!");
                    }
                }
            }
            else
            {
                MessageBox.Show("All the fields are mandatory!");
            }
            Clear();
            this.DatabaseForm_Load(sender,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AppDbContext context = new AppDbContext())
            {
                string name = comboBox1.Text;
                Pizza pizza = context.Pizzas.FirstOrDefault(x=>x.Name==name);
                textBox4.Text= pizza.ImageUrl;
                textBox5.Text = pizza.Price.ToString();
            }
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            using (AppDbContext context = new AppDbContext())
            {
                string[] names = context.Pizzas.Select(x => x.Name).ToArray();
                comboBox1.Items.AddRange(names);
            }
            radioButton1.Checked= true;
            groupBox2.Enabled=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(AppDbContext context = new AppDbContext()) 
            {
                string name = comboBox1.Text;
                Pizza pizza = context.Pizzas.FirstOrDefault(x => x.Name == name);
                if (pizza==null)
                {
                    MessageBox.Show("No pizza is selected!");
                }
                else
                {
                    pizza.ImageUrl = textBox4.Text;
                    pizza.Price = decimal.Parse(textBox5.Text);
                    context.Pizzas.Update(pizza);
                    context.SaveChanges();
                    MessageBox.Show("Success!");
                }
                comboBox1.Text = string.Empty;
                textBox4.Text= string.Empty;
                textBox5.Text= string.Empty;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = false;
                groupBox1.Enabled = true;
            }
            else 
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
        }
    }
}
