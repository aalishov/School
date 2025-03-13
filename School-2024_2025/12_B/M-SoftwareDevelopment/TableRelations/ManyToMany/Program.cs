using ManyToMany.Data;
using ManyToMany.Data.Models;

namespace ManyToMany
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            while (true)
            {
                Console.WriteLine("Enter command: [S]tudents, [E]xams, [Q]uit");
                string cmd = Console.ReadLine();
                if (cmd.ToLower() == "q") { break; }
                else if (cmd.ToLower() == "s")
                {
                    Console.WriteLine("Enter command: [A]dd, [D]elete, [U]pdate, [P]rint");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "a")
                    {
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Student student = new Student() { Name = name };
                        context.Students.Add(student);
                        context.SaveChanges();
                        Console.WriteLine("Succesfully added student!");
                    }
                    else if (input.ToLower() == "d")
                    {
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Student student = context.Students.FirstOrDefault(x => x.Name == name);
                        context.Students.Remove(student);
                        context.SaveChanges();
                        Console.WriteLine("Succesfully removed student!");
                    }
                    else if (input.ToLower() == "p")
                    {
                        foreach (var student in context.Students.ToList())
                        {
                            Console.WriteLine($"{student.Id} -> {student.Name}");
                        }
                    }
                }
            }
        }
    }
}
