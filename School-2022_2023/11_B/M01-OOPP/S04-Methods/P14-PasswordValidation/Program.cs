using System;


public class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        bool validLength = IsLengthValid(password);
        bool consistOnlyLettersAndDigits = IsConsistOnlyLettersAndDigits(password);
        bool consistsTwoDigits = IsDigitsConsisted(password);

        if (validLength && consistOnlyLettersAndDigits && consistsTwoDigits)
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            if (!validLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!consistOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!consistsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
    static bool IsLengthValid(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return true;
        }
        return false;
    }
    static bool IsConsistOnlyLettersAndDigits(string password)
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (!(char.IsDigit(password[i]) || char.IsLetter(password[i])))
            {
                return false;
            }
        }
        return true;
    }
    static bool IsDigitsConsisted(string password)
    {
        int digitCounter = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
            {
                digitCounter++;
                if (digitCounter >= 2) { return true; }
            }
        }
        return false;
    }
}
