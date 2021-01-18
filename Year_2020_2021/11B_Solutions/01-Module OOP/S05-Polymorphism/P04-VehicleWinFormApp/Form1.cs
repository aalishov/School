using P04_VehicleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_VehicleWinFormApp
{
    public partial class Form1 : Form
    {
        private Car car;
        private Truck truck;
        public Form1()
        {
            InitializeComponent();
        }

        private void createVehicle_Click(object sender, EventArgs e)
        {
            this.car = new Car(carBrandTextBox.Text, carModelTextBox.Text, double.Parse(carConsumptionTextBox.Text), double.Parse(carFuelTextBox.Text));
            this.truck = new Truck(truckBrandTextBox.Text, truckModelTextBox.Text, double.Parse(truckConsumptionTextBox.Text), double.Parse(truckFuelTextBox.Text));
            DesableTextBox();
        }

        private void DesableTextBox()
        {
            carBrandTextBox.Enabled = false;
            carModelTextBox.Enabled = false;
            carFuelTextBox.Enabled = false;
            carConsumptionTextBox.Enabled = false;
            truckModelTextBox.Enabled = false;
            truckBrandTextBox.Enabled = false;
            truckConsumptionTextBox.Enabled = false;
            truckFuelTextBox.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            double value = double.Parse(valueTextBox.Text);

            if (driveRadioButton.Checked)
            {
                if (carRadioButton.Checked)
                {
                    resultLabel.Text = car.Drive(value);
                }
                else if (truckRadioButton.Checked)
                {
                    resultLabel.Text = truck.Drive(value);
                }
                else
                {
                    resultLabel.Text = "Invalid vehicle!";
                }
            }
            else if (refuelRadioButton.Checked)
            {
                if (carRadioButton.Checked)
                {
                    resultLabel.Text = car.Refuel(value);
                }
                else if (truckRadioButton.Checked)
                {
                    resultLabel.Text = truck.Refuel(value);
                }
                else
                {
                    resultLabel.Text = "Invalid vehicle!";
                }
            }
            else
            {
                resultLabel.Text = "Not suported command!";
            }

            carFuelTextBox.Text = car.Fuel.ToString();
            truckFuelTextBox.Text = truck.Fuel.ToString();
        }
    }
}
