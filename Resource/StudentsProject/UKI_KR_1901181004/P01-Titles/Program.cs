using System;

public class Program
{
  public  static void Main()
    {
        int age=int.Parse(Console.ReadLine());
        string gender=Console.ReadLine();
        if (age<16)
        {
            if (gender == "m") { Console.WriteLine("Master"); }
            else if(gender == "f") { Console.WriteLine("Miss"); }
        }
        else
        {
            if (gender == "m") { Console.WriteLine("Mr."); }
            else if (gender == "f") { Console.WriteLine("Ms."); }
        }
    }
}

