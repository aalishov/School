public class Program
{
    public static void Main()
    {
        PrintOuput();
    }

    private static void PrintOuput()
    {
        string password = Console.ReadLine();
        if (IsValidPassword(password)) { Console.WriteLine("Password is valid"); }
        else
        {
            if (!IsValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsConsistOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsConsistAtLeast2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }

    public static bool IsValidPassword(string password)
    {
        if (IsConsistAtLeast2Digits(password) && IsConsistOnlyLettersAndDigits(password) && IsValidLength(password)) { return true; }
        return false;
    }
    public static bool IsConsistAtLeast2Digits(string password)
    {
        int digitsCount = 0;
        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
            {
                digitsCount++;
                if (digitsCount >= 2) { return true; }
            }
        }
        return false;
    }
    public static bool IsConsistOnlyLettersAndDigits(string password)
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (!char.IsLetterOrDigit(password[i])) { return false; }
        }
        return true;
    }
    public static bool IsValidLength(string password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return true;
        }
        return false;
    }
}

