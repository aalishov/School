using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace P01_DemoJSON_XML
{
    class Program
    {
        static void Main()
        {
            //double[] grades = new double[] { 5, 3.2, 4 };
            //School school = new School() { Name = "Vasil Levski", Address = "Kristal 10", IsPrimarySchool = true, StudentsCount = 550 };

            //Student firstStudent = new Student("Ivan", "Ivanov", 17, school, grades);
            //Student secondStudent = new Student("Ivan", "Petrvo", 13, school, grades);
            //Student thirdStudent = new Student("Nikolay", "Petrvo", 13, null, null);

            //List<Student> students = new List<Student>() { firstStudent, secondStudent, thirdStudent };

            //string jsonObject = JsonConvert.SerializeObject(students,Formatting.Indented);

            //File.WriteAllText(@"D:\GIT\School-Repository\Year_2020_2021\11B_Solutions\01-Module OOP\S06-JSON_XML\P01-DemoJSON_XML\students.txt", jsonObject);

            //Console.WriteLine(jsonObject);

            string jsonObject = File.ReadAllText(@"D:\GIT\School-Repository\Year_2020_2021\11B_Solutions\01-Module OOP\S06-JSON_XML\P01-DemoJSON_XML\students.txt");

            var objStudents = JsonConvert.DeserializeObject<List<Student>>(jsonObject);

            Console.WriteLine();
        }
    }
}
