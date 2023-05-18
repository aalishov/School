using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_CountNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[richTextBox1.Lines.Count()];
            int p = int.Parse(textBox1.Text);
            int q = int.Parse(textBox2.Text);

            int countInterval = 0;
            int countEven = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(richTextBox1.Lines[i]);
                // Count nums in interval [p;q]
                if (nums[i] >= p && nums[i] <= q) { countInterval++; }
                if (nums[i] % 2 == 0) { countEven++; }
            }

            label4.Text = countInterval.ToString();
            label6.Text = countEven.ToString();
        }
    }
}
