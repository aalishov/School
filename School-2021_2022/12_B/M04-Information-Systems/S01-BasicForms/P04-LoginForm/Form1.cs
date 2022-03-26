using P04_LoginForm.Data;
using P04_LoginForm.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_LoginForm
{
    public partial class Form1 : Form
    {
        private AppDbContext context;
        public Form1()
        {
            InitializeComponent();
            context = new AppDbContext();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cities = context
                .Cities
                .Select(x => x.Name).ToArray();
            comboBoxCity.Items.AddRange(cities);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = comboBoxCity.Text;
                City city = context.Cities
                    .FirstOrDefault(x => x.Name == cityName);
                if (city == null)
                {
                    city = new City() { Name = cityName };
                }
                if (context.Users.Any(x=>x.Username==textBoxUsername.Text))
                {
                    throw new ArgumentException("User already exist!");
                }
                User user = new User()
                {
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Balance = decimal.Parse(textBoxBalance.Text),
                    City = city
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
