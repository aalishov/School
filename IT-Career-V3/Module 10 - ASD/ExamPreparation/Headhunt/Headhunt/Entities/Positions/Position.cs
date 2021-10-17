using Headhunt.Entities.Positions.Contracts;
using Headhunt.Entities.Workers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Headhunt.Entities.Positions
{
    public class Position : IPosition
    {
        private string positionName;
        private string companyName;
        private List<IWorker> applicants;

        public Position(int refNumber, string positionName, string description, string companyName, string location)
        {
            this.RefNumber = refNumber;
            this.PositionName = positionName;
            this.Description = description;
            this.CompanyName = companyName;
            this.Location = location;
            this.applicants = new List<IWorker>();
        }

        public int RefNumber { get; set; }

        public string PositionName
        {
            get { return positionName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Position name cannot be null, empty or whitespace.");
                }
                positionName = value;
            }
        }

        public string Description { get; set; }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Company name cannot be null, empty or whitespace.");
                }
                companyName = value;
            }
        }

        public string Location { get; set; }

        public List<IWorker> Applicants { get => applicants; set => applicants = value; }

        public void Apply(IWorker worker)
        {
            this.applicants.Add(worker);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Position {RefNumber}: {PositionName} by {CompanyName}");
            sb.AppendLine($"Description: {Description}");
            sb.AppendLine($"Location: {Location}");
            return sb.ToString().TrimEnd();
        }
    }
}
