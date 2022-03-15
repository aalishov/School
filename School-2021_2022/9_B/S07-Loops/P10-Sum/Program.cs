int n = int.Parse(Console.ReadLine());
int sum = 0;
int max = 0;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    max = Math.Max(max, num);
}
if ((sum - max) == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
}