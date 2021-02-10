using NUnit.Framework;
using P01_PersonWithBankAccounts;
using System;

namespace P00_SolutionTests
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorAgeTest()
        {
            //Arrange
            Person person = new Person("TestPerson", 10);

            //Act

            //Assert
            int expectedValue = 10;
            int actualValue = person.Age;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ConstructorNameTest()
        {
            //Arrange
            Person person = new Person("TestPerson", 10);

            //Act

            //Assert
            string expectedValue = "TestPerson";
            string actualValue = person.Name;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestAgeWithNegativeValue()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(
                () => 
                    {
                        Person person = new Person("TestPerson", -2);
                    }
                );
        }
        [Test]
        public void TestNameWithShortValue()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    Person person = new Person("T", 10);
                }
                );
        }
        [Test]
        public void TestNameWithLongValue()
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    Person person = new Person("Tasdasdsdasd", 10);
                }
                );
        }
        
        [Test]
        public void GrowTest()
        {
            //Arrange
            Person person = new Person("TestPerson", 10);

            //Act
            person.Grow();

            //Assert
            int expectedValue = 11;
            int actualValue = person.Age;

            Assert.AreEqual(expectedValue,actualValue);
        }
    }
}