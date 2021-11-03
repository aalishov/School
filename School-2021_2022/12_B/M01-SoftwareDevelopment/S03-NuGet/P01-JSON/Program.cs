using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace P01_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "John", "Biden", 16, new List<int>() { 3, 2, 3, 4, 2 });

            string output = JsonConvert.SerializeObject(s, Formatting.Indented);

            Student s2 = JsonConvert.DeserializeObject<Student>(output);

            Console.WriteLine(output);
        }
    }
}
