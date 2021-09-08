using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P05_SpaceStationFormApp
{
    public partial class AddAstronautToSpaceStation : Form
    {
        private Dictionary<string, SpaceStation> spaceStations;
        public AddAstronautToSpaceStation(Dictionary<string, SpaceStation> spaceStations)
        {
            InitializeComponent();
            this.spaceStations = spaceStations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spaceStation = textBox1.Text;
            string name = textBox2.Text;
            int age = int.Parse(textBox3.Text);
            string country = textBox4.Text;

            if (spaceStations.ContainsKey(spaceStation))
            {
                spaceStations[spaceStation].Add(new Astronaut(name, age, country));
                MessageBox.Show("Astronaut is add to space station!");
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Space station not found!");
                ClearTextBox();
            }
        }
        private void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
