using System.Diagnostics;
using System.Timers;

public class Program
{
    private static System.Timers.Timer aTimer;
    public static void Main()
    {
        SetTimer();

        Console.WriteLine("\nPress the Enter key to exit the application...\n");
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        Console.ReadLine();
        aTimer.Dispose();

        Console.WriteLine("Terminating the application...");

      
    }

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(4000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        //aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        aTimer.Stop();
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
    }

    private static void StopWatch()
    {
        Stopwatch stopWatch = new Stopwatch();
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        stopWatch.Start();

        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(100);
        }

        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed.TotalSeconds);
    }
}

