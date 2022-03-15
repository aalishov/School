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
    public partial class AddStudentForm : Form
    {
        private readonly StudentsService studentsService;

        public AddStudentForm(StudentsService studentsService)
        {
            InitializeComponent();
            this.studentsService = studentsService;
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string birthDay = textBoxBirthday.Text;
            string result = await this.studentsService.CreateStudentAsync(name, phone, birthDay);
            MessageBox.Show(result);
            ClearUserInput();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearUserInput()
        {
            textBoxName.Text = string.Empty;
        }
    }
}
