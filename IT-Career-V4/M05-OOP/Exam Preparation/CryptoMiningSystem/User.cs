namespace CryptoMiningSystem
{
    using System;
    public class User : IUser
    {
        private string name;
        private decimal money;
        public User(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                name = value;
            }
        }
        public int Stars { get { return (int)this.Money / 100; }  }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }
                money = value;
            }
        }
        public IComputer Computer { get;  set; }
    }
}
