

namespace Product.FormApp
{
    using Product.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Models;
    public partial class MainForm : Form
    {
        private ProductsService service = new ProductsService();
        private int editId = 0;
        private int page = 1;
        private int pageCount=0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
            comboBox1.Items.AddRange(service.GetCategoriesName());
            lblCurrentPage.Text = page.ToString();
            CalculatePageCount();
        }

        private void CalculatePageCount()
        {
           
            pageCount = (int)Math.Ceiling(service.ProductsCount() / 10.0);
            lblPageCount.Text = pageCount.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if ((page-1)<1)
            {
                page = pageCount;
            }
            else
            {
                page--;
            }
            lblCurrentPage.Text = page.ToString();
            UpdateGrid(page);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((page+1) > pageCount)
            {
                page = 1;
            }
            else
            {
                page++;
            }
            lblCurrentPage.Text = page.ToString();
            UpdateGrid(page);
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            string imageUrl = "https://th.bing.com/th/id/OIP.tcDCCEB3BogiiIKJkxdJUAHaHa?w=158&h=180&c=7&r=0&o=5&dpr=1.25&pid=1.7";
            try
            {
                service.AddProduct(txtName.Text, txtPrice.Text, txtStock.Text, comboBox1.Text, imageUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CalculatePageCount();
            ClearTextBoxes();
            UpdateGrid();
        }


        private void UpdateGrid(int page=1)
        {
            dataGridView1.VirtualMode = true;
            dataGridView1.DataSource = service.GetProducts(page);
            dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[7].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id=int.Parse(item[0].Value.ToString());
                editId = id;
                btnInsert.Enabled = false;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                int id = int.Parse(item[0].Value.ToString());
                service.DeleteProduct(id);
                CalculatePageCount();
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            service.UpdateProductPrice(editId, txtPrice.Text);
            btnInsert.Enabled = true;
            UpdateGrid();
            ClearTextBoxes();
            ResetSelect();
            ToggleSaveUpdate();
        }
        public void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }
        public void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }
        public void DisableSelect()
        {
            dataGridView1.Enabled=false;
        }

        public void UpdateTextBoxes(int id)
        {
            Product product=service.GetProduct(id);
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text=product.Stock.ToString();
            comboBox1.Text=product.Category.Name;
        }
        private void ClearTextBoxes()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType().Name == nameof(TextBox))
                {
                    ((TextBox)control).Text = String.Empty;
                }
            }
        }


    }
}
