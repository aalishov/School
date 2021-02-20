using RealEstates.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstates.Services
{
    public class WindowsFormService
    {
        private ApplicationDbContext dbContext;

        public WindowsFormService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public object[] GetYears()
        {
            ICollection<object> years = new List<object>();
            for (int i = DateTime.Today.Year; i >= 1850; i--)
            {
                years.Add(i);
            }
            return years.ToArray();
        }

        public object[] GetDistricts()
        {
            return this.dbContext.Districts.Select(x => x.Name).ToArray();
        }

        public object[] GetPropertyTypes()
        {
            return this.dbContext.PropertyTypes.Select(x => x.Name).ToArray();
        }

        public object[] GetBuildingTypes()
        {
            return this.dbContext.BuildingTypes.Select(x => x.Name).ToArray();
        }
    }
}
