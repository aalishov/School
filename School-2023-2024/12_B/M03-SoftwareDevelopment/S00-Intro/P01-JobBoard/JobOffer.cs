using System.Text;

public abstract class JobOffer
{
    private string jobTitle;
    private string company;
    private double salary;

    protected JobOffer(string jobTitle, string company, double salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public string JobTitle
    {
        get { return jobTitle; }
        private set
        {
            if (value.Length >= 3 && value.Length <= 30)
                jobTitle = value;
            else
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
            
        }
    }
    public string Company
    {
        get => company;
        private set
        {
            if (value.Length >= 3 && value.Length <= 30)
            {
                company = value;
            }
            else
            throw new ArgumentException("Company should be between 3 and 30 characters!");
        }
    }
    public double Salary
    {
        get => salary;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary should be 0 or positive!");
            }
            salary = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"JobTitle: {JobTitle}");
        sb.AppendLine($"Company: {Company}");
        sb.AppendLine($"Salary: {Salary:F2} BGN");
        return sb.ToString().TrimEnd();
    }
}

