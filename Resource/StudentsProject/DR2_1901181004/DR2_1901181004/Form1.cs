using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DR2_1901181004
{
    public partial class Form1 : Form
    {
        private static Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    form2.listBox1.Items.Add(txtInput.Text);
                }
                else
                {
                    bool f = false;
                    for (int i = 0; i < form2.listBox1.Items.Count; i++)
                    {
                        if (form2.listBox1.Items[i].ToString() == txtInput.Text)
                        {
                            f = true;
                        }
                    }
                    if (!f)
                    {
                        form2.listBox1.Items.Add(txtInput.Text);
                    }
                    else
                    {
                        MessageBox.Show("Елемента се дублира!",
                                          "Грешка при добавяне", 0, MessageBoxIcon.Error);
                    }
                }
                txtInput.Text = "";
                txtInput.Focus();

            }
            else if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    form2.listBox2.Items.Add(txtInput.Text);
                }
                else
                {
                    bool f = false;
                    for (int i = 0; i < form2.listBox2.Items.Count; i++)
                    {
                        if (form2.listBox2.Items[i].ToString() == txtInput.Text)
                        {
                            f = true;
                        }
                    }
                    if (!f)
                    {
                        form2.listBox2.Items.Add(txtInput.Text);
                    }
                    else
                    {
                        MessageBox.Show("Елемента се дублира!",
                                          "Грешка при добавяне", 0, MessageBoxIcon.Error);
                    }
                }
                txtInput.Text = "";
                txtInput.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
