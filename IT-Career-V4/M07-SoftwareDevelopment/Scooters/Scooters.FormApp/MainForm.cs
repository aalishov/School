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
    public partial class MainForm : Form
    {
        private MainService mainService;
        public MainForm()
        {
            InitializeComponent();
            mainService = new MainService();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxCities.Items.AddRange(mainService.Users.GetAllCitiesName().ToArray());
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string result = mainService.Login(tbUsernameLogin.Text, tbPasswordLogin.Text);
            MessageBox.Show(result);
            if (mainService.IsLogged && mainService.IsAdmin)
            {
                AdminForm form = new AdminForm(mainService);
                form.Show();
                this.Hide();
            }
            else if (mainService.IsLogged)
            {
                UserForm form = new UserForm(mainService);
                form.Show();
                this.Hide();
            }
            ClearTextBoxes();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                mainService.Users.CreateUser(tbUsername.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text, tbBalance.Text, comboBoxCities.Text);
                MessageBox.Show("Register successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            foreach (Control groupBox in this.Controls)
            {
                if (groupBox.GetType() == typeof(GroupBox))
                {
                    foreach (var textBox in groupBox.Controls)
                    {
                        if (textBox.GetType()==typeof(TextBox))
                        {
                            ((TextBox)textBox).Clear();
                        }
                    }
                }
            }
        }
    }
}
