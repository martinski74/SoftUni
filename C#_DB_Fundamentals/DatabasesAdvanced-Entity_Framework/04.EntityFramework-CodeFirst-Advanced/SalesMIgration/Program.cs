using SalesDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMIgration
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SalesContext();

            Product p = new Product();
            p.Name = "Product1";
           
            context.Products.Add(p);
            context.SaveChanges();
            Console.WriteLine(context.Products.First().Name);

           
        }
    }
}
