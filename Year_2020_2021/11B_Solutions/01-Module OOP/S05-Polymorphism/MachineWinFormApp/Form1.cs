using MachinesCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Machine operator if free!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                Car car = new Car();
                MachineOperator mo = new MachineOperator(car);
                label1.Text = mo.ChangeMessage() + Environment.NewLine;
                label1.Text += mo.Start() + Environment.NewLine;
                label1.Text += mo.Stop() + Environment.NewLine;
            }
            else if(radioButtonLawn.Checked)
            {
                LawnMower lawnMower = new LawnMower();
                MachineOperator mo = new MachineOperator(lawnMower);
                label1.Text = mo.ChangeMessage() + Environment.NewLine;
                label1.Text += mo.Start() + Environment.NewLine;
                label1.Text += mo.Stop() + Environment.NewLine;
            }
            else
            {
                label1.Text = "Machine operator if free!";
            }
            
        }
    }
}
