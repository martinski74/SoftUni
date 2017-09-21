using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShopHierarchy
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new ShopDbContext())
            {
                // Included problrm 06.Extended, problem 07.Comlex Query, 
                // problem 08.ExplicitDataLoading and problem 09.Query Loaded Data


                PrepareDatabase(db);
                SaveSalesman(db);
                SaveItems(db);
                ProcessComands(db);
                //PrintSalesmanWithCustomCount(db);
                //PrintCustomersWithOrdersAndReviewsCount(db);
                //PrintCustomersWithOrdersAndReviews(db);
                //PrintCustomerData(db);
                PrintOrdersWithMoerThanOneItam(db);
            }
        }

        private static void PrintOrdersWithMoerThanOneItam(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var order = db
                .Orders
                .Where(o => o.CustomerId == customerId)
                .Where(o => o.Items.Count > 1)
                .Count();
            Console.WriteLine($"Orders: {order}");
        }

        private static void PrintCustomerData(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var custimerData = db
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                    Salesman = c.Salesman.Name
                })
                .FirstOrDefault();

            Console.WriteLine($"Customer: {custimerData.Name}");
            Console.WriteLine($"Order count: {custimerData.Orders}");
            Console.WriteLine($"Reviews count: {custimerData.Reviews}");
            Console.WriteLine($"Salesman: {custimerData.Salesman}");
        }

        private static void PrintCustomersWithOrdersAndReviews(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var customerData = db
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    Orders = c
                    .Orders
                    .Select(o => new
                    {
                        o.Id,
                        Items = o.Items.Count
                    })
                    .OrderBy(o => o.Id),
                    Reviews = c.Reviews.Count
                })
                .FirstOrDefault();

            foreach (var order in customerData.Orders)
            {
                Console.WriteLine($"order {order.Id}: {order.Items} item");
            }
            Console.WriteLine($"reviews: {customerData.Reviews}");
        }

        private static void PrintCustomersWithOrdersAndReviewsCount(ShopDbContext db)
        {
            var customers = db
                .Customers
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count
                })
            .OrderByDescending(c => c.Orders)
            .ThenByDescending(c => c.Reviews)
            .ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine($"Orders: {customer.Orders}");
                Console.WriteLine($"Reviews: {customer.Reviews}");
            }

        }

        private static void PrintSalesmanWithCustomCount(ShopDbContext db)
        {
            var salesManData = db
                 .Salesmen
                 .Select(s => new
                 {
                     s.Name,
                     Customers = s.Customers.Count
                 })
                 .OrderByDescending(s => s.Customers)
                 .ThenBy(s => s.Name)
                 .ToList();

            foreach (var item in salesManData)
            {
                Console.WriteLine($"{item.Name} - {item.Customers} customers");
            }

        }

        private static void ProcessComands(ShopDbContext db)
        {
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var parts = line.Split('-');
                var command = parts[0];
                var arguments = parts[1];

                switch (command)
                {
                    case "register":
                        RegisterCustomer(db, arguments);
                        break;
                    case "review":
                        SaveReview(db, arguments);
                        break;

                    case "order":
                        SaveOrder(db, arguments);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void SaveOrder(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var customerId = int.Parse(parts[0]);

            var order = new Order { CustomerId = customerId };

            for (int i = 1; i < parts.Length; i++)
            {
                var itemId = int.Parse(parts[i]);
                order.Items.Add(new ItemOrder
                {
                    ItemId = itemId
                });
            }

            db.Add(order);

            db.SaveChanges();
        }

        private static void SaveReview(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var customerId = int.Parse(parts[0]);
            var itemId = int.Parse(parts[1]);

            db.Add(new Review
            {
                CustomerId = customerId,
                ItemId = itemId
            });

            db.SaveChanges();
        }

        private static void RegisterCustomer(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var custumerName = parts[0];
            var salesmanId = int.Parse(parts[1]);

            db.Add(new Customer
            {
                Name = custumerName,
                SalesmanId = salesmanId
            });

            db.SaveChanges();
        }

        private static void SaveItems(ShopDbContext db)
        {

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                var parts = line.Split(';');
                var itemName = parts[0];
                var itemPrice = decimal.Parse(parts[1]);

                db.Add(new Item
                {
                    Name = itemName,
                    Price = itemPrice
                });
            }
            db.SaveChanges();
        }

        private static void SaveSalesman(ShopDbContext db)
        {
            var salesman = Console.ReadLine().Split(';');

            foreach (var sm in salesman)
            {
                db.Add(new Salesman { Name = sm });
            }
            db.SaveChanges();
        }

        private static void PrepareDatabase(ShopDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}
