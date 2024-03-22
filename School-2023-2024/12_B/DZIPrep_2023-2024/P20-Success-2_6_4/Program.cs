namespace P20_Success_2_6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = $"{parent}\\input.txt";
            string[]data=File.ReadAllLines(path);
            string outputPath = $"{parent}\\output.txt";
            Dictionary<string,double>grades=new Dictionary<string,double>();
            foreach (var item in data)
            {
                string[]input=item.Split(" - ");
                grades.Add(input[0], double.Parse(input[1]));
            }
           grades= grades.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).ToDictionary();
            File.WriteAllLines(outputPath, grades.Select(x=>$"{x.Key} - {x.Value}"));
            
        }
    }
}
