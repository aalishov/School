using System.Collections.Generic;

public interface ICommando
{
    IReadOnlyCollection<Mission> Missions { get; }
}