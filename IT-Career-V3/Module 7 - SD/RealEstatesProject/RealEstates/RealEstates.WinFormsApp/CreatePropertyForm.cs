using RealEstates.Services;
using RealEstates.Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealEstates.WinFormsApp
{
    public partial class CreatePropertyForm : Form
    {
        private readonly PropertiesService propertiesService;
        private readonly WindowsFormService windowsFormService;
        public CreatePropertyForm(PropertiesService propertiesService, WindowsFormService windowsFormService)
        {
            InitializeComponent();
            this.propertiesService = propertiesService;
            this.windowsFormService = windowsFormService;
        }

        private void CreatePropertyForm_Load(object sender, EventArgs e)
        {
            UpdateComboBoxItems();
        }

        private void UpdateComboBoxItems()
        {
            this.comboBoxDistrict.Items.AddRange(windowsFormService.GetDistricts());
            this.comboBoxYear.Items.AddRange(windowsFormService.GetYears());
            this.comboBoxBuildingType.Items.AddRange(windowsFormService.GetBuildingTypes());
            this.comboBoxPropertyType.Items.AddRange(windowsFormService.GetPropertyTypes());
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                PropertyInputViewModel model = new PropertyInputViewModel()
                {
                    District = comboBoxDistrict.Text,
                    Size = int.Parse(textBoxSize.Text),
                    Price = int.Parse(textBoxPrice.Text),
                    Year = int.Parse(comboBoxYear.SelectedItem.ToString()),
                    PropertyType = comboBoxPropertyType.Text,
                    BuildingType = comboBoxBuildingType.Text,
                    Floor = int.TryParse(textBoxFloor.Text, out _) ? int.Parse(textBoxFloor.Text) : 0,
                    TotalFloors = int.TryParse(textBoxTotalFloors.Text, out _) ? int.Parse(textBoxTotalFloors.Text) : 0,
                };
                this.propertiesService.Create(model);
                MessageBox.Show("Имота е добавен в базата от данни!");
                ClearTextAndComboBoxes(Controls);
                UpdateComboBoxItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ClearTextAndComboBoxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Text = string.Empty;
                ClearTextAndComboBoxes(ctrl.Controls);
            }
        }
        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPropertyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBuildingType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
