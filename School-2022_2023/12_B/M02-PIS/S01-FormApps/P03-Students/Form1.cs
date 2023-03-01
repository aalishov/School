using P03_Students.Data;
using P03_Students.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_Students
{
    public partial class Form1 : Form
    {
        private Student currentStudent = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            for (double i = 2.5; i <= 6.0; i += 0.5)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            LoadListItems();
        }

        private void LoadListItems()
        {
            using (AppDbContext context = new AppDbContext())
            {
                listBox1.Items.Clear();
                List<string> students = context
                    .Students
                    .Select(x => $"{x.Id} - {x.Name}")
                    .ToList();
                students.ForEach(student => listBox1.Items.Add(student));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
                listBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = false;
                listBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Add")
            {
                try
                {
                    string name = textBox1.Text;
                    double averageGrade = double.Parse(comboBox1.Text);
                    DateTime birthDate = dateTimePicker1.Value;
                    Student student = new Student()
                    {
                        Name = name,
                        AverageGrade = averageGrade,
                        Birthdate = birthDate
                    }
                    ;
                    using (AppDbContext context = new AppDbContext())
                    {
                        context.Students.Add(student);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Student added!");
                    LoadListItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (button1.Text=="Update")
            {
                currentStudent.Name= textBox1.Text;
                currentStudent.AverageGrade=double.Parse(comboBox1.Text);
                currentStudent.Birthdate = dateTimePicker1.Value;
                using (AppDbContext context= new AppDbContext())
                {
                    context.Students.Update(currentStudent);
                    context.SaveChanges();
                }
                currentStudent=null;
                groupBox1.Enabled= false;
                button1.Text="Add";
                groupBox2.Enabled = true;
                LoadListItems();
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int id = int.Parse(listBox1.Text.Split(" - ").FirstOrDefault());
            Student s = null;
            using (AppDbContext context = new AppDbContext())
            {
                s = context.Students.Find(id);
            }
            currentStudent= s;
            textBox1.Text = s.Name;
            comboBox1.Text = s.AverageGrade.ToString();
            dateTimePicker1.Value= s.Birthdate;
            groupBox1.Enabled = true;
            button1.Text = "Update";
            groupBox2.Enabled= false;
        }
    }
}
