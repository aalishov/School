using Scooters.Models;
using Scooters.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scooters.FormApp
{
    public partial class AdminForm : Form
    {
        private readonly MainService service;
        private int currentPage = 1;
        private int totalPage = 0;
        public AdminForm(MainService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            radioButtonUsers.Checked = true;
            ICollection<User> users = this.service.Users.GetUsers();
            string result = this.service.Output.PrintUsers(users);
            richTextBox1.Text = result;
            totalPage = (int)Math.Ceiling(service.Users.GetUsersCount() / 10.0);
            groupBox1.Hide();
            richTextBox1.Enabled=false;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (radioButtonUsers.Checked)
            {
                totalPage = (int)Math.Ceiling(service.Users.GetUsersCount() / 10.0);
                if ((currentPage - 1) < 1 || currentPage > totalPage)
                {
                    currentPage = totalPage;
                }
                else
                {
                    currentPage--;
                }
                ICollection<User> users = this.service.Users.GetUsers(currentPage);
                string result = this.service.Output.PrintUsers(users);
                richTextBox1.Text = result;
            }
            else if (radioButtonScooters.Checked)
            {
                totalPage = (int)Math.Ceiling(service.Scooters.GetScootersCount() / 10.0);
                if ((currentPage - 1) < 1 || currentPage > totalPage)
                {
                    currentPage = totalPage;
                }
                else
                {
                    currentPage--;
                }
                ICollection<Scooter> scooters = this.service.Scooters.GetScooters(currentPage);
                string result = this.service.Output.PrintScooters(scooters);
                richTextBox1.Text = result;
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButtonUsers.Checked)
            {
                totalPage = (int)Math.Ceiling(service.Users.GetUsersCount() / 10.0);
                if ((currentPage + 1) > totalPage || currentPage > totalPage)
                {
                    currentPage = 1;
                }
                else
                {
                    currentPage++;
                }
                ICollection<User> users = this.service.Users.GetUsers(currentPage);
                string result = this.service.Output.PrintUsers(users);
                richTextBox1.Text = result;
            }
            else if (radioButtonScooters.Checked)
            {
                totalPage = (int)Math.Ceiling(service.Scooters.GetScootersCount() / 10.0);
                if ((currentPage + 1) > totalPage || currentPage > totalPage)
                {
                    currentPage = 1;
                }
                else
                {
                    currentPage++;
                }
                ICollection<Scooter> scooters = this.service.Scooters.GetScooters(currentPage);
                string result = this.service.Output.PrintScooters(scooters);
                richTextBox1.Text = result;
            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelete.Checked)
            {
                groupBox1.Show();
                buttonClose.Hide();
            }
            else
            {
                groupBox1.Hide();
                buttonClose.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonUsers.Checked)
                {
                    service.Users.DeleteUserById(int.Parse(textBox1.Text));
                }
                else if (radioButtonScooters.Checked)
                {
                    service.Scooters.DeleteScooterById(int.Parse(textBox1.Text));
                }
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            service.Logout();
            MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (main != null)
            {
                main.Show();
            };
            this.Close();
        }
    }
}
