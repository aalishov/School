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
    public partial class UserForm : Form
    {
        private readonly MainService service;
        private ICollection<Rent> rents;
        public UserForm(MainService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            textBoxModel.Enabled = false;
            textBoxStart.Enabled = false;
            labelUsername.Text = service.AppUser;
            UpdateBalance();
            LoadComboBoxId();
            SelectRent();
        }

        private void UpdateBalance()
        {
            labelBalance.Text = service.Users.GetUserBalance(service.AppUser).ToString();
        }

        private void LoadComboBoxId()
        {
            rents = service.Rents.GetRentsByUsername(service.AppUser);
            comboBoxRentsId.Items.AddRange(rents.Select(x => (object)x.Id).ToArray());
        }
        private void SelectRent(int selectedIndex = 0)
        {
            if (rents.Any())
            {
                comboBoxRentsId.SelectedIndex = selectedIndex;
                int rentId = (int)comboBoxRentsId.SelectedItem;
                Rent rent = rents.FirstOrDefault(x => x.Id == rentId);
                textBoxModel.Text = rent.Scooter.Model;
                textBoxStart.Text = rent.StartDate.ToShortDateString();
            }
            else
            {
                textBoxModel.Text = "-";
                textBoxStart.Text = "-";
                comboBoxRentsId.Enabled = false;
                buttonPay.Enabled = false;
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            RentForm form = new RentForm(service);
            form.Show();
            this.Close();
        }

        private void comboBoxRentsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxRentsId.SelectedIndex;
            SelectRent(index);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            int rentId = (int)comboBoxRentsId.SelectedItem;
            service.Rents.Complete(rentId, service.AppUser);
            comboBoxRentsId.Items.Clear();
            LoadComboBoxId();
            SelectRent();
            UpdateBalance();
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

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogForm dialog = new DialogForm("Enter balance: ");
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    service.Users.Deposit(service.AppUser, dialog.Result);
                    UpdateBalance();
                }
                else
                {
                    MessageBox.Show("You close the dialog!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
