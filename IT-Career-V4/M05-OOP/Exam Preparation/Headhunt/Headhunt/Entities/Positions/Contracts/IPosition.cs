using Headhunt.Entities.Workers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headhunt.Entities.Positions.Contracts
{
    interface IPosition
    {
        int RefNumber { get; }
        string PositionName { get; }
        string Description { get; }
        string CompanyName { get; }
        string Location { get; }
        List<IWorker> Applicants { get; }

        void Apply(IWorker worker);
    }
}