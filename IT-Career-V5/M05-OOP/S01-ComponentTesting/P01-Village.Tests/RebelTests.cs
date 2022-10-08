using NUnit.Framework;
using System;

[TestFixture]
public class RebelTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RebelSetAge()
    {
        //Arrange //Act
        Rebel rebel = new Rebel("TestRebel", 30, 30);
        //Assert
        int expected = 30;
        int actual = rebel.Age;
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void RebelSetInvalidAge()
    {
        var ex = Assert.Throws<ArgumentException>
            (
                () => new Rebel("Test", 60, 30)
            );
        string expected = "Age should be less or equal to 50!";
        Assert.That(ex.Message, Is.EqualTo(expected));
    }
    [Test]
    public void RebelSetInvalidNegativeAge()
    {
        var ex = Assert.Throws<ArgumentException>
            (
                () => new Rebel("Test", -10, 30)
            );
        string expected = "Age should be 0 or positive!";
        Assert.That(ex.Message, Is.EqualTo(expected));
    }
    [Test]
    public void RebelSetHarm()
    {
        //Arrange //Act
        Rebel rebel = new Rebel("TestRebel", 30, 30);
        //Assert
        int expected = 30;
        int actual = rebel.Harm;
        Assert.That(actual, Is.EqualTo(expected));
    }
}
