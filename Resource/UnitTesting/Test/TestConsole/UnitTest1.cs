
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
            var n = "10";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(n);
            Console.SetIn(stringReader);

            //act
            Program.Main();

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
        [Test]
        public void Test2()
        {
            var n = "15";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(n);
            Console.SetIn(stringReader);

            //act
            Program.Main();

            string expected = @"0
1
2
3
4
5
6
7
8
9
10
11
12
13
14";

            //assert
            var output = stringWriter.ToString().TrimEnd();
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test3()
        {
            var n = "0";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(n);
            Console.SetIn(stringReader);

            //act
            Program.Main();

            string expected = @"";

            //assert
            var output = stringWriter.ToString().TrimEnd();
            Assert.AreEqual(expected, output);
        }
    }
}

