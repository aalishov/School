using BrokerCompany.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BrokerCompany.WinFormsApp
{
    public partial class CreateCompanyForm : Form
    {
        private readonly CompanyController companyController;

        public CreateCompanyForm(CompanyController companyController)
        {
            InitializeComponent();
            this.companyController = companyController;
        }

        private void buttonCreateCompany_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            try
            {
                List<string> args = new List<string>() { textBoxComoanyName.Text };
                result = companyController.CreateCompany(args);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
          
            MessageBox.Show(result);
        }

        private void CreateCompanyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
