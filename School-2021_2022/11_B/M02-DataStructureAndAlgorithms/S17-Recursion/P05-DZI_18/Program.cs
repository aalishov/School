// See https://aka.ms/new-console-template for more information
int n = Function(99);
Console.WriteLine(n);


static int Function(int n)
{
    Console.WriteLine(n);
    if (n > 100)
        return n - 10;
    return Function(Function(n + 11));
}