namespace P01_Game
{
    public class Pair
    {
        public Pair(int first, int second, bool isSpecial = false)
        {
            this.First = first;
            this.Second = second;
            this.IsSpecial = isSpecial;
        }

        public int First { get; set; }

        public int Second { get; set; }

        public bool IsSpecial { get; set; }

        public override string ToString()
        {
            return $"({this.First}, {this.Second})";
        }
    }
}
