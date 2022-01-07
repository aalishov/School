using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P02_Cars.Models.Home
{
    public class InfoViewModel
    {
        public string OsVersion { get => Environment.OSVersion.ToString(); }

        public string DayOfWeek  { get => DateTime.UtcNow.DayOfWeek.ToString(); }

        public string Year { get => DateTime.UtcNow.Year.ToString(); }

        public int ManufacturersCout { get; set; }
    }
}
