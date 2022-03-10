int n=int.Parse(Console.ReadLine());
int sum=0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
}
Console.WriteLine($"Sum={sum}");
