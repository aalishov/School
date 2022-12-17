using P02_SoftUniConsole.Data;

public class Program
{
    private static SoftUniContext db = new SoftUniContext();
    public static void Main()
    {
        DeleteEmployeeById();
    }

    private static void AddJuniorEmployye()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Employee employee = new Employee()
        {
            FirstName = firstName,
            LastName = lastName,
            HireDate = DateTime.UtcNow,
            Salary = 10000,
            JobTitle = "Junior employee",
            DepartmentId = db.Departments.First().DepartmentId,

        };
        db.Employees.Add(employee);
        db.SaveChanges();
        PrintEmployeeInfo();
    }

    private static void UpdateEmployeeSalryById()
    {
        PrintEmployeeInfo();
        Console.WriteLine(new String('*', 20));
        Console.Write("Enter id: ");
        int id = int.Parse(Console.ReadLine());
        Employee e = db.Employees.Find(id);
        if (e != null)
        {
            Console.Write("Enter salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            e.Salary = salary;
            Console.WriteLine($"Employee {e.EmployeeId} - {e.FirstName} {e.LastName}");
            db.Update(e);
            db.SaveChanges();
        }
        Console.WriteLine(new String('*', 20));
        PrintEmployeeInfo();

    }

    private static void DeleteEmployeeById()
    {
        PrintEmployeeInfo();

        Console.WriteLine(new String('*', 20));
        Console.Write("Enter id: ");
        int id = int.Parse(Console.ReadLine());
        Employee e = db.Employees.Find(id);
        if (e != null)
        {
            db.Employees.Remove(e);
            Console.WriteLine($"Employee {e.EmployeeId} - {e.FirstName} {e.LastName}");
            db.SaveChanges();
        }
        Console.WriteLine(new String('*', 20));
        PrintEmployeeInfo();
    }

    private static void PrintEmployeeInfo()
    {
        List<Employee> employees = db.Employees.OrderByDescending(x => x.EmployeeId)
            .Skip(0)
            .Take(10)
            .ToList();
        string header = $"{"Id",5} {"First name",15} | {"Last name",15} | {"Job",25} | {"Salary",8}";
        Console.WriteLine(header);
        Console.WriteLine(new string('-', header.Length));
        foreach (var e in employees)
        {
            Console.WriteLine($"{e.EmployeeId,5} {e.FirstName,15} | {e.LastName,15} | {e.JobTitle,25} | {e.Salary:c2}");
        }
    }
}