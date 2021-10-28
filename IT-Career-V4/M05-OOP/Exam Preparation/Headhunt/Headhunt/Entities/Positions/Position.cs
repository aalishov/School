namespace Headhunt.Entities.Positions
{
    using Headhunt.Entities.Positions.Contracts;
    using Headhunt.Entities.Workers.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Position : IPosition
    {
        private string positionName;
        private string companyName;

        protected Position(int refNumber, string positionName, string description, string companyName, string location)
        {
            this.RefNumber = refNumber;
            this.PositionName = positionName;
            this.Description = description;
            this.CompanyName = companyName;
            this.Location = location;
            this.Applicants = new List<IWorker>();
        }

        public int RefNumber { get; private set; }

        public string PositionName
        {
            get { return positionName; }
            //TODO: Check property PositionName
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Position name cannot be null, empty or whitespace.");
                }
                positionName = value;
            }
        }

        public string Description { get; private set; }

        public string CompanyName
        {
            get { return companyName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Company name cannot be null, empty or whitespace.");
                }
                companyName = value;
            }
        }

        public string Location { get; private set; }

        public List<IWorker> Applicants { get; private set; }


        public void Apply(IWorker worker)
        {
            this.Applicants.Add(worker);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Position {this.RefNumber}: {this.PositionName} by {this.CompanyName}");
            sb.AppendLine($"Description: {this.Description}");
            sb.AppendLine($"Location: {this.Location}");
            return sb.ToString().TrimEnd();
        }
    }
}
