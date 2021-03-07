using RealEstates.Services;
using RealEstates.Services.Models;
using RealEstates.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealEstates.WinFormsApp
{
    public partial class CatalogForm : Form
    {
        private readonly IPropertiesService propertiesService;
        private PropertiesViewModel model;

        public CatalogForm(IPropertiesService propertiesService)
        {
            InitializeComponent();
            this.propertiesService = propertiesService;
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            model = propertiesService.GetProperties();
            FillDataGrid();
            dataGridViewProperties.AutoResizeColumns();
            dataGridViewProperties.AutoSize = true;
            dataGridViewProperties.Columns[0].ReadOnly = true;
            dataGridViewProperties.Columns[4].ReadOnly = true;
        }

        private void FillDataGrid()
        {
            dataGridViewProperties.Rows.Clear();
            foreach (var property in model.Properties)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewProperties.Rows[0].Clone();
                row.Cells[0].Value = property.Id;
                row.Cells[1].Value = property.Price;
                row.Cells[2].Value = property.Size;
                row.Cells[3].Value = property.Floor;
                row.Cells[4].Value = property.District;
                this.dataGridViewProperties.Rows.Add(row);
            }
            labelPageInfo.Text = $"Страница: {model.PageNumber} / {model.PagesCount}\nИмоти: {model.ElementsCount}";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (model.HasNextPage)
            {
                model = propertiesService.GetProperties(model.NextPageNumber);
                FillDataGrid();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (model.HasPreviousPage)
            {
                model = propertiesService.GetProperties(model.PreviousPageNumber);
                FillDataGrid();
            }
        }

        private void dataGridViewProperties_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewProperties.CurrentRow;
            if (row.Cells[0].Value != null)
            {
                PropertyViewModel model = new PropertyViewModel();
                model.Id = int.Parse(row.Cells[0].Value.ToString());
                model.Price = int.Parse(row.Cells[1].Value.ToString());
                model.Size = int.Parse(row.Cells[2].Value.ToString());
                model.Floor = row.Cells[3].Value.ToString();
                model.District = row.Cells[4].Value.ToString();
                propertiesService.UpdateProperties(model);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var row = dataGridViewProperties.CurrentRow;

            int id = row.Cells[0].Value != null ? int.Parse(row.Cells[0].Value.ToString()) : -1;
            bool isDeleted = propertiesService.DeleteProperty(id);
            if (isDeleted)
            {
                model = propertiesService.GetProperties(model.PageNumber);
                FillDataGrid();
                MessageBox.Show("Записът е изтрит!");
            }
            else
            {
                MessageBox.Show("Не е намерен запис!");
            }
        }
    }
}
