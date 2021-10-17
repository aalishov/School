using Headhunt.Core;
using Headhunt.Core.Contracts;
using System;

namespace Headhunt
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
