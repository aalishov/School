namespace LinearSearch
{
    using System;
    internal class Search
    {
        // LinearSearch = Линейно търсене = O(n)
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }
    }
}
