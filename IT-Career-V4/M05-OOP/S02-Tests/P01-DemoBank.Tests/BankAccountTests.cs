using NUnit.Framework;
using System;

namespace P01_DemoBank.Tests
{
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorWithInitialBalance()
        {
            decimal expected = 50;
            //Arrange, Act
            BankAccount account = new BankAccount(1, expected);

            //Assert
            decimal actual = account.Balance;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DepositWithPositiveValue()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 0);
            //Act
            account.Deposit(100);
            //Assert
            decimal expected = 100;
            decimal actual = account.Balance;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void DepostitWithNegativeValue()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 100);

            decimal expected = 100;
            decimal actual = account.Balance;

            Assert.AreEqual(expected, actual);

            Assert.Throws<ArgumentException>(
                () => { account.Deposit(-50); }
                );
        }

        [Test]
        public void TestWithdrawWithPositiveValue()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 100);

            //Act
            account.Withdraw(50);

            //Assert
            decimal expected = 50;
            decimal actual = account.Balance;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWithdrawWithNegativeValue()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 200);

            //Act, Assert
            Assert.Throws<ArgumentException>(() => { account.Withdraw(-50); });
        }

        [Test]
        public void TestWithdrawInsuficientAmount()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 200);

            //Act, Assert
            Assert.Throws<InvalidOperationException>(() => { account.Withdraw(300); });
        }

        [Test]
        public void BankAccountToString()
        {
            //Arrange
            BankAccount account = new BankAccount(1, 200);

            string expected = "Id: 1 => balance: 200.000";
            string actual = account.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}