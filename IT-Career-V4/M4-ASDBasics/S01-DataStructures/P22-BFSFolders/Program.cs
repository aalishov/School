using System;
using System.IO;
using System.Threading;

class Program
{
    static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
    static void Main()
    {
        //PrintAll();

        string[] drives = System.Environment.GetLogicalDrives();
        WalkDirectoryTree(new System.IO.DriveInfo(drives[0]).RootDirectory);
    }

    private static string[] PrintAll()
    {
        string[] drives = System.Environment.GetLogicalDrives();

        foreach (string dr in drives)
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

            // Here we skip the drive if it is not ready to be read. This
            // is not necessarily the appropriate action in all scenarios.
            if (!di.IsReady)
            {
                Console.WriteLine("The drive {0} could not be read", di.Name);
                continue;
            }
            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            WalkDirectoryTree(rootDir);
        }

        // Write out all the files that could not be processed.
        Console.WriteLine("Files with restricted access:");
        foreach (string s in log)
        {
            Console.WriteLine(s);
        }
        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key");
        Console.ReadKey();
        return drives;
    }

    static void WalkDirectoryTree(System.IO.DirectoryInfo root)
    {
        System.IO.FileInfo[] files = null;
        System.IO.DirectoryInfo[] subDirs = null;

        try
        {
            files = root.GetFiles("*.*");
        }
        catch (UnauthorizedAccessException e)
        {
            log.Add(e.Message);
        }

        catch (System.IO.DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        if (files != null)
        {
            foreach (System.IO.FileInfo fi in files)
            {
                Thread.Sleep(500);
                Console.WriteLine(fi.FullName);
            }
            subDirs = root.GetDirectories();

            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                WalkDirectoryTree(dirInfo);
            }
        }
    }
}

