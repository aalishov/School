using P04_OnlineStore.Data;
using P04_OnlineStore.Data.Models;

namespace P04_OnlineStore
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Add city");
                Console.WriteLine("2) List cities");
                Console.WriteLine("3) Update city");
                Console.WriteLine("4) Delete city");
                Console.WriteLine("5) Add customer");
                Console.WriteLine("6) List customers");
                Console.WriteLine("7) Update customer");
                Console.WriteLine("8) Delete customer");
                Console.WriteLine("9) Add item type");
                Console.WriteLine("10) Add item");
                Console.WriteLine("11) Exit");
                Console.Write("Choice: ");

                string? choice = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddCity();
                        break;
                    case "2":
                        ListCities();
                        break;
                    case "3":
                        UpdateCity();
                        break;
                    case "4":
                        DeleteCity();
                        break;
                    case "5":
                        AddCustomer();
                        break;
                    case "6":
                        ListCustomers();
                        break;
                    case "7":
                        UpdateCustomer();
                        break;
                    case "8":
                        DeleteCustomer();
                        break;
                    case "9":
                        AddItemType();
                        break;
                    case "10":
                        AddItem();
                        break;
                    case "11":
                        return;
                    default:
                        Console.WriteLine("Unknown choice. Try again.");
                        break;
                }
            }
        }

        public static void ListCities()
        {
            var cities = context.Cities
                .OrderBy(c => c.Id)
                .ToList();

            if (!cities.Any())
            {
                Console.WriteLine("No cities found.");
                return;
            }

            Console.WriteLine("Cities:");
            foreach (var city in cities)
            {
                Console.WriteLine($"Id: {city.Id}, Name: {city.Name}");
            }
        }

        public static void ListCustomers()
        {
            var customers = context.Customers
                .OrderBy(c => c.Id)
                .ToList();

            if (!customers.Any())
            {
                Console.WriteLine("No customers found.");
                return;
            }

            Console.WriteLine("Customers:");
            foreach (var customer in customers)
            {
                var cityName = customer.City?.Name ?? "(no city)";
                var bday = customer.Birthday.HasValue ? customer.Birthday.Value.ToString("yyyy-MM-dd") : "(unknown)";
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Birthday: {bday}, City: {cityName}");
            }
        }

        public static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Customer name is required.");
                return;
            }

            if (name.Length > 50)
            {
                Console.WriteLine("Customer name is too long (max 50 characters).");
                return;
            }

            Console.Write("Enter customer birthday (yyyy-MM-dd) or leave empty: ");
            string? bdayInput = Console.ReadLine()?.Trim();
            DateTime? birthday = null;
            if (!string.IsNullOrEmpty(bdayInput))
            {
                if (DateTime.TryParse(bdayInput, out DateTime dt))
                {
                    birthday = dt.Date;
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                    return;
                }
            }

            Console.Write("Enter city id for customer: ");
            string? cityIdInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(cityIdInput, out int cityId))
            {
                Console.WriteLine("Invalid city id.");
                return;
            }

            var city = context.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                Console.WriteLine($"City with Id {cityId} not found.");
                return;
            }

            var customer = new Customer
            {
                Name = name,
                Birthday = birthday,
                City = city
            };

            context.Customers.Add(customer);
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Customer '{customer.Name}' was added (Id: {customer.Id}).");
            }
            else
            {
                Console.WriteLine("Something went wrong while saving the customer.");
            }
        }

        public static void UpdateCustomer()
        {
            Console.Write("Enter customer id to update: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var customer = context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                Console.WriteLine($"Customer with Id {id} not found.");
                return;
            }

            Console.Write($"Enter new name for customer (current: '{customer.Name}'): ");
            string? newName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("Customer name is required.");
                return;
            }

            if (newName.Length > 50)
            {
                Console.WriteLine("Customer name is too long (max 50 characters).");
                return;
            }

            Console.Write($"Enter new birthday (yyyy-MM-dd) or leave empty to keep current (current: {(customer.Birthday.HasValue ? customer.Birthday.Value.ToString("yyyy-MM-dd") : "(unknown)")}): ");
            string? bdayInput = Console.ReadLine()?.Trim();
            DateTime? birthday = customer.Birthday;
            if (!string.IsNullOrEmpty(bdayInput))
            {
                if (DateTime.TryParse(bdayInput, out DateTime dt))
                {
                    birthday = dt.Date;
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                    return;
                }
            }

            Console.Write($"Enter new city id or leave empty to keep current (current: {customer.CityId}): ");
            string? cityIdInput = Console.ReadLine()?.Trim();
            int cityId = customer.CityId;
            if (!string.IsNullOrEmpty(cityIdInput))
            {
                if (!int.TryParse(cityIdInput, out cityId))
                {
                    Console.WriteLine("Invalid city id.");
                    return;
                }

                var city = context.Cities.FirstOrDefault(c => c.Id == cityId);
                if (city == null)
                {
                    Console.WriteLine($"City with Id {cityId} not found.");
                    return;
                }
                customer.City = city;
            }

            customer.Name = newName;
            customer.Birthday = birthday;

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Customer '{customer.Name}' (Id: {customer.Id}) was updated.");
            }
            else
            {
                Console.WriteLine("Something went wrong while updating the customer.");
            }
        }

        public static void DeleteCustomer()
        {
            Console.Write("Enter customer id to delete: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var customer = context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                Console.WriteLine($"Customer with Id {id} not found.");
                return;
            }

            bool hasOrders = context.Orders.Any(o => o.CustomerId == id);
            if (hasOrders)
            {
                Console.WriteLine("Cannot delete customer because there are orders associated with them.");
                return;
            }

            Console.Write($"Are you sure you want to delete customer '{customer.Name}' (Id: {customer.Id})? (y/N): ");
            var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (yn != "y")
            {
                Console.WriteLine("Aborted.");
                return;
            }

            context.Customers.Remove(customer);
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Customer '{customer.Name}' (Id: {customer.Id}) was deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong while deleting the customer.");
            }
        }

        public static void UpdateCity()
        {
            Console.Write("Enter city id to update: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var city = context.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                Console.WriteLine($"City with Id {id} not found.");
                return;
            }

            Console.Write($"Enter new name for city (current: '{city.Name}'): ");
            string? newName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("City name is required.");
                return;
            }

            if (newName.Length > 50)
            {
                Console.WriteLine("City name is too long (max 50 characters).");
                return;
            }

            bool exists = context.Cities.Any(x => x.Name == newName && x.Id != id);
            if (exists)
            {
                Console.WriteLine($"Another city with name '{newName}' already exists.");
                return;
            }

            city.Name = newName;
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"City '{city.Name}' (Id: {city.Id}) was updated.");
            }
            else
            {
                Console.WriteLine("Something went wrong while updating the city.");
            }
        }

        public static void DeleteCity()
        {
            Console.Write("Enter city id to delete: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var city = context.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                Console.WriteLine($"City with Id {id} not found.");
                return;
            }

            bool hasCustomers = context.Customers.Any(c => c.CityId == id);
            if (hasCustomers)
            {
                Console.WriteLine("Cannot delete city because there are customers associated with it.");
                return;
            }

            Console.Write($"Are you sure you want to delete city '{city.Name}' (Id: {city.Id})? (y/N): ");
            var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (yn != "y")
            {
                Console.WriteLine("Aborted.");
                return;
            }

            context.Cities.Remove(city);
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"City '{city.Name}' (Id: {city.Id}) was deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong while deleting the city.");
            }
        }

        public static void AddCity()
        {
            Console.Write("Enter city name: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("City name is required.");
                return;
            }

            bool exists = context.Cities.Any(x => x.Name == name);
            if (exists)
            {
                Console.WriteLine($"City '{name}' already exists.");
                return;
            }

            var city = new City { Name = name };
            context.Cities.Add(city);

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"City '{city.Name}' was added (Id: {city.Id}).");
            }
            else
            {
                Console.WriteLine("Something went wrong while saving the city.");
            }
        }

        public static void AddItemType()
        {
            Console.Write("Enter item type name: ");
            string? name = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Item type name is required.");
                return;
            }

            if (name.Length > 50)
            {
                Console.WriteLine("Item type name is too long (max 50 characters).");
                return;
            }

            bool exists = context.ItemTypes.Any(it => it.Name == name);
            if (exists)
            {
                Console.WriteLine($"Item type '{name}' already exists.");
                return;
            }

            var itemType = new ItemType { Name = name };
            context.ItemTypes.Add(itemType);

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item type '{itemType.Name}' was added (Id: {itemType.Id}).");
            }
            else
            {
                Console.WriteLine("Something went wrong while saving the item type.");
            }
        }

        public static void AddItem()
        {
            Console.Write("Enter item name: ");
            string? itemName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(itemName))
            {
                Console.WriteLine("Item name is required.");
                return;
            }

            if (itemName.Length > 50)
            {
                Console.WriteLine("Item name is too long (max 50 characters).");
                return;
            }

            Console.Write("Enter item type name: ");
            string? typeName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(typeName))
            {
                Console.WriteLine("Item type name is required.");
                return;
            }

            var itemType = context.ItemTypes.FirstOrDefault(it => it.Name == typeName);
            if (itemType == null)
            {
                Console.Write($"Item type '{typeName}' does not exist. Create it? (y/N): ");
                var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
                if (yn == "y")
                {
                    itemType = new ItemType { Name = typeName };
                    context.ItemTypes.Add(itemType);
                    // will be saved together with the item below
                }
                else
                {
                    Console.WriteLine("Aborted.");
                    return;
                }
            }

            bool itemExists = context.Items.Any(i => i.Name == itemName && i.ItemTypeId == itemType.Id);
            if (itemExists)
            {
                Console.WriteLine($"Item '{itemName}' of type '{itemType.Name}' already exists.");
                return;
            }

            var item = new Item
            {
                Name = itemName,
                ItemType = itemType
            };

            context.Items.Add(item);

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item '{item.Name}' was added (Id: {item.Id}) under type '{itemType.Name}'.");
            }
            else
            {
                Console.WriteLine("Something went wrong while saving the item.");
            }
        }
    }
}
