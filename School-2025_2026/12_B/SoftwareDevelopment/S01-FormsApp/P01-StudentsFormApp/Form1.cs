using P01_StudentsFormApp.Data;
using P01_StudentsFormApp.Data.Models;

namespace P01_StudentsFormApp
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            bool isMale = rbMale.Checked;
            DateTime birthdate = dateTimePicker1.Value;
            Student student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                IsMale = isMale,
                Birthdate = birthdate
            };

            context.Students.Add(student);
            var result = context.SaveChanges();

            if (result != 0)
            {
                MessageBox.Show("Student added!");
            }

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var s in context.Students)
            {
                string sex = s.IsMale ? "male" : "female";
                listBox1.Items.Add($"{s.Id} - {s.FirstName} {s.LastName} - {s.Birthdate.ToShortDateString()} - {sex}");
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
