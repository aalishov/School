Dictionary<string, int> data = new Dictionary<string, int>();
string comand;
while ((comand = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());
    if (data.ContainsKey(comand))
    {
        data[comand] += quantity;
    }
    else
    {
        data.Add(comand, quantity);
    }

}
foreach (var resours in data)
{
    Console.WriteLine($"{resours.Key} -> {resours.Value}");
}