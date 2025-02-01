namespace BarberRating.ViewModels
{
    using System;
    public class PagingViewModel
    {
        public PagingViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index")
        {
            this.ItemsPerPage = itemsPerPage;
            this.ElementsCount=elementsCount;
            this.Action = action;
            this.Page = 1;
        }

        public int Page { get; set; }

        public bool HasPreviousPage => this.Page > 1;

        public int PreviousPageNumber => this.Page - 1;

        public bool HasNextPage => this.Page < this.PagesCount;

        public int NextPageNumber => this.Page + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.ElementsCount / this.ItemsPerPage);

        public int ElementsCount { get; set; }

        public int ItemsPerPage { get; set; }

        public string Action { get; set; }

    }


}
