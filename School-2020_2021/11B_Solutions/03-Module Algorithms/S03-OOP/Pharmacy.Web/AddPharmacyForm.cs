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
    public partial class AddPharmacyForm : Form
    {
        public AddPharmacyForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\GIT\School\School-2020_2021\11B_Solutions\03-Module Algorithms\S03-OOP\Pharmacy.Web\pharmacy.txt";
            try
            {
                Pharmacy pharmacy = new Pharmacy(textBox1.Text);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine($"@{textBox1.Text}");
                }
                textBox1.Clear();
                MessageBox.Show("Pharmacy is add!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
