using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarDealer.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CarDealerContext())
            {
                // 4.	Car Dealer check DB Models here:  .\Models\*
                context.Database.Initialize(true);

                // 5.	Car Dealer Import Data
                ImportSuppliers(context);
                ImportParts(context);
                ImportCarsWithParts(context);
                ImportCustomers(context);
                ImportSales(context);

                // 6.	Car Dealer Query and Export Data
                Query_1_OrderedCustomers(context);
                Query_2_CarsFromMakeToyota(context);
                Query_3_LocalSuppliers(context);
                Query_4_CarsWithTheirListOfParts(context);
                Query_5_TotalSalesByCustomer(context);
                Query_6_SalesWithAppliedDiscount(context);
            }
        }

            private static void Query_6_SalesWithAppliedDiscount(CarDealerContext context)
        {
            var salesWithAppliedDiscount = context.Sales.Select(s => new
            {
                car = new { s.Car.Make, s.Car.Model, s.Car.TravelledDistance },
                customerName = s.Customer.Name,
                Discount = s.DiscountPercentage + (s.Customer.IsYoungDriver ? 5 : 0)
            });

            PrintJson(salesWithAppliedDiscount);
        }

        private static void Query_5_TotalSalesByCustomer(CarDealerContext context)
        {
            var totalSalesByCustomer = context.Customers.Where(c => c.Sales.Count >= 1).Select(s => new
            {
                fullName = s.Name,
                boughtCars = s.Sales.Count,
                spentMoney = s.Sales.Select(x => x.Car.Parts.Sum(p => p.Price)).Sum()
            }).OrderByDescending(x => x.spentMoney);

            PrintJson(totalSalesByCustomer);
        }

        private static void Query_4_CarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsWithTheirListOfParts = context.Cars.Where(c => c.Id == 100).Select(c => new
            {
                Car = new { c.Make, c.Model, c.TravelledDistance, },
                Parts = c.Parts.Select(p => new
                {
                    p.Name,
                    p.Price
                })
            });

            PrintJson(carsWithTheirListOfParts);
        }

        private static void Query_3_LocalSuppliers(CarDealerContext context)
        {
            var localSuppliers = context.Suppliers.Where(s => s.IsImporter == false).Select(x => new
            {
                x.Id,
                x.Name,
                PartsCount = x.Parts.Count
            });
            PrintJson(localSuppliers);
        }

        private static void Query_2_CarsFromMakeToyota(CarDealerContext context)
        {
            var carsFromMakeToyota =
                context.Cars.Where(c => c.Make == "Toyota")
                    .OrderBy(c => c.Model)
                    .ThenByDescending(c => c.TravelledDistance).Select(x => new
                    {
                        x.Id,
                        x.Make,
                        x.Model,
                        x.TravelledDistance
                    });
            PrintJson(carsFromMakeToyota);
        }

        private static void Query_1_OrderedCustomers(CarDealerContext context)
        {
            var orderedCustomers = context.Customers.OrderBy(c => c.BirthDate).ThenBy(c => c.IsYoungDriver);
            PrintJson(orderedCustomers);
        }

        private static void PrintJson(IQueryable json)
        {
            string result = JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine(result);
        }

        private static void ImportSales(CarDealerContext context)
        {
            Console.WriteLine("Importing sales..");

            var carsCount = context.Cars.Count();
            var customersCount = context.Customers.Count();
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < carsCount - 30; i++)
            {
                Random rnd1 = new Random();
                System.Threading.Thread.Sleep(8);
                int carId = rnd1.Next(1, carsCount);

                Random rnd2 = new Random();
                System.Threading.Thread.Sleep(8);
                int customerId = rnd1.Next(1, customersCount);

                int discount = GenerateDiscount(i, carId, customerId);
                Sale sale = new Sale
                {
                    CarId = carId,
                    CustomerId = customerId,
                    DiscountPercentage = discount
                };
                sales.Add(sale);
            }
            context.Sales.AddRange(sales);
            context.SaveChanges();
        }

        private static int GenerateDiscount(int i, int carId, int customerId)
        {
            int discount = ((carId * customerId * i % 11) * 5);
            if (discount == 25)
            {
                discount = 30;
            }
            else if (discount == 35)
            {
                discount = 40;
            }
            else if (discount == 45)
            {
                discount = 50;
            }

            return discount;
        }

        private static void ImportCustomers(CarDealerContext context)
        {
            Console.WriteLine("Importing customers..");
            string jsnoFile = File.ReadAllText(@"..\..\Import\customers.json");
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(jsnoFile);

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private static void ImportCarsWithParts(CarDealerContext context)
        {
            Console.WriteLine("Importing cars..");

            string jsnoFile = File.ReadAllText(@"..\..\Import\cars.json");
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(jsnoFile);
            int partCap = context.Parts.Count() + 1;
            foreach (var car in cars)
            {
                Random rnd1 = new Random();
                System.Threading.Thread.Sleep(15);
                for (int i = 0; i < rnd1.Next(10, 20); i++)
                {
                    // 10-20 parts
                    Random rnd2 = new Random();
                    System.Threading.Thread.Sleep(15);
                    int partId = rnd2.Next(1, partCap);
                    var part = context.Parts.FirstOrDefault(p => p.Id == partId);
                    car.Parts.Add(part);
                }
                Console.WriteLine($"Adding car: {car.Model}, {car.Make} with parts..");
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        private static void ImportParts(CarDealerContext context)
        {
            Console.WriteLine("Importing parts..");

            string jsnoFile = File.ReadAllText(@"..\..\Import\parts.json");
            List<Part> parts = JsonConvert.DeserializeObject<List<Part>>(jsnoFile);

            var suppliersCount = context.Suppliers.Count();
            foreach (var part in parts)
            {
                Random rnd1 = new Random();
                System.Threading.Thread.Sleep(15);
                //Console.WriteLine(rnd1.Next(1, suppliersCount));
                part.SupplierId = rnd1.Next(1, suppliersCount);
            }
            context.Parts.AddRange(parts);
            context.SaveChanges();
        }

        private static void ImportSuppliers(CarDealerContext context)
        {
            Console.WriteLine("Importing suppliers..");
            string jsnoFile = File.ReadAllText(@"..\..\Import\suppliers.json");
            List<Supplier> suppliers = JsonConvert.DeserializeObject<List<Supplier>>(jsnoFile);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();
        }
    }
}


