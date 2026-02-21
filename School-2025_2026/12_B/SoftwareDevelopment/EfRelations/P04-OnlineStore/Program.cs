using System;
using System.Linq;
using System.Collections.Generic;
using P04_OnlineStore.Data;
using P04_OnlineStore.Data.Models;

namespace P04_OnlineStore
{
    public class Program
    {
        private static AppDbContext context = new AppDbContext();

        public static void Main()
        {
            // ensure there is some initial data
            SeedDataIfEmpty();

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
                Console.WriteLine("10) List item types");
                Console.WriteLine("11) Update item type");
                Console.WriteLine("12) Delete item type");
                Console.WriteLine("13) Add item");
                Console.WriteLine("14) List items");
                Console.WriteLine("15) Update item");
                Console.WriteLine("16) Delete item");
                Console.WriteLine("17) Create order");
                Console.WriteLine("18) List orders");
                Console.WriteLine("19) Update order");
                Console.WriteLine("20) Delete order");
                Console.WriteLine("21) Exit");
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
                        ListItemTypes();
                        break;
                    case "11":
                        UpdateItemType();
                        break;
                    case "12":
                        DeleteItemType();
                        break;
                    case "13":
                        AddItem();
                        break;
                    case "14":
                        ListItems();
                        break;
                    case "15":
                        UpdateItem();
                        break;
                    case "16":
                        DeleteItem();
                        break;
                    case "17":
                        CreateOrder();
                        break;
                    case "18":
                        ListOrders();
                        break;
                    case "19":
                        UpdateOrder();
                        break;
                    case "20":
                        DeleteOrder();
                        break;
                    case "21":
                        return;
                default:
                        Console.WriteLine("Unknown choice. Try again.");
                        break;
                }
            }
        }

        // Seed initial data when database is empty
        public static void SeedDataIfEmpty()
        {
            // if there are any cities, assume DB already seeded
            if (context.Cities.Any()) return;

            // create sample cities
            var c1 = new City { Name = "Springfield" };
            var c2 = new City { Name = "Shelbyville" };

            context.Cities.AddRange(c1, c2);

            // create sample item types
            var t1 = new ItemType { Name = "Electronics" };
            var t2 = new ItemType { Name = "Books" };
            context.ItemTypes.AddRange(t1, t2);

            // create sample items
            var i1 = new Item { Name = "Laptop", ItemType = t1 };
            var i2 = new Item { Name = "Smartphone", ItemType = t1 };
            var i3 = new Item { Name = "C# Programming", ItemType = t2 };
            context.Items.AddRange(i1, i2, i3);

            // create sample customers
            var cust1 = new Customer { Name = "John Doe", Birthday = new DateTime(1990, 1, 1), City = c1 };
            var cust2 = new Customer { Name = "Jane Smith", Birthday = new DateTime(1985, 5, 20), City = c2 };
            context.Customers.AddRange(cust1, cust2);

            // create sample order for customer 1
            var order1 = new Order { Customer = cust1 };
            context.Orders.Add(order1);
            context.OrdersItems.Add(new OrderItem { Order = order1, Item = i1 });
            context.OrdersItems.Add(new OrderItem { Order = order1, Item = i3 });

            context.SaveChanges();

            Console.WriteLine("Seeded initial data.");
        }

        public static void ListItemTypes()
        {
            var types = context.ItemTypes.OrderBy(t => t.Id).ToList();
            if (!types.Any())
            {
                Console.WriteLine("No item types found.");
                return;
            }

            Console.WriteLine("Item types:");
            foreach (var t in types)
            {
                Console.WriteLine($"Id: {t.Id}, Name: {t.Name}");
            }
        }

        public static void UpdateItemType()
        {
            Console.Write("Enter item type id to update: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var type = context.ItemTypes.FirstOrDefault(t => t.Id == id);
            if (type == null)
            {
                Console.WriteLine($"Item type with Id {id} not found.");
                return;
            }

            Console.Write($"Enter new name for item type (current: '{type.Name}'): ");
            string? newName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("Item type name is required.");
                return;
            }

            if (newName.Length > 50)
            {
                Console.WriteLine("Item type name is too long (max 50 characters).");
                return;
            }

            bool exists = context.ItemTypes.Any(x => x.Name == newName && x.Id != id);
            if (exists)
            {
                Console.WriteLine($"Another item type with name '{newName}' already exists.");
                return;
            }

            type.Name = newName;
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item type '{type.Name}' (Id: {type.Id}) was updated.");
            }
            else
            {
                Console.WriteLine("Something went wrong while updating the item type.");
            }
        }

        public static void DeleteItemType()
        {
            Console.Write("Enter item type id to delete: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var type = context.ItemTypes.FirstOrDefault(t => t.Id == id);
            if (type == null)
            {
                Console.WriteLine($"Item type with Id {id} not found.");
                return;
            }

            bool hasItems = context.Items.Any(i => i.ItemTypeId == id);
            if (hasItems)
            {
                Console.WriteLine("Cannot delete item type because there are items associated with it.");
                return;
            }

            Console.Write($"Are you sure you want to delete item type '{type.Name}' (Id: {type.Id})? (y/N): ");
            var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (yn != "y")
            {
                Console.WriteLine("Aborted.");
                return;
            }

            context.ItemTypes.Remove(type);
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item type '{type.Name}' (Id: {type.Id}) was deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong while deleting the item type.");
            }
        }

        public static void ListItems()
        {
            var items = context.Items.OrderBy(i => i.Id).ToList();
            if (!items.Any())
            {
                Console.WriteLine("No items found.");
                return;
            }

            Console.WriteLine("Items:");
            foreach (var it in items)
            {
                var typeName = it.ItemType?.Name ?? "(no type)";
                Console.WriteLine($"Id: {it.Id}, Name: {it.Name}, Type: {typeName}");
            }
        }

        public static void UpdateItem()
        {
            Console.Write("Enter item id to update: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var item = context.Items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                Console.WriteLine($"Item with Id {id} not found.");
                return;
            }

            Console.Write($"Enter new name for item (current: '{item.Name}'): ");
            string? newName = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("Item name is required.");
                return;
            }

            if (newName.Length > 50)
            {
                Console.WriteLine("Item name is too long (max 50 characters).");
                return;
            }

            Console.Write($"Enter new item type id or leave empty to keep current (current: {item.ItemTypeId}): ");
            string? typeIdInput = Console.ReadLine()?.Trim();
            if (!string.IsNullOrEmpty(typeIdInput))
            {
                if (!int.TryParse(typeIdInput, out int typeId))
                {
                    Console.WriteLine("Invalid type id.");
                    return;
                }
                var type = context.ItemTypes.FirstOrDefault(t => t.Id == typeId);
                if (type == null)
                {
                    Console.WriteLine($"Item type with Id {typeId} not found.");
                    return;
                }
                item.ItemType = type;
            }

            item.Name = newName;
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item '{item.Name}' (Id: {item.Id}) was updated.");
            }
            else
            {
                Console.WriteLine("Something went wrong while updating the item.");
            }
        }

        public static void DeleteItem()
        {
            Console.Write("Enter item id to delete: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var item = context.Items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                Console.WriteLine($"Item with Id {id} not found.");
                return;
            }

            bool usedInOrders = context.OrdersItems.Any(oi => oi.ItemId == id);
            if (usedInOrders)
            {
                Console.WriteLine("Cannot delete item because it is used in orders.");
                return;
            }

            Console.Write($"Are you sure you want to delete item '{item.Name}' (Id: {item.Id})? (y/N): ");
            var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (yn != "y")
            {
                Console.WriteLine("Aborted.");
                return;
            }

            context.Items.Remove(item);
            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Item '{item.Name}' (Id: {item.Id}) was deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong while deleting the item.");
            }
        }

        public static void CreateOrder()
        {
            Console.Write("Enter customer id for order: ");
            string? custInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(custInput, out int custId))
            {
                Console.WriteLine("Invalid customer id.");
                return;
            }

            var customer = context.Customers.FirstOrDefault(c => c.Id == custId);
            if (customer == null)
            {
                Console.WriteLine($"Customer with Id {custId} not found.");
                return;
            }

            var order = new Order { Customer = customer };
            context.Orders.Add(order);

            while (true)
            {
                Console.Write("Enter item id to add to order (or empty to finish): ");
                string? itemInput = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(itemInput)) break;
                if (!int.TryParse(itemInput, out int itemId))
                {
                    Console.WriteLine("Invalid item id.");
                    continue;
                }

                var item = context.Items.FirstOrDefault(i => i.Id == itemId);
                if (item == null)
                {
                    Console.WriteLine($"Item with Id {itemId} not found.");
                    continue;
                }

                var oi = new OrderItem { Order = order, Item = item };
                context.OrdersItems.Add(oi);
            }

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine($"Order {order.Id} created for customer {customer.Name}.");
            }
            else
            {
                Console.WriteLine("Something went wrong while creating the order.");
            }
        }

        public static void ListOrders()
        {
            var orders = context.Orders.OrderBy(o => o.Id).ToList();
            if (!orders.Any())
            {
                Console.WriteLine("No orders found.");
                return;
            }

            Console.WriteLine("Orders:");
            foreach (var o in orders)
            {
                var custName = o.Customer?.Name ?? "(no customer)";
                var items = context.OrdersItems.Where(oi => oi.OrderId == o.Id).Select(oi => oi.Item.Name).ToList();
                Console.WriteLine($"Order Id: {o.Id}, Customer: {custName}, Items: {string.Join(", ", items)}");
            }
        }

        public static void UpdateOrder()
        {
            Console.Write("Enter order id to update: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var order = context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                Console.WriteLine($"Order with Id {id} not found.");
                return;
            }

            Console.WriteLine("Current items:");
            var currentItems = context.OrdersItems.Where(oi => oi.OrderId == id).ToList();
            foreach (var ci in currentItems)
            {
                Console.WriteLine($"ItemId: {ci.ItemId}, Name: {ci.Item?.Name}");
            }

            Console.WriteLine("Enter commands: 'add <itemId>' or 'remove <itemId>' or empty to finish");
            while (true)
            {
                Console.Write("> ");
                string? cmd = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(cmd)) break;
                var parts = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2) { Console.WriteLine("Invalid command."); continue; }
                if (!int.TryParse(parts[1], out int itemId)) { Console.WriteLine("Invalid item id."); continue; }

                if (parts[0].ToLowerInvariant() == "add")
                {
                    var item = context.Items.FirstOrDefault(i => i.Id == itemId);
                    if (item == null) { Console.WriteLine("Item not found."); continue; }
                    if (context.OrdersItems.Any(oi => oi.OrderId == id && oi.ItemId == itemId)) { Console.WriteLine("Item already in order."); continue; }
                    context.OrdersItems.Add(new OrderItem { Order = order, Item = item });
                }
                else if (parts[0].ToLowerInvariant() == "remove")
                {
                    var oi = context.OrdersItems.FirstOrDefault(x => x.OrderId == id && x.ItemId == itemId);
                    if (oi == null) { Console.WriteLine("Item not in order."); continue; }
                    context.OrdersItems.Remove(oi);
                }
                else { Console.WriteLine("Unknown action."); }
            }

            int result = context.SaveChanges();
            if (result > 0)
            {
                Console.WriteLine("Order updated.");
            }
            else
            {
                Console.WriteLine("Nothing changed or error occurred.");
            }
        }

        public static void DeleteOrder()
        {
            Console.Write("Enter order id to delete: ");
            string? idInput = Console.ReadLine()?.Trim();
            if (!int.TryParse(idInput, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            var order = context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                Console.WriteLine($"Order with Id {id} not found.");
                return;
            }

            Console.Write($"Are you sure you want to delete order {order.Id}? (y/N): ");
            var yn = Console.ReadLine()?.Trim().ToLowerInvariant();
            if (yn != "y") { Console.WriteLine("Aborted."); return; }

            var orderItems = context.OrdersItems.Where(oi => oi.OrderId == id).ToList();
            foreach (var oi in orderItems) context.OrdersItems.Remove(oi);
            context.Orders.Remove(order);

            int result = context.SaveChanges();
            if (result > 0) Console.WriteLine("Order deleted."); else Console.WriteLine("Something went wrong while deleting the order.");
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
