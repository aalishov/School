using BookManagement.Data.Models;
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

namespace BookManagement.FormApp
{
    public partial class BooksForm : Form
    {
        private BooksService service = new BooksService();
        private GanresService ganresService = new GanresService();

        //Pagination variables
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int pageCount = 0;
        private int totalItems = 0;
        private bool ascSort = true;
        private BookSortBy sortBy = BookSortBy.Title;

        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            UpdatePagination();
            LoadBooks();
        }

        private void LoadBooks()
        {
            dataGridView1.DataSource = service
                .GetBooks(currentPage, itemsPerPage, ascSort, sortBy)
                .Select(x => new BookViewModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Author = x.Author,
                    Price = x.Price,
                    Year = x.Year,
                    Ganres = string.Join(", ", x.Ganres.Select(x => x.Ganre.Name))
                })
                .ToList();
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
            if (service.GetBooksCount() < 10)
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
                    service.Add(book);
                }
            }
        }

        private void UpdatePagination()
        {
            totalItems = service.GetBooksCount();
            pageCount = (int)Math.Ceiling((double)totalItems / itemsPerPage);

            //lblCount.Text = totalItems.ToString();
        }
    }
}
