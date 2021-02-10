using System;
using System.Collections.Generic;
using System.Text;

namespace MachinesCommon
{
    public interface IMachine
    {
        string MachineType { get; set; }
        string Start();
        string Stop();
    }
}
