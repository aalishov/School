using System.Collections.Generic;

public interface IEngineer
{
    IReadOnlyCollection<Repair> IReadOnlyEngineers { get; }
}