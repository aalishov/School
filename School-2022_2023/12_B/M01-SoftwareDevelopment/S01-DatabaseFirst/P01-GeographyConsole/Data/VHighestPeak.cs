using System;
using System.Collections.Generic;

namespace P01_GeographyConsole.Data;

public partial class VHighestPeak
{
    public int Id { get; set; }

    public string PeakName { get; set; } = null!;

    public int Elevation { get; set; }

    public int MountainId { get; set; }
}
