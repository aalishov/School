using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    private static AppDbContext db = new AppDbContext();
    public static void Main()
    {
        Console.WriteLine(ReportsAndCategories()); 
    }
    public static string ReportsAndCategories()
    {
        StringBuilder sb = new StringBuilder();
        List<Report> reports = db.Reports.Where(x=>x.Category!=null).OrderBy(x=>x.Description).ThenBy(x=>x.Category).ToList();
        sb.AppendLine($"{"Description",-20} | {"CategoryName"}");
        foreach (var report in reports)
        {
            sb.AppendLine($"{new string(report.Description.Take(20).ToArray())} | {report.Category.Name}");
        }
        return sb.ToString().TrimEnd();
    }
    public static string UnassignedReports()
    {
        StringBuilder sb= new StringBuilder();
        List<Report> reportList = db.Reports
            .Where(x=>x.Employee==null)
            .OrderBy(x => x.OpenDate)
            .ThenBy(x => x.Description)
            .ToList();
       sb.AppendLine($"{"Description",-20} | {"OpenDate"}");
        foreach (var report in reportList)
        {
           sb.AppendLine($"{new string(report.Description.Take(20).ToArray())} | { report.OpenDate.ToString("dd-MM-yyyy")}");
        }
       return sb.ToString().TrimEnd();
    }
    public static void Delete() 
    {
        db.Reports.RemoveRange(db.Reports.Where(x => x.StatusId == 4));
        db.SaveChanges();
    }
    public static void Update()
    {
        foreach (var report in db.Reports.Where(x=>x.CloseDate==null))
        {
            report.CloseDate = DateTime.UtcNow;
        }
        db.SaveChanges();
    }
    public static void Insert()
    {
        db.Employees.Add(new Employee()
        {
            FirstName = "Marlo",
            LastName = "O'Malley",
            Birthdate = new DateTime(1958, 9, 21),
            DepartmentId = 1
        });
        db.Employees.Add(new Employee()
        {
            FirstName = "Niki",
            LastName = "Stanaghan",
            Birthdate = new DateTime(1969, 11, 26),
            DepartmentId = 4
        });
        db.Employees.Add(new Employee()
        {
            FirstName = "Ayrton",
            LastName = "Senna",
            Birthdate = new DateTime(1960, 3, 21),
            DepartmentId = 9
        });
        db.Employees.Add(new Employee()
        {
            FirstName = "Ronnie",
            LastName = "Peterson",
            Birthdate = new DateTime(1944, 2, 14),
            DepartmentId = 9
        });
        db.Employees.Add(new Employee()
        {
            FirstName = "Giovanna",
            LastName = "Amati",
            Birthdate = new DateTime(1959, 7, 20),
            DepartmentId = 5
        });

        db.Reports.Add(new Report()
        {
            CategoryId = 1,
            StatusId = 1,
            OpenDate = new DateTime(2017, 4, 13),
            CloseDate = null,
            Description = "Stuck Road on Str.133",
            UserId = 6,
            EmployeeId = 2
        });
        db.Reports.Add(new Report()
        {
            CategoryId = 6,
            StatusId = 3,
            OpenDate = new DateTime(2015, 9, 5),
            CloseDate = new DateTime(2015,12,6),
            Description = "Charity trail running",
            UserId = 3,
            EmployeeId = 5
        });
        db.Reports.Add(new Report()
        {
            CategoryId = 14,
            StatusId = 2,
            OpenDate = new DateTime(2015, 9, 7),
            CloseDate = null,
            Description = "Falling bricks on Str.58",
            UserId = 5,
            EmployeeId = 2
        });
        db.Reports.Add(new Report()
        {
            CategoryId = 4,
            StatusId = 3,
            OpenDate = new DateTime(2017, 7, 3),
            CloseDate = new DateTime(2017, 7, 6),
            Description = "Cut off streetlight on Str.11",
            UserId = 1,
            EmployeeId = 1
        });
        db.SaveChanges();
    }
}

