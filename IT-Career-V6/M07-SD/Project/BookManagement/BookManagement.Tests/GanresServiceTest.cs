namespace BookManagement.Tests
{
    using BookManagement.Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Services;
    using System.Collections.Generic;
    using System.Net.Sockets;

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
            for (int i = 0; i < 5; i++)
            {
                ganresList.Add(new Ganre() { Name = $"Ganre {i}" });
            }

            dbTable = ganresList.ToList().AsQueryable();


            mockSet = new Mock<DbSet<Ganre>>();

            mockSet.As<IQueryable<Ganre>>().Setup(m => m.Provider).Returns(dbTable.Provider);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.Expression).Returns(dbTable.Expression);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.ElementType).Returns(dbTable.ElementType);
            mockSet.As<IQueryable<Ganre>>().Setup(m => m.GetEnumerator()).Returns(dbTable.GetEnumerator());
            mockSet.Setup(d => d.Add(It.IsAny<Ganre>())).Callback<Ganre>((s) => ganresList.Add(s));

            mockContext = new Mock<AppDbContext>();
            mockContext.Setup(p => p.Ganres).Returns(mockSet.Object);


            service = new GanresService(mockContext.Object);
        }

        [Test]

        public void GetGanresCountTest()
        {   //Arange
            var expected = ganresList.Count;

            //Act
            var actual = service.GetGenresCount();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AddGanreTest()
        {
           
        }
    }
}