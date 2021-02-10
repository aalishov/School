namespace RealEstates.Services
{
    using RealEstates.Data;
    using RealEstates.Data.Models;
    using RealEstates.Services.Models;
    using System;
    using System.Linq;

    public class PropertiesService
    {
        private readonly ApplicationDbContext db;

        public PropertiesService(ApplicationDbContext db)
        {
            this.db = db;
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
            if (propertyType==null)
            {
                propertyType = new PropertyType() { Name = input.PropertyType };
            }

            property.PropertyType = propertyType;

            BuildingType buildingType = this.db.BuildingTypes.FirstOrDefault(x => x.Name == input.BuildingType);
            if (buildingType==null)
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
    }
}
