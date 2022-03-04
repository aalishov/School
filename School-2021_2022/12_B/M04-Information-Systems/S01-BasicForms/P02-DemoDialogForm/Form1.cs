using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_DemoDialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogForm dialog = new DialogForm("City", "Enter city name: ");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string city = dialog.TextResult;
                listBox1.Items.Add(city);
            }
            else
            {
                MessageBox.Show("You close the dialog!");
            }
        }
    }
}
