
using NUnit.Framework;
using System;
using System.IO;

namespace TestConsole
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var greeter = new Program();
            var name = "Hello, World!";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(name);
            Console.SetIn(stringReader);

            //act
            Program.Print();

            string expected = @"0
1
2
3
4
5
6
7
8
9";

            //assert
            var output = stringWriter.ToString().TrimEnd();
            Assert.AreEqual(expected, output);
        }
    }
}