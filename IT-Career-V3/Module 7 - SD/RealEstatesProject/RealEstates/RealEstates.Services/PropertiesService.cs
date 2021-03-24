

namespace RealEstates.Services
{
    using System;
    using System.Linq;
    using RealEstates.Data;
    using RealEstates.Data.Models;
    using RealEstates.ViewModels;

    public class PropertiesService : IPropertiesService
    {
        private readonly ApplicationDbContext db;

        public PropertiesService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public bool DeleteProperty(int id)
        {
            Property property = this.db.Properties.FirstOrDefault(x => x.Id == id);
            if (property == null)
            {
                return false;
            }
            this.db.Properties.Remove(property);
            this.db.SaveChanges();
            return true;
        }

        public void UpdateProperties(PropertyViewModel model)
        {
            Property property = this.db.Properties.FirstOrDefault(x => x.Id == model.Id);
            if (property == null)
            {
                return;
            }

            property.Price = model.Price;
            property.Size = model.Size;
            if (int.TryParse(model.Floor.Split('/').First(), out _) && int.TryParse(model.Floor.Split('/').Last(), out _))
            {
                property.Floor = int.Parse(model.Floor.Split('/').First());
                property.TotalNumberOfFloors = int.Parse(model.Floor.Split('/').Last());
            }
            else
            {
                property.Floor = null;
                property.TotalNumberOfFloors = null;
            }

            this.db.Properties.Update(property);
            this.db.SaveChanges();
        }

        public PropertiesViewModel GetProperties(int pageNumber = 1)
        {
            PropertiesViewModel model = new PropertiesViewModel();

            model.ElementsCount = db.Properties.Count();
            model.PageNumber = pageNumber;
            model.Properties = db.Properties.Select(x => new PropertyViewModel()
            {
                Id = x.Id,
                District = x.District.Name,
                Size = x.Size,
                Price = x.Price,
                Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                Tags = x.Tags.Select(t => t.Tag.Name).ToList(),
            }).Skip(model.ItemsPerPage * (model.PageNumber - 1))
            .Take(model.ItemsPerPage)
            .ToList();

            return model;
        }
       
        public SearchPropertiesViewModel SearchByPrice(int minPrice, int maxPrice, int pageNumber = 1)
        {
            SearchPropertiesViewModel model = new SearchPropertiesViewModel();

            model.ElementsCount = db.Properties.Count();
            model.PageNumber = pageNumber;
            model.MinPrice = minPrice;
            model.MaxPrice = maxPrice;


            model.Properties = db.Properties
                .OrderBy(x => x.Price)
                .Where(x => x.Price >= minPrice && x.Price <= maxPrice)
                .Select(x => new PropertyViewModel()
                {
                    District = x.District.Name,
                    Size = x.Size,
                    Price = x.Price,
                    Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                    Tags = x.Tags.Select(t => t.Tag.Name).ToList(),
                }).Skip(model.ItemsPerPage * (model.PageNumber - 1))
            .Take(model.ItemsPerPage)
            .ToList();

            return model;
        }

        public void Create(PropertyInputViewModel input)
        {
            if (input.District == null)
            {
                throw new ArgumentException(nameof(input.District));
            }

            Property property = new Property()
            {
                Size = input.Size,
                Price = input.Price,
                Year = input.Year < 1500 ? null : input.Year,
                Floor = input.Floor <= 0 ? null : input.Floor,
                TotalNumberOfFloors = input.TotalFloors <= 0 ? null : input.TotalFloors
            };

            District district = this.db.Districts.FirstOrDefault(x => x.Name == input.District);

            if (district == null)
            {
                district = new District() { Name = input.District };
            }

            property.District = district;

            PropertyType propertyType = this.db.PropertyTypes.FirstOrDefault(x => x.Name == input.PropertyType);
            if (propertyType == null)
            {
                propertyType = new PropertyType() { Name = input.PropertyType };
            }

            property.PropertyType = propertyType;

            BuildingType buildingType = this.db.BuildingTypes.FirstOrDefault(x => x.Name == input.BuildingType);
            if (buildingType == null)
            {
                buildingType = new BuildingType() { Name = input.BuildingType };
            }

            property.BuildingType = buildingType;

            this.db.Properties.Add(property);
            this.db.SaveChanges();

            this.UpdateTags(property.Id);
        }

