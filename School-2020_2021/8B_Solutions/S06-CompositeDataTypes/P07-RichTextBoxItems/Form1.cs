using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_RichTextBoxItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int p = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);

            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                int currentElement = int.Parse(richTextBox1.Lines[i]);
                if (richTextBox1.Lines[i] != "")
                {
                    if (currentElement >= p && currentElement <= q)
                    {
                        listBox1.Items.Add(currentElement);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
