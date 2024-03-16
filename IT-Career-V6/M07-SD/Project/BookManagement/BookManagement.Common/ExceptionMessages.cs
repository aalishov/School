namespace BookManagement.Common
{
    public class ExceptionMessages
    {
        //Ganres exception messages
        public const string InvalidGanreName = "Invalid ganre name!";
        public const string GanreAlreadyExyst = "Ganre already exist!";
        public const string GanreNotFound = "Ganre not found!";

        //Books exception messages
        public const string InvalidBookTitle = "Invalid book title!";
        public const string InvalidBookAuthor = "Invalid book auhtor!";
        public const string InvalidBookYear = "Year must be between {0} and {1}";
        public const string InvalidBookPrice = "Price must be positive!";
        public const string BookAlreadyExyst = "Book already exist!";
        public const string BookNotFound = "Book not found!";
    }
}
