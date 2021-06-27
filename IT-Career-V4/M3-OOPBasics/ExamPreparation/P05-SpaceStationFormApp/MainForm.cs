using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_SpaceStationFormApp
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, SpaceStation> spaceStations;
        public MainForm()
        {
            InitializeComponent();
            this.spaceStations = new Dictionary<string, SpaceStation>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSpaceStationForm form = new AddSpaceStationForm(spaceStations);
            form.Show();
        }


        public void RefreshText()
        {
            richTextBox1.Clear();
            foreach (var item in this.spaceStations)
            {
                richTextBox1.Text += item.Value + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAstronautToSpaceStation form = new AddAstronautToSpaceStation(spaceStations);
            form.Show();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            RefreshText();
        }
    }
}
