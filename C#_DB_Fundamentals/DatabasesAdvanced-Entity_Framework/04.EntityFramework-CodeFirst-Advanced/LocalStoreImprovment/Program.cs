using LocalStoreImprovment.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalStoreImprovment
{
    class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product("Prqsno mlqko",
                          "Transport OOD", "Mlqko ot krava", 2);
            milk.Quantity = 3;
            milk.Weight = 4;

            Product cheese = new Product("Bqlo",
               "Sirene i vino",
               "Sirene ot shtastlivi jivotni",
               15);

            Product yellowCheese = new Product("Kawhkaval",
               "Transport OOD",
               "kashkaval...", 25);

            var context = new LocalStoreImprovmentContext();

            context.Products.Add(milk);

            context.SaveChanges();
        }
    }
}
