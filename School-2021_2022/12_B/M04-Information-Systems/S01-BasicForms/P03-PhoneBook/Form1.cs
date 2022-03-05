using P03_PhoneBook.Data;
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
    public partial class Form1 : Form
    {
        private readonly AppDbContext context;

        public Form1()
        {
            InitializeComponent();
            this.context = new AppDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm(context);
            addContactForm.Show();
        }
    }
}