        private void UpdateTags(int propertyId)
        {
            Property property = this.db.Properties.FirstOrDefault(x => x.Id == propertyId);

            if (property == null)
            {
                return;
            }

            property.Tags.Clear();

            if (property.Year.HasValue && property.Year < 1990)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("OldBuilding")
                    });
            }

            if (property.Size > 200)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("HugeProperty")
                    });
            }
            else if (property.Size > 100)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("BigProperty")
                    });
            }
            else if (property.Size > 50 && property.Size <= 100)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("MediumProperty")
                    });
            }
            else
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("SmallProperty")
                    });
            }

            if (property.Year.HasValue && property.Year > 2016 && property.TotalNumberOfFloors.HasValue && property.TotalNumberOfFloors > 5)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("HasParking")
                    });
            }

            if (((double)property.Price / property.Size) < 800)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("CheapProperty")
                    });
            }
            else if (((double)property.Price / property.Size) > 2000)
            {
                property.Tags.Add(
                    new TagProperty
                    {
                        Tag = this.GetOrCreateTag("ExpensiveProperty")
                    });
            }

            //db.Properties.Update(property);
            db.SaveChanges();
        }
        private Tag GetOrCreateTag(string tagName)
        {
            Tag tag = this.db.Tags.FirstOrDefault(x => x.Name == tagName);

            if (tag == null)
            {
                tag = new Tag() { Name = tagName };
            }

            return tag;
        }

        public TopPropertiesViwModel GetTopExpensivePropeties()
        {
            TopPropertiesViwModel model = new TopPropertiesViwModel();

            model.Properties = this.db.Properties
                .OrderByDescending(x => x.Price)
                .Take(6)
                .Select(x => new PropertyViewModel()
                {
                    District = x.District.Name,
                    Size = x.Size,
                    Price = x.Price,
                    Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                    PropertyType = x.PropertyType.Name
                })
                .ToList();

            return model;
        }

        public TopPropertiesViwModel GetTopChepestPropeties()
        {
            TopPropertiesViwModel model = new TopPropertiesViwModel();

            model.Properties = this.db.Properties
                .Where(x => x.Price > 0)
                .OrderBy(x => x.Price)
                .Take(6)
                .Select(x => new PropertyViewModel()
                {
                    District = x.District.Name,
                    Size = x.Size,
                    Price = x.Price,
                    Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                    PropertyType = x.PropertyType.Name
                })
                .ToList();

            return model;
        }

        public TopPropertiesViwModel TopNewestProperties()
        {
            TopPropertiesViwModel model = new TopPropertiesViwModel();

            model.Properties = this.db.Properties
                .Where(x => x.Price > 0 && x.Year <= DateTime.Now.Year)
                .OrderByDescending(x => x.Year)
                .Take(6)
                .Select(x => new PropertyViewModel()
                {
                    District = x.District.Name,
                    Size = x.Size,
                    Price = x.Price,
                    Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                    PropertyType = x.PropertyType.Name,
                    Year = x.Year != null ? (int)x.Year : 0
                })
                .ToList();

            return model;
        }

        public TopPropertiesViwModel GetLastAddedProperties()
        {
            TopPropertiesViwModel model = new TopPropertiesViwModel();

            model.Properties = this.db.Properties
                .Where(x => x.Price > 0 && x.Year <= DateTime.Now.Year)
                .OrderByDescending(x => x.Id)
                .Take(6)
                .Select(x => new PropertyViewModel()
                {
                    District = x.District.Name,
                    Size = x.Size,
                    Price = x.Price,
                    Floor = (x.Floor ?? 0).ToString() + "/" + (x.TotalNumberOfFloors ?? 0),
                    PropertyType = x.PropertyType.Name,
                    Year = x.Year != null ? (int)x.Year : 0
                })
                .ToList();

            return model;
        }
    }
}
