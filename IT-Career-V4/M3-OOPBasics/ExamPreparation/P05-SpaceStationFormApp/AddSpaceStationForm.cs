using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P05_SpaceStationFormApp
{
    public partial class AddSpaceStationForm : Form
    {
        private Dictionary<string, SpaceStation> spaceStations;
        public AddSpaceStationForm(Dictionary<string, SpaceStation> spaceStations)
        {
            InitializeComponent();
            this.spaceStations = spaceStations;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int capacity = int.Parse(textBox2.Text);
            if (!spaceStations.ContainsKey(name))
            {
                this.spaceStations.Add(name, new SpaceStation(name, capacity));
                MessageBox.Show("Successfully added!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Space station alreadyy exist!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
