// See https://aka.ms/new-console-template for more information
Console.WriteLine(A(10));

static int A(int a)
{
    Console.WriteLine(a);
    return A(a - 1);
}