using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headhunt.Core.Contracts
{
    using System.Collections.Generic;
    interface IJobController
    {
        string CreatePosition(List<string> args);
        string CreateWorker(List<string> args);
        string Apply(List<string> args);
        string PositionInfo(List<string> args);
        string WorkerInfo(List<string> args);
        string ListPositionApplicantsByExperience(List<string> args);
    }
}