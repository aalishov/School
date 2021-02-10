using System;

class Program
{
    static void Main()
    {
        var inputAge = "24";
        var age = 0;
        var isNum = int.TryParse(inputAge, out age);
        Console.WriteLine($"Age: {age}");
    }
}
