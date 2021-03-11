using System;
using System.Windows.Forms;

namespace P08_TravelWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonSummer.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isNum = decimal.TryParse(textBoxBudget.Text, out _);

            if (!isNum || !(decimal.Parse(textBoxBudget.Text) > 0))
            {
                MessageBox.Show("Invalid budget!");
            }
            else
            {
                decimal budget = decimal.Parse(textBoxBudget.Text);

                string season = radioButtonSummer.Checked ? "summer" : "winter";


                string destination = string.Empty;
                string place = string.Empty;
                decimal expenses = 0.0m;

                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    if (season == "summer")
                    {
                        place = "Camp";
                        expenses = budget * 30 / 100;
                    }
                    else
                    {
                        place = "Hotel";
                        expenses = budget * 70 / 100;
                    }
                }
                else if (budget > 100 && budget <= 1000)
                {
                    destination = "Balkans";
                    if (season == "summer")
                    {
                        place = "Camp";
                        expenses = budget * 40 / 100;
                    }
                    else
                    {
                        place = "Hotel";
                        expenses = budget * 80 / 100;
                    }
                }
                else
                {
                    destination = "Europe";
                    place = "Hotel";
                    expenses = budget * 90 / 100;
                }
                labelResult.Text = $"Somewhere in {destination}\n{place} - {expenses:f2}";
            }

        }
    }
}
