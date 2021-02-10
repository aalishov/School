using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private StudentService service = new StudentService();
        public Form1()
        {
            InitializeComponent();
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            string result = service.CreateStudent(int.Parse(studentIdTextBox.Text), studentFirstNameTextBox.Text, studentLastNameTextBox.Text, int.Parse(studentAgeTextBox.Text), studetnSchoolTextBox.Text);
            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = service.GetStudentInfo(int.Parse(inputIdTextBox.Text));
        }
    }
}
