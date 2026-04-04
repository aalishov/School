using P02_CarsCatalogFormApp.Data;
using P02_CarsCatalogFormApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P02_CarsCatalogFormApp
{
    public partial class ManufacturerForm : Form
    {
        private AppDbContext context;
        public ManufacturerForm(AppDbContext context)
        {
            InitializeComponent();
            this.context = context;
            UpdateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;

            Manufacturer manufacturer = context
                .Manufacturers
                .FirstOrDefault(x => x.Name == name) ?? new Manufacturer()
                {
                    Name = name,
                    EstablishedOn = date
                };


            context.Manufacturers.Add(manufacturer);
            int result = context.SaveChanges();
            if (result != 0)
            {
                MessageBox.Show($"Manufacturer {name} added succesffully");
            }

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            context.Manufacturers.ToList().ForEach(x => listBox1.Items.Add(x.Name));
        }
    }
}
