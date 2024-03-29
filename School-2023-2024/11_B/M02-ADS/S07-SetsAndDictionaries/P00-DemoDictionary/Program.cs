using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        SortedDictionary<int, string> numbers = new SortedDictionary<int, string>();
        Dictionary<string, string> numbersAsString = new Dictionary<string, string>();
        Dictionary<string, Dictionary<string, List<int>>> students = new Dictionary<string, Dictionary<string, List<int>>>();
        numbers.Add(1, "one");
        numbers.Add(6, "six");
        numbers.Add(2, "two");
        numbersAsString.Add("one","1");


        students.Add("John", new Dictionary<string, List<int>>());
        students["John"].Add("Math", new List<int> { 5, 2, 3, 4, });
        students["John"].Add("ICT", new List<int> { 5, 6, 6, 4, });
        students["John"].Add("Biology", new List<int> { 3, 3, 3, 4, });
        students.Add("Alex", new Dictionary<string, List<int>>());
        students["Alex"].Add("Biology", new List<int> { 5, 2, 3, 4, });

        if (!students.ContainsKey("John"))
        {
            students.Add("John", new Dictionary<string, List<int>>());
        }
        else
        {
            Console.WriteLine("Already exist!");
        }


        //Console.WriteLine(numbers.Remove(7));
        //Console.WriteLine(numbers.Remove(6));

        foreach (var item in numbers)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}");
            foreach (var subject in student.Value)
            {
                Console.WriteLine($"\t{subject.Key} =>{string.Join(", ", subject.Value)}"); ;
            }
        }

    }
}

