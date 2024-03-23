namespace BookManagement.Tests
{
    using BookManagement.Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Services;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using BookManagement.Common;
    using System.Linq.Expressions;

    [TestFixture]
    public class GanresServiceTests
    {
        private List<Ganre> ganresList = new List<Ganre>();
        private IQueryable<Ganre> dbTable = null;
        private GanresService service = null;
        private Mock<AppDbContext> mockContext = null;
        private Mock<DbSet<Ganre>> mockSet = null;

        [SetUp]
        public void Setup()
        {
            // Инициализиране на списъка с жанрове
            ganresList = new List<Ganre>();
            for (int i = 1; i <= 5; i++)
            {
                ganresList.Add(new Ganre() { Id = i, Name = $"Ganre {i}" });
            }

            // Превръщане на списъка в IQueryable
            dbTable = ganresList.AsQueryable();

            // Подиграване (Mocking) на DbSet<Ganre>
            mockSet = new Mock<DbSet<Ganre>>();
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.GetEnumerator()).Returns(() => ganresList.GetEnumerator());

            // Подиграване на метода Add
            mockSet.Setup(m => m.Add(It.IsAny<Ganre>())).Callback<Ganre>(ganre => ganresList.Add(ganre));

            // Инициализиране и настройка на подигравания контекст
            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Ganres).Returns(mockSet.Object);

            // Не е нужно да се подиграва методът Any, тъй като LINQ операциите ще работят върху подигравания DbSet

            // Подиграване на SaveChanges
            mockContext.Setup(m => m.SaveChanges()).Returns(1);

            // Инициализиране на сервиса с подигравания контекст
            service = new GanresService(mockContext.Object);
        }



        [Test]
        public void GetGanresCountTest()
        {
            // Arrange
            var expected = ganresList.Count;

            // Act
            var actual = service.GetGenresCount();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AddGanreWithInvalidNameTest()
        {
            // Arrange
            // Act

          
            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Ganre() { Name = "" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.InvalidGanreName);
        }

        [Test]
        public void AddGanreWithSameNameTest()
        {
            // Arrange
            // Act


            var ex = Assert.Throws<ArgumentException>(() => service.Add(new Ganre() { Name = "Ganre 1" }));

            // Assert
            Assert.AreEqual(ex.Message, ExceptionMessages.GanreAlreadyExyst);
        }

        [Test]
        public void GetGanreByNameTest()
        {
            // Arrange
            var expected = ganresList[0];

            // Act
            var actual = service.GetGanreByName("Ganre 1");

            // Assert
            Assert.That(actual.Name, Is.EqualTo(expected.Name));
        }

        [Test]
        public void GetAllGanreTest()
        {
            // Arrange
            var expected = ganresList.Count;

            // Act
            var actual = service.GetAllGanres();

            // Assert
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void GetGanresIdTest()
        {
            // Arrange
            var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var actual = service.GetGanresId();

            // Assert
            Assert.That(actual, Is.EquivalentTo(expected)); // За сравнение без подредба
        }



    }
}
