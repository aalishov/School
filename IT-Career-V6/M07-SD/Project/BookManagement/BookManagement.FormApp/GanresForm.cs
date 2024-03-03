using BookManagement.Services;
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
    public partial class GanresForm : Form
    {
        GanresService service = new GanresService();

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;

        public GanresForm()
        {
            InitializeComponent();
        }

        private void GanresForm_Load(object sender, EventArgs e)
        {
            rdBtnAsc.Checked = true;
            comboBox1.SelectedText = itemsPerPage.ToString();

            UpdatePagination();

            LoadGanres();
        }

        private void LoadGanres()
        {
            listBox1.Items.Clear();
            string[] ganres = service.GetGanres(currentPage, itemsPerPage, ascSort)
                .Select(x => $"{x.Id} - {x.Name}")
                .ToArray();
            listBox1.Items.AddRange(ganres);
            lblPageInfo.Text = $"{currentPage}/{pageCount}";
        }

        private void UpdatePagination()
        {
            totalItems = service.GetGenresCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if ((currentPage - 1) > 0)
            {
                currentPage--;
            }
            else
            {
                currentPage = pageCount;
            }
            LoadGanres();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 <= pageCount)
            {
                currentPage++;
            }
            else
            {
                currentPage = 1;
            }
            LoadGanres();
        }

        private void rdBtnAsc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = true;
            LoadGanres();
        }

        private void rdBtnDesc_CheckedChanged(object sender, EventArgs e)
        {
            ascSort = false;
            LoadGanres();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemsPerPage = int.Parse(comboBox1.Text);
            UpdatePagination();
            LoadGanres();
        }
    }
}
