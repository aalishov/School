using Hospital.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.FormApp
{
    public partial class Form1 : Form
    {
        DoctorService service = new DoctorService();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in service.DoctorsNames())
            {
                listBox1.Items.Add(item);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var doctors = service.DoctorsNames();
            foreach (var item in service.DoctorsNames())
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
