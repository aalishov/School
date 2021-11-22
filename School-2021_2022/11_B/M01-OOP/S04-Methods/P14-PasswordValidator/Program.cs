using System;
using System.Text;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        string result = IsValidPassword(password);
        Console.WriteLine(result);
    }

    static string IsValidPassword(string password)
    {
        bool isValidLength = CheckLength(password);
        bool hasOlnyLettersAndDigits = CheckConsistOnlyLettersAndDigits(password);
        bool hasTwoDigits = CheckHaveTwoDigits(password);

        if (isValidLength && hasOlnyLettersAndDigits && hasTwoDigits)
        {
            return $"Password is valid";
        }

        StringBuilder sb = new StringBuilder();

        if (!isValidLength)
        {
            sb.AppendLine("Password must be between 6 and 10 characters");
        }
        if (!hasOlnyLettersAndDigits)
        {
            sb.AppendLine("Password must consist only of letters and digits");
        }
        if (!hasTwoDigits)
        {
            sb.AppendLine("Password must have at least 2 digits");
        }
        return sb.ToString().TrimEnd();
    }
    static bool CheckLength(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return true;
        }
        return false;
    }

    static bool CheckConsistOnlyLettersAndDigits(string password)
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

    static bool CheckHaveTwoDigits(string password)
    {
        int countDigit = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
            {
                countDigit++;
                if (countDigit >= 2)
                {
                    return true;
                }
            }
        }
        return false;
    }
}

