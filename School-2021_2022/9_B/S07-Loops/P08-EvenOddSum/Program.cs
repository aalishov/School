int n = int.Parse(Console.ReadLine());
int evenSum = 0;
int oddSum = 0;
for (int i = 0; i < n; i += 2)
{
    oddSum += int.Parse(Console.ReadLine());
    evenSum += int.Parse(Console.ReadLine());
}
if (oddSum == evenSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {oddSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
}