// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        for (int k = 'a'; k < ('a' + l); k++)
        {
            for (int m = 'a'; m < ('a' + l); m++)
            {
                for (int o = 1; o <= n; o++)
                {
                    if (o > i && o > j)
                    {
                        Console.WriteLine($"{i}{j}{(char)k}{(char)m}{o}");
                    }
                }
            }
        }
    }
}
