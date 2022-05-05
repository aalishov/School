int n = int.Parse(Console.ReadLine());

int count2 = 0;
int count3 = 0;
int count5 = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0) { count2++; }
    if (num % 3 == 0) { count3++; }
    if (num % 5 == 0) { count5++; }
}
Console.WriteLine(count2);
Console.WriteLine(count3);
Console.WriteLine(count5);