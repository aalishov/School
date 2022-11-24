using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_ComponentsProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (txtInput.Visible)
            {
                txtInput.Visible = false;
                btnFirst.Text = "Show";
            }
            else
            {
                txtInput.Visible = true;
                btnFirst.Text = "Hide";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFirst.Text = "Hide";
            txtInput.Text = "Enter title here";
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtInput.Enabled)
            {
                txtInput.Enabled = false;
                btnActivate.Text = "Enable";
            }
            else
            {
                txtInput.Enabled = true;
                btnActivate.Text = "Desable";
            }
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                label1.Text = txtInput.Text;
                txtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter new title!");
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
