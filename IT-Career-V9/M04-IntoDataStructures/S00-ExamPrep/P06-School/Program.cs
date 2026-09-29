public class Program
{
    private static School school;
    public static void Main()
    {
        Run();
    }

    private static void Run()
    {
        school = new School("SoftUni");

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmd = input[0];

            switch (cmd)
            {
                case "Add":
                    Add(input);
                    break;
                case "END":
                    Environment.Exit(0);
                    break;
                case "Print":
                    Print();
                    break;
                case "SortByName":
                    SortByName();
                    break;
                case "SortByGrade":
                    SortByGrade();
                    break;
                case "CheckStudent":
                    CheckStudent(input);
                    break;
                case "AverageResult":
                    AverageResult(input);
                    break;
                case "RemoveStudents":
                    RemoveStudent(input);
                    break;
            }
        }
    }

    private static void RemoveStudent(string[] input)
    {
        double gradeToRemove = double.Parse(input[1]);
        List<string> removedStudents = school.RemoveStudentsByGrade(gradeToRemove);
        Console.WriteLine($"Poor students: {string.Join(", ", removedStudents)}");
    }

    private static void AverageResult(string[] input)
    {
        int start = int.Parse(input[1]);
        int end = int.Parse(input[2]);
        Console.WriteLine($"Average result is: {school.AverageResultInRange(start, end):f2}");
    }

    private static void CheckStudent(string[] input)
    {
        string studentName = input[1];
        string result = school.CheckStudentIsInSchool(studentName) ? $"Student {studentName} is available." : $"Student {studentName} is not available.";
        Console.WriteLine(result);
    }

    private static void SortByGrade()
    {
        school.SortDescendingByGrade();
        Console.WriteLine($"The worst student is: {school.Students.LastOrDefault().Name}");
    }

    private static void SortByName()
    {
        school.SortAscendingByName();
        Console.WriteLine($"First student is: {school.Students.FirstOrDefault().Name}");
    }

    private static void Print()
    {
        Console.WriteLine(string.Join(Environment.NewLine, school.ProvideInformationAboutAllStudents()));
    }

    private static void Add(string[] input)
    {
        string name = input[1];
        double grade = double.Parse(input[2]);
        school.AddStudent(name, grade);
        Console.WriteLine($"Added student {name}.");
    }
}

