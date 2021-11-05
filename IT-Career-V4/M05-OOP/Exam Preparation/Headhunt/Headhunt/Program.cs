namespace Headhunt
{
    using Headhunt.Core;
    using Headhunt.Core.Contracts;
    using System;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {

            //    IEngine engine = new Engine();
            //engine.Run();

            for (int i = 0; i < 50; i++)
            {
                Console.Beep();
                Thread.Sleep(1000);
            }
        }
    }
}
