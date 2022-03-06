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
    public partial class RentForm : Form
    {
        private readonly MainService service;

        public RentForm(MainService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            FillListBoxScooters();
        }

        private void FillListBoxScooters()
        {
            ICollection<Scooter> scooters = service.Scooters.GetFreeScooters(1, 10);
            if (scooters.Any())
            {
                listBoxScooters.Items.Clear();
                listBoxScooters.Items.AddRange(scooters.Select(x => $"{x.Id} - {x.Model}").ToArray());
            }
            else
            {
                listBoxScooters.Items.Add("No available scooters!");
                listBoxScooters.Enabled = false;
            }
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            try
            {
                int scooterId = int.Parse(((string)listBoxScooters.SelectedItem).Split(" - ").FirstOrDefault());
                int userId = service.Users.GetUserIdByUsername(service.AppUser);
                service.Rents.Rent(userId, scooterId);
                FillListBoxScooters();
                MessageBox.Show("You rent scooter!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(service);
            form.Show();
            this.Close();
        }
    }
}
