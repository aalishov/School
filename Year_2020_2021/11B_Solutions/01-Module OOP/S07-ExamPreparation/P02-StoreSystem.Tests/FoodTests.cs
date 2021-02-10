using NUnit.Framework;
using P01_StoreSystem;
using System;

namespace P02_StoreSystem.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ////Arrange
            //Food food = new Food("Pizza", 10, 10, 50);
        }

        [Test]
        public void TestFoodFinalPrize()
        {
            //Arrange
            //Act
            Food food = new Food("Pizza", 10, 10, 50);

            double expected = 15;
            double actual = food.FinalPrice;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestFoodQuantitySetterWittCorrevValue()
        {
            //Arrange
            //Act
            Food food = new Food("Pizza", 10, 10, 50);

            double expected = 10;
            double actual = food.Quantity;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestFoodQuantitySetterWittInCorrevValue()
        {
            //Arrange
            //Act
            Food food = new Food("Pizza", 10, 10, 50);

            Assert.Throws<ArgumentException>(() => food.Quantity = -10, "Quantity cannot be less or equal to 0!");
        }
    }
}
