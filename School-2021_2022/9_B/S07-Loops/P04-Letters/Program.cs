
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

for (int i = 1; i <= 500; i++)
{
    Console.WriteLine($"{i} => {(char)i}");
}
