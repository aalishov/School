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
        private Bus bus;
        public Form1()
        {
            InitializeComponent();
            EnableDisableFormOperationComponents(false);
        }

        private void createVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                this.car = new Car(carBrandTextBox.Text, carModelTextBox.Text, double.Parse(carConsumptionTextBox.Text), double.Parse(carFuelTextBox.Text));
                this.truck = new Truck(truckBrandTextBox.Text, truckModelTextBox.Text, double.Parse(truckConsumptionTextBox.Text), double.Parse(truckFuelTextBox.Text));
                this.bus = new Bus(busBrandTextBox.Text, busModelTextBox.Text, double.Parse(busConsumtionTextBox.Text), double.Parse(busFuelTextBox.Text));
                this.busCurrentPassengersCountLabel.Text = bus.CurrentPassengersCount.ToString();
                DesableInputTextBox();
                EnableDisableFormOperationComponents(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = trackBar1.Value;

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
                    else if (busRadioButton.Checked)
                    {
                        resultLabel.Text = bus.Drive(value);
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
                    else if (busRadioButton.Checked)
                    {
                        resultLabel.Text = bus.Refuel(value);
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
                busFuelTextBox.Text = bus.Fuel.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

          
        }


        private void EnableDisableFormOperationComponents(bool isEnabled)
        {
            carRadioButton.Enabled = isEnabled;
            truckRadioButton.Enabled = isEnabled;
            driveRadioButton.Enabled = isEnabled;
            busRadioButton.Enabled = isEnabled;
            refuelRadioButton.Enabled = isEnabled;
            executeButton.Enabled = isEnabled;
            trackBar1.Enabled = isEnabled;
            addPassengersButton.Enabled = isEnabled;
            removePassengersButton.Enabled = isEnabled;
        }

        private void DesableInputTextBox()
        {
            carBrandTextBox.Enabled = false;
            carModelTextBox.Enabled = false;
            carFuelTextBox.Enabled = false;
            carConsumptionTextBox.Enabled = false;
            truckModelTextBox.Enabled = false;
            truckBrandTextBox.Enabled = false;
            truckConsumptionTextBox.Enabled = false;
            truckFuelTextBox.Enabled = false;
            busModelTextBox.Enabled = false;
            busBrandTextBox.Enabled = false;
            busConsumtionTextBox.Enabled = false;
            busFuelTextBox.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void addPassengersButton_Click(object sender, EventArgs e)
        {
            this.bus.AddPassenger();
            this.busCurrentPassengersCountLabel.Text = bus.CurrentPassengersCount.ToString();
        }

        private void removePassengersButton_Click(object sender, EventArgs e)
        {
            this.bus.RemovePassenger();
            this.busCurrentPassengersCountLabel.Text = bus.CurrentPassengersCount.ToString();
        }
    }
}
