using System.Collections.Generic;

public interface ILieutenantGeneral
{
    IReadOnlyList<Private> Privates { get; }

    void Add(Private p);
}