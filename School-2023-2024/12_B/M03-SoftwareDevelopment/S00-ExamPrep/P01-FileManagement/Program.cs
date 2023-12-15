public class Program
{
    private static Dictionary<string, List<string>> directories = new Dictionary<string, List<string>>();
    public static void Main()
    {
        try
        {
            Console.Write("Enter folder path: ");
            string path = Console.ReadLine();

            ReadFolderInfo();

            CreateDirectories();

            CopyFiles(path);

            NewMethod();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong!");
        }
        finally
        {
            Console.WriteLine("End!");
        }
    }

    private static void NewMethod()
    {
        foreach (var item in directories)
        {
            Console.WriteLine($"{item.Key} - {Directory.GetFiles(item.Key).Length}");
        }
    }

    private static void CopyFiles(string path)
    {
        string[] files = Directory.GetFiles(path);
        foreach (var f in files)
        {
            int dotIndex = f.LastIndexOf('.');
            int slashIndex = f.LastIndexOf("\\");
            string extension = f.Substring(dotIndex + 1);
            string fileName = f.Substring(slashIndex);
            foreach (var d in directories)
            {
                if (d.Value.Any(x => x == extension))
                {
                    File.Copy(f, d.Key + fileName);
                }
            }
        }
    }

    private static void CreateDirectories()
    {
        foreach (var item in directories)
        {
            if (Directory.Exists(item.Key))
            {
                string[] files = Directory.GetFiles(item.Key);
                foreach (var f in files)
                {
                    File.Delete(f);
                }
                Directory.Delete(item.Key);
            }

            if (!Directory.Exists(item.Key))
            {
                Directory.CreateDirectory(item.Key);
            }
        }
    }

    private static void ReadFolderInfo()
    {
        Console.Write("Enter file type count: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("-").ToArray();
            string extension = input[0];
            string folderName = input[1];
            if (directories.ContainsKey(folderName))
            {
                if (!directories[folderName].Any(x => x == extension))
                {
                    directories[folderName].Add(extension);
                }
            }
            else
            {
                directories.Add(folderName, new List<string>() { extension });
            }
        }
    }
}
