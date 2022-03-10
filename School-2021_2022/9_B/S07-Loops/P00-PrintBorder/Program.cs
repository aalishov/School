int n=int.Parse(Console.ReadLine());
int repeat = n - 2;
string specialLine = $"+{new string('-',repeat)}+";

//First row
Console.WriteLine(specialLine);

//Middle rows
for (int i = 0; i < repeat; i++)
{
    Console.WriteLine(new string('-',n));
}


//Last row
Console.WriteLine(specialLine);