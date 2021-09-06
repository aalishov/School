namespace P01_VideoLibrary
{
    public class Movie
    {
        private string title;
        private double rating;

        public Movie(string title, double rating)
        {
            this.Title = title;
            this.Rating = rating;
        }

        public string Title
        {
            get { return $"{this.title}"; }
            set { this.title = value; }
        }

        public double Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }

        public override string ToString()
        {
            return $"Movie {this.Title} is with {this.Rating} rating.";
        }

    }
}
