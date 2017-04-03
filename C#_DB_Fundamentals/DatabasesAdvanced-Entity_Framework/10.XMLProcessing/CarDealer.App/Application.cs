namespace CarDealer.App
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Data;
    using Dtos;

    public class Application
    {
        public static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();
            //context.Database.Initialize(true);


            //importing data
            //ImportSuplayer(context);

            //ImportParts(context);

            //ImportCars(context);

            //ImportCustomers(context);

            //ImportSales(context);

            //Queries

            //Query_1_Cars(context);
            //Query_2_CarsFromMakeFerrari(context);
            //Query_3_LocalSuppliers(context);
            //Query_4_CarsWithTheirListOfParts(context);
            //Query_5_TotalSalesByCustomer(context);
            //Query_6_SalesWithAppliedDiscount(context);



        }

        private static void Query_6_SalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales.
                Include(s => s.Car)
                .Include(s => s.Customer)
                .Include(s => s.Car.Parts)
                .Select(s => new
                {
                    Car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance
                    },
                    CustomerName = s.Customer.Name,
                    Discount = s.Discount,
                    Price = s.Car.Parts.Sum(p => p.Price),
                    PriceWithDiscount = (s.Car.Parts.Sum(p => p.Price) * (1.0M - s.Discount))
                });
            XDocument salesDoc = new XDocument();
            XElement salesXML = new XElement("sale");

            foreach (var sale in sales)
            {
                XElement saleXML = new XElement("sale");
                XElement car = new XElement("car");
                car.SetAttributeValue("make", sale.Car.Make);
                car.SetAttributeValue("model", sale.Car.Model);
                car.SetAttributeValue("distance-travelled", sale.Car.TraveledDistance);

                XElement customer = new XElement("customer-name");
                customer.Value = sale.CustomerName;

                XElement discount = new XElement("discount");
                discount.Value = sale.Discount.ToString();

                XElement price = new XElement("price");
                price.Value = sale.Price.ToString();

                XElement priceWithDiscount = new XElement("price-with-discount");
                priceWithDiscount.Value = sale.PriceWithDiscount.ToString();

                saleXML.Add(car);
                saleXML.Add(customer); 
                saleXML.Add(discount);
                saleXML.Add(price);
                saleXML.Add(priceWithDiscount);

                salesXML.Add(saleXML);
            }
            salesDoc.Add(salesXML);

            salesDoc.Save("../../Export/sales.xml");
            
        }

        private static void Query_5_TotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers.Where(c => c.Sales.Count >= 1).ProjectTo<CustomerDto>().ToList();
            CreateXml(customers, "customers-total-sales.xml", "customers");
        }

        private static void Query_4_CarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars.ProjectTo<CarWithPartsDto>().ToList();
            CreateXml(cars, "cars-and-parts.xml", "cars");
        }

        private static void Query_3_LocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers.Where(x => x.IsImporter == false).ProjectTo<SupplierDto>().ToList();
            CreateXml(suppliers, "local-suppliers.xml", "suppliers");
        }

        private static void Query_2_CarsFromMakeFerrari(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Ferrari")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ProjectTo<FerrariDto>().ToList();


            CreateXml(cars, "ferrari-cars.xml", "cars");
        }

        private static void Query_1_Cars(CarDealerContext context)
        {
            var cars =
                context.Cars.Where(c => c.TravelledDistance >= 2000000)
                    .OrderBy(c => new { c.Make, c.Model })
                    .ProjectTo<CarDto>().ToList();
            CreateXml(cars, "cars.xml", "cars");
        }

        private static void CreateXml<T>(List<T> list, string fileName, string rootName)
        {
            var serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(rootName));
            var writer = new StreamWriter($@"..\..\Export\{fileName}");
            using (writer)
            {
                serializer.Serialize(writer, list);
            }
            Console.WriteLine($"File {fileName} has been created.{Environment.NewLine}It is located in folder \"Export\". If you cant see them Click: \"Show All Files\" icon on the top row of \"Solution Explorer\". ");
        }
        private static void ImportSales(CarDealerContext context)
        {
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
                    Discount = discount
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
            XDocument xmlFile = XDocument.Load(@"..\..\Import\customers.xml");
            var root = xmlFile.Root.Elements();
            List<Customer> customers = new List<Customer>();

            foreach (var partElement in root)
            {
                Customer customer = new Customer()
                {
                    Name = partElement.Attribute("name")?.Value,
                    BirthDate = XmlConvert.ToDateTime(partElement.Element("birth-date").Value),
                    IsYoungDriver = XmlConvert.ToBoolean(partElement.Element("is-young-driver")?.Value)
                };

                customers.Add(customer);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private static void ImportCars(CarDealerContext context)
        {
            XDocument carsDoc = XDocument.Load("../../Import/cars.xml");
            XElement carsRoot = carsDoc.Root;

            foreach (XElement carElem in carsRoot.Elements())
            {
            
                XDocument xmlFile = XDocument.Load(@"..\..\Import\cars.xml");
                var root = xmlFile.Root.Elements();
                List<Car> cars = new List<Car>();

                foreach (var partElement in root)
                {
                    Car car = new Car()
                    {
                        Make = partElement.Element("make")?.Value,
                        Model = partElement.Element("model")?.Value,
                        TravelledDistance = XmlConvert.ToInt64(partElement.Element("travelled-distance")?.Value)
                    };

                    cars.Add(car);
                }

                int partCap = context.Parts.Count() + 1;
                foreach (var car in cars)
                {
                    Random rnd1 = new Random();
                    System.Threading.Thread.Sleep(15);
                    for (int i = 0; i < rnd1.Next(10, 20); i++)
                    {
                       
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
        }

        private static void ImportParts(CarDealerContext context)
        {
           
            XDocument xmlFile = XDocument.Load(@"..\..\Import\parts.xml");
            var root = xmlFile.Root.Elements();
            List<Part> parts = new List<Part>();

            foreach (var partElement in root)
            {
                Part part = new Part()
                {
                    Name = partElement.Attribute("name")?.Value,
                    Price = XmlConvert.ToDecimal(partElement.Attribute("price")?.Value),
                    Quantity = XmlConvert.ToInt32(partElement.Attribute("quantity")?.Value)
                };

                parts.Add(part);
            }

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

        private static void ImportSuplayer(CarDealerContext context)
        {
            XDocument supplierDoc = XDocument.Load("../../Import/suppliers.xml");
            XElement suppliersRoot = supplierDoc.Root;

            foreach (XElement supplierElement in suppliersRoot.Elements())
            {
                string name = supplierElement.Attribute("name")?.Value;
                bool isImporter = bool.Parse(supplierElement.Attribute("is-importer")?.Value);

                Supplier sup = new Supplier()
                {
                    Name = name,
                    IsImporter = isImporter
                };
                context.Suppliers.Add(sup);

            }
            context.SaveChanges();
        }
    }
}
