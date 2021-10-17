using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headhunt.Entities.Workers.Contracts
{
    public interface IWorker
    {
        string Name { get; }
        int Experience { get; }
        string Description { get; }
        int Salary { get; }
    }
}
