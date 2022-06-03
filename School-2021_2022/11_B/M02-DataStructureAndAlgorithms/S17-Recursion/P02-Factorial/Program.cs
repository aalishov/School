// See https://aka.ms/new-console-template for more information
Console.WriteLine(GetFactorial(5));


static long GetFactorial(int n)
{
    if (n==0)
    {
        return 1;
    }

    return n * GetFactorial(n - 1);
}