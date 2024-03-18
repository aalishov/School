using BookManagement.Data.Models;
using BookManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.FormApp
{
    public partial class BookGanresForm : Form
    {
        BooksService booksService;
        GanresService ganresService;
        Book currentBook;
        public BookGanresForm(BooksService booksService, GanresService ganresService, int bookId)
        {
            InitializeComponent();
            this.booksService = booksService;
            this.ganresService = ganresService;
            currentBook = booksService.GetBookById(bookId);
        }

        private void BookGanresForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = currentBook.Title;
            lblAuthor.Text = currentBook.Author;
            checkedListBox1.Items.AddRange(ganresService.GetAllGanres());
            LoadBookGanres();
        }

        private void LoadBookGanres()
        {
            List<string> bookGanres = currentBook.Ganres.Select(x => x.Ganre.Name).ToList();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (bookGanres.Any(x => x == checkedListBox1.Items[i].ToString()))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void btnUpdateGanres_Click(object sender, EventArgs e)
        {
            currentBook.Ganres.Clear();
            booksService.EditBookGanres(currentBook);
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string ganreName = checkedListBox1.CheckedItems[i].ToString();
                currentBook.Ganres.Add(new BookGanre() { Ganre = ganresService.GetGanreByName(ganreName) });
            }
            booksService.EditBookGanres(currentBook);
   

            MessageBox.Show("Book is updated!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
