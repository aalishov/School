int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxDiff = 0;
bool isEqual = true;
for (int i = 0; i < n; i++)
{
    int first = int.Parse(Console.ReadLine());
    int second = int.Parse(Console.ReadLine());
    if (i > 0)
    {
        int currentSum = first + second;
        if (currentSum != sum) { isEqual = false; }
        int currentDiff = Math.Abs(sum - currentSum);
        maxDiff = Math.Max(maxDiff, currentDiff);
        sum = currentSum;
    }
    else
    { sum = first + second; }
}
if (isEqual)
{ Console.WriteLine($"Yes, value={sum}"); }
else
{ Console.WriteLine($"No, maxdiff={maxDiff}"); }