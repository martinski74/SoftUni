using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesContext context = new SalesContext();

            Product car = new Product();
            car.Name = "Car";
            car.Price = 2000m;
            car.Quantity = 10;

            Product truck = new Product();
            truck.Name = "Truck";
            truck.Price = 2000m;
            truck.Quantity = 8;

            Product motorcycle = new Product();
            motorcycle.Name = "Motorcycle";
            motorcycle.Price = 2000m;
            motorcycle.Quantity = 8;

            Customer pesho = new Customer();
            pesho.Name = "Pesho";
            pesho.CreditCardNumber = "sdsdfwetrer46d";

            Customer mitko = new Customer();
            mitko.Name = "Mitko";
            mitko.CreditCardNumber = "sdsdfwetrer46d";

            Customer georgi = new Customer();
            georgi.Name = "Georgi";
            georgi.CreditCardNumber = "dfggrftyh6678";

            StoreLocation sofia = new StoreLocation();
            sofia.LocationName = "Gr. Sofia";

            StoreLocation plovdiv = new StoreLocation();
            plovdiv.LocationName = "Gr. Plovdiv";

            Sale carSale = new Sale();
            carSale.Products = car;
            carSale.Customers = mitko;
            carSale.StoreLocation = sofia;
            carSale.Date = DateTime.Now;

            Sale motorcycleSale = new Sale();
            motorcycleSale.Products = motorcycle;
            motorcycleSale.Customers = georgi;
            motorcycleSale.StoreLocation = sofia;
            motorcycleSale.Date = DateTime.Now;

            Sale truckSale = new Sale();
            truckSale.Products = truck;
            truckSale.Customers = pesho;
            truckSale.StoreLocation = plovdiv;
            truckSale.Date = DateTime.Now;


            context.Sales.Add(carSale);
            context.Sales.Add(motorcycleSale);
            context.Sales.Add(truckSale);

            context.SaveChanges();
        }
    }
}
