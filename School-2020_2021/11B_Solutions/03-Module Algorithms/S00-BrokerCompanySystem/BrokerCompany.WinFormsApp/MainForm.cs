using BrokerCompany.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokerCompany.WinFormsApp
{
    public partial class MainForm : Form
    {
        CompanyController companyController = new CompanyController();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioCreateCompany.Checked)
            {
                var form = new CreateCompanyForm(companyController);
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
