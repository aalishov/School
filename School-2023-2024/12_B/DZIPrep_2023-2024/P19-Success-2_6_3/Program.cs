public class Program
{
    public static void Main()
    {
        string day = Console.ReadLine();
        string path = string.Empty;
        path = SelectDay(day);

        string[] data = File.ReadAllLines(path);
        int countLessons = 0;
        foreach (string line in data)
        {
            string[] infoAoutDay = line.Split(' ').ToArray();

            if (infoAoutDay[1] != "-")
            {
                countLessons++;
            }
        }
        string dayName = string.Empty;
        if (day == "1") { dayName = "Mon"; }
        else if (day == "2") { dayName = "Tue"; }
        else if (day == "3") { dayName = "Wed"; }
        else if (day == "4") { dayName = "Thu"; }
        else { dayName = "Fri"; }
        Console.WriteLine($"{dayName} {countLessons}");
    }

    private static string SelectDay(string day)
    {
        string path;
        switch (day)
        {
            case "1":
                path = @"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\1.txt";
                break;
            case "2":
                path = @"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\2.txt";
                break;
            case "3":
                path = @"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\3.txt";
                break;
            case "4":
                path = @"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\4.txt";
                break;
            case "5":
                path = @"C:\Users\aalis\Desktop\Repo\School\School-2023-2024\12_B\DZIPrep_2023-2024\P19-Success-2_6_3\5.txt";
                break;
            default:
                path = "Invalid day!";
                break;
        }

        return path;
    }
}

