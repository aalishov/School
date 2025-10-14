public class Program
{
    public static void Main()
    {
        try
        {
            int.Parse("15");
            Student s = null;
            Console.WriteLine(s.Age);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Invalid object");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong");
        }
        finally
        {
            Console.WriteLine("Exit...");
        }
    }
}



public class Student
{
    private int age;
    List<int> grades;

    public Student(int age)
    {
        Age = age;
        grades = new List<int>();
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 7 || value > 20)
            {
                throw new ArgumentException("Invalid age!");
            }
            age = value;
        }
    }
}