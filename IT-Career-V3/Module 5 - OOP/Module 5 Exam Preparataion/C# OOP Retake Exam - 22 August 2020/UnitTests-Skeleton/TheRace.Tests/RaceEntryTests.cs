using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        RaceEntry race = new RaceEntry();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddNullDriver()
        {
            //Arange
            //Act
            //Assert

            UnitDriver driver = null;

            Assert.Throws<InvalidOperationException>(
                    () => { race.AddDriver(driver); }
                    );
            Assert.Pass();
        }

        [Test]
        public void AddExistingDriver()
        {
            //Arange
            UnitDriver driver = new UnitDriver("Gosho", new UnitCar("Audi", 200, 1500));
            race.AddDriver(driver);
            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(
                () => { race.AddDriver(driver); }
                );
            Assert.Pass();
        }

        [Test]
        public void AddDriverSuccesfuly()
        {
            //Arange
            //Act
            UnitDriver driver = new UnitDriver("Ivan", new UnitCar("Audi", 200, 1500));
            string actualResult = race.AddDriver(driver);
            string expectedResult = "Driver Ivan added in race.";
            
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}