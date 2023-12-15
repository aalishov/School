public class OnSiteJobOffer : JobOffer
{
    private string city;

    
    public OnSiteJobOffer(string city, string jobTitle, string company, double salary) : base(jobTitle, company, salary)
    {
        City = city;
    }
    public string City
    {
        get => city; 
        private set
        {
            if (value.Length>=3&&value.Length<=30)
            {
                city = value;
            }
            else
                throw new ArgumentException("City should be between 3 and 30 characters!");
        }
    }
    public override string ToString()
    {
        return base.ToString()+ $"\nCity: {City}";
    }

}

