using P07_InheritanceWindowsFormDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_InheritanceWindowsFormDemo
{
    public partial class Form1 : Form
    {
        private List<Child> school = new List<Child>();
        private StringBuilder sb = new StringBuilder();
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
            int age = 0;
            bool isNum = int.TryParse(textBoxAge.Text, out _);
            if (isNum)
            {
                age = int.Parse(textBoxAge.Text);
                Child child = new Child(textBoxName.Text, age, labelSchoolName.Text, textBoxClass.Text);
                this.sb.AppendLine(child.ToString());
                listBoxChildrens.Items.Add(child.ToString());
                ClearTextBox();
            }
            else
            {
                textBoxAge.Text = "Въведи години - цяло число!";
            }
        }

        private void ClearTextBox()
        {
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxClass.Text = string.Empty;
        }
    }
}
