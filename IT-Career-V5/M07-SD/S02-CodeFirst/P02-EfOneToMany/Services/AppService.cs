namespace P02_EfOneToMany.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Data;
    using Data.Models;
    public class AppService
    {
        private readonly AppDbContext context;

        public AppService(AppDbContext context)
        {
            this.context = context;
        }

        public string AddModel(string manufacturer, string model)
        {
            Manufacturer m = this.context.Manufacturers.FirstOrDefault(x => x.Name == manufacturer);
            if (m == null)
            {
                return $"Manufacturer doesn't exist!";
            }
            this.context.Models.Add(new Model() { Name = model, Manufacturer = m });
            this.context.SaveChanges();
            return $"Model is added successfully!";
        }

        public string AddManufacturer(string name, DateTime establishedOn)
        {
            Manufacturer m = this.context.Manufacturers.FirstOrDefault(x => x.Name == name);
            if (m != null)
            {
                return $"Manufacturer exists!";
            }
            m = new Manufacturer() { Name = name, EstablishedOn = establishedOn };
            this.context.Manufacturers.Add(m);
            this.context.SaveChanges();
            return $"Manufacturer is added successfully!";
        }

        public string GetModelsInfo()
        {
            StringBuilder sb = new StringBuilder();

            List<Model> models = this.context.Models.ToList();

            if (models.Any())
            {
                string firstRow = $"|{"Brand",-10} | {"Model",-10}|";
                string line = ($"|{new string('-',firstRow.Length - 2)}|");
                sb.AppendLine(firstRow);
                sb.AppendLine(line);
                foreach (var model in models)
                {
                    sb.AppendLine($"|{model.Manufacturer.Name,-10} | {model.Name,-10}|");
                    sb.AppendLine(line);
                }
            }
            else
            {
                sb.AppendLine("Database is empty!");
            }

            return sb.ToString().TrimEnd();
        }

        public bool DoesManufacturerExist(string name)
        {
            return this.context.Manufacturers.Any(x => x.Name == name);
        }
    }
}
