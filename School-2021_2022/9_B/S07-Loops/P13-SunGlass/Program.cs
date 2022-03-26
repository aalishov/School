
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

string line = $"{new string('*', n * 2)}{new string(' ', n)}{new string('*', n * 2)}";

string main = $"*{new string('/', 2 * n - 2)}*{new string('|', n)}*{new string('/', 2 * n - 2)}*";

string middle = $"*{new string('/', 2 * n - 2)}*{new string(' ', n)}*{new string('/', 2 * n - 2)}*";

int before = (n - 3) / 2;
int after = (int)Math.Ceiling((n - 3) / 2.0);

Console.WriteLine(line);
for (int i = 0; i < before; i++)
{
    Console.WriteLine(middle);
}
Console.WriteLine(main);
for (int i = 0; i < after; i++)
{
    Console.WriteLine(middle);
}
Console.WriteLine(line);
