using RealEstates.Data;
using RealEstates.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstates.WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PropertiesService propertiesService;
        private readonly WindowsFormService windowsFormService;
        public MainForm()
        {
            InitializeComponent();
            this.dbContext = new ApplicationDbContext();
            this.propertiesService = new PropertiesService(this.dbContext);
            this.windowsFormService = new WindowsFormService(this.dbContext);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonCreateProperty_Click(object sender, EventArgs e)
        {
            CreatePropertyForm form = new CreatePropertyForm(this.propertiesService, this.windowsFormService);
            form.Show();
        }


        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm form = new CatalogForm(this.propertiesService);
            form.Show();
        }
    }
}
