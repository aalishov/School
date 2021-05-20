using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy.Web
{
    public partial class AddMedicineForm : Form
    {
        public AddMedicineForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\GIT\School\School-2020_2021\11B_Solutions\03-Module Algorithms\S03-OOP\Pharmacy.Web\medicine.txt";
            try
            {
                string name = textBox1.Text;
                double price = double.Parse(textBox2.Text);
                Medicine medicine = new Medicine(name, price);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine($"{name}-{price}");
                }
                MessageBox.Show("Medicine is added!");

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
