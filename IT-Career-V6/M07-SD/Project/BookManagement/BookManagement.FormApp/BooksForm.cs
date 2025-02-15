﻿using BookManagement.Data.Models;
using BookManagement.Services;
using BookManagement.FormApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManagement.Services.Enums;
using BookManagement.Common;
using BookManagement.Data;

namespace BookManagement.FormApp
{
    public partial class BooksForm : Form
    {
        private BooksService booksService ;
        private GanresService ganresService ;
        private int currentBookId = -1;

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;
        private BookSortBy sortBy = BookSortBy.Title;

        public BooksForm(AppDbContext context)
        {
            InitializeComponent();
            ganresService = new GanresService(context);
            booksService = new BooksService(context);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            UpdatePagination();
            LoadBooks();
            pictureBox1.Load(GlobalConstants.DefaultImg);

            cmbOrderBy.Items.AddRange(System.Enum.GetNames<BookSortBy>());
            cmbOrder.SelectedIndex = 0;
            cmbOrderBy.SelectedIndex = 0;
        }

        private void LoadBooks()
        {
            dataGridView1.DataSource = booksService
                .GetBooks(currentPage, itemsPerPage, ascSort, sortBy)
                .Select(x => new BookViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Author = x.Author,
                    Price = x.Price,
                    Year = x.Year,
                    Ganres = string.Join(", ", x.Ganres.Select(x => x.Ganre.Name)),
                    ImageUrl = x.ImageUrl != null ? x.ImageUrl : GlobalConstants.DefaultImg,
                })
                .ToList();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblPages.Text = $"{currentPage}/{pageCount}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
            LoadBooks();
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
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (booksService.GetBooksCount() < 10)
            {
                List<int> ganres = ganresService.GetGanresId();

                for (int i = 0; i < 50; i++)
                {
                    Book book = new Book()
                    {
                        Title = $"Book {i}",
                        Author = $"Author {new Random().Next(1, 11)}",
                        Year = new Random().Next(2000, 2025),
                        Price = new Random().Next(10, 70),
                    };
                    book.Ganres.Add(new BookGanre() { GanreId = ganres[new Random().Next(0, ganres.Count)] });
                    booksService.Add(book);
                }
            }
        }

        private void UpdatePagination()
        {
            totalItems = booksService.GetBooksCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            lblCount.Text = totalItems.ToString();
            lblPages.Text = $"{currentPage}/{pageCount}";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0];
            currentBookId = int.Parse(item.Cells[0].Value.ToString());
            txtTitle.Text = item.Cells[1].Value.ToString();
            cmbAuthor.Text = item.Cells[2].Value.ToString();
            dateTimePicker1.Value = new DateTime(int.Parse(item.Cells[3].Value.ToString()), 1, 1);
            txtPrice.Text = item.Cells[4].Value.ToString();
            try
            {
                pictureBox1.Load(item.Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                pictureBox1.Load(GlobalConstants.DefaultImg);
            }
            rbUpdate.Checked = true;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Add";
            ClearComponents();
            cmbAuthor.Items.AddRange(booksService.GetAuthorsList());
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Update";
        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            btnAction.Text = "Delete";
        }

        public void ClearComponents()
        {
            txtTitle.Text = string.Empty;
            cmbAuthor.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtPrice.Text = string.Empty;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAdd.Checked)
                {
                    Book book = new Book()
                    {
                        Title = txtTitle.Text,
                        Author = cmbAuthor.Text,
                        Year = dateTimePicker1.Value.Year,
                        Price = double.Parse(txtPrice.Text)
                    };
                    int id = booksService.Add(book);
                    MessageBox.Show(string.Format(OutputMessages.AddBook, id));
                }
                else if (rbDelete.Checked)
                {
                    if (currentBookId != -1)
                    {
                        int id = booksService.DeleteBook(currentBookId);
                        MessageBox.Show(string.Format(OutputMessages.DeleteBook, id));
                    }
                    else
                    {
                        MessageBox.Show(OutputMessages.BookNotSelected);
                    }
                }
                else if (rbUpdate.Checked)
                {
                    if (currentBookId != -1)
                    {
                        Book book = booksService.GetBookById(currentBookId);
                        book.Title = txtTitle.Text;
                        book.Price = double.Parse(txtPrice.Text);
                        book.Author = cmbAuthor.Text;
                        book.Year = dateTimePicker1.Value.Year;
                        int id = booksService.EditBook(book);
                        MessageBox.Show(string.Format(OutputMessages.EditBook, id));
                    }
                    else
                    {
                        MessageBox.Show(OutputMessages.BookNotSelected);
                    }

                }
                currentBookId = -1;
                ClearComponents();
                UpdatePagination();
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortBy = Enum.Parse<BookSortBy>(cmbOrderBy.Text);
            LoadBooks();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ = cmbOrder.Text == "ASC" ? ascSort = true : ascSort = false;
            LoadBooks();
        }

        private void btnGanres_Click(object sender, EventArgs e)
        {
            BookGanresForm form = new BookGanresForm(booksService, ganresService, currentBookId);
            form.ShowDialog();
        }
    }
}
