using System;
class Program
{
    static void Main(string[] args)
    {
        DateTime peterBirthday = new DateTime(1996, 11, 27);
        DateTime mariaBirthday = new DateTime(1995, 6, 14);
        Console.WriteLine("Peter's birth date: {0:d-MMM-yyyy}", peterBirthday);
        // 27-Nov-1996
        Console.WriteLine("Maria's birth date: {0:d-MMM-yyyy}", mariaBirthday);
        // 14-Jun-1995
        var mariaAfter18Months = mariaBirthday.AddMonths(18);
        Console.WriteLine("Maria after 18 months: {0:d-MMM-yyyy}", mariaAfter18Months);
        // 14-Dec-1996
        TimeSpan ageDiff = peterBirthday.Subtract(mariaBirthday);
        Console.WriteLine("Maria older than Peter by: {0} days", ageDiff.Days);
        // 532 days
    }
}

