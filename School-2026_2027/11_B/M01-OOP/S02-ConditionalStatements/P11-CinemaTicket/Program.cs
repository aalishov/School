

using System;
public class Program
{
    public static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        switch(dayOfWeek)
        {
            case "Monday":
               
            case "Tuesday":
            case "Friday":
                Console.WriteLine("12");
                break;
            case "Wednesday":
                
            case "Thursday":
                Console.WriteLine("14");
                break;
        
            case "Saturday":
                
            case "Sunday":
                Console.WriteLine("16");
                break;
            default:
                Console.WriteLine("Invalid day of the week");
                break;
        }
    }
}

