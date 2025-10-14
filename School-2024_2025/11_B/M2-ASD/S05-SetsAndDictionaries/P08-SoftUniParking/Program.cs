
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string,string> users = new Dictionary<string,string>();
        for (int i = 0; i < n; i++)
        {
            string[] cmd = Console.ReadLine().Split(" ").ToArray();
            if (cmd[0]=="register")
            {
                if (users.ContainsKey(cmd[1])) { Console.WriteLine($"ERROR: already registered with plate number {cmd[2]}"); }
                else
                {
                    string username = cmd[1];
                    string plateNum = cmd[2];
                    users.Add(username, plateNum);
                    Console.WriteLine($"{username} registered {plateNum} successfully");
                }                    
            }
            else
            {
                string username = cmd[1];
                if (!users.ContainsKey(cmd[1])) { Console.WriteLine($"ERROR: user {username} not found"); }
                else 
                {
                    users.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }                  
            }
        }
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}

