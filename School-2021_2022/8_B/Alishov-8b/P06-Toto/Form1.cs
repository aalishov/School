using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_Toto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = GetRandom();
            textBox1.Text = list[0].ToString();
            textBox2.Text = list[1].ToString();
            textBox3.Text = list[2].ToString();
            textBox4.Text = list[3].ToString();
            textBox5.Text = list[4].ToString();
            textBox6.Text = list[5].ToString();
        }
        private List<int> GetRandom()
        {

            Random r = new Random();
            List<int> nums = new List<int>();
            while (nums.Count<6)
            {
                nums.Add(r.Next(1, 49));
                nums = nums.Distinct().ToList();
            }
            return nums;
        }
    }
}
