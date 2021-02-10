namespace StorageMaster
{
    using Entities.Storage;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
