Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    string space=new String(' ', n - i);
    string stars = new String('*', i);
    string middle=" | ";
    Console.WriteLine($"{space}{stars}{middle}{stars}");
}

