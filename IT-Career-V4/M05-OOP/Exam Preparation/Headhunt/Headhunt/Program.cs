namespace Headhunt
{
    using Headhunt.Core;
    using Headhunt.Core.Contracts;
    public class Program
    {
        public static void Main()
        {
            
                IEngine engine = new Engine();
                engine.Run();
            
        }
    }
}
