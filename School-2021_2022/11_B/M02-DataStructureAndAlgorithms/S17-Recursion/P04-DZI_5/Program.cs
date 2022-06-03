// See https://aka.ms/new-console-template for more information
Counter(5);


static void Counter(int n)
{
    if (n == 0) { return; }
    Console.Write(n);
    Counter(n - 1);
}