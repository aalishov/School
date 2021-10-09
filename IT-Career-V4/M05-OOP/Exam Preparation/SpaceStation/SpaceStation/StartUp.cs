namespace SpaceStation
{
    using Core;
    using Core.Contracts;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //IEngine engine = new Engine();
            //engine.Run();
            for (int i = 0; i < 50; i++)
            {
                Console.Beep();
            }
        }
    }
}