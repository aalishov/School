using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using RealEstates.Data;
using RealEstates.Data.Models;
using RealEstates.Services;
using RealEstates.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace RealEstates.Tests
{
    public class PropertiesServiceTests
    {
        IQueryable<Property> data = new List<Property>
            {
                new Property {Id=1,Price=10000, Size = 20,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2001 },
                new Property {Id=2,Price=20000, Size = 30,District= new District(){Name="София"},PropertyType= new PropertyType(){Name="Тухла" } ,Year=2002 },
                new Property {Id=3,Price=30000, Size = 40 ,District= new District(){Name="София"},PropertyType= new PropertyType(){Name="Тухла" } ,Year=2003 },
                new Property {Id=4,Price=40000, Size = 20,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" } ,Year=2004},
                new Property {Id=5,Price=50000, Size = 30,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2005 },
                new Property {Id=6,Price=60000, Size = 40 ,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2006 },
                 new Property {Id=7,Price=70000, Size = 40 ,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2007 },
                  new Property {Id=8,Price=80000, Size = 40 ,District= new District(){Name="София"},PropertyType= new PropertyType(){Name="Тухла" }  ,Year=2008},
                   new Property {Id=9,Price=90000, Size = 40 ,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2009 },
                new Property {Id=10,Price=100000, Size = 40 ,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2010 },
                     new Property {Id=11,Price=110000, Size = 40 ,District= new District(){Name="София"} ,PropertyType= new PropertyType(){Name="Тухла" },Year=2011 },
                      new Property {Id=12,Price=120000, Size = 40 ,District= new District(){Name="Last Added"} ,PropertyType= new PropertyType(){Name="Last Added" },Year=2012 },
            }.AsQueryable();
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void TestGetPropertiesFirstPage()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.GetProperties();

            Assert.AreEqual(10, properties.Properties.Count);
            Assert.AreEqual(1, properties.Properties.First().Id);
            Assert.AreEqual(2, properties.Properties.Skip(1).First().Id);
            Assert.AreEqual(3, properties.Properties.Skip(2).First().Id);
            Assert.AreEqual(10, properties.Properties.Last().Id);
        }
        [Test]
        public void TestGetPropertiesSecondPage()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.GetProperties(2);

            Assert.AreEqual(2, properties.Properties.Count);
            Assert.AreEqual(11, properties.Properties.First().Id);
            Assert.AreEqual(12, properties.Properties.Skip(1).First().Id);
        }
        [Test]
        public void TestSearch()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.SearchByPrice(50000, 100000);

            Assert.AreEqual(6, properties.Properties.Count);
            Assert.AreEqual(50000, properties.Properties.First().Price);
            Assert.AreEqual(100000, properties.Properties.Last().Price);
        }

        [Test]
        public void TestGetTopExpensive()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.GetTopExpensivePropeties();

            Assert.AreEqual(6, properties.Properties.Count);
            Assert.AreEqual(120000, properties.Properties.First().Price);
        }

        [Test]
        public void TestGetTopCheapest()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.GetTopChepestPropeties();

            Assert.AreEqual(6, properties.Properties.Count);
            Assert.AreEqual(10000, properties.Properties.First().Price);
        }

        [Test]
        public void TestTopNewest()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.TopNewestProperties();

            Assert.AreEqual(6, properties.Properties.Count);
            Assert.AreEqual(2012, properties.Properties.First().Year);
        }
        [Test]
        public void TestLastAdded()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var properties = service.GetLastAddedProperties();

            Assert.AreEqual(6, properties.Properties.Count);
            Assert.AreEqual("Last Added", properties.Properties.First().District);
        }

        [Test]
        public void TestUpdatePropertyWithCorrectValue()
        {
            PropertyViewModel model = new PropertyViewModel()
            {
                Id = 5,
                Size = 400,
                Floor = "8/88",
                Price = 15000,
            };

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            service.UpdateProperties(model);

            var updatetProperty = mockContext.Object.Properties.ToList().Where(x => x.Id == 5).FirstOrDefault();

            Assert.AreEqual(15000, updatetProperty.Price);
            Assert.AreEqual(400, updatetProperty.Size);
            Assert.AreEqual(8, updatetProperty.Floor);
            Assert.AreEqual(88, updatetProperty.TotalNumberOfFloors);
        }
        [Test]
        public void TestUpdatePropertyWithInCorrectValue()
        {
            PropertyViewModel model = new PropertyViewModel()
            {
                Id = 6,
                Size = 400,
                Floor = "aaaa",
                Price = 15000,
            };

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            service.UpdateProperties(model);

            var updatetProperty = mockContext.Object.Properties.ToList().Where(x => x.Id == 6).FirstOrDefault();

            Assert.AreEqual(15000, updatetProperty.Price);
            Assert.AreEqual(400, updatetProperty.Size);
            Assert.AreEqual(null, updatetProperty.Floor);
            Assert.AreEqual(null, updatetProperty.TotalNumberOfFloors);
        }


        [Test]
        public void TestDelete()
        {

            var mockSet = new Mock<DbSet<Property>>();
            mockSet.As<IQueryable<Property>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Property>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Property>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Property>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(p => p.Properties).Returns(mockSet.Object);

            var service = new PropertiesService(mockContext.Object);
            var isDeleted = service.DeleteProperty(5);

            Assert.AreEqual(true, isDeleted);
        }

    }
}