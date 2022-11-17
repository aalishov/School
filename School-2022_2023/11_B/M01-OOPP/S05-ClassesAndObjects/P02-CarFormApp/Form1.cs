using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_CarFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Make = "Opel";
            c.Model = "Astra";
            c.Year = 2018;
            c.FuelConsumption = 8;
            c.FuelQuantity = 22;
            c.Drive(100);
            c.Drive(150);
            c.Drive(50);
            label1.Text = c.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Make = "Opel";
            c.Model = "Astra";
            c.Year = 2018;
            c.FuelConsumption = 8;
            c.FuelQuantity = 22;
            c.Drive(100);
            c.Drive(150);
            c.Drive(50);
            c.Drive(50);
        }
    }
}
