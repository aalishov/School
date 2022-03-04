using P03_PhoneBook.Data;
using P03_PhoneBook.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_PhoneBook
{
    public partial class AddContactForm : Form
    {
        private readonly AppDbContext context;

        public AddContactForm(AppDbContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                FirstName=textBox1.Text,
                LastName=textBox2.Text,
                Phone=textBox3.Text,
                Email=textBox4.Text
            };
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
