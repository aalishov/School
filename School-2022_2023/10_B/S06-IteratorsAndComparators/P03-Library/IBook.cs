using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public interface IBook
    {
        IReadOnlyList<string> Authors { get; set; }
        string Title { get; set; }
        int Year { get; set; }

    }
}