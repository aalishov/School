using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            int result = x.Year.CompareTo(y.Year);
            if (result == 0)
            {
                result = x.Title.CompareTo(y.Title);
            }
            return result;
        }
    }
}
