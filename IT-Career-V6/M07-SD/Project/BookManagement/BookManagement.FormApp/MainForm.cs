using BookManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.FormApp
{
    public partial class MainForm : Form
    {
        AppDbContext context = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGanres_Click(object sender, EventArgs e)
        {
            GanresForm form = new GanresForm(context);
            form.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm(context);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
