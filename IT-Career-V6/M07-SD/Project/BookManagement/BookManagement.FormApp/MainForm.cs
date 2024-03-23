using BookManagement.Data;
using BookManagement.Services;
using BookManagement.Services.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagement.FormApp
{
    public partial class MainForm : Form
    {
        private AppDbContext context = new AppDbContext();
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
            radioButton1.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                BooksService service = new BooksService(context);
                string[] result = null;
                if (radioButton1.Checked)
                {
                    result = service.Search(BookSearchBy.Title, txtSearch.Text);
                }
                else if (radioButton2.Checked)
                {
                    result = service.Search(BookSearchBy.Author, txtSearch.Text);
                }
                listBox1.Items.Clear();
                if (result.Length != 0)
                {
                    listBox1.Items.AddRange(result);
                }
                else
                {
                    listBox1.Items.Add("Items not found!");
                }
            }
            else
            {
                errorProvider1.SetError(txtSearch, "Needs to contain a text");

            }
        }
    }
}
