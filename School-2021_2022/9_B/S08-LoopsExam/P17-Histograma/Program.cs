// See https://aka.ms/new-console-template for more information

int p1Counter = 0;
int p2Counter = 0;
int p3Counter = 0;
int p4Counter = 0;
int p5Counter = 0;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num < 200) { p1Counter++; }
    else if (num < 400) { p2Counter++; }
    else if (num < 600) { p3Counter++; }
    else if (num < 800) { p4Counter++; }
    else { p5Counter++; }
}
Console.WriteLine($"{p1Counter / (double)n * 100.0:f2}%");
Console.WriteLine($"{p2Counter / (double)n * 100.0:f2}%");
Console.WriteLine($"{p3Counter / (double)n * 100.0:f2}%");
Console.WriteLine($"{p4Counter / (double)n * 100.0:f2}%");
Console.WriteLine($"{p5Counter / (double)n * 100.0:f2}%");
