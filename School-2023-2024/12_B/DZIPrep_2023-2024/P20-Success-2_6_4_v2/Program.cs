public class Program
{
    public static void Main()
    {
        string parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string path = $"{parent}\\input.txt";

        File.WriteAllLines($"{parent}\\output.txt",
            File.ReadAllLines(path)
            .Select(x => x.Split(" - "))
                .Select(s => new { Name = s[0], Grade = double.Parse(s[1]) })
                .OrderByDescending(x => x.Grade)
                .ThenBy(x => x.Name)
                .Select(x => $"{x.Name} - {x.Grade}")
            );
    }
}
