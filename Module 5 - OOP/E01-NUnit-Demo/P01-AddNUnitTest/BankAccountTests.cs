using NUnit.Framework;
using P01_AddNUnit;
using System;

namespace P01_AddNUnitTest
{
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            //AAA - Arange, Act, Assert

            //Arrange
            decimal initialValue = 100;

            //Act
            BankAccount account = new BankAccount(initialValue);

            //Assert
            Assert.AreEqual(initialValue, account.Amount);
        }

        [Test]
        public void AccountDeposit()
        {
            //Arrdange
            BankAccount account = new BankAccount(50);
            decimal amount = 50;
            //Act
            account.Deposit(amount);
            //Assert
            decimal expectedValue = 100;
            decimal actualValue = account.Amount;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void AccountDepostiException()
        {
            //Arrange
            BankAccount account = new BankAccount(50);
            decimal amount = -50;

            //Act
            //Assert
            Assert.Throws<ArgumentException>(
                () => { account.Deposit(amount); }, "Value must be positive!"
                );
        }

        [Test]
        public void AccountPass()
        {
            Assert.Pass();
        }
    }
}