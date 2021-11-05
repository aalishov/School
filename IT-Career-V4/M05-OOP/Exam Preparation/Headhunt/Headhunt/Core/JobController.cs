using Headhunt.Core.Contracts;
using Headhunt.Entities.Positions;
using Headhunt.Entities.Positions.Contracts;
using Headhunt.Entities.Workers;
using Headhunt.Entities.Workers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Headhunt.Core
{
    public class JobController : IJobController
    {
        private readonly IList<IPosition> positions;
        private readonly IList<IWorker> workers;

        public JobController()
        {
            this.positions = new List<IPosition>();
            this.workers = new List<IWorker>();
        }
        public string CreatePosition(List<string> args)
        {
            int refNumber = int.Parse(args[0]);
            string positionType = args[1]; // “Remote” или “Onsite”
            string positionName = args[2];
            string description = args[3];
            string companyName = args[4];


            if (!this.positions.Any(x => x.RefNumber.Equals(refNumber)))
            {
                if (positionType.Equals("Remote"))
                {
                    this.positions.Add(new RemotePosition(refNumber, positionName, description, companyName));
                }
                else if (positionType.Equals("Onsite"))
                {
                    string location = args[5];
                    this.positions.Add(new OnsitePosition(refNumber, positionName, description, companyName, location));
                }
                else
                {
                    return $"Invalid type: {positionType}!";
                }
                return $"{refNumber}: {positionName} opened!";
            }
            return $"Position with number: {refNumber} already exists!";
        }

        public string CreateWorker(List<string> args)
        {
            string name = args[0];
            int experience = int.Parse(args[1]);
            string description = args[2];
            int salary = int.Parse(args[3]);

            if (!this.workers.Any(x => x.Name.Equals(name)))
            {
                this.workers.Add(new Worker(name, experience, description, salary));
                return $"Successfully added worker {name} with {experience} years of experience!";
            }
            return $"Can’t add worker {name}.";
        }

        public string Apply(List<string> args)
        {
            string workerName = args[0];
            int refNumber = int.Parse(args[1]);
            if (this.workers
                .Any(x => x.Name.Equals(workerName))
                && this.positions
                .Any(x => x.RefNumber.Equals(refNumber)))
            {
                IWorker worker = this.workers.FirstOrDefault(x => x.Name.Equals(workerName));
                IPosition position = this.positions.FirstOrDefault(x => x.RefNumber.Equals(refNumber));
                position.Apply(worker);
                return $"Worker {workerName} applied for position {refNumber} called {position.PositionName}.";
            }
            return null;
        }

        public string PositionInfo(List<string> args)
        {
            int refNumber = int.Parse(args[0]);

            if (this.positions.Any(x=>x.RefNumber.Equals(refNumber)))
            {
                return this.positions.FirstOrDefault(x => x.RefNumber.Equals(refNumber)).ToString();
            }
            return null;
        }
        public string WorkerInfo(List<string> args)
        {
            string workerName = args[0];
            if (this.workers.Any(x=>x.Name.Equals(workerName)))
            {
                return this.workers.FirstOrDefault(x => x.Name.Equals(workerName)).ToString();
            }
            return null;
        }
        public string ListPositionApplicantsByExperience(List<string> args)
        {
            int refNumber = int.Parse(args[0]);

            if (this.positions.Any(x=>x.RefNumber.Equals(refNumber)))
            {
                IPosition position = this.positions.FirstOrDefault(x => x.RefNumber.Equals(refNumber));

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Position {refNumber}: {position.PositionName} by {position.CompanyName}");
                sb.AppendLine("Applicants:");
                if (position.Applicants.Any())
                {
                    foreach (var a in position.Applicants.OrderByDescending(x=>x.Experience))
                    {
                        sb.AppendLine($"{a.Name} - {a.Experience}");
                    }
                }
                else
                {
                    sb.AppendLine("N/A");
                }
                return sb.ToString().TrimEnd();
            }
            return null;
        }
    }
}
