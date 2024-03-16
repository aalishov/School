using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.FormApp.ViewModels
{
    public class BooksViewModel
    {
        public List<BookViewModel> Books { get; set; } = new List<BookViewModel>();
    }
}
