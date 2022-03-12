using StudentSystem.Data;
using StudentSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsSystem.FormsApp
{
    public partial class MainForm : Form
    {
        private AppDbContext context;
        private StudentsService studentsService;
        public MainForm()
        {
            InitializeComponent();
            this.context= new AppDbContext();
            this.studentsService = new StudentsService(context);
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm(studentsService);
            addStudent.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
