﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pilot
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int? Rating { get; set; }

    public virtual ICollection<PilotAircraft> PilotAircrafts { get; set; } = new List<PilotAircraft>();
}

