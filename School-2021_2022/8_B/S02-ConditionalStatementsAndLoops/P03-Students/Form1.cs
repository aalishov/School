using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int girlsA = int.Parse(textBoxGirlsA.Text);
            int boysA = int.Parse(textBoxBoysA.Text);
            int girlsB = int.Parse(textBoxGirlsB.Text);
            int boysB = int.Parse(textBoxBoysB.Text);
            int girlsV = int.Parse(textBoxGirlsV.Text);
            int boysV = int.Parse(textBoxBoysV.Text);
            int total = 0;
            if (radioButtonGirls.Checked)
            {
                if (checkBoxClassA.Checked)
                {
                    total += girlsA;
                }
                if (checkBoxClassB.Checked)
                {
                    total += girlsB;
                }
                if (checkBoxClassV.Checked)
                {
                    total += girlsV;
                }
            }
            else if (radioButtonBoys.Checked)
            {
                if (checkBoxClassA.Checked)
                {
                    total += boysA;
                }
                if (checkBoxClassB.Checked)
                {
                    total += boysB;
                }
                if (checkBoxClassV.Checked)
                {
                    total += boysV;
                }
            }
            else
            {
                if (checkBoxClassA.Checked)
                {
                    total += boysA+girlsA;
                }
                if (checkBoxClassB.Checked)
                {
                    total += boysB+girlsB;
                }
                if (checkBoxClassV.Checked)
                {
                    total += boysV+girlsV;
                }
            }
            labelResult.Text = total.ToString();
        }
    }
}
