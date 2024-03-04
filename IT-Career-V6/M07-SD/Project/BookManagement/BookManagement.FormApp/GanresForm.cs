using BookManagement.Common;
using BookManagement.Data.Models;
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
            btnAction.Text = rbAdd.Text;
            rbAdd.Checked = true;
            rbDelete.Enabled = false;
            rbUpdate.Enabled = false;

            //Default asc order
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

            lblCount.Text = totalItems.ToString();
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
            currentPage = 1;
            UpdatePagination();
            LoadGanres();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] info = listBox1.Text.Split(" - ");
            txtId.Text = info[0];
            txtName.Text = info[1];

            rbUpdate.Enabled = true;
            rbDelete.Enabled = true;

            RadioCheckedFalse();

            btnAction.Enabled = false;
        }

        private void RadioCheckedFalse()
        {
            //Remove radio selection
            rbAdd.Checked = false;
            rbDelete.Checked = false;
            rbUpdate.Checked = false;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbAdd.Text;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;

            rbUpdate.Enabled = false;
            rbDelete.Enabled = false;
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbUpdate.Text;
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Enabled = true;
            btnAction.Text = rbDelete.Text;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                // Add ganre
                if (rbAdd.Checked)
                {
                    Ganre ganre = new Ganre() { Name = txtName.Text };
                    int id = service.Add(ganre);
                    MessageBox.Show(string.Format(OutputMessages.AddGanre, id, ganre.Name));
                }
                // Edit ganre
                else if (rbUpdate.Checked)
                {
                    int id = int.Parse(txtId.Text);
                    string name = txtName.Text;
                    service.EditGanre(id, name);
                    MessageBox.Show(string.Format(OutputMessages.EditGanre, id));
                }
                // Delete ganre
                else if (rbDelete.Checked)
                {
                    int id = int.Parse(txtId.Text);
                    service.DeleteGanre(id);
                    MessageBox.Show(string.Format(OutputMessages.DeleteGanre, id));
                }
                txtId.Text = string.Empty;
                txtName.Text = string.Empty;

                RadioCheckedFalse();
                UpdatePagination();
                LoadGanres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
