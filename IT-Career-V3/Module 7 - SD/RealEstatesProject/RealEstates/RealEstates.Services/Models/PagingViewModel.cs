namespace RealEstates.Services.Models
{
    using System;
    public class PagingViewModel
    {
        public PagingViewModel()
        {
            this.ItemsPerPage = 10;
            this.PageNumber = 1;
        }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.ElementsCount / this.ItemsPerPage);

        public int ElementsCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
