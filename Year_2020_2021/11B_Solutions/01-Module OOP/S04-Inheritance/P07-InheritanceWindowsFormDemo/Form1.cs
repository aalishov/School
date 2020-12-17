using P07_InheritanceWindowsFormDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_InheritanceWindowsFormDemo
{
    public partial class Form1 : Form
    {
        //Конструктор
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(textBoxAge.Text, out _);
            if (isNum)
            {
                Child child = new Child(textBoxName.Text, int.Parse(textBoxAge.Text), labelSchoolName.Text, textBoxClass.Text);
                listBoxChildrens.Items.Add(child.ToString());
                ClearTextBox();
            }
            else
            {
                textBoxAge.Text = "Въведи  цяло число!";
            }
        }

        private void ClearTextBox()
        {
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxClass.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxChildrens.Items.Add("няма ученик");
            Thread.Sleep(3000);
        }
    }
}
