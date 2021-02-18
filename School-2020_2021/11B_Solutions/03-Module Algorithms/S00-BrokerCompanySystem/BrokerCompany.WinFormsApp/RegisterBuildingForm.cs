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
    public partial class RegisterBuildingForm : Form
    {
        CompanyController companyController;
        public RegisterBuildingForm(CompanyController companyController)
        {
            InitializeComponent();
            this.companyController = companyController;
        }

        private void RegisterBuildingForm_Load(object sender, EventArgs e)
        {
           var companies=this.companyController.CompanyList();
            foreach (var company in companies)
            {
                listBoxCompanies.Items.Add(company);
                comboBox1.Items.Add(company);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = listBoxCompanies.SelectedItem.ToString();
        }
    }
}
