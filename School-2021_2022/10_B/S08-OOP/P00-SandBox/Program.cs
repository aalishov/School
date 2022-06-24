Console.WriteLine("Въведете две цели числа");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a < b)
        Console.WriteLine("Първото число е по-малко");
    else
        Console.WriteLine("Първото число НЕ е по-малко");
}
catch (FormatException)
{
    Console.WriteLine("Некоректно въведено число");
}
