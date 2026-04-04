using P02_CarsCatalogFormApp.Data;

namespace P02_CarsCatalogFormApp
{
    public partial class MainForm : Form
    {
        private AppDbContext context = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            ManufacturerForm manufacturerForm = new ManufacturerForm(context);
            manufacturerForm.ShowDialog();
        }
    }
}
