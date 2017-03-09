namespace SalesMIgration.Migrations
{
    using SalesDatabase;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesMIgration.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesMIgration.SalesContext context)
        {
            context.Products.AddOrUpdate(new Product() { Name = "Car",Description = "Vehicle"});
            context.Products.AddOrUpdate(new Product() { Name = "Motorcycle",Description = "Vehicle"});
            context.Products.AddOrUpdate(new Product() { Name = "Truck",Description = "Vehicle"});

            context.Customers.AddOrUpdate(new Customer() { FirstName = "Teo",LastName = "Todorov"});
            context.Customers.AddOrUpdate(new Customer() { FirstName = "Ivan",LastName = "Ivanov"});
            context.Customers.AddOrUpdate(new Customer() { FirstName = "Pesho",LastName = "Petrov"});
        }
    }
}
