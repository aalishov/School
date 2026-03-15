public class Program
{
    private static List<string> phones = new List<string>();
    public static void Main()
    {
        phones.AddRange((Console.ReadLine() ?? string.Empty).Split(", "));

        while (true)
        {
            string[] input = (Console.ReadLine() ?? string.Empty).Split(" - ");
            string cmd = input[0];

            switch (cmd)
            {
                case "Add":
                    string phoneToAdd = input[1];
                    if (!phones.Contains(phoneToAdd))
                    {
                        phones.Add(phoneToAdd);
                    }
                    break;
                case "Remove":
                    string phoneToRemove = input[1];
                    phones.Remove(phoneToRemove);
                    break;
                case "Bonus phone":
                    string[] bonusPhones = input[1].Split(":");
                    string oldPhone = bonusPhones[0];
                    string newPhone = bonusPhones[1];
                    if (phones.Contains(oldPhone))
                    {
                        int index = phones.IndexOf(oldPhone);
                        phones.Insert(index + 1, newPhone);
                    }
                    break;
                case "Last":
                    int position = phones.IndexOf(input[1]);
                    if (position != -1)
                    {
                        string phone = phones[position];
                        phones.RemoveAt(position);
                        phones.Add(phone);
                    }
                    break;
                case "End":
                    Console.WriteLine(string.Join(", ", phones));
                    Environment.Exit(0);
                    break;
            }
        }
    }
}